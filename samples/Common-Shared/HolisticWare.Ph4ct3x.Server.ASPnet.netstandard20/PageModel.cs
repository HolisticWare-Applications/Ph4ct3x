
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace HolisticWare.Ph4ct3x.Server.ASPnet
{
    public class PageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        public List<SelectListItem> CommunicationOptions 
        { 
            get; 
            set; 
        }

        public void OnGet()
        {
            CommunicationOptions = new List<SelectListItem>
            {
                new SelectListItem()
                {
                    Text = "HTTP POST",
                    Value = "HTTP POST"
                },
                new SelectListItem()
                {
                    Text = "HTTP POST (WebAPI)",
                    Value = "HTTP POST (WebAPI)"
                },
                new SelectListItem()
                {
                    Text = "SignalR",
                    Value = "SignalR"
                },
            };
        }
    }
}
