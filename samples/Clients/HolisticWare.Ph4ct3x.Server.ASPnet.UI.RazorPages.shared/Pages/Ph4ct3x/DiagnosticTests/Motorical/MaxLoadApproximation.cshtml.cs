using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolisticWare.Ph4ct3x.Server.Pages.Ph4ct3x.DiagnosticTests.Motorical
{
    public class MaxLoadApproximationModel : PageModel
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
        public uint NumberOfRepetitions
        {
            get;
            set;
        }

        [System.ComponentModel.DataAnnotations.Required]
        [BindProperty]
        [TempData]
        public double MaxLoadApproximation
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
