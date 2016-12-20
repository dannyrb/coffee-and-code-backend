using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CoffeeAndCode.Controllers
{
    public class HomeController : Controller
    {
        private LocalSettings ConfigSettings { get; set; }

        public HomeController(IOptions<LocalSettings> settings)
        {
            ConfigSettings = settings.Value;
        }

        public IActionResult Index()
        {
            // Redirect to Swagger on load
            var redirectUrl = ConfigSettings.BaseUrl + "/swagger/ui";
            return Redirect(redirectUrl);
        }
    }
}
