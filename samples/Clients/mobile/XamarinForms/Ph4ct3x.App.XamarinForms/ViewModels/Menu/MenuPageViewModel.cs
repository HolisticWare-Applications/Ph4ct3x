using System.Collections.Generic;
using Ph4ct3x.App.XamarinForms.Models;
using Ph4ct3x.App.XamarinForms.Models.Menu;

namespace Ph4ct3x.App.XamarinForms.ViewModels.Menu
{
    public class MenuPageViewModel : BaseViewModel
    {
        public List<GroupedMenuListItem> GroupedItems { get; }

        public MenuPageViewModel()
        {
            GroupedItems = new List<GroupedMenuListItem>();

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
                        Id = MenuItemType.BodyFatApproximation,
                        Title = "Body Fat Approximation"
                    }
                );
            morphologicalMenuItems.Add
                (
                    new HomeMenuItem
                    {
                        Id = MenuItemType.BodyIndexes,
                        Title = "Body Indexes"
                    }
                );
            morphologicalMenuItems.Add
                (
                    new HomeMenuItem
                    {
                        Id = MenuItemType.SomatoType,
                        Title = "SomatoType"
                    }
                );

            // MOTORICAL MENU ITEMS
            motoricalMenuItems.Add
                (
                    new HomeMenuItem
                    {
                        Id = MenuItemType.MaxLoadApproximation,
                        Title = "Max Load Approximation"
                    }
                );

            // PHYSIOLOGICAL MENU ITEMS
            physiologicalMenuItems.Add
                (
                    new HomeMenuItem
                    {
                        Id = MenuItemType.BasalMetabolicRate,
                        Title = "Basal Metabolic Rate"
                    }
                );

            // APPLICATION MENU ITEMS
            applicationMenuItems.Add
                (
                    new HomeMenuItem
                    {
                        Id = MenuItemType.About,
                        Title = "About"
                    }
                );

            GroupedItems.Add(morphologicalMenuItems);
            GroupedItems.Add(motoricalMenuItems);
            GroupedItems.Add(physiologicalMenuItems);
            GroupedItems.Add(applicationMenuItems);

            return;
        }
    }
}
