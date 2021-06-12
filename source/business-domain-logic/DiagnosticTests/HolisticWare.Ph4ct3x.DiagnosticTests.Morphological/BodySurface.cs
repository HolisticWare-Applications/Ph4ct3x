using System;
using System.Collections.Generic;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref=""/>
    /// <see cref=""/>
    /// <see cref=""/>
    /// <see cref=""/>
    /// <see cref=""/>
    /// <see cref=""/>
    /// <see cref=""/>
    /// TODO: Func<> delegate + Dictionary
    public partial class BodySurface : MorphologicalMeasurement
    {

        /// <summary>
        /// Body Surface according to Dubois approximation
        /// </summary>
        /// <param name="height">height in meters</param>
        /// <param name="weight">weight in kilograms</param>
        /// <returns></returns>
        public double CalculateDubois
                                    (
                                        double height,
                                        double weight
                                    )
        {
            return 0.007184 * Math.Pow(weight, 0.425) * Math.Pow((height * 100.0), 0.725);
        }

        /// <summary>
        /// Body Surface according to Mosteller approximation
        /// </summary>
        /// <param name="height">height in meters</param>
        /// <param name="weight">weight in kilograms</param>
        /// <returns></returns>
        public double CalculateMosteller
                                    (
                                        double height,
                                        double weight
                                    )
        {
            return Math.Pow(weight, 0.5) * (height * 100.0) / 60.0;
        }

        /// <summary>
        /// Body Surface according to Haycock approximation
        /// </summary>
        /// <param name="height">height in meters</param>
        /// <param name="weight">weight in kilograms</param>
        /// <returns></returns>
        public double CalculateHaycock
                                    (
                                        double height,
                                        double weight
                                    )
        {
            return 0.024265 * Math.Pow(weight, 0.5378) * Math.Pow((height * 100.0), 0.3964);
        }

        /// <summary>
        /// Body Surface according to Gehan & George approximation
        /// </summary>
        /// <param name="height">height in meters</param>
        /// <param name="weight">weight in kilograms</param>
        /// <returns></returns>
        public double CalculateGehanAndGeorge
                                    (
                                        double height,
                                        double weight
                                    )
        {
            return 0.0235 * Math.Pow(weight, 0.51456) * Math.Pow((height * 100.0), 0.42246);
        }

        /// <summary>
        /// Body Surface according to Boyd approximation
        /// </summary>
        /// <param name="height">height in meters</param>
        /// <param name="weight">weight in kilograms</param>
        /// <returns></returns>
        public double CalculateBoyd
                                    (
                                        double height,
                                        double weight
                                    )
        {
            double wg = weight * 1000.0;

            return
                0.0003207
                *
                Math.Pow(wg, 0.7285 - 0.0188 * Math.Log(wg))
                *
                Math.Pow(height * 100.0, 0.3)
                ;
        }

        /// <summary>
        /// Body Surface according to Fujimoto approximation
        /// </summary>
        /// <param name="height">height in meters</param>
        /// <param name="weight">weight in kilograms</param>
        /// <returns></returns>
        public double CalculateFujimoto
                                    (
                                        double height,
                                        double weight
                                    )
        {
            return 0.008883 * Math.Pow(weight, 0.444) * Math.Pow((height * 100.0), 0.663);
        }

    }
}
