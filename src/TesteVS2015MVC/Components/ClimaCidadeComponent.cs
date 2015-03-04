using Microsoft.AspNet.Mvc;

namespace TesteVS2015MVC.Components
{
    [ViewComponent(Name = "ClimaCidade")]
    public class ClimaCidadeComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string referenciaCidade)
        {
            ViewBag.ReferenciaCidade = referenciaCidade;
            return View();
        }
    }
}