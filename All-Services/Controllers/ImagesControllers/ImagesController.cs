using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AllServicesData.EF;
using AllServicesData.Model;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace All_Services.Controllers.ImageControllers
{
    [Route("api/images")]
    [ApiController]
    [Authorize]
    public class ImagesController : ControllerBase
    {
        private readonly AllServicesContext _context;
        IWebHostEnvironment _appEnvironment;

        public ImagesController(AllServicesContext context, IWebHostEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }

        // GET: api/Images
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Image>>> GetImages()
        {
            return await _context.Images.ToListAsync();
        }

        // GET: api/Images/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Image>> GetImage(int id)
        {
            var Image = await _context.Images.FindAsync(id);

            if (Image == null)
            {
                return NotFound();
            }

            return Image;
        }
        [HttpGet("defaultImage")]
        public async Task<ActionResult<Image>> GetDefaultImage()
        {
            return await _context.Images.FirstOrDefaultAsync(i => i.Name =="All-Service_default-image.jpg");
        }
        // POST: api/Images
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult> PostImage(IFormFile uploadedFile)
        {
            Image image = new Image();
            if (uploadedFile == null)
            {
                return BadRequest("File not found");
            }
            // путь к папке Files
            string path = "/Images/" + Guid.NewGuid().ToString() + "_" + uploadedFile.FileName;
            // сохраняем файл в папку Files в каталоге wwwroot
            using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
            {
                await uploadedFile.CopyToAsync(fileStream);
            }
            image = new Image { Name = uploadedFile.FileName, Path = path };
            _context.Images.Add(image);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetImage", new { id = image.Id }, image);
        }

        // DELETE: api/Images/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Image>> DeleteImage(int id)
        {
            var Image = await _context.Images.FindAsync(id);
            if (Image == null)
            {
                return NotFound();
            }

            _context.Images.Remove(Image);
            await _context.SaveChangesAsync();

            return Image;
        }
    }
}
