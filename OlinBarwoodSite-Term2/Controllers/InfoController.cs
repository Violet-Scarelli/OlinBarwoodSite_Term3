using Microsoft.AspNetCore.Mvc;

namespace OlinBarwoodSite_Term2.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Links()
        {
            return View();
        }
        public IActionResult People()
        {
            return View();
        }
        public IActionResult Quiz()
        {
            return View();
        }
    }
}
