 using System;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological
{
    /// <summary>
    /// 
    /// </summary>
    /// TODO: Func<> delegate + Dictionary
    public partial class WaistToHeightRatio
    {
        public double Calculate(double height, double waist)
        {
            double whr = waist / height;

            return whr;
        }

//Subjects
//Waist-to-height ratio
//Marilyn Monroe
//0.3359 
//Female college swimmer
//0.4240 
//Male college swimmer
//0.4280 
//Bodybuilder
//0.4580 
//Female at increased risk
//0.4920 
//General healthy cutoff
//0.5000 
//Risk equivalent to BMI of 25
//0.5100 
//Males at increased risk
//0.5360 
//Risk equivalent to BMI of 30
//0.5700 
//Obese
//0.5770 
//Substantial risk increase
//0.5820 


    }
}
