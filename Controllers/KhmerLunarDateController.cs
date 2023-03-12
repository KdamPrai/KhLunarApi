using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace kh_lunisolar_calendar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KhmerLunarDateController : ControllerBase
    {
        private readonly ILogger<KhmerLunarDateController> _logger;

        public KhmerLunarDateController(ILogger<KhmerLunarDateController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            string[] someDate = {"dd", "mm", "YYYY"};
            return someDate;
        }

        [AllowAnonymous]
        public IActionResult Calendar()
        {
            DateTime dt = DateTime.Now;

            DateTime firstDayOfMonth = new DateTime(dt.Year, dt.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            Hashtable hashMonth = KhmerLunar.getHashMonth();

            string firstDayLunarCode = KhmerLunar.getKhmerLunarCode(firstDayOfMonth);
            string prevMonth = hashMonth[firstDayLunarCode.Substring(8,2)].ToString();
            ViewBag.prevMonth = prevMonth;

            string lastDayLunarCode = KhmerLunar.getKhmerLunarCode(lastDayOfMonth);
            string nextMonth = hashMonth[lastDayLunarCode.Substring(8,2)].ToString();
            ViewBag.nextMonth = nextMonth;

            int skipper = (int) firstDayOfMonth.DayOfWeek; // number of col to skip for first day of month
            int lastDay = lastDayOfMonth.Day; // where to stop loop from adding day to table
            int numRows = (lastDay + skipper) / 7;
            ViewBag.skipper = skipper;
            ViewBag.lastDay = lastDay;
            ViewBag.numRows = numRows;

            String mKh = KhmerLunar.getKhmerLunarString(dt);
            ViewBag.mKh = mKh;

            //function to create calendar needs to be param of month (default: current month)

            KhmerLunarDate kld = new KhmerLunarDate();
            return View();
        }
    }
}
