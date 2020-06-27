using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllServicesData.EF.Configuration.AddData
{
    public class TestData
    {
        ModelBuilder _modelBuilder;
        /// <summary>
        /// Заполняет БД тестовой информацией
        /// </summary>
        /// <param name="modelBuilder"></param>
        public TestData(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
            Initialize();
        }

        private void Initialize()
        {
            AddUsers();
            AddCompanies();
            AddTelephones();
            AddCompaniesTypes();
        }
        private void AddUsers()
        {
            _modelBuilder.Entity<User>().HasData(
               new User[]
               {
                    new User{ Id=1, AccessId = 1, Adress = "admin", Email= "admin", LastName= "admin", FirstName= "admin", PasswordHash= "admin", Telephone = "admin" },
                    new User{ Id=2, AccessId = 2, Adress = "user", Email= "user", LastName= "user", FirstName= "user", PasswordHash= "user", Telephone = "user" },
                    new User{ Id=3, AccessId = 3, Adress = "company", Email= "company", LastName= "company", FirstName= "company", PasswordHash= "company", Telephone = "company" },
               });
        }
        #region Companies
        private void AddCompanies()
        {
            _modelBuilder.Entity<Company>().HasData(GenerateCompanies());
        }

        private Company[] GenerateCompanies()
        {
            Company[] companies = new Company[50];
            for (int i = 0; i < companies.Length; i++)
            {
                int index = i + 1;
                companies[i] = RandomCompany(index);
            }
            return companies;
        }
        private Company RandomCompany(int id)
        {
            Company c = new Company
            {
                Id = id,
                Name = "RandomCompany-" + id,
                UserId = 3,
                Description = RandomString(200),
                SmallDescription = RandomString(50),
                Likes = RandomInt(1000),
                Dislikes = RandomInt(1000),
                Popularity = RandomInt(1000),
                Email = RandomString(10) + "@email.com",
                WebSiteUrl = $"http://{RandomString(10)}.com",
                LogoUrl = "/Images/All-Service_default-image.jpg"
            };
            return c;
        }
        #endregion

        #region Companies Types
        private void AddCompaniesTypes()
        {
            _modelBuilder.Entity<CompanyServiceType>().HasData(GenerateCompaniesTypes());
        }

        private List<CompanyServiceType> GenerateCompaniesTypes()
        {
            List<CompanyServiceType> types = new List<CompanyServiceType>();
            int typeId = 1;
            for (int i = 1; i < 51; i++)
            {
                int count = RandomInt(5);
                for (int j = 0; j < count; j++)
                {
                    types.Add(new CompanyServiceType { Id = typeId++, CompanyId = i, ServiceTypeId = RandomInt(12) });
                }
            }
            return types;
        }
        #endregion

        #region Companies Telephones
        private void AddTelephones()
        {
            _modelBuilder.Entity<Telephones>().HasData(GenerateTelephones());
        }

        private List<Telephones> GenerateTelephones()
        {
            List<Telephones> telephones = new List<Telephones>();
            for (int i = 1; i <= 50; i++)
            {
                telephones.Add(new Telephones { Id = i, CompanyId = i, Telephone = "+38" + RandomTelephone()});
            }
            return telephones;
        }
        #endregion
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string RandomTelephone()
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static int RandomInt(int max)
        {
            return random.Next(1, max);
        }
    }
}
