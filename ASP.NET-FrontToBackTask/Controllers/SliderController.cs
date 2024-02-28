using ASP.NET_FrontToBackTask.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_FrontToBackTask.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly PronioDbContext _context;

        public SliderController(PronioDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var sliders = await _context.Sliders.ToListAsync();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string title)
        {
            return Content(title);
        }
    }
}
