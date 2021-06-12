 using System;


namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.BodyIndices
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref="https://www.ncbi.nlm.nih.gov/pmc/articles/PMC3477292/"/>
    /// TODO: Func<> delegate + Dictionary
    public partial class BodyAdiposityIndex : MorphologicalMeasurement
    {
        public double Calculate(double height, double circumference_hip)
        {
            height = base.FixUnits(height);

            // (100.0 x Hip(meters) ) / (Height(meters) x(Height(meters)1 / 2) - 18
            double retval = ((100.0 * circumference_hip) / Math.Pow(height, 1.5)) - 18.0;

            return retval;
        }
    }
}
