using Microsoft.AspNetCore.Mvc;

namespace Controllere.Pages
{
    public class HomeHome : Controller
    {
        public IActionResult Index()
        {
            return View("HomeView");
        }
    }
}
