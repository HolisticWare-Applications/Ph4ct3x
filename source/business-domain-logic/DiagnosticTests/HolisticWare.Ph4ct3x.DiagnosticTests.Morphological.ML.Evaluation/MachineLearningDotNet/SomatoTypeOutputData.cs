using System.Collections.Generic;

using HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes.ML.Evaluation.MachineLearningDotNet
{
    public class SomatotypeOutputData
    {
        [Microsoft.ML.Data.LoadColumn(0)]
        public float EndomorphicComponent
        {
            get;
            set;
        }


    }
}