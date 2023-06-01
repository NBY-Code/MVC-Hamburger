using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Hamburger.Models;

namespace MVC_Hamburger.Controllers
{
    public class MenuController : Controller
    {
        private readonly NBYBurgerContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public MenuController(NBYBurgerContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }



        //public static List<Menu> menus = new List<Menu>
        //     {
        //    new Menu { Id = 1, Name = "Cheeseburger", Price = 9.99M, Photo = "/Assest/images/f2.png" },
        //    new Menu { Id = 2, Name = "Chicken burger", Price = 11.99M, Photo = "/Assest/images/f8.png" },
        //    new Menu { Id = 3, Name = "Chicken Cheeseburger", Price = 13.99M, Photo ="/Assest/images/f7.png" },
        //    new Menu { Id = 4, Name = "Pepperoni Pizza", Price = 14.99M, Photo = "/Assest/images/f3.png" },
        //    new Menu { Id = 5, Name = "Margherita Pizza", Price = 12.99M, Photo = "/Assest/images/f1.png" },
        //    new Menu { Id = 6, Name = "Meat Lovers Pizza", Price = 16.99M, Photo = "/Assest/images/f6.png" },
        //    new Menu { Id = 7, Name = "Spaghetti Carbonara", Price = 10.99M, Photo = "/Assest/images/f9.png" },
        //    new Menu { Id = 8, Name = "Special Pasta", Price = 11.99M, Photo = "/Assest/images/f4.png" },
        //    new Menu { Id = 9, Name = "Garlic Fries", Price = 4.99M, Photo = "/Assest/images/f5.png" },
        //      };

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
           
            return View(_context.Menus.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Menu menu)
        {
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(menu.PhotoData.FileName);
            string extension = Path.GetExtension(menu.PhotoData.FileName);
            //ismini alıyor
            //menu.Photo = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            menu.Photo = fileName +extension;
            string path = Path.Combine(wwwRootPath + "/Assest/images/", (fileName+extension));
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                menu.PhotoData.CopyTo(fileStream);
            }
    
            _context.Menus.Add(menu);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int? id)
        {
            var menu = _context.Menus.Find(id);
            return View(menu);
        }
        [HttpPost]      
        public IActionResult Edit(Menu menu)
        {
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(menu.PhotoData.FileName);
           string extension = Path.GetExtension(menu.PhotoData.FileName);
            //ismini alıyor
          //  menu.Photo = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            menu.Photo = fileName+ extension;
            string path = Path.Combine(wwwRootPath + "/Assest/images/", (fileName+ extension));
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                menu.PhotoData.CopyTo(fileStream);
            }     
            _context.Menus.Update(menu);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int? id) 
        {
            var silinenMenu = _context.Menus.Find(id);
            _context.Menus.Remove(silinenMenu);
            _context.SaveChanges();
            return RedirectToAction("List");
        }

    }
}
