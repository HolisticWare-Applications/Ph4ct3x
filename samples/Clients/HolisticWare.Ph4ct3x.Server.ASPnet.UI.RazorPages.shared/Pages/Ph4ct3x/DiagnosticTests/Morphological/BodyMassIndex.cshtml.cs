using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.BodyIndices;

namespace HolisticWare.Ph4ct3x.Server.Pages.Ph4ct3x.DiagnosticTests.Morphological
{
    public class BodyMassIndexModel : PageModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        [BindProperty(SupportsGet = true)]
        public double Mass
        {
            get;
            set;
        }

        [System.ComponentModel.DataAnnotations.Required]
        [BindProperty(SupportsGet = true)]
        public double Height
        {
            get;
            set;
        }

        [BindProperty(SupportsGet = true)]
        public double Exponent
        {
            get;
            set;
        } = 2.5;

        [BindProperty(SupportsGet = true)]
        public BodyMassIndex BodyMassIndex
        {
            get;
            set;
        }

        [TempData]
        public double BMI1
        {
            get;
            set;
        }

        [TempData]
        public double BMI2
        {
            get;
            set;
        }

        string url_api = null;

        [TempData]
        public string UrlAPI
        {
            get
            {
                url_api = $"/api/diagnostic-tests/morhpological/body-mass-index?mass={Mass}&height={Height}";
                return url_api; 
            }
            set
            {
                value = url_api;
            }
        }

        public void OnGet() //(1)
        {

            return;
        }

        public async 
            Task<IActionResult> 
                OnPostAsync
                    (
                        double mass, 
                        double height
                    ) //(2)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            this.Mass = this.BodyMassIndex.Mass;
            this.Height = this.BodyMassIndex.Height;

            BMI1 = this.BodyMassIndex.Calculate(Mass, Height);
            BMI2 = this.BodyMassIndex.Calculate(Mass, Height, Exponent);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append($"/api/diagnostic-tests/morhpological/body-mass-index?");
            sb.Append($"mass={Mass}");
            sb.Append($"&");
            sb.Append($"height={Height}");
            UrlAPI = sb.ToString();

            return RedirectToPage();
        }
    }
}
