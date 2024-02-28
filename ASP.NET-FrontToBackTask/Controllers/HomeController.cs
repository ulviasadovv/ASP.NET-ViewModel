using ASP.NET_FrontToBackTask.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ASP.NET_FrontToBackTask.Controllers
{
    public class HomeController : Controller
    {

        private readonly PronioDbContext _context;

        public HomeController(PronioDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var sliders = await _context.Sliders.ToListAsync();
            var shippings = await _context.Shippings.ToListAsync();

            HomeViewModel homeViewModel = new HomeViewModel
            {
                Sliders = sliders,
                Shippings = shippings
            };

            return View(homeViewModel);
        }
    }
}
