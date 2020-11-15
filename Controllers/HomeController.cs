using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MercadoVisual.Models;

namespace MercadoVisual.Controllers
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

        public IActionResult boleto()
        {
            return View();
        }

        public IActionResult cadastrar()
        {
            return View();
        }
        public IActionResult inicio()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult pagarBoleto()
        {
            return View();
        }
        public IActionResult scanearBoleto()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    public class MercadoVisualController : Controller
    {
        private readonly ILogger<MercadoVisualController> _logger;

        public MercadoVisualController(ILogger<MercadoVisualController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult boleto()
        {
            return View();
        }

        public IActionResult cadastrar()
        {
            return View();
        }
        public IActionResult inicio()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult pagarBoleto()
        {
            return View();
        }
        public IActionResult scanearBoleto()
        {
            return View();
        }

    }


}

