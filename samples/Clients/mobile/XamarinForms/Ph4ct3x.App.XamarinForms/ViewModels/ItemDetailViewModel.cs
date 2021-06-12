using System;

using Ph4ct3x.App.XamarinForms.Models;

namespace Ph4ct3x.App.XamarinForms.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
