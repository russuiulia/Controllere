using Microsoft.AspNetCore.Mvc;

namespace Controllere
{
    public class PlainText : Controller
    {
        public IActionResult Index()
        {
            return Content("Text simplu woow");
        }
    }
}
