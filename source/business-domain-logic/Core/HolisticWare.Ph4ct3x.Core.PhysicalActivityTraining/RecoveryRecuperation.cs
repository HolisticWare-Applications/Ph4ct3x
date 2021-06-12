using System;
using System.Collections.Generic;

namespace HolisticWare.Ph4ct3x.PhysicalActivityTraining.Core
{
    public partial class RecoveryRecuperation
        :
            BaseData
    {
        public static List<string> RecoveryRecuperationTypes
        {
            get;
            set;
        } = new List<string>()
        {
            "Imediate",
            "Short-Term",
            "Mid-Term",
        };

        public string RecoveryRecuperationType
        {
            get;
            set;
        }

        Func<double, double> Metabolism;

        /// <summary>
        /// Calculate the Recovery/Recuperation
        /// </summary>
        /// <returns>The calculate.</returns>
        /// <param name="volume">Volume.</param>
        //public Recovery Calculate
        //                    (
        //                        TrainingVolume volume,
        //                        FitnessLevel fitness_level,
        //                        Metabolism m,
        //                        Nutrition n
        //                    )
        //{
        //    return null;
        //}
    }
}
