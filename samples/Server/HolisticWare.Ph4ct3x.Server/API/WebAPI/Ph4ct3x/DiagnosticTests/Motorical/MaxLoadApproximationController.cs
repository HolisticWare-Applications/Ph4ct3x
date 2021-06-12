using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net;
using Microsoft.AspNetCore.Mvc;

using Swashbuckle.AspNetCore.SwaggerGen;

using HolisticWare.Ph4ct3x.DiagnosticTests.Motorical;

namespace HolisticWare.Ph4ct3x.Server.API.WebAPI
{
    // http://127.0.0.1:5000/
    [Route("api/diagnostic-tests/motorical/max-load-approximation")]
    public class MaxLoadApproximationController : Controller
    {
        [HttpGet]
        [ProducesResponseType
            (
                typeof(Dictionary<string, double>),
                (int)HttpStatusCode.OK
            )
        ]
        public async Task<Dictionary<string, double>> Calculate(double mass, ulong number_of_repetitions)
        {
            return mla.Calculate(mass, number_of_repetitions);
        }

        //----------------------------------------------------------------------
        MaxLoadApproximation mla = null;

        public MaxLoadApproximationController()
        {
            this.mla = new MaxLoadApproximation(0.0,0);

            return;
        }
        //----------------------------------------------------------------------

        [HttpGet]
        public 
            double 
                CalculateBrzycki_BrianMac
                    (
                        double mass, 
                        ulong number_of_repetitions
                    )
        {
            return mla.CalculateBrzycki_BrianMac(mass, number_of_repetitions);
        }

        [HttpGet]
        public 
            double 
                CalculateBrzycki_SportScience
                    (
                        double mass,
                        ulong number_of_repetitions
                    )
        {
            return mla.CalculateBrzycki_SportScience(mass, number_of_repetitions);
        }

        [HttpGet]
        public 
            double 
                CalculateBaechle_BrianMac
                    (
                        double mass,
                        ulong number_of_repetitions
                    )
        {
            return mla.CalculateBaechle_BrianMac(mass, number_of_repetitions);
        }

        [HttpGet]
        public 
            double 
                CalculateEpley_SportScience
                    (
                        double mass,
                        ulong number_of_repetitions
                    )
        {
            return mla.CalculateEpley_SportScience(mass, number_of_repetitions);
        }

        [HttpGet]
        public 
            double 
                CalculateEpley_BrianMac
                    (
                        double mass,
                        ulong number_of_repetitions
                    )
        {
            return mla.CalculateEpley_BrianMac(mass, number_of_repetitions);
        }

        [HttpGet]
        public 
            double 
                CalculateLander_SportScience_Landers_BrianMac
                    (
                        double mass,
                        ulong number_of_repetitions
                    )
        {
            return mla.CalculateLander_SportScience_Landers_BrianMac(mass, number_of_repetitions);
        }

        [HttpGet]
        public 
            double 
                CalculateLombardi_SportScience
                    (
                        double mass,
                        ulong number_of_repetitions
                    )
        {
            return mla.CalculateLombardi_SportScience(mass, number_of_repetitions);
        }

        [HttpGet]
        public 
            double 
                CalculateMayhewEtAl_SportScience
                    (
                        double mass,
                        ulong number_of_repetitions
                    )
        {
            return mla.CalculateMayhewEtAl_SportScience(mass, number_of_repetitions);
        }

        [HttpGet]
        public 
            double 
                CalculateOConnerEtAl_SportScience
                    (
                        double mass,
                        ulong number_of_repetitions
                    )
        {
            return mla.CalculateOConnerEtAl_SportScience(mass, number_of_repetitions);
        }

        [HttpGet]
        public 
            double 
                CalculateWathan_SportScience
                    (
                        double mass,
                        ulong number_of_repetitions
                    )
        {
            return mla.CalculateWathan_SportScience(mass, number_of_repetitions);
        }

    }
}
