using System.Collections.Generic;
using System.Threading.Tasks;
using HolisticWare.Ph4ct3x.DiagnosticTests.Motorical;
using MvvmCross.Commands;

namespace MvvmCross.Ph4ct3x.Core.ViewModels.DiagnosticTests.MotoricalTests
{
    public class MaxLoadApproximationPageViewModel : BaseViewModel
    {
        private double bodyMass;
        private ulong numberOfRepetition;
        private string resultEpleyWikipedia;
        private string resultBrzyckiWikipedia;
        private string resultMcGlothinWikipedia;
        private string resultLombardiWikipedia;
        private string resultMayhewWikipedia;
        private string resultOConnerWikipedia;
        private string resultWathanWikipedia;
        private string resultBeachleBrianMac;
        private string resultBryzickyBrianMac;
        private string resultBryzickySportScience;
        private string resultEpleyBrianMac;
        private string resultEpleySportScience;
        private string resultLanderSportScience;
        private string resultLandersBrianMac;
        private string resultLombardiSportScience;
        private string resultMayhewSportScience;
        private string resultOConnerSportScience;
        private string resultWathanSportScience;

        public MaxLoadApproximationPageViewModel()
        {
            CalculateAsyncCommand = new MvxAsyncCommand(CalculateAsync);
        }

        public double BodyMass
        {
            get => bodyMass;
            set => SetProperty(ref bodyMass, value);
        }

        public ulong NumberOfRepetition
        {
            get => numberOfRepetition;
            set => SetProperty(ref numberOfRepetition, value);
        }

        public string ResultEpleyWikipedia
        {
            get => resultEpleyWikipedia;
            set => SetProperty(ref resultEpleyWikipedia, value);
        }

        public string ResultBrzyckiWikipedia
        {
            get => resultBrzyckiWikipedia;
            set => SetProperty(ref resultBrzyckiWikipedia, value);
        }

        public string ResultMcGlothinWikipedia
        {
            get => resultMcGlothinWikipedia;
            set => SetProperty(ref resultMcGlothinWikipedia, value);
        }

        public string ResultLombardiWikipedia
        {
            get => resultLombardiWikipedia;
            set => SetProperty(ref resultLombardiWikipedia, value);
        }

        public string ResultMayhewWikipedia
        {
            get => resultMayhewWikipedia;
            set => SetProperty(ref resultMayhewWikipedia, value);
        }

        public string ResultOConnerWikipedia
        {
            get => resultOConnerWikipedia;
            set => SetProperty(ref resultOConnerWikipedia, value);
        }

        public string ResultWathanWikipedia
        {
            get => resultWathanWikipedia;
            set => SetProperty(ref resultWathanWikipedia, value);
        }

        public string ResultBeachleBrianMac
        {
            get => resultBeachleBrianMac;
            set => SetProperty(ref resultBeachleBrianMac, value);
        }

        public string ResultBryzickyBrianMac
        {
            get => resultBryzickyBrianMac;
            set => SetProperty(ref resultBryzickyBrianMac, value);
        }

        public string ResultBryzickySportScience
        {
            get => resultBryzickySportScience;
            set => SetProperty(ref resultBryzickySportScience, value);
        }

        public string ResultEpleyBrianMac
        {
            get => resultEpleyBrianMac;
            set => SetProperty(ref resultEpleyBrianMac, value);
        }

        public string ResultEpleySportScience
        {
            get => resultEpleySportScience;
            set => SetProperty(ref resultEpleySportScience, value);
        }

        public string ResultLanderSportScience
        {
            get => resultLanderSportScience;
            set => SetProperty(ref resultLanderSportScience, value);
        }

        public string ResultLandersBrianMac
        {
            get => resultLandersBrianMac;
            set => SetProperty(ref resultLandersBrianMac, value);
        }

        public string ResultLombardiSportScience
        {
            get => resultLombardiSportScience;
            set => SetProperty(ref resultLombardiSportScience, value);
        }

        public string ResultMayhewSportScience
        {
            get => resultMayhewSportScience;
            set => SetProperty(ref resultMayhewSportScience, value);
        }

        public string ResultOConnerSportScience
        {
            get => resultOConnerSportScience;
            set => SetProperty(ref resultOConnerSportScience, value);
        }

        public string ResultWathanSportScience
        {
            get => resultWathanSportScience;
            set => SetProperty(ref resultWathanSportScience, value);
        }

        public IMvxAsyncCommand CalculateAsyncCommand { get; set; }

        private async Task CalculateAsync()
        {
            await Task.Run(() =>
            {
                MaxLoadApproximation maxLoadApproximation = new MaxLoadApproximation
                {
                    Mass = BodyMass,
                    NumberOfRepetitions = NumberOfRepetition,
                };

                Dictionary<string, double> results = maxLoadApproximation.Calculate((double)maxLoadApproximation.Mass, (ulong)maxLoadApproximation.NumberOfRepetitions);

                ResultEpleyWikipedia = results["Epley (Wikipedia)"].ToString();
                ResultBrzyckiWikipedia = results["Brzycki (Wikipedia)"].ToString();
                ResultMcGlothinWikipedia = results["McGlothin (Wikipedia)"].ToString();
                ResultLombardiWikipedia = results["Lombardi (Wikipedia)"].ToString();
                ResultMayhewWikipedia = results["Mayhew et al. (Wikipedia)"].ToString();
                ResultOConnerWikipedia = results["O'Conner et al. (Wikipedia)"].ToString();
                ResultWathanWikipedia = results["Wathan (Wikipedia)"].ToString();
                ResultBeachleBrianMac = results["Beachle (BrianMac)"].ToString();
                ResultBryzickyBrianMac = results["Bryzicky (BrianMac)"].ToString();
                ResultBryzickySportScience = results["Bryzicky (SportScience)"].ToString();
                ResultEpleyBrianMac = results["Epley (BrianMac)"].ToString();
                ResultEpleySportScience = results["Epley (SportScience)"].ToString();
                ResultLanderSportScience = results["Lander (SportScience)"].ToString();
                ResultLandersBrianMac = results["Landers (BrianMac)"].ToString();
                ResultLombardiSportScience = results["Lombardi (SportScience)"].ToString();
                ResultMayhewSportScience = results["Mayhew et. al. (SportScience)"].ToString();
                ResultOConnerSportScience = results["OConner et. al. (SportScience)"].ToString();
                ResultWathanSportScience = results["Wathan (SportScience)"].ToString();
            });
        }
    }
}
