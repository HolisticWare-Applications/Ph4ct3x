using System;

using HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.BodyIndices;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.BodyFatApproximations
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref="http://bmi-calories.com/body-fat-percentage-calculator.html"/>
    /// <see cref=""/>
    /// <see cref=""/>
    /// <see cref=""/>
    /// TODO: Func<> delegate + Dictionary
    public partial class Simple : MorphologicalMeasurement
    {
        public double Calculate(double mass, double height, Gender gender, double age, double age_childhood_treshold)
        {
            double gender_factor = double.NaN;

            if (gender == Gender.Female)
            {
                gender_factor = 0;
            }
            else
            {
                gender_factor = 1;
            }

            double retval = double.NaN;
            double bmi = new BodyMassIndex().Calculate(mass, height);

            if (age > age_childhood_treshold)
            {
                // Adults
                retval = (1.20 * bmi) + (0.23 * age) - (10.8 * gender_factor) - 5.4;
            }
            else
            {
                // Children
                retval = (1.51 * bmi) - (0.70 * age) - (3.6 * gender_factor) + 1.4;
            }
                
            return retval;
        }

    }
}
