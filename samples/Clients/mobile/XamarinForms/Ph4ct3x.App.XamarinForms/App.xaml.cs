using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ph4ct3x.App.XamarinForms.Services;
using Ph4ct3x.App.XamarinForms.Views;
using System.Collections.Generic;

namespace Ph4ct3x.App.XamarinForms
{
    public partial class App : Application
    {
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        //To debug on Android emulators run the web backend against .NET Core not IIS
        //If using other emulators besides stock Google images you may need to adjust the IP address
        public static string AzureBackendUrl =
            DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";
        public static bool UseMockDataStore = true;

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<AzureDataStore>();
            MainPage = new MainPage();

            // https://devblogs.microsoft.com/xamarin/xamarin-forms-4-5/
            // https://github.com/xamarin/Xamarin.Forms/blob/master/Xamarin.Forms.Core/ExperimentalFlags.cs
            Xamarin.Forms.Device.SetFlags
                                    (
                                        new List<string>()
                                        {
                                            "StateTriggers_Experimental",
                                            "IndicatorView_Experimental",
                                            "Shell_UWP_Experimental",
                                            "CarouselView_Experimental",
                                            "SwipeView_Experimental",
                                            "MediaElement_Experimental",
                                        }
                                    );
            return;
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
