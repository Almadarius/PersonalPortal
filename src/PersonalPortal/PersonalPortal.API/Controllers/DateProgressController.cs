using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersonalPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateProgressController : ControllerBase
    {
        [HttpGet]
        public double YearToDate(int decimals = 2)
        { 
            double remaining = 0;            
            int currentYear = DateTime.Now.Year;
            int daysInYear = DateTime.IsLeapYear(currentYear) ? 366 : 365;            

            var totalHours = daysInYear * 24;
            var totalMinutes = totalHours * 60;
            var totalSeconds = totalMinutes * 60;

            DateTime endOfYear = new DateTime(DateTime.Now.Year, 12, 31, 23, 59, 59);
            var diff = endOfYear - DateTime.Now;

            remaining = diff.TotalSeconds / totalSeconds * 100;
            var progress = Math.Round(100 - remaining, decimals);

            return progress;
        }
    }
}
