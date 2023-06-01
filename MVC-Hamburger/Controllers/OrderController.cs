using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Hamburger.Models;

namespace MVC_Hamburger.Controllers
{
    public class OrderController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly NBYBurgerContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public OrderController(NBYBurgerContext context, IWebHostEnvironment hostEnvironment,UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _context = context;
            _hostEnvironment = hostEnvironment;
        }
      
        public async Task<IActionResult> List()
        {
            var cookie = HttpContext.Request.Cookies["UserName"];
            var selectedUser = await _userManager.FindByNameAsync(cookie);

            var orders = _context.Orders
                .Include(o => o.OrdersMenus)
                .ThenInclude(om => om.Menu)
                .Include(o => o.OrdersExtraMaterials)
                .ThenInclude(oe => oe.ExtraMaterial)
                .Where(o => o.AppUserId == selectedUser.Id)
                .ToList();

            var menus = orders.SelectMany(o => o.OrdersMenus.Select(om => om.Menu)).ToList();
            var extraMaterials = orders.SelectMany(o => o.OrdersExtraMaterials.Select(oe => oe.ExtraMaterial)).ToList();

            var tuple = (menus.AsEnumerable(), extraMaterials.AsEnumerable());
            return View(tuple);
        }

       public async Task<IActionResult> AddBasketFood(int id)
        {
            var cookie = HttpContext.Request.Cookies["UserName"];
            var selectedUser = await _userManager.FindByNameAsync(cookie);
            var selectedMenu = await _context.Menus.FindAsync(id);
            var order = new Order();
            order.OrdersMenus.Add(new OrdersMenu()
            {
                MenuId = selectedMenu.Id
            });
            selectedUser.Orders.Add(order);
           // _context.Orders.Add(order);
            _context.SaveChanges();
            
          
          
            return RedirectToAction("List","Menu");
        }

        public async Task<IActionResult> AddBasketExtraMaterial(int id)
        {
            var cookie = HttpContext.Request.Cookies["UserName"];
            var selectedUser = await _userManager.FindByNameAsync(cookie);
            var selectedAperatif = await _context.ExtraMaterials.FindAsync(id);
            var order = new Order();
            order.OrdersExtraMaterials.Add(new OrdersExtraMaterial()
            {
                ExtraMaterialId = selectedAperatif.Id
            });
            selectedUser.Orders.Add(order);
            // _context.Orders.Add(order);
            _context.SaveChanges();



            return RedirectToAction("List", "Menu");
        }
        public async Task<IActionResult> DeleteFood(int id)
        {
            var cookie = HttpContext.Request.Cookies["UserName"];
            var selectedUser = await _userManager.FindByNameAsync(cookie);
            var order = _context.Orders
                .Include(o => o.OrdersMenus)
                .FirstOrDefault(o => o.AppUserId == selectedUser.Id && o.OrdersMenus.Any(om => om.MenuId == id));

            if (order != null)
            {
                var ordersMenu = order.OrdersMenus.FirstOrDefault(om => om.MenuId == id);
                order.OrdersMenus.Remove(ordersMenu);
                await _context.SaveChangesAsync(); // Değişiklikleri kaydet
            }

            return RedirectToAction("List");
        }
        public async Task<IActionResult> DeleteExtraMaterial(int id)
        {
            var cookie = HttpContext.Request.Cookies["UserName"];
            var selectedUser = await _userManager.FindByNameAsync(cookie);
            var order = _context.Orders
                .Include(o => o.OrdersExtraMaterials)
                .FirstOrDefault(o => o.AppUserId == selectedUser.Id && o.OrdersExtraMaterials.Any(om => om.ExtraMaterialId == id));

            if (order != null)
            {
                var ordersMenu = order.OrdersExtraMaterials.FirstOrDefault(om => om.ExtraMaterialId == id);
                order.OrdersExtraMaterials.Remove(ordersMenu);
                await _context.SaveChangesAsync(); // Değişiklikleri kaydet
            }

            return RedirectToAction("List");
        }
        public async Task<IActionResult> CompleteToOrder()
        {
            var cookie = HttpContext.Request.Cookies["UserName"];
            var selectedUser = await _userManager.FindByNameAsync(cookie);

            var orders = _context.Orders
                .Include(o => o.OrdersMenus)
                .ThenInclude(om => om.Menu)
                .Include(o => o.OrdersExtraMaterials)
                .ThenInclude(oe => oe.ExtraMaterial)
                .Where(o => o.AppUserId == selectedUser.Id)
                .ToList();

            // OrdersMenus ilişkili verilerini silme
            foreach (var order in orders)
            {
                _context.OrdersMenus.RemoveRange(order.OrdersMenus);
            }

            // OrdersExtraMaterials ilişkili verilerini silme
            foreach (var order in orders)
            {
                _context.OrdersExtraMaterials.RemoveRange(order.OrdersExtraMaterials);
            }

            // Orders verisini silme
            _context.Orders.RemoveRange(orders);

            await _context.SaveChangesAsync();

            return RedirectToAction("List");
        }
        public async Task<IActionResult> Logout()
        {
            // Çıkış işlemleri

            // Kullanıcının sepetini temizle
            var cookie = HttpContext.Request.Cookies["UserName"];
            var selectedUser = await _userManager.FindByNameAsync(cookie);

            var orders = _context.Orders
                .Where(o => o.AppUserId == selectedUser.Id)
                .ToList();

            _context.Orders.RemoveRange(orders);
            await _context.SaveChangesAsync();

            return RedirectToAction("LogIn","Account");
        }

    }
}
