using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Net.Http.Headers;

namespace HolisticWare.Ph4ct3x.Server.Pages
{
    public class Cookie : PageModel
    {
        public ITrackingConsentFeature TrackingConsentFeature;
        public Microsoft.AspNetCore.Http.IRequestCookieCollection RequestCookieCollection;

        [TempData]
        public string ResponseCookies { get; set; }

        public void OnGet()
        {
            RequestCookieCollection = Request.Cookies;
            TrackingConsentFeature = HttpContext.Features.Get<ITrackingConsentFeature>();

            return;      
        }

        #region snippet1
        public IActionResult OnPostCreateEssentialAsync()
        {
            HttpContext.Response.Cookies.Append
                    (
                        Constants.EssentialSec,
                        DateTime.Now.Second.ToString(),
                        new Microsoft.AspNetCore.Http.CookieOptions() 
                        { 
                            IsEssential = true 
                        }
                    );
            ResponseCookies = Response.Headers[HeaderNames.SetCookie].ToString();

            return RedirectToPage("./Index");
        }
        #endregion

        public IActionResult OnPostCreateAsync()
        {
            HttpContext.Response.Cookies.Append
                    (
                        Constants.NonEssentialMS,
                        DateTime.Now.Millisecond.ToString()
                    );

            ResponseCookies = Response.Headers[HeaderNames.SetCookie].ToString();

            return RedirectToPage("./Index");
        }

        public IActionResult OnPostDeleteAsync()
        {
            HttpContext.Response.Cookies.Delete(Constants.NonEssentialMS);
            HttpContext.Response.Cookies.Delete(Constants.EssentialSec);

            return RedirectToPage("./Index");
        }

        public IActionResult OnPostDeleteAllAsync()
        {

            foreach (var cookie in Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);
            }

            return RedirectToPage("./Index");
        }
    }
}
