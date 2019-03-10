using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace HolisticWare.Ph4ct3x.MasterDetail.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}