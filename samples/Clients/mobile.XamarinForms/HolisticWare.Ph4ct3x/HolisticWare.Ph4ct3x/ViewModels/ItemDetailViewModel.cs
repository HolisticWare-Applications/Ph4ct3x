using System;

using HolisticWare.Ph4ct3x.Models;

namespace HolisticWare.Ph4ct3x.ViewModels
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
