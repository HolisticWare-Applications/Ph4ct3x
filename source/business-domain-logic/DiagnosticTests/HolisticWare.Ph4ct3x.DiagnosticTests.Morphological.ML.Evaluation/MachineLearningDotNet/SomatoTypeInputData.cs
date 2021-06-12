using System.Collections.Generic;

using HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes.ML.Evaluation.MachineLearningDotNet
{
    public class SomatotypeInputData
    {
        [Microsoft.ML.Data.LoadColumn(0)]
        public float EndomorphicComponent
        {
            get;
            set;
        }

        [Microsoft.ML.Data.LoadColumn(1)]
        public float MesomorphicComponent
        {
            get;
            set;
        }

        [Microsoft.ML.Data.LoadColumn(2)]
        public float EctomorphicComponent
        {
            get;
            set;
        }

        [Microsoft.ML.Data.LoadColumn(3)]
        public int Id
        {
            get;
            set;
        }

        [Microsoft.ML.Data.LoadColumn(4)]
        public double Height
        {
            get;
            set;
        }

        [Microsoft.ML.Data.LoadColumn(5)]
        public double Mass
        {
            get;
            set;
        }


        [Microsoft.ML.Data.LoadColumn(6)]
        public double BreadthHumerus
        {
            get;
            set;
        }

        [Microsoft.ML.Data.LoadColumn(7)]
        public double BreadthFemur
        {
            get;
            set;
        }

        [Microsoft.ML.Data.LoadColumn(8)]
        public double GirthArmUpper
        {
            get;
            set;
        }

        [Microsoft.ML.Data.LoadColumn(9)]
        public double GirthCalfStanding
        {
            get;
            set;
        }

        [Microsoft.ML.Data.LoadColumn(10)]
        public double SkinfoldSubscapular
        {
            get;
            set;
        }

        [Microsoft.ML.Data.LoadColumn(11)]
        public double SkinfoldTriceps
        {
            get;
            set;
        }
        
        [Microsoft.ML.Data.LoadColumn(12)]
        public double SkinfoldSupraspinale
        {
            get;
            set;
        }

        [Microsoft.ML.Data.LoadColumn(13)]
        public double SkinfoldMedialCalf
        {
            get;
            set;
        }

    }
}