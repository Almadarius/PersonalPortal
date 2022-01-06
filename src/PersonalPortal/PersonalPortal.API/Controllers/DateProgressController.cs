using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersonalPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateProgressController : ControllerBase
    {
        [HttpGet]
        [Route("YearToDate")]
        public double YearToDate(int decimals = 2)
        {
            var startDate = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0);
            var endDate = new DateTime(DateTime.Now.Year, 12, 31, 23, 59, 59);
            var totalSeconds = (endDate - startDate).TotalSeconds;            
            var diff = endDate - DateTime.Now;
            var remaining = diff.TotalSeconds / totalSeconds * 100;
            var progress = Math.Round(100 - remaining, decimals);

            return progress;
        }

        [HttpGet]
        [Route("ProgressToDate")]
        public double ProgressToDate(DateTime startDate, DateTime endDate, int decimals = 2)
        {
            var totalDiff = endDate - startDate;
            var totalSeconds = totalDiff.TotalSeconds;
            var diff = endDate - DateTime.Now;
            var remaining = diff.TotalSeconds / totalSeconds * 100;
            var progress = Math.Round(100 - remaining, decimals);

            return progress;
        }
    }
}
