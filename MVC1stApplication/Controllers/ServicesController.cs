using Microsoft.AspNetCore.Mvc;

namespace MVC1stApplication.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
