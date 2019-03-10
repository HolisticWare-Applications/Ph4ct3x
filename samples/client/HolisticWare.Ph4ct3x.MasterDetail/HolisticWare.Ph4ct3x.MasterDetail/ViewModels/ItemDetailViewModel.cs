using System;

using HolisticWare.Ph4ct3x.MasterDetail.Models;

namespace HolisticWare.Ph4ct3x.MasterDetail.ViewModels
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
