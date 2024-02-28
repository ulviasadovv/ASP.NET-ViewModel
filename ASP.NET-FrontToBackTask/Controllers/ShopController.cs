using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_FrontToBackTask.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
