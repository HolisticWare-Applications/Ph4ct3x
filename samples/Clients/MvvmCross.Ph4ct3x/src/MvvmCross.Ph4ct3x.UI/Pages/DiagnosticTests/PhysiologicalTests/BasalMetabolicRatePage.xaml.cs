using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using MvvmCross.Ph4ct3x.Core.ViewModels.DiagnosticTests.PhysiologicalTests;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmCross.Ph4ct3x.UI.Pages.DiagnosticTests.PhysiologicalTests
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = true, Title = "Basal Metabolic RatePage")]
    public partial class BasalMetabolicRatePage : MvxContentPage<BasalMetabolicRatePageViewModel>
    {
        public BasalMetabolicRatePage()
        {
            InitializeComponent();
        }
    }
}
