using FutureValueMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FutureValueMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View(new FutureValueModel() { });

        [HttpPost]
        public IActionResult Index(FutureValueModel valueModel)
        {
            if (!ModelState.IsValid) return View(valueModel);

            ViewBag.FutureValue = valueModel.CalculateFutureModel().ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

            return View(valueModel);
        }
    }
}
