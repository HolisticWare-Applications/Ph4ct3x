using System;

using Core;

using HolisticWare.Ph4ct3x;
using HolisticWare.Ph4ct3x.DiagnosticTests.Physiological;


namespace HolisticWare.Ph4ct3x.DiagnosticTests.Physiological
{
    /// <summary>
    /// 
    /// </summary>
    /// TODO: Func<> delegate + Dictionary
    /// <see href="https://en.wikipedia.org/wiki/Basal_metabolic_rate"/>
    /// <see href="https://en.wikipedia.org/wiki/Harris%E2%80%93Benedict_equation"/>
    public partial class BasalMetabolicRate 
    {
        public BasalMetabolicRate()
        {
            CalculationAlgorithmUsingAge = CalculateHarrisBenedictRevised;

            return;
        }

        public bool IsUsingCalories
        {
            get;
            set;
        } = true;

        public double CalculateUsingDateOfBirth
                                        (
                                            double mass,
                                            double height,
                                            DateTime date_of_birth,
                                            Gender gender
                                        )
        {
            double age_in_years = date_of_birth.Age();

            return CalculationAlgorithmUsingAge(mass, height, age_in_years, gender);
        }

        public Func
                    <
                        double,     // mass
                        double,     // height
                        DateTime,   // age
                        Gender,     // gender
                        double      // bmr - basal metabolic rate
                    > CalculationAlgorithmUsingDateOfBirth
        {
            get;
            set;
        }

        public double CalculateUsingAge
                                        (
                                            double mass,
                                            double height,
                                            double age_in_years,
                                            Gender gender
                                        )
        {
            return CalculationAlgorithmUsingAge(mass, height, age_in_years, gender);
        }

        public Func
                    <
                        double,     // mass
                        double,     // height
                        double,     // age in years
                        Gender,     // gender
                        double      // bmr - basal metabolic rate
                    > CalculationAlgorithmUsingAge
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// <see href="https://en.wikipedia.org/wiki/Harris%E2%80%93Benedict_equation"/>
        /// <see href="https://www.thestar.com.my/lifestyle/viewpoints/tell-me-about/2013/08/28/understanding-bmr"/>
        /// </summary>
        /// <param name="mass"></param>
        /// <param name="height"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <returns></returns>
        public double CalculateHarrisBenedictWikipedia
                                                (
                                                    double mass,
                                                    double height,
                                                    double age,
                                                    Gender gender
                                                )
        {
            //double gender_specific_rate = 0;
            double bmr = 0;

            if (gender == Gender.Female)
            {
                //gender_specific_rate = 161.0;
                bmr = 655.1 + (9.563 * mass) + (1.850 * height * 100.0) - (4.676 * age);
            }
            else if (gender == Gender.Male)
            {
                //gender_specific_rate = 5.0;
                bmr = 66.5 + (13.75 * mass) + (5.003 * height * 100.0) - (6.755  * age);
            }
            else
            {
                bmr = double.NaN;
            }

            if (! IsUsingCalories)
            {
                bmr = bmr * 4184.0;
            }

            return bmr;
        }

        /// <summary>
        ///
        /// <see href="https://en.wikipedia.org/wiki/Harris%E2%80%93Benedict_equation"/>
        /// <see href="https://www.thestar.com.my/lifestyle/viewpoints/tell-me-about/2013/08/28/understanding-bmr"/>
        /// </summary>
        /// <param name="mass"></param>
        /// <param name="height"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <returns></returns>
        public double CalculateHarrisBenedictWikipediaRozaShizgal
                                                (
                                                    double mass,
                                                    double height,
                                                    double age,
                                                    Gender gender
                                                )
        {
            //double gender_specific_rate = 0;
            double bmr = 0;

            if (gender == Gender.Female)
            {
                //gender_specific_rate = 161.0;
                bmr = 447.593 + (9.247 * mass) + (3.098 * height * 100.0) - (4.330 * age);
            }
            else if (gender == Gender.Male)
            {
                //gender_specific_rate = 5.0;
                bmr = 88.362 + (13.397 * mass) + (4.799 * height * 100.0) - (5.677  * age);
            }
            else
            {
                bmr = double.NaN;
            }

            if (! IsUsingCalories)
            {
                bmr = bmr * 4184.0;
            }

            return bmr;
        }

        public double CalculateHarrisBenedictRevised
                                                (
                                                    double mass,
                                                    double height,
                                                    double age,
                                                    Gender gender
                                                )
        {
            //double gender_specific_rate = 0;
            double bmr = 0;
            double height_cm = height * 100.0;
            if (gender == Gender.Female)
            {
                //gender_specific_rate = 161.0;
                bmr = 9.247 * mass + 3.098 * height_cm - 4.330 * age + 447.593;
            }
            else
            {
                //gender_specific_rate = 5.0;
                bmr = 13.397 * mass + 4.799 * height_cm - 5.677 * age + 88.362;
            }

            if (! IsUsingCalories)
            {
                bmr = bmr * 4184.0;
            }

            return bmr;
        }

        public double CalculateMifflinStJeor
                                                (
                                                    double mass,
                                                    double height,
                                                    double age,
                                                    Gender gender
                                                )
        {
            //double gender_specific_rate = 0;
            double bmr = 0;

            if (gender == Gender.Female)
            {
                //gender_specific_rate = 161.0;
                bmr = 10.0 * mass + 6.25 * height - 5.0 * age - 161.0;
            }
            else
            {
                //gender_specific_rate = 5.0;
                bmr = 10.0 * mass + 6.25 * height - 5.0 * age + 5.0;
            }

            if (! IsUsingCalories)
            {
                bmr = bmr * 4184.0;
            }

            return bmr;
        }
        
        public double CalculateKatchMcArdleOriginal
                                                (
                                                    double mass,
                                                    double body_fat_percentage
                                                )
        {
            double bmr = 370.0 + (21.6 * ( mass * (1 - body_fat_percentage)));

            if (! IsUsingCalories)
            {
                bmr = bmr * 4184.0;
            }

            return bmr;
        }

    }
}
