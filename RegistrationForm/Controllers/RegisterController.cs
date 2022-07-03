using Microsoft.AspNetCore.Mvc;

namespace RegistrationForm.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
