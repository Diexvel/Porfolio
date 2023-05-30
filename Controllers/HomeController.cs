using Microsoft.AspNetCore.Mvc;
using Potafolio.Models;
using Potafolio.Servicios;
using System.Diagnostics;

namespace Potafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private readonly IRepositorioProyectos repositorioProyectos;

		public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos)
        {
            _logger = logger;
			this.repositorioProyectos = repositorioProyectos;
		}

        public IActionResult Index()
        {
        
           var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
		   var modelo = new HomeIndexViewModel() { Proyectos = proyectos };

			return View(modelo);
        }

       
        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos();

            return View(proyectos);
        }

        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(Contacto contacto)
        {
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}