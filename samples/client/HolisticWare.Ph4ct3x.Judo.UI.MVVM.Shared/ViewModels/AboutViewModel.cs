using System;
using System.Windows.Input;

using Xamarin.Forms;

using HolisticWare.Ph4ct3x.Judo.Views;

namespace HolisticWare.Ph4ct3x.Judo.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
            //Navigation = 
            OpenSearchPageCommand = new Command
                (
                    async () => 
                    Device.OpenUri(new Uri("https://xamarin.com/platform"))
                    //await Application.Current.MainPage.Navigation.PushAsync(new SearchJudoka())
                );
        }

        public INavigation Navigation { get; set; }

        public ICommand OpenWebCommand { get; }

        public ICommand OpenSearchPageCommand { get; }
    }
}