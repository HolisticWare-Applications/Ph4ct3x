using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes;
//using HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes.ML.Evaluation.AzureMachineLearningStudio;
//using HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes.ML.Evaluation.Core;

namespace Ph4ct3x.App.XamarinForms.Views.DiagnosticTests
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SomatoTypePage : ContentPage
    {
        public SomatoTypePage()
        {
            InitializeComponent();

            entryBodyMass.Text = 82.ToString();
            entryBodyHeight.Text = 191.7.ToString();
            entrySkinfoldTriceps.Text = 7.ToString();
            entrySkinfoldSubscapular.Text = 6.ToString();
            entrySkinfoldSupraspinale.Text = 4.ToString();
            entrySkinfoldCalfMedial.Text = 9.ToString();
            entryBreadthsHumerus.Text = 7.3.ToString();
            entryBreadthsFemur.Text = 10.1.ToString();
            entryGirthCircumfenceArmUpper.Text = 33.2.ToString();
            entryGirthCircumfenceCalf.Text = 36.ToString();

            return;
        }

        private void ButtonCalculateLocal_Clicked(object sender, EventArgs e)
        {
            HeathCarterEastonUniversityOfExeter hc1 = new HeathCarterEastonUniversityOfExeter()
            {
                Mass = double.Parse(entryBodyMass.Text),
                Height = double.Parse(entryBodyHeight.Text),
                Skinfolds = new Skinfolds
                {
                    SubTriceps = double.Parse(entrySkinfoldTriceps.Text),
                    SubScapular = double.Parse(entrySkinfoldSubscapular.Text),
                    SupraIliac = double.Parse(entrySkinfoldSupraspinale.Text),
                    Calf = double.Parse(entrySkinfoldCalfMedial.Text)
                },
                Bicondyles = new Bicondyles()
                {
                    Femur = double.Parse(entryBreadthsFemur.Text),
                    Humerus = double.Parse(entryBreadthsHumerus.Text)
                },
                Circumferences = new Circumferences
                {
                    ArmUpper = double.Parse(entryGirthCircumfenceArmUpper.Text),
                    Calf = double.Parse(entryGirthCircumfenceCalf.Text)
                }
            };

            double endomorphic1 = hc1.EndomorphicComponent();
            double mesomorphic1 = hc1.MesomorphicComponent();
            double ectomorphic1 = hc1.EctomorphicComponent();

            string result1 = $"{endomorphic1}, {mesomorphic1}, {ectomorphic1}";

            labelCalculationResultUniversityOfExeter.Text = result1;

            HeathCarterMisigojDurakovic hc2 = new HeathCarterMisigojDurakovic()
            {
                Mass = double.Parse(entryBodyMass.Text),
                Height = double.Parse(entryBodyHeight.Text),
                Skinfolds = new Skinfolds
                {
                    SubTriceps = double.Parse(entrySkinfoldTriceps.Text),
                    SubScapular = double.Parse(entrySkinfoldSubscapular.Text),
                    SupraIliac = double.Parse(entrySkinfoldSupraspinale.Text),
                    Calf = double.Parse(entrySkinfoldCalfMedial.Text)
                },
                Bicondyles = new Bicondyles()
                {
                    Femur = double.Parse(entryBreadthsFemur.Text),
                    Humerus = double.Parse(entryBreadthsHumerus.Text)
                },
                Circumferences = new Circumferences
                {
                    ArmUpper = double.Parse(entryGirthCircumfenceArmUpper.Text),
                    Calf = double.Parse(entryGirthCircumfenceCalf.Text)
                }
            };

            double endomorphic2 = hc2.EndomorphicComponent();
            double mesomorphic2 = hc2.MesomorphicComponent();
            double ectomorphic2 = hc2.EctomorphicComponent();

            string result2 = $"{endomorphic2}, {mesomorphic2}, {ectomorphic2}";

            labelCalculationResultMisigojDurakovic.Text = result2;

            return;
        }

        //SomatotypeInputData sample_ml;

        private void ButtonCalculateAzureMLStudio_Clicked(object sender, EventArgs e)
        {
            //    labelCalculationResultAzureMachineLearningStudio.Text = "Request sent to Azure ML Web Service...";

            //    sample_ml = new SomatotypeInputData()
            //    {
            //        Height = double.Parse(entryBodyHeight.Text),
            //        Mass = double.Parse(entryBodyMass.Text),
            //        BreadthHumerus = double.Parse(entryBreadthsHumerus.Text),
            //        BreadthFemur = double.Parse(entryBreadthsFemur.Text),
            //        GirthArmUpper = double.Parse(entryGirthCircumfenceArmUpper.Text),
            //        GirthCalfStanding = double.Parse(entryGirthCircumfenceCalf.Text),
            //        SkinfoldTriceps = double.Parse(entrySkinfoldTriceps.Text),
            //        SkinfoldSubscapular = double.Parse(entrySkinfoldSubscapular.Text),
            //        SkinfoldMedialCalf = double.Parse(entrySkinfoldCalfMedial.Text),
            //        SkinfoldSupraspinale = double.Parse(entrySkinfoldSupraspinale.Text)
            //    };

            //    double endomorphic = AzureMachineLearningService.Request
            //                                                        (
            //                                                            sample_ml.Height,
            //                                                            sample_ml.Mass,
            //                                                            sample_ml.SkinfoldTriceps,
            //                                                            sample_ml.SkinfoldSubscapular,
            //                                                            sample_ml.SkinfoldSupraspinale,
            //                                                            sample_ml.SkinfoldMedialCalf,
            //                                                            sample_ml.GirthArmUpper,
            //                                                            sample_ml.GirthCalfStanding,
            //                                                            sample_ml.BreadthFemur,
            //                                                            sample_ml.BreadthHumerus
            //                                                        );


            //    labelCalculationResultAzureMachineLearningStudio.Text = endomorphic.ToString();

            //    return;
        }
    }
}