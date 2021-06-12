using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using MvvmCross.Ph4ct3x.Core.ViewModels.DiagnosticTests.MotoricalTests;
using Xamarin.Forms.Xaml;

namespace MvvmCross.Ph4ct3x.UI.Pages.DiagnosticTests.MotoricalTests
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = true, Title = "Max Load Approximation Page")]
    public partial class MaxLoadApproximationPage : MvxContentPage<MaxLoadApproximationPageViewModel>
    {
        public MaxLoadApproximationPage()
        {
            InitializeComponent();
        }
    }
}
