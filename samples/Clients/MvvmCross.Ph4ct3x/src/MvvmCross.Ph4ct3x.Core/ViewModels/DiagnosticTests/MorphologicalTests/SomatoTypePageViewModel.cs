using System.Threading.Tasks;
using HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes;
using HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes.ML.Evaluation.AzureMachineLearningStudio;
using HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes.ML.Evaluation.Core;
using MvvmCross.Commands;

namespace MvvmCross.Ph4ct3x.Core.ViewModels.DiagnosticTests.MorphologicalTests
{
    public class SomatoTypePageViewModel : BaseViewModel
    {
        private double bodyMass;
        private double bodyHeight;
        private double skinfoldTriceps;
        private double skinfoldSubscapular;
        private double skinfoldSupraspinale;
        private double skinfoldCalfMedial;
        private double breadthsHumerus;
        private double breadthsFemur;
        private double girthCircumfenceArmUpper;
        private double girthCircumfenceCalft;
        private string calculationResultUniversityOfExeter = "N/A";
        private string calculationResultMisigojDurakovic = "N/A";
        private SomatotypeInputData sampleml;

        public SomatoTypePageViewModel()
        {
            BodyMass = 82;
            BodyHeight = 191.7;
            SkinfoldTriceps = 7;
            SkinfoldSubscapular = 6;
            SkinfoldSupraspinale = 4;
            SkinfoldCalfMedial = 9;
            BreadthsHumerus = 7.3;
            BreadthsFemur = 10.1;
            GirthCircumfenceArmUpper = 33.2;
            GirthCircumfenceCalf = 36;
            CalculateAsyncCommand = new MvxAsyncCommand(CalculateAsync);
            CalculateAzureMLStudioAsyncCommand = new MvxAsyncCommand(CalculateAzureMLStudioAsync);
        }

        public double BodyMass
        {
            get => bodyMass;
            set => SetProperty(ref bodyMass, value);
        }

        public double BodyHeight
        {
            get => bodyHeight;
            set => SetProperty(ref bodyHeight, value);
        }

        public double SkinfoldTriceps
        {
            get => skinfoldTriceps;
            set => SetProperty(ref skinfoldTriceps, value);
        }

        public double SkinfoldSubscapular
        {
            get => skinfoldSubscapular;
            set => SetProperty(ref skinfoldSubscapular, value);
        }

        public double SkinfoldSupraspinale
        {
            get => skinfoldSupraspinale;
            set => SetProperty(ref skinfoldSupraspinale, value);
        }

        public double SkinfoldCalfMedial
        {
            get => skinfoldCalfMedial;
            set => SetProperty(ref skinfoldCalfMedial, value);
        }

        public double BreadthsHumerus
        {
            get => breadthsHumerus;
            set => SetProperty(ref breadthsHumerus, value);
        }

        public double BreadthsFemur
        {
            get => breadthsFemur;
            set => SetProperty(ref breadthsFemur, value);
        }

        public double GirthCircumfenceArmUpper
        {
            get => girthCircumfenceArmUpper;
            set => SetProperty(ref girthCircumfenceArmUpper, value);
        }

        public double GirthCircumfenceCalf
        {
            get => girthCircumfenceCalft;
            set => SetProperty(ref girthCircumfenceCalft, value);
        }

        public string CalculationResultUniversityOfExeter
        {
            get => calculationResultUniversityOfExeter;
            set => SetProperty(ref calculationResultUniversityOfExeter, value);
        }

        public string CalculationResultMisigojDurakovic
        {
            get => calculationResultMisigojDurakovic;
            set => SetProperty(ref calculationResultMisigojDurakovic, value);
        }

        public string CalculationResultAzureMachineLearningStudio
        {
            get => calculationResultAzureMachineLearningStudio;
            set => SetProperty(ref calculationResultAzureMachineLearningStudio, value);
        }

        public IMvxAsyncCommand CalculateAsyncCommand { get; set; }

        public IMvxAsyncCommand CalculateAzureMLStudioAsyncCommand { get; set; }

        private async Task CalculateAsync()
        {
            await Task.Run(() =>
            {
                HeathCarterEastonUniversityOfExeter hc1 = new HeathCarterEastonUniversityOfExeter()
                {
                    Mass = BodyMass,
                    Height = BodyHeight,
                    Skinfolds = new Skinfolds
                    {
                        SubTriceps = SkinfoldTriceps,
                        SubScapular = SkinfoldSubscapular,
                        SupraIliac = SkinfoldSupraspinale,
                        Calf = SkinfoldCalfMedial,
                    },
                    Bicondyles = new Bicondyles()
                    {
                        Femur = BreadthsFemur,
                        Humerus = BreadthsHumerus,
                    },
                    Circumferences = new Circumferences
                    {
                        ArmUpper = GirthCircumfenceArmUpper,
                        Calf = GirthCircumfenceCalf,
                    }
                };

                double endomorphic1 = hc1.EndomorphicComponent();
                double mesomorphic1 = hc1.MesomorphicComponent();
                double ectomorphic1 = hc1.EctomorphicComponent();

                CalculationResultUniversityOfExeter = $"{endomorphic1}, {mesomorphic1}, {ectomorphic1}";

                HeathCarterMisigojDurakovic hc2 = new HeathCarterMisigojDurakovic()
                {
                    Mass = BodyMass,
                    Height = BodyHeight,
                    Skinfolds = new Skinfolds
                    {
                        SubTriceps = SkinfoldTriceps,
                        SubScapular = SkinfoldSubscapular,
                        SupraIliac = SkinfoldSupraspinale,
                        Calf = SkinfoldCalfMedial
                    },
                    Bicondyles = new Bicondyles()
                    {
                        Femur = BreadthsFemur,
                        Humerus = BreadthsHumerus
                    },
                    Circumferences = new Circumferences
                    {
                        ArmUpper = GirthCircumfenceArmUpper,
                        Calf = GirthCircumfenceCalf
                    }
                };

                double endomorphic2 = hc2.EndomorphicComponent();
                double mesomorphic2 = hc2.MesomorphicComponent();
                double ectomorphic2 = hc2.EctomorphicComponent();

                CalculationResultMisigojDurakovic = $"{endomorphic2}, {mesomorphic2}, {ectomorphic2}";
            });
        }

        private string calculationResultAzureMachineLearningStudio;

        private async Task CalculateAzureMLStudioAsync()
        {
            await Task.Run(() =>
            {
                CalculationResultAzureMachineLearningStudio = "Request sent to Azure ML Web Service...";

                sampleml = new SomatotypeInputData()
                {
                    Height = BodyHeight,
                    Mass = BodyMass,
                    BreadthHumerus = BreadthsHumerus,
                    BreadthFemur = BreadthsFemur,
                    GirthArmUpper = GirthCircumfenceArmUpper,
                    GirthCalfStanding = GirthCircumfenceCalf,
                    SkinfoldTriceps = SkinfoldTriceps,
                    SkinfoldSubscapular = SkinfoldSubscapular,
                    SkinfoldMedialCalf = SkinfoldCalfMedial,
                    SkinfoldSupraspinale = SkinfoldSupraspinale
                };

                double endomorphic = AzureMachineLearningService.Request
                                                                    (
                                                                        sampleml.Height,
                                                                        sampleml.Mass,
                                                                        sampleml.SkinfoldTriceps,
                                                                        sampleml.SkinfoldSubscapular,
                                                                        sampleml.SkinfoldSupraspinale,
                                                                        sampleml.SkinfoldMedialCalf,
                                                                        sampleml.GirthArmUpper,
                                                                        sampleml.GirthCalfStanding,
                                                                        sampleml.BreadthFemur,
                                                                        sampleml.BreadthHumerus
                                                                    );


                CalculationResultAzureMachineLearningStudio = endomorphic.ToString();
            });
        }
    }
}
