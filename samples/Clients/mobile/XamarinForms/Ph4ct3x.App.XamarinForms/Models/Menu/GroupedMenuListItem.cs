using System.Collections.ObjectModel;

namespace Ph4ct3x.App.XamarinForms.Models.Menu
{
    public class GroupedMenuListItem : ObservableCollection<HomeMenuItem>
    {
        public string GroupName { get; set; }
    }
}