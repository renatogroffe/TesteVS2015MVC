using Microsoft.AspNet.Mvc;
using Microsoft.Framework.ConfigurationModel;

namespace TesteVS2015MVC.Controllers
{
    public class CidadeController : Controller
    {
        private IConfiguration _configuration;

        public CidadeController(IConfiguration config)
        {
            this._configuration = config;
        }

        public IActionResult Cidade1()
        {
            ViewBag.Cidade1 = _configuration.Get("Teste:Cidade1");
            return View();
        }

        public IActionResult Cidade2()
        {
            return View();
        }
    }
}