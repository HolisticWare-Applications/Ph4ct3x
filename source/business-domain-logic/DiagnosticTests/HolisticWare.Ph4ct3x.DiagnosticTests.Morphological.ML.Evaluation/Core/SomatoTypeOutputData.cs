
namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes.ML.Evaluation.Core
{
    public class SomatotypeOutputtData : SomatotypeInputData
    {
        public SomatotypeOutputtData(SomatotypeInputData stid)
            : base(stid)
        {

        }

        public double Endomorphic
        {
            get;
            set;
        }

        public double Mesomorphic
        {
            get;
            set;
        }

        public double EctoMorphic
        {
            get;
            set;
        }

    }
}