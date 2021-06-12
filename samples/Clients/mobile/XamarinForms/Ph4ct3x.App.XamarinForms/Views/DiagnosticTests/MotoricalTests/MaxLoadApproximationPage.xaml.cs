using System;
using System.Collections.Generic;
using HolisticWare.Ph4ct3x.DiagnosticTests.Motorical;
using Xamarin.Forms;

namespace Ph4ct3x.App.XamarinForms.Views.MotoricalTests
{
    public partial class MaxLoadApproximationPage : ContentPage
    {
        public MaxLoadApproximationPage()
        {
            InitializeComponent();

            entryBodyMass.Text = 82.ToString();
            entryNumberOfRepetition.Text = 5.ToString();
        }

        private void ButtonCalculate_Clicked(object sender, EventArgs e)
        {
            MaxLoadApproximation maxLoadApproximation = new MaxLoadApproximation
            {
                Mass = double.Parse(entryBodyMass.Text),
                NumberOfRepetitions = ulong.Parse(entryNumberOfRepetition.Text),
            };

            Dictionary<string, double> results = maxLoadApproximation.Calculate((double)maxLoadApproximation.Mass, (ulong)maxLoadApproximation.NumberOfRepetitions);

            labelResultEpleyWikipedia.Text = results["Epley (Wikipedia)"].ToString();
            labelResultBrzyckiWikipedia.Text = results["Brzycki (Wikipedia)"].ToString();
            labelResultMcGlothinWikipedia.Text = results["McGlothin (Wikipedia)"].ToString();
            labelResultLombardiWikipedia.Text = results["Lombardi (Wikipedia)"].ToString();
            labelResultMayhewWikipedia.Text = results["Mayhew et al. (Wikipedia)"].ToString();
            labelResultOConnerWikipedia.Text = results["O'Conner et al. (Wikipedia)"].ToString();
            labelResultWathanWikipedia.Text = results["Wathan (Wikipedia)"].ToString();
            labelResultBeachleBrianMac.Text = results["Beachle (BrianMac)"].ToString();
            labelResultBryzickyBrianMac.Text = results["Bryzicky (BrianMac)"].ToString();
            labelResultBryzickySportScience.Text = results["Bryzicky (SportScience)"].ToString();
            labelResultEpleyBrianMac.Text = results["Epley (BrianMac)"].ToString();
            labelResultEpleySportScience.Text = results["Epley (SportScience)"].ToString();
            labelResultLanderSportScience.Text = results["Lander (SportScience)"].ToString();
            labelResultLandersBrianMac.Text = results["Landers (BrianMac)"].ToString();
            labelResultLombardiSportScience.Text = results["Lombardi (SportScience)"].ToString();
            labelResultMayhewSportScience.Text = results["Mayhew et. al. (SportScience)"].ToString();
            labelResultOConnerSportScience.Text = results["OConner et. al. (SportScience)"].ToString();
            labelResultWathanSportScience.Text = results["Wathan (SportScience)"].ToString();
        }
    }
}
