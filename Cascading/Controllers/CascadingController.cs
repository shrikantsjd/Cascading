using Microsoft.AspNetCore.Mvc;

namespace Cascading.Controllers
{
    public class CascadingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
