using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolisticWare.Ph4ct3x.Server.Pages.Ph4ct3x.DiagnosticTests.Morphological
{
    public class HeartRateMaximalModel : PageModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        [BindProperty]
        [TempData]
        public double Age
        {
            get;
            set;
        }

        [System.ComponentModel.DataAnnotations.Required]
        [BindProperty]
        [TempData]
        public string DateOfBirth
        {
            get;
            set;
        }

        [TempData]
        public string UrlAPI
        {
            get;
            set;
        }

        [TempData]
        public double HeartRateMaximal
        {
            get;
            set;
        }

        public void OnGet()
        {
        }
    }
}
