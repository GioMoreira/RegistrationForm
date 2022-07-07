using Microsoft.AspNetCore.Mvc;

namespace RegistrationForm.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
