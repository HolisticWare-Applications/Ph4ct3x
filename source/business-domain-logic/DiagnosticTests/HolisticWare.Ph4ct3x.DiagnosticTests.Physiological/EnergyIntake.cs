using System;
using System.Collections.Generic;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Physiological
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref="http://www.bmi-calculator.net/bmr-calculator/harris-benedict-equation/"/> 
    /// TODO: Func<> delegate + Dictionary
    public partial class EnergyIntake 
    {
        public Dictionary<string, double> HarrisBenedictFormula
        {
            get;
            set;
        }

        public EnergyIntake()
        {
            HarrisBenedictFormula = new Dictionary<string, double>()
            {
                {
                    "sedentary (little or no exercise)",
                    1.2
                },
                {
                    "lightly active (light exercise/sports 1-3 days/week)",
                    1.375
                },
                {
                    "moderatetely active (moderate exercise/sports 3-5 days/week)",
                    1.55
                },
                {
                    "very active (hard exercise/sports 6-7 days a week)",
                    1.725
                },
                {
                    "extra active (very hard exercise/sports & physical job or 2x training)",
                    1.9
                },
            };

            return;
        }

    }
}
