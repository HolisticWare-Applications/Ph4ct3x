using System;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological
{
    public class MorphologicalMeasurement
    {
        public double FixUnits(double? height)
        {
            double h;

            if (height.HasValue)
            {
                if (height >= 30 && height <= 300)
                {
                    // centimeters to meters
                    h = height.Value / 100.0;
                }
                else if (height >= 0.30 && height <= 3.00)
                {
                    // meters
                    h = height.Value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Height {height}");
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Height {height}");
            }

            return h;
        }

    }
}