using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Models.Utilities
{
    public class KhmerLunarDate
    {
		public DateTime solarDate { get; set; }
		public string lunarDate { get; set; }
		public string note { get; set; }
		public bool holiday { get; set; }
		public bool buddhistDay { get; set; } //holy-day
		public bool specialCase { get; set; } //shaved day or month transition

		public KhmerLunarDate(){}
		
		public KhmerLunarDate(DateTime solarDate, string lunarDate)
		{
			this.solarDate = solarDate;
			this.lunarDate = lunarDate;
		}

		public KhmerLunarDate(DateTime solarDate, string lunarDate, bool buddhistDay)
		{
			this.solarDate = solarDate;
			this.lunarDate = lunarDate;
			this.buddhistDay = buddhistDay; // this property is calculated
		}

		public KhmerLunarDate(DateTime solarDate, string lunarDate, string note)
		{
			this.solarDate = solarDate;
			this.lunarDate = lunarDate;
			this.note = note;
		}

		public KhmerLunarDate(DateTime solarDate, string lunarDate, bool holiday, string note)
		{
			this.solarDate = solarDate;
			this.lunarDate = lunarDate;
			this.holiday = holiday;
			this.note = note;
		}

		public KhmerLunarDate(DateTime solarDate, string lunarDate, string note, bool specialCase)
		{
			this.solarDate = solarDate;
			this.lunarDate = lunarDate;
			this.note = note;
			this.specialCase = specialCase;
		}

		// constructor for holiday
		public KhmerLunarDate(DateTime solarDate, bool holiday, string note)
		{
			this.solarDate = solarDate;
			this.holiday = holiday;
			this.note = note;
		}

		// define static holiday
	}
}