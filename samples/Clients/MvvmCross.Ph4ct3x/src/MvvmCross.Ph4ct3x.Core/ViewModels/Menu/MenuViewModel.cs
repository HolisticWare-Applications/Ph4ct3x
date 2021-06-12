using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvvmCross.Ph4ct3x.Core.ViewModels.Contacts;
using MvvmCross.Ph4ct3x.Core.ViewModels.Home;
using Xamarin.Forms;
using MvvmCross.Ph4ct3x.Core.Enums;
using MvvmCross.Ph4ct3x.Core.Models.Menu;
using MvvmCross.Ph4ct3x.Core.ViewModels.DiagnosticTests.MorphologicalTests;
using MvvmCross.Ph4ct3x.Core.ViewModels.DiagnosticTests.MotoricalTests;
using MvvmCross.Ph4ct3x.Core.ViewModels.DiagnosticTests.PhysiologicalTests;

namespace MvvmCross.Ph4ct3x.Core.ViewModels.Menu
{
    public class MenuViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService navigationService;

        public IMvxAsyncCommand ShowDetailPageAsyncCommand { get; private set; }

        public ObservableCollection<GroupedMenuListItem> GroupedItems
        {
            get => groupedItems;
            set => SetProperty(ref groupedItems, value);
        }

        public MenuViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;

            GroupedItems = new MvxObservableCollection<GroupedMenuListItem>();

            GroupedMenuListItem morphologicalMenuItems = new GroupedMenuListItem
            {
                GroupName = "Morphological Tests"
            };
            GroupedMenuListItem motoricalMenuItems = new GroupedMenuListItem
            {
                GroupName = "Motorical Tests"
            };
            GroupedMenuListItem physiologicalMenuItems = new GroupedMenuListItem
            {
                GroupName = "Physiological Tests"
            };
            GroupedMenuListItem applicationMenuItems = new GroupedMenuListItem
            {
                GroupName = "Application"
            };

            // MORPHOLOGICAL MENU ITEMS
            morphologicalMenuItems.Add
                (
                    new HomeMenuItem
                    {
                        MenuItemType = MenuItemType.BodyFatApproximation,
                        Title = "Body Fat Approximation"
                    }
                );
            morphologicalMenuItems.Add
                (
                    new HomeMenuItem
                    {
                        MenuItemType = MenuItemType.BodyIndexes,
                        Title = "Body Indexes"
                    }
                );
            morphologicalMenuItems.Add
                (
                    new HomeMenuItem
                    {
                        MenuItemType = MenuItemType.SomatoType,
                        Title = "Somato Type"
                    }
                );

            // MOTORICAL MENU ITEMS
            motoricalMenuItems.Add
                (
                    new HomeMenuItem
                    {
                        MenuItemType = MenuItemType.MaxLoadApproximation,
                        Title = "Max Load Approximation"
                    }
                );

            // PHYSIOLOGICAL MENU ITEMS
            physiologicalMenuItems.Add
                (
                    new HomeMenuItem
                    {
                        MenuItemType = MenuItemType.BasalMetabolicRate,
                        Title = "Basal Metabolic Rate"
                    }
                );

            // APPLICATION MENU ITEMS
            applicationMenuItems.Add
                (
                    new HomeMenuItem
                    {
                        MenuItemType = MenuItemType.Contacts,
                        Title = "Contacts"
                    }
                );
            applicationMenuItems.Add
                (
                    new HomeMenuItem
                    {
                        MenuItemType = MenuItemType.Home,
                        Title = "Home"
                    }
                );

            //MenuItemList = new MvxObservableCollection<MenuItemType>()
            //{
            //    MenuItemType.Home,
            //    MenuItemType.Contacts,
            //};

            GroupedItems.Add(morphologicalMenuItems);
            GroupedItems.Add(motoricalMenuItems);
            GroupedItems.Add(physiologicalMenuItems);
            GroupedItems.Add(applicationMenuItems);

            ShowDetailPageAsyncCommand = new MvxAsyncCommand(ShowDetailPageAsync);
        }

        //private ObservableCollection<MenuItemType> menuItemList;
        //public ObservableCollection<MenuItemType> MenuItemList
        //{
        //    get => menuItemList;
        //    set => SetProperty(ref menuItemList, value);
        //}

        private async Task ShowDetailPageAsync()
        {
            // Implement your logic here.
            switch (SelectedMenuItem.MenuItemType)
            {
                case MenuItemType.Home:
                    await navigationService.Navigate<HomeViewModel>();
                    break;
                case MenuItemType.Contacts:
                    await navigationService.Navigate<ContactsViewModel>();
                    break;
                case MenuItemType.SomatoType:
                    await navigationService.Navigate<SomatoTypePageViewModel>();
                    break;
                case MenuItemType.MaxLoadApproximation:
                    await navigationService.Navigate<MaxLoadApproximationPageViewModel>();
                    break;
                case MenuItemType.BasalMetabolicRate:
                    await navigationService.Navigate<BasalMetabolicRatePageViewModel>();
                    break;
                case MenuItemType.BodyIndexes:
                    await navigationService.Navigate<BodyIndexesPageViewModel>();
                    break;
                case MenuItemType.BodyFatApproximation:
                    await navigationService.Navigate<BodyFatApproximationPageViewModel>();
                    break;
                default:
                    break;
            }

            if (Application.Current.MainPage is MasterDetailPage masterDetailPage)
            {
                masterDetailPage.IsPresented = false;
            }
            else if (Application.Current.MainPage is NavigationPage navigationPage
                     && navigationPage.CurrentPage is MasterDetailPage nestedMasterDetail)
            {
                nestedMasterDetail.IsPresented = false;
            }
        }

        private HomeMenuItem selectedMenuItem;
        private ObservableCollection<GroupedMenuListItem> groupedItems;

        public HomeMenuItem SelectedMenuItem
        {
            get => selectedMenuItem;
            set => SetProperty(ref selectedMenuItem, value);
        }
    }
}
