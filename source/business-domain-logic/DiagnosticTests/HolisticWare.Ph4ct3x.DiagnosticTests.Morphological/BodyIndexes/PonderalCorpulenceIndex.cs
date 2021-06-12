using System;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.BodyIndices
{
    /// <summary>
    /// 
    /// </summary>
    /// TODO: Func<> delegate + Dictionary
    public partial class PonderalCorpulenceIndex : MorphologicalMeasurement
    {
        public double Calculation(double mass, double height)
        {
            double pi = mass / (height * height * height);

            return pi;
        }
    }
}
