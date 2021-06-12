using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Ph4ct3x.App.XamarinForms.Models;
using Ph4ct3x.App.XamarinForms.Views.DiagnosticTests;
using Ph4ct3x.App.XamarinForms.Views.MotoricalTests;
using Ph4ct3x.App.XamarinForms.Views.PhysiologicalTests;

namespace Ph4ct3x.App.XamarinForms.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        readonly Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.SomatoType:
                        MenuPages.Add(id, new NavigationPage(new SomatoTypePage()));
                        break;
                    case (int)MenuItemType.BodyIndexes:
                        MenuPages.Add(id, new NavigationPage(new BodyIndexesPage()));
                        break;
                    case (int)MenuItemType.MaxLoadApproximation:
                        MenuPages.Add(id, new NavigationPage(new MaxLoadApproximationPage()));
                        break;
                    case (int)MenuItemType.BodyFatApproximation:
                        MenuPages.Add(id, new NavigationPage(new BodyFatApproximationPage()));
                        break;
                    case (int)MenuItemType.BasalMetabolicRate:
                        MenuPages.Add(id, new NavigationPage(new BasalMetabolicRatePage()));
                        break;
                }
            }

            NavigationPage newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}