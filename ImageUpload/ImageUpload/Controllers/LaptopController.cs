using ImageUpload.Data;
using ImageUpload.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ImageUpload.Controllers
{
    public class LaptopController : Controller
    {
        private readonly ImageUploadDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public LaptopController(ImageUploadDbContext context,IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var data = _context.laptops.ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult AddLaptop()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> AddLaptop(Laptop model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string uploadFile = "~/Images/" + UploadImage(model);
                    var data = new Laptop()
                    {
                        Brand = model.Brand,
                        Description = model.Description,
                        Path = uploadFile

                    };
                    await _context.laptops.AddAsync(data);

                    _context.SaveChanges();
                    TempData["Success"] = "Record Successfully Saved !";
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError(string.Empty, "Model property is not valid please check ");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(model);
        }
        public string UploadImage(Laptop model)
        {
            string uploadFileName = string.Empty;
            if (model.ImagePath != null)
            {
                string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
                uploadFileName = Guid.NewGuid().ToString() + "_" + model.ImagePath.FileName;
                string fullPath = Path.Combine(uploadFolder, uploadFileName);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    model.ImagePath.CopyTo(fileStream);
                }
            }
            return uploadFileName;
        }
    }
}
