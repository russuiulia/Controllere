using Microsoft.AspNetCore.Mvc;

namespace Controllere
{
    public class DateTimeNow : Controller
    {
        public DateTime Index()
        {
            return DateTime.Now;
        }
    }
}
