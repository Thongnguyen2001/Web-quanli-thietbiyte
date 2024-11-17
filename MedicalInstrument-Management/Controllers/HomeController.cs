using MedicalInstrument_Management.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MedicalInstrument_Management.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly HospitalContext _context;

        public HomeController(ILogger<HomeController> logger, HospitalContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(string? device_name)
        {
            var hospital = _context.CDHA.Where(x => x.Name == device_name).FirstOrDefault();
            ViewData["hospital"] = hospital;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Demo()
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
