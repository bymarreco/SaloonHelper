﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SaloonHelper.Models;
using SaloonHelper.ViewModel;

namespace SaloonHelper.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Calculate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(PriceCalculationViewModel model)
        {
            PriceCalculationViewModel product = new PriceCalculationViewModel
            {
                InitialPrice = Math.Round((model.InitialPrice),2,MidpointRounding.ToEven),
                DezPorCento= Math.Round((model.InitialPrice*1.1),2,MidpointRounding.ToEven),
                VintePorCento = Math.Round((model.InitialPrice*1.2),2,MidpointRounding.ToEven),
                TrintaPorCento = Math.Round((model.InitialPrice*1.3),2,MidpointRounding.ToEven),
                QuarentaPorCento = Math.Round((model.InitialPrice*1.4),2,MidpointRounding.ToEven),
                CinquentaPorCento = Math.Round((model.InitialPrice*1.5),2,MidpointRounding.ToEven),
                SessentaPorCento = Math.Round((model.InitialPrice*1.6),2,MidpointRounding.ToEven),
                SetentaPorCento = Math.Round((model.InitialPrice*1.7),2,MidpointRounding.ToEven),
                OitentaPorCento = Math.Round((model.InitialPrice*1.8),2,MidpointRounding.ToEven),
                NoventaPorCento = Math.Round((model.InitialPrice*1.9),2,MidpointRounding.ToEven),
                CemPorCento = Math.Round((model.InitialPrice*2),2,MidpointRounding.ToEven)
            };

            return View("Result", product);
        }
    }
}
