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

	}
}

