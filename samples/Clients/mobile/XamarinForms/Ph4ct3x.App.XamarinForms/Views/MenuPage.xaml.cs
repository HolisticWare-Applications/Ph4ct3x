using Ph4ct3x.App.XamarinForms.Models;
using Ph4ct3x.App.XamarinForms.Models.Menu;
using Ph4ct3x.App.XamarinForms.ViewModels.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ph4ct3x.App.XamarinForms.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }

        readonly MenuPageViewModel menuPageViewModel;

        public MenuPage()
        {
            InitializeComponent();
            BindingContext = menuPageViewModel = new MenuPageViewModel();

            ListViewMenu.ItemsSource = menuPageViewModel.GroupedItems;

            ListViewMenu.SelectedItem = menuPageViewModel.GroupedItems[0][2];
            ListViewMenu.ItemSelected += ListViewMenu_ItemSelected;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            int id = (int)((HomeMenuItem)ListViewMenu.SelectedItem).Id;
            await RootPage.NavigateFromMenu(id);
        }

        private async void ListViewMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            int id = (int)((HomeMenuItem)e.SelectedItem).Id;
            await RootPage.NavigateFromMenu(id);
        }
    }
}