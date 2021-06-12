using System;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Physiological
{
    /// <summary>
    /// 
    /// </summary>
    public class WaterIntakeTests
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="exercise"></param>
        /// <returns></returns>
        /// <see href="https://goodcalculators.com/water-intake-calculator/"/>
        public double Calculate(double weight, double exercise)
        {
            double water_per_30_minutes_exercise = 0.354882; // 12 ounces
            double n = exercise / 30.0;

            return (2.0 / 3.0) * weight + water_per_30_minutes_exercise * n;
        }
    }
}
