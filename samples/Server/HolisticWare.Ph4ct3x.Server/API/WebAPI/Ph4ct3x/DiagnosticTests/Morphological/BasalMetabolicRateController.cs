using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using HolisticWare.Ph4ct3x.DiagnosticTests.Physiological;

namespace HolisticWare.Ph4ct3x.Server.API.WebAPI
{
    // http://127.0.0.1:5000
    [Route("api/diagnostic-tests/morhpological/basal-metabolic-rate")]
    public class BasalMetabolicRateController : Controller
    {
        [Route("by-age")]
        [HttpGet]
        public double CalculateByAge
                            (
                                [FromQuery] double mass, 
                                [FromQuery] double height, 
                                [FromQuery] double age, 
                                [FromQuery] Gender gender
                            )
        
        {
            return bmr.CalculateUsingAge(mass, height, age, gender);
        }

        [Route("by-date-of-birth")]
        [HttpGet]
        public double CalculateByDateOfBirth
        (
                                [FromQuery] double mass,
                                [FromQuery] double height,
                                [FromQuery] DateTime date_of_birth,
                                [FromQuery] Gender gender
                            )
        {
            return bmr.CalculateUsingDateOfBirth(mass, height, date_of_birth, gender);
        }

        //----------------------------------------------------------------------
        BasalMetabolicRate bmr = null;

        public BasalMetabolicRateController()
        {
            this.bmr = new BasalMetabolicRate();

            return;
        }
        //----------------------------------------------------------------------
    }
}
