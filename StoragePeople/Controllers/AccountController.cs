using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StoragePeople.Models.Enterties;
using StoragePeople.Models.ViewModels;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace StoragePeople.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManage, SignInManager<AppUser> signInManager)
        {
            _userManager = userManage;
            _signInManager = signInManager;
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult RegisterUser()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterUser(CreateUserViewModel registerUser)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    FirstName = registerUser.FirstName,
                    LastName = registerUser.LastName,
                    DateOfBirth = registerUser.DateOfBirth,
                    UserName = registerUser.UserName,
                    Email = registerUser.Email


                };
                IdentityResult result = await _userManager.CreateAsync(user, registerUser.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                foreach (var identityError in result.Errors)
                {
                    ModelState.AddModelError(identityError.Code, identityError.Description);
                }
            }
            return View(registerUser);
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel userLogin)
        {
            // Ambiguous => SignInResult
            SignInResult result = await _signInManager.PasswordSignInAsync(userLogin.UserName, userLogin.Password, false, false);
            if (result.IsNotAllowed)
            {
                ViewBag.Msg = "Access denied! You are not allowed to login";
            }
            if (result.IsLockedOut)
            {
                ViewBag.Msg = "You have been locked out from Login";
            }
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}
