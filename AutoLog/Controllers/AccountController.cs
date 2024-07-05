//using AutoLog.Models;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using System.Security.Cryptography.X509Certificates;

//namespace AutoLog.Controllers
//{
//    public class AccountController : Controller
//    {
//        private readonly UserManager<Organization> _userManager;
//        private readonly SignInManager<Organization> _signInManager;

//        public AccountController(UserManager<Organization> userManager, SignInManager<Organization> signInManager)
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//        }

//        [HttpGet]
//        public IActionResult Login()
//        {
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> Login(LoginViewModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password.model.RememberMe, lockoutOnFailure: false);
//                if (result.Succeeded)
//                {
//                    return RedirectToAction("Index", "Home");
//                }
//                else
//                {
//                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
//                    return View(model);
//                }
//            }

//            return View(model);
//        }

//        [HttpGet]
//        public IActionResult Register()
//        {
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> Register(RegisterViewModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                var organization = new Organization { Username = model.Username, OrganizationName = model.OrganizationName };
//                var result = await _userManager.CreateAsync(organization, model.Password);
//                if (result.Succeeded)
//                {
//                    await _signInManager.SignInAsync(organization, isPersistent: false);
//                    return RedirectToAction("Index", "Home");
//                }
//                foreach (var error in result.Errors)
//                {
//                    ModelState.AddModelError(string.Empty, error.Description);
//                }
//            }

//            return View(model);
//        }

//        [HttpPost]
//        public async Task<IActionResult> Logout()
//        {
//            await _signInManager.SignOutAsync();
//            return RedirectToAction("Index", "Home");
//        }
//    }
//}
