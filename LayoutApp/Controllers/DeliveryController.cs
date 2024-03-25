using Microsoft.AspNetCore.Mvc;

namespace LayoutApp.Controllers
{
    public class DeliveryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Grocery()
        {
            return View();
        }

        public IActionResult Pharmacy()
        {
            return View();
        }

        public IActionResult Restaurant()
        {
            return View();
        }
        public IActionResult Order()
        {
            return View();
        }


    }
}
