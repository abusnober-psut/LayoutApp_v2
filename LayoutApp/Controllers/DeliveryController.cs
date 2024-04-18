using Microsoft.AspNetCore.Mvc;
using LayoutApp.Models;

namespace LayoutApp.Controllers
{
    public class DeliveryController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                string msg = null;
                ViewBag.Message = msg.Length;

                return View();
            }
            catch (Exception)
            {
                return View("Error", new ErrorViewModel());
            }
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
