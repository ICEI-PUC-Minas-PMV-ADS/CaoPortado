using Microsoft.AspNetCore.Mvc;
using PetHotel.Models;
using System.Diagnostics;

namespace PetHotel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Depoimentos()
        {
            return View();
        }

        public IActionResult Empresa()
        {
            return View();
        }
      
        public IActionResult MeuPerfil()
        {
            return View();
        }

        public IActionResult MeuPet()
        {
            return View();
        }

        public IActionResult fotosevideos()
        {
            return View();
        }

        public IActionResult videos()
        {
            return View();
        }

        public IActionResult Serviços()
        {
            return View();
        }

        public IActionResult agendaadest()
        {
            return View();
        }

        public IActionResult agendacreche()
        {
            return View();
        }

        public IActionResult agendahotel()
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