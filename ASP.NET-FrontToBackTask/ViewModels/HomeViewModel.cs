using ASP.NET_FrontToBackTask.Models;

namespace ASP.NET_FrontToBackTask.ViewModels
{
    public class HomeViewModel 
    {
        public List<Slider> Sliders { get; set; } = null!;
        public List<Shipping> Shippings { get; set; } = null!;
    }
}
