using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class SerasaController : Controller
    {
        private readonly List<Serasa> devendo = new List<Serasa>();

        public SerasaController()
        {
            devendo.Add(new Serasa()
            { 
                Nome = "henrique",
                Divida = "100$",
                id = "216914"           
            });
        }
        public IActionResult Index()
        {
            return View(devendo);
        }

        public IActionResult Details(string id)
        {
            var endividado = devendo.Find(a => a.id == id);
            if (endividado == null) return NotFound();
            return View(endividado);
        }
    }
}
