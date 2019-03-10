using System;
using Robotics.Mobile.Core.Bluetooth.LE;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HeartRateMonitor
{
    public partial class App : Application
    {
        static IAdapter Adapter;

        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new DeviceList(Adapter));

        }

        public static void SetAdapter(IAdapter adapter)
        {
            Adapter = adapter;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
