using ASP.NET_FrontToBackTask.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_FrontToBackTask.Contexts
{
    public class PronioDbContext : DbContext
    {
        public PronioDbContext(DbContextOptions<PronioDbContext> options) : base(options) 
        {

        }

        public DbSet<Slider> Sliders { get; set; } = null!;
        public DbSet<Shipping> Shippings {  get; set; } = null!;
    }
}