using System;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological
{
    /// <summary>
    /// 
    /// </summary>
    /// TODO: Func<> delegate + Dictionary
    public partial class HeartRateMaximal : MorphologicalMeasurement
    {
        public double Calculation(double age)
        {
            double hrm = 220.0 - age;

            return hrm;
        }

        /// <summary>
        /// Heart Rate Maximal based on Mioglobal algorithm
        /// NOTE: very suspicious algorithm (0.64 factor and no gender in their formula)
        /// CalculateMioglobal 
        /// </summary>
        /// <returns>CalculateMioglobal</returns>
        /// <param name="age">Age.</param>
        /// <see cref="https://www.mioglobal.com/en-us/calculate-heart-rate-zone.htm"/>
        public double CalculateMioglobal(double age)
        {
            double hrm = 211 - (0.64 * age);

            return hrm;
        }


        public double Calculate(double age, Gender g)
        {
            double hrm = 0.0;

            if (g == Gender.Male)
            {
                hrm = 214 - (0.8 * age);
            }
            else if (g == Gender.Female)
            {
                hrm = 209 - (0.9 * age);
            }

            return hrm;
        }
    }
}
