using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HolisticWare.Ph4ct3x.DiagnosticTests.Morphological;

namespace HolisticWare.Ph4ct3x.Server.Pages
{
    public class BodyMassIndexModel : PageModel
    {
        [BindProperty]
        public BodyMassIndex BodyMassIndex
        {
            get;
            private set;
        }

        public void OnGet()
        {
            this.BodyMassIndex = new BodyMassIndex();

            return;
        }
    }
}
