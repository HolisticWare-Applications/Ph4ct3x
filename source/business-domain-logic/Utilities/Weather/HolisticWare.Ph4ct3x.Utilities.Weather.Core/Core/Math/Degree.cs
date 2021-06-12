using System;

namespace Core.Math
{
    /// <summary>
    /// Degree
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Degree_(angle)"/>
    /// <see href="https://en.wikipedia.org/wiki/Decimal_degrees"/>
    /// <see cref="https://en.wikipedia.org/wiki/Geographical_distance"/>
    public class Degree
    {
        public Degree()
        {
        }

        public
                double
                                Decimal
        {
            get;
            set;
        }

        public
            (
                int Degrees,
                int Minutes,
                double Seconds
            )
                                DegreesMinutesSeconds
        {
            get;
            set;
        }

        public
            (
                int Degrees,
                int Minutes,
                double Seconds
            )
                                DMS
        {
            get
            {
                return DegreesMinutesSeconds;
            }
            set
            {
                DegreesMinutesSeconds = value;
            }
        }

        public
            double
                                Radians
        {
            get
            {
                return 0.0;
            }
            set
            {

            }
        }

        public
            (
                int Degrees,
                int Minutes,
                double Seconds
            )
                                DecimalToDegreesMinutesSeconds
            (
                double degrees_decimal
            )
        {
            int d = (int)System.Math.Truncate(degrees_decimal);
            int m = (int)System.Math.Truncate(60.0 * (degrees_decimal - d));
            double s = 3600.0 * (degrees_decimal - d) - 60.0 * m;

            return
                (
                    Degrees: d,
                    Minutes: m,
                    Seconds: s
                );
        }

    }
}
