using System;

namespace HolisticWare.Ph4ct3x
{
	public class Person : HolisticWare.Ph4ct3x.Object
	{
		public Person ()
		{
		}

		public string NameFirstGiven
		{
			get;
			set;
		}

		public string NameSecondFamily
		{
			get;
			set;
		}

		public DateTime DateOfBirth
		{
			get;
			set;
		}

		public Gender Gender
		{
			get;
			set;
		}

		public TimeSpan Age ()
		{
			DateTime dt_stop = DateTime.Now;
			DateTime dt_start = this.DateOfBirth;

			TimeSpan ts_age = dt_stop -  dt_start;

			DateTime Age = DateTime.MinValue + ts_age;

			// note: MinValue is 1/1/1 so we have to subtract...
	        int Years = Age.Year - 1;
	        int Months = Age.Month - 1;
	        int Days = Age.Day - 1;
	 
			return ts_age;
		}

		public double AgeinYears ()
		{
			TimeSpan a = this.Age();
			double age = a.TotalDays;

			return age / 365.25;
		}
	}
}

