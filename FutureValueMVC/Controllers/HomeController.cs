using FutureValueMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FutureValueMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            FutureValueModel valueModel = new();
            return View(valueModel);
        }
    }
}
