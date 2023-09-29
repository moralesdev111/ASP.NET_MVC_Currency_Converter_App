using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using System.Diagnostics;

namespace MVCProject.Controllers
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
        [HttpGet]
        public IActionResult CurrencyMenu(decimal _valueInput)
        {
            Currency currency = new Currency();
            currency.valueInput = _valueInput;
            return View(currency);            
        }
        [HttpPost]
        public IActionResult CurrencyMenu(Currency currency)
        {
            if (ModelState.IsValid)
            {
                currency.valueOutput = currency.valueInput * 1.06M;
                return View("Output",currency);
            }
            

                return View("CurrencyMenu",currency);
            }

        }


       
      
        


        
    }
