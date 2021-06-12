using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolisticWare.Ph4ct3x.Server.Pages.Ph4ct3x
{
    public class IndexModel : PageModel
    {
        Microsoft.AspNetCore.Http.CookieOptions cookieOptions = new Microsoft.AspNetCore.Http.CookieOptions
        {
            Expires = DateTime.Now.AddDays(30)
        };

        public void OnGet()
        {
        }
    }
}
