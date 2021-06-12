using System;

namespace HolisticWare.Ph4ct3x
{
    public partial class Person
    {
        public string NameLast
        {
            get;
            set;
        }

        public string NameFirst
        {
            get;
            set;
        }

        public Gender Gender
        {
            get;
            set;
        }

        public DateTime DateOfBirth
        {
            get;
            set;
        }

        public double AgeNumeric
        {
            get
            {
                double a = (DateTime.Today - this.DateOfBirth).Days / 365.25;

                return a;
            }
        }

        public Age Age
        {
            get
            {
                return new Age(this.DateOfBirth);
            }
        }
    }
}
