using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Avast.Utilities;
namespace Avast.PrimeNumbers.Web.Controllers
{
    public class PrimeNumberController : Controller
    {

        protected readonly IPrimeNumbers primeNumbers;
        public  PrimeNumberController(IPrimeNumbers primeNumbers)
        {
            this.primeNumbers = primeNumbers;
        }

        public IActionResult Index(string nPrimeNumbersList)
        {
            if (int.TryParse(nPrimeNumbersList, out int listOfPrimesCount))
            {
                // count is incremented by 1 as per requirement : The application should output an N+1 x N+1 grid of numbers (we will test it with N== 1)
                var listOfPrimes = primeNumbers.GetListofPrimeNumbers(listOfPrimesCount + 1);
                return View(listOfPrimes);
            }
            else
            {
                return Content("Please check your input");
            }
        }
    }
}