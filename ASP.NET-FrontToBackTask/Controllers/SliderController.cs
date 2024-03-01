using ASP.NET_FrontToBackTask.Contexts;
using ASP.NET_FrontToBackTask.Models;
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
        public async Task<IActionResult> Create(Slider slider)
        {
            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
