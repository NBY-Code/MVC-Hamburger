using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Hamburger.Models;
using MVC_Hamburger.ViewModel;

namespace MVC_Hamburger.Controllers
{
    public class AccountController : Controller
    {
      

        private readonly SignInManager<AppUser> _signInManager;
        readonly UserManager<AppUser> _userManager;
        private readonly NBYBurgerContext _context;
        private readonly IPasswordHasher<AppUser> _passwordHasher;
        public AccountController(UserManager<AppUser> userManager, NBYBurgerContext context, IPasswordHasher<AppUser> password, SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
            _passwordHasher = password;
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult List()
        {
            List<AppUser> appUsers = _context.AppUsers.ToList();
            return View(appUsers);
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserVM userVM)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    UserName = userVM.UserName,
                    Email = userVM.EMail
                };
                IdentityResult result = await _userManager.CreateAsync(appUser, userVM.Password);
                if (result.Succeeded)
                {
                   await _userManager.AddToRoleAsync(appUser, "USER");
                   //await _userManager.AddToRoleAsync(appUser, "ADMIN");
                    return RedirectToAction("Index","Home");
                }
            }
            return View();
        }
     
        public async Task<IActionResult> Update(string id)
        {
            var appUser = await _context.AppUsers.FindAsync(id);
            UserUpdateDTO userUpdateVM = new UserUpdateDTO()
            {
                Id = appUser.Id,
                UserName = appUser.UserName,
                EMail = appUser.Email,
                Password = appUser.PasswordHash
            };

            return View(userUpdateVM);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UserUpdateDTO userUpdate)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await _context.AppUsers.FindAsync(userUpdate.Id);

                if (appUser == null)
                    return View(userUpdate);

                appUser.UserName = userUpdate.UserName;
                appUser.Email = userUpdate.EMail;
                //ilk alan şifresi güncellenecek kullanıcı 
                //ikinci alan şifreyi tekrar hashleyip şifreyi güncelliyor
                _passwordHasher.HashPassword(appUser, userUpdate.Password);
                IdentityResult result = await _userManager.UpdateAsync(appUser);
                if (result.Succeeded)
                {
                    _context.AppUsers.Update(appUser);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("List");
                }
            }

            return View(userUpdate);

        }
        public async Task<IActionResult> Delete(string id)
        {
            var appUser = await _context.AppUsers.FindAsync(id);
            _context.AppUsers.Remove(appUser);
            await _context.SaveChangesAsync();
            return RedirectToAction("List");
        }
        public async Task<IActionResult> LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(LoginVm logInVm)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.FindByNameAsync(logInVm.UserName);
                if (user != null)
                {
                    Response.Cookies.Append("UserName", user.UserName);
                    await _signInManager.PasswordSignInAsync(user, logInVm.Password, false, false);

                    return Redirect(logInVm.ReturnURL);
                }
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }
            return View(logInVm);
        }

        public async Task<IActionResult> LogOut(LoginVm logInVm)
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(LogIn));
        }
    }
}
