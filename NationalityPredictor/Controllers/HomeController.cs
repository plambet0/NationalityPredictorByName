using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NationalityPredictor.Models;
using NationalityPredictor.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NationalityPredictor.Controllers
{
    public class HomeController : Controller
    {
        private readonly INationalityPredictorService nationalityPredictorService;

        public HomeController(INationalityPredictorService nationalityPredictorService)
        {
            this.nationalityPredictorService = nationalityPredictorService;
        }
        
        public async Task<IActionResult> Index(string name)
        {
            var model = new DataModel();

            if (!string.IsNullOrEmpty(name))
            {
                model =  await nationalityPredictorService.GetCountries(name);
            }

            return View(model);

        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
