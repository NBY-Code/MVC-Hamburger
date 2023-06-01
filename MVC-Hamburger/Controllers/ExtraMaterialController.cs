using Microsoft.AspNetCore.Mvc;
using MVC_Hamburger.Models;

namespace MVC_Hamburger.Controllers
{
    public class ExtraMaterialController : Controller
    {
        private readonly NBYBurgerContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ExtraMaterialController(NBYBurgerContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult List()
        {
            
            return View(_context.ExtraMaterials.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ExtraMaterial extraMaterial)
        {
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(extraMaterial.PhotoData.FileName);
            string extension = Path.GetExtension(extraMaterial.PhotoData.FileName);
            //ismini alıyor
          //  extraMaterial.Photo = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            extraMaterial.Photo = fileName + extension;
            string path = Path.Combine(wwwRootPath + "/Assest/images/", (fileName + extension));
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                extraMaterial.PhotoData.CopyTo(fileStream);
            }

            _context.ExtraMaterials.Add(extraMaterial);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int? id)
        {
            var menu = _context.Menus.Find(id);
            return View(menu);
        }
        [HttpPost]
        public IActionResult Edit(ExtraMaterial extraMaterial)
        {
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(extraMaterial.PhotoData.FileName);
            string extension = Path.GetExtension(extraMaterial.PhotoData.FileName);
            //ismini alıyor
            // extraMaterial.Photo = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            extraMaterial.Photo = fileName + extension;
            string path = Path.Combine(wwwRootPath + "/Assest/images/", (fileName + extension));
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                extraMaterial.PhotoData.CopyTo(fileStream);
            }
            _context.ExtraMaterials.Update(extraMaterial);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int? id)
        {
            var silinenMaterial = _context.ExtraMaterials.Find(id);
            _context.ExtraMaterials.Remove(silinenMaterial);
            _context.SaveChanges();
            return RedirectToAction("List");
        }

    }
}
