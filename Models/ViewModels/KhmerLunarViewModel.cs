using System;
using System.Collections.Generic;
using Models.Utilities;

namespace Models.ViewModels
{
    public class KhmerLunarViewModel
    {
		public string prevMonth { get; set; }
		public string nextMonth { get; set; }
		public int skipper { get; set; }
		public int lastDay { get; set; }
		public int numRows { get; set; }
		public string lLunarDate { get; set; } // long lunar date

        public ICollection<KhmerLunarDate> khmerLunarDates { get; set; }

		public KhmerLunarViewModel(){}
    }
}