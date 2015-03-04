using Microsoft.AspNet.Mvc;
using Microsoft.Framework.ConfigurationModel;

namespace TesteVS2015MVC.Controllers
{
    public class HomeController : Controller
    {
        [Activate]
        public IConfiguration Configuration { get; set; }

        public IActionResult Index()
        {
            ViewBag.Cidade1 = Configuration.Get("Teste:Cidade1");
            ViewBag.Cidade2 = Configuration.Get("Teste:Cidade2");

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}