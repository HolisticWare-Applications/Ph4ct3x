using System;

using HolisticWare.Ph4ct3x.Judo.Models;

namespace HolisticWare.Ph4ct3x.Judo.ViewModels
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
