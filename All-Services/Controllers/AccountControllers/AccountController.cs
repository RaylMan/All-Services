using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using All_Services.EntityRequest.Admin_f.Accesses_f;
using All_Services.EntityRequest.Users_f;
using All_Services.Models.Authorization;
using All_Services.ViewModels.Account;
using AllServicesData.EF;
using AllServicesData.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace All_Services.Controllers.AccountControllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly ILogger logger;
        private readonly AllServicesContext db;
        public AccountController(ILogger<AccountController> logger, AllServicesContext context)
        {
            this.logger = logger;
            this.db = context;
        }

        #region Auth
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost, Route("login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var identity = await GetIdentity(model);

            if (identity == null)
            {
                return BadRequest(new { error = "Не верные номер телефона или пароль" }); //
            }

            var now = DateTime.Now; //UTCNow
            var date = DateTime.Now.AddDays(-1);
            // создаем JWT-токен notBefore: now,
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256)); ;

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            return Ok(new { Token = encodedJwt });
        }
        private async Task<ClaimsIdentity> GetIdentity(LoginViewModel model)
        {
            User user = await db.Users.Where(u => u.Telephone == model.Telephone && u.PasswordHash == model.Password)
                                                    .Include(a => a.Access).FirstOrDefaultAsync();
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Id.ToString()),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Access.AccessName),
                    new Claim("id", user.Id.ToString()),
                    new Claim("access", user.Access.AccessName)
                };
                ClaimsIdentity claimsIdentity =
                                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                                ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }

            // если пользователя не найдено
            return null;
        }
        private async Task Authenticate(User user)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Telephone),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Access.AccessName) //user.Access.AccessName
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        #endregion

        #region User
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost, Route("register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            User user = await db.Users.FirstOrDefaultAsync(u => u.Telephone == model.Telephone);
            if (user == null)
            {
                var access = await AccessesRequests.GetUserAccessAsync(db);
                User newUser = new User
                {
                    AccessId = access.Id,
                    Telephone = model.Telephone,
                    PasswordHash = model.Password,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Adress = model.Adress,
                    Access = access
                };
                // добавляем пользователя в бд
                db.Users.Add(newUser);
                await db.SaveChangesAsync();

                return await Login(new LoginViewModel { Telephone = newUser.Telephone, Password = newUser.PasswordHash });

                //return Ok(new { Status = true});
            }
            else
                return BadRequest("Пользователь с такими номером телефона уже зарегистрирован");
        }
        [HttpPost, Authorize, Route("user-account")]
        private async Task<ActionResult<User>> GetUserAccount()
        {
            int.TryParse(User.Identity.Name, out int id);
            var user = await db.Users.FindAsync(id);
            if (user != null)
                return user;
            else
                return BadRequest("User not found");
        }
        #endregion

        #region Company
        [HttpGet]
        public IActionResult RegisterCompany()
        {
            return View();
        }
        [HttpPost, Route("registerCompany")]
        public async Task<IActionResult> RegisterCompany(RegisterCompanyViewModel model)
        {
            Console.WriteLine(model);
            Company company = await db.Companies.FirstOrDefaultAsync(u => u.Name == model.Name);
            if (company != null)
            {
                return BadRequest("Компания с такими названием уже зарегистрирована");
            }
            await UsersRequests.ChangeAccessToCompanyAsync(db, model.UserId);

            Company newCompany = new Company
            {
                UserId = model.UserId,
                Name = model.Name,
                Email = model.Email,
                LogoUrl = model.LogoUrl,
                WebSiteUrl = model.WebSiteUrl,
                Description = model.Description,
                SmallDescription = model.SmallDescription
            };
            await db.Companies.AddAsync(newCompany);
            await db.SaveChangesAsync();


            if (model.Addresses != null) await CreateCompanyAddresses(model.Addresses, newCompany.Id);
            await CreateCompanyTelephones(model.Telephones, newCompany.Id);
            await CreateCompanyServiceTypes(model.Types, newCompany.Id);
            await db.SaveChangesAsync();

            return Ok();
        }


        public async Task CreateCompanyAddresses(ICollection<string> addresses, int companyId)
        {
            foreach (var address in addresses)
            {
                if (!string.IsNullOrWhiteSpace(address))
                {
                    CompanyAddress adrs = new CompanyAddress { CompanyId = companyId, Address = address };
                    await db.CompanyAddresses.AddAsync(adrs);
                }
            }
        }
        public async Task CreateCompanyTelephones(ICollection<string> telephones, int companyId)
        {
            foreach (var tel in telephones)
            {
                if (!string.IsNullOrWhiteSpace(tel))
                {
                    Telephones newTelephone = new Telephones { CompanyId = companyId, Telephone = tel };
                    await db.Telephones.AddAsync(newTelephone);
                }

            }
        }
        public async Task CreateCompanyServiceTypes(ICollection<int> types, int companyId)
        {
            foreach (var id in types)
            {
                if (id != 0)
                {
                    CompanyServiceTypes newTypes = new CompanyServiceTypes { ServiceTypeId = id, CompanyId = companyId };
                    await db.CompanyServiceTypes.AddAsync(newTypes);
                }
            }
        }
        #endregion
    }
}