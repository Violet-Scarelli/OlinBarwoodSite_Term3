using Microsoft.AspNetCore.Mvc;

namespace OlinBarwoodSite_Term2.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Forum()
        {
            return View();
        }
    }
}
