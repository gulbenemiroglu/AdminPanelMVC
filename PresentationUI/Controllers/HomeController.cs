using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PresentationUI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IProductService _productService;    

        public HomeController(ILogger<HomeController> logger,IProductService productService)
        {
            _productService=productService; 
            _logger = logger;
        }

      
        public IActionResult Index()
        {
            var result = _productService.ListGetir();
            return View(result);
        }

        public IActionResult UrunlerinHepsiniListele()
        {
            var result = _productService.ListGetir();
            return View(result);
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
}
