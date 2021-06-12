using System;
namespace Demo.ConsoleApp
{
    public class App : Xamarin.Forms.Application
    {
        public App()
        {
            MainPage = new MainPageCS();
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
    }}
