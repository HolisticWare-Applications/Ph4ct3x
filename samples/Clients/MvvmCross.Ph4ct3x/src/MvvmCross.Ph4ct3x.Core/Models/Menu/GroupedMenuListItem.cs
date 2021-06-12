using System.Collections.ObjectModel;

namespace MvvmCross.Ph4ct3x.Core.Models.Menu
{
    public class GroupedMenuListItem : ObservableCollection<HomeMenuItem>
    {
        public string GroupName { get; set; }
    }
}
