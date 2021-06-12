using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolisticWare.Ph4ct3x.Server.Pages
{
    public class Consent : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPostGrantAsync()
        {
            HttpContext.Features.Get<ITrackingConsentFeature>().GrantConsent();
            return RedirectToPage("./Index");
        }

        public IActionResult OnPostWithdrawAsync()
        {
            HttpContext.Features.Get<ITrackingConsentFeature>().WithdrawConsent();
            return RedirectToPage("./Index");
        }
    }
}
