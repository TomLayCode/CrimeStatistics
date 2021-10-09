using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrimeStatistics.Web.Controllers
{
    public class CrimeInformationController : Controller
    {
        //Acceptance Criteria
        //• For any UK latitude/longitude and a month in the last year, a summary of crimes is returned.
        //• The count of crimes are shown, grouped by category.
        //Technical Requirements
        //• The solution should make use of .NET, but the type of application is not limited.
        //• You may use whatever libraries / packages you wish.
        //• Your solution must include tests.

        public IActionResult GetCrime(decimal lat, decimal lon, DateTime fromDate, DateTime untilDate, int radius)
        {

            return View();
        }
    }
}
