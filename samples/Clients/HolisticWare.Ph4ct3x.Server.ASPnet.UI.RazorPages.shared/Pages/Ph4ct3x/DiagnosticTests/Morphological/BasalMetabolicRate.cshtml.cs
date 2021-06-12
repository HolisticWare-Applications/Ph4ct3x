using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HolisticWare.Ph4ct3x.Server.Pages.Ph4ct3x.DiagnosticTests.Morphological
{
    public class BasalMetabolicRateModel 
        : 
            //HolisticWare.Ph4ct3x.Server.ASPnet.PageModel 
            Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        [BindProperty]
        [TempData]
        public double Mass
        {
            get;
            set;
        }

        [System.ComponentModel.DataAnnotations.Required]
        [BindProperty]
        [TempData]
        public double Height
        {
            get;
            set;
        }

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
        public string Gender
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

        [System.ComponentModel.DataAnnotations.Required]
        [BindProperty]
        [TempData]
        public double BasalMetabolicRate
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

        public void OnGet()
        {
        }
    }
}
