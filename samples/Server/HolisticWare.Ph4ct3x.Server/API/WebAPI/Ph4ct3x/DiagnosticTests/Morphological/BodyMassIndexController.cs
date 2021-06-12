using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.BodyIndices;

namespace HolisticWare.Ph4ct3x.Server.API.WebAPI
{
    // http://127.0.0.1:5000/
    [Route("api/diagnostic-tests/morhpological/body-mass-index")]
    public class BodyMassIndexController : Controller
    {
        [HttpGet]
        public double Calculate(double mass, double height, double age, Gender gender)
        {
            return bmi.Calculate(mass, height);
        }

        //----------------------------------------------------------------------
        BodyMassIndex bmi = null;

        public BodyMassIndexController()
        {
            this.bmi = new BodyMassIndex();

            return;
        }
        //----------------------------------------------------------------------
    }
}
