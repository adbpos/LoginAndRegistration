using LoginAndRegistration.Models;
using LoginAndRegistration.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoginAndRegistration.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult processLogin(UserModel userModel)
        {
            SecurityServices SecurityServices = new SecurityServices();
            if (SecurityServices.isValid(userModel))
            {
                return View("LoginSuccess", userModel);
            } else
            {
                return View("LoginFailure", userModel);
            }
        }
    }
}
