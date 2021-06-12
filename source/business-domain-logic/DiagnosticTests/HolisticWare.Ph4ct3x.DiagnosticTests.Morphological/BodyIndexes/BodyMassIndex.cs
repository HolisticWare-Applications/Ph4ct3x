 using System;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.BodyIndices
{
    /// <summary>
    /// 
    /// </summary>
    /// TODO: Func<> delegate + Dictionary
    public partial class BodyMassIndex : DiagnosticTests.Morphological.BodyIndices.BodyIndexBase
    {
        public double Calculate(double mass, double height)
        {
            double bmi = mass / (height * height);

            return bmi;
        }

        public double Calculate(double mass, double height, double? exponent)
        {
            double exponent_calculated = 2.5;

            //Interval<double> exponent_range = new Interval<double>("[2.3, 2.7]");

            //if (exponent_range.Contains(exponent))
            //(
            //)

            double bmi = mass / System.Math.Pow(height, exponent_calculated);

            return bmi;
        }

        public double Mass
        {
            get;
            set;
        }

        public double Height
        {
            get;
            set;
        }

        public double Exponent
        {
            get;
            set;
        }

		public override double Value
		{
			get
			{
				
				return Double.NaN;
			}
		}

    }
}
