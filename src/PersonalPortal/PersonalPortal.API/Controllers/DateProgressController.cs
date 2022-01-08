using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersonalPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateProgressController : ControllerBase
    {
        [HttpGet]
        [Route("/YearToDate")]
        public IActionResult YearToDate(int decimals = 2)
        {                      
            int currentYear = DateTime.Now.Year;
            int daysInYear = DateTime.IsLeapYear(currentYear) ? 366 : 365;            

            var totalHours = daysInYear * 24;
            var totalMinutes = totalHours * 60;
            var totalSeconds = totalMinutes * 60;

            DateTime endOfYear = new DateTime(DateTime.Now.Year, 12, 31, 23, 59, 59);
            var diff = endOfYear - DateTime.Now;

            double remaining = diff.TotalSeconds / totalSeconds * 100;
            var progress = Math.Round(100 - remaining, decimals);

            return Ok(progress);
        }

        [HttpGet]
        [Route("/PeriodProgress")]
        public IActionResult ProgressToDate(DateTime startDate, DateTime endDate, int decimals = 2)
        { 
            var diff = endDate - startDate;
            var current = endDate - DateTime.Now;

            double remaining = current.TotalSeconds / diff.TotalSeconds * 100;
            var progress = Math.Round(100 - remaining, decimals);

            return Ok(progress);
        }
    }
}
