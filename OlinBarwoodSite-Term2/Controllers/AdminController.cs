using Microsoft.AspNetCore.Mvc;

namespace OlinBarwoodSite_Term3.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
