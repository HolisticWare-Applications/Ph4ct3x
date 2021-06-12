using System;

namespace Core
{
    public static class DateTimeExtensions
    {
        public static double Age(this DateTime date_of_birth)
        {
            TimeSpan age = DateTime.Now - date_of_birth;

            double age_in_years = age.TotalHours / 8765.82;

            return age_in_years;
        }
    }
}
