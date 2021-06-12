using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using HolisticWare.Ph4ct3x.Judo.Views;

namespace HolisticWare.Xamarin.Forms.Services
{
    public partial class NavigationService
    {
        public async Task PushPageSearchJudo()
        {
            if (_navigationPage != null)
            {
                await _navigationPage?.PushAsync(new SearchJudoka());
            }
        }

        private static NavigationService _instance = null;

        public static NavigationService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NavigationService();
                }
                return _instance;
            }
        }

        private readonly NavigationPage _navigationPage;

        private NavigationService()
        {
            _navigationPage = Application.Current.MainPage as NavigationPage;
        }

    }
}
