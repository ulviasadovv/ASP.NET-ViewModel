using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_FrontToBackTask.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Dashboard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
