using Microsoft.AspNetCore.Mvc;

namespace FutureValueMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
