using System;
using System.Collections.Generic;

//using Core.Math.Intervals;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Motorical
{
    /// <summary>
    /// Approximation for 1RM (1 repetitio/rep maximum, one repetition max) AKA Max Load
    /// 
    /// <a href="https://en.wikipedia.org/wiki/One-repetition_maximum"/>
    /// <a href="https://www.brianmac.co.uk/maxload.htm"/>
    /// <a href="http://www.sportsscience.co/tools/1-rep-max-1rm-calculator/"/>
    /// </summary>
    /// TODO: Func<> delegate + Dictionary
    public partial class MaxLoadApproximation
    {
        /// <summary>
        /// </summary>
        /// <param name="mass">Mass (weight)</param>
        /// <param name="number_of_repetitions">Number of repetitions</param>
        /// <returns></returns>
        public double CalculateBrzycki_BrianMac
                                    (
                                        double mass,
                                        ulong number_of_repetitions
                                    )
        {
            // original:    Weight ÷ ( 1.0278 - ( 0.0278 × Number of repetitions ) )
            double max_load = mass / (1.0278 - (0.0278 * number_of_repetitions));

            return max_load;
        }

        public 
            double 
                CalculateBrzycki_SportScience
                                    (
                                        double mass,
                                        ulong number_of_repetitions
                                    )
        {
            double max_load = mass * (36.0 / (37.0 - number_of_repetitions));

            return max_load;
        }

        public 
            double 
                CalculateBaechle_BrianMac
                                    (
                                        double mass,
                                        ulong number_of_repetitions
                                    )
        {
            // original: Weight × ( 1 + ( 0.033 × Number of repetitions ) )
            double max_load = mass * (1 + (0.033 * number_of_repetitions));

            return max_load;
        }

        public 
            double 
                CalculateEpley_BrianMac
                                    (
                                        double mass,
                                        ulong number_of_repetitions
                                    )
        {
            double max_load = mass * (1 + double_0_033_AKA_1_over_30_Epley * number_of_repetitions);

            return max_load;
        }

    }
}
