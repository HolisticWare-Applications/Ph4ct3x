using System;
using System.Collections.Generic;
using System.Linq;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes
{
    /// <summary>
    ///
    ///
    ///
    /// <a href="http://stackoverflow.com">here</a>
    /// </summary>
    public class HeathCarterEastonUniversityOfExeter : HeathCarterBase
    {
        public HeathCarterEastonUniversityOfExeter() : base()
        {
            Initialize();

            return;
        }

        public Dictionary
            <
                double,
                (
                    double Lower,
                    double Upper
                )
            >
                EndomorphicTable
        {
            get;
            private set;
        } = null;

        public void Initialize()
        {
            this.Skinfolds = new Skinfolds();
            this.Bicondyles = new Bicondyles();
            this.Circumferences = new Circumferences();

            return;
        }

        /// <summary>
        /// Excel formula: ∑3skf (Tri+Subs+Supra)
        /// </summary>
        public double SkinfoldsSum
        {
            get
            {
                return
                    this.Skinfolds.SubTriceps
                    +
                    this.Skinfolds.SubScapular
                    +
                    this.Skinfolds.SupraIliac
                    ;
            }
        }

        /// <summary>
        /// Excel formula: ∑3skf (Tri+Subs+Supra)
        /// </summary>
        public double SkinfoldsSumCorrectedForHeight
        {
            get
            {
                return
                    this.SkinfoldsSum
                    *
                    (170.18 / Height)
                    ;
            }
        }

        /// <summary>
        /// Ht / 3√weight
        /// </summary>
        public double MassHeightRatio
        {
            get
            {
                return Height / MassCubicRoot;

            }
        }

        public double MassCubicRoot
        {
            get
            {
                return Math.Pow(Mass, 1.0 / 3.0);

            }
        }

        public double HeightMassCubicRooRatio
        {
            get
            {
                return this.Height / MassCubicRoot;

            }
        }

        public double PartEq1End
        {
            get
            {
                double skn =
                                // 16      // Excel???
                                this.SkinfoldsSumCorrectedForHeight
                                ;

                return
                            - 0.00068 * skn * skn
                            +
                            0.0000014 * skn * skn * skn
                            ;
            }
        }

        public double PartEq2End
        {
            get
            {
                return
                    -0.7182 + 0.1451 * this.SkinfoldsSumCorrectedForHeight
                    ;

            }
        }

        public double EndomorphicComponent()
        {
            double endomorphic = this.PartEq2End + this.PartEq1End;

            return endomorphic;
        }

        public double EctomorphicComponent()
        {
            (double Lower, double Middle, double Upper) ectomprphic_height_mass_ratio_tupple;

            ectomprphic_height_mass_ratio_tupple = this.EctomorphicComponentHeightWeightRatioTuple();

            double ectomorphic = double.NaN;

            if
                (
                    !double.IsNaN(ectomprphic_height_mass_ratio_tupple.Lower)
                    &&
                    !double.IsNaN(ectomprphic_height_mass_ratio_tupple.Middle)
                    &&
                    !double.IsNaN(ectomprphic_height_mass_ratio_tupple.Upper)
                )
            {
                throw new InvalidOperationException("Ectomorphic component - tuple 3 values");
            }

            if
                (
                    !double.IsNaN(ectomprphic_height_mass_ratio_tupple.Middle)
                    &&
                    !double.IsNaN(ectomprphic_height_mass_ratio_tupple.Upper)
                )
            {
                throw new InvalidOperationException("Ectomorphic component - tuple - Middle and Upper");
            }

            if
                (
                    !double.IsNaN(ectomprphic_height_mass_ratio_tupple.Lower)
                    &&
                    !double.IsNaN(ectomprphic_height_mass_ratio_tupple.Upper)
                )
            {
                throw new InvalidOperationException("Ectomorphic component - tuple 2 values - Lower and Upper");
            }

            if
                (
                    !double.IsNaN(ectomprphic_height_mass_ratio_tupple.Lower)
                    &&
                    !double.IsNaN(ectomprphic_height_mass_ratio_tupple.Middle)
                )
            {
                throw new InvalidOperationException("Ectomorphic component - tuple 2 values - Lower and Middle");
            }

            if (!double.IsNaN(ectomprphic_height_mass_ratio_tupple.Lower))
            {
                ectomorphic = ectomprphic_height_mass_ratio_tupple.Lower;
            }
            if (!double.IsNaN(ectomprphic_height_mass_ratio_tupple.Middle))
            {
                ectomorphic = ectomprphic_height_mass_ratio_tupple.Middle;
            }
            if (!double.IsNaN(ectomprphic_height_mass_ratio_tupple.Upper))
            {
                ectomorphic = ectomprphic_height_mass_ratio_tupple.Upper;
            }

            return ectomorphic;
        }

        public
                (
                    double Lower,
                    double Midlle,
                    double Upper
                )
                    EctomorphicComponentHeightWeightRatioTuple()
        {
            double ectomorphic = this.MassHeightRatio;
            double HWR_weight_index = ectomorphic;

            (double Lower, double Middle, double Upper) ectomprphic_tupple = EctomorphicComponentTuple();

            (double Lower, double Middle, double Upper) ectomprphic_height_mass_ratio_tupple;

            ectomprphic_height_mass_ratio_tupple = (double.NaN, double.NaN, double.NaN);

            // TODO: check
            if
                (
                    HWR_weight_index >= 40.74
                    &&
                    HWR_weight_index < 40.75
                )
            {
                throw new InvalidOperationException("Ectomorphic component - tuple validation range ambigious!");
            }
            else if
                (
                    HWR_weight_index >= 40.74
                )
            {
                ectomprphic_height_mass_ratio_tupple.Upper = ectomprphic_tupple.Upper;
            }
            // TODO: check this!! 
            else if
                (
                    36.95 < HWR_weight_index //// 38.25 ????
                    &&
                    HWR_weight_index < 40.75
                )
            {
                ectomprphic_height_mass_ratio_tupple.Middle = ectomprphic_tupple.Middle;
            }
            // TODO: check this!! 
            if (HWR_weight_index <= 36.95) // 38.25)
            {
                // TODO: check this!! 
                ectomprphic_height_mass_ratio_tupple.Lower = ectomprphic_tupple.Lower;
            }

            return ectomprphic_height_mass_ratio_tupple;
        }

        public
                (
                    double Lower,
                    double Midlle,
                    double Upper
                )
                    EctomorphicComponentTuple()
        {
            double HWR_weight_index = this.MassHeightRatio;

            double lower = 0.5;                              // 0.1; original???
            double mid = 0.463 * HWR_weight_index - 17.63;
            double upper = 0.732 * HWR_weight_index - 28.58;

            return (Lower: lower, Midlle: mid, Upper: upper);
        }

        public double MesomorphicComponent()
        {
            // D25 = =D23-(D14/10)
            double circumference_arm_upper_corercted =
                                                        this.Circumferences.ArmUpper
                                                        -
                                                        (this.Skinfolds.SubTriceps / 10.0)
                                                        ;
            // D26 = D24-(D17/10)
            double circumference_calf_corercted =
                                                        this.Circumferences.Calf
                                                        -
                                                        (this.Skinfolds.Calf / 10.0)
                                                        ;

            double mesomorphic =
                            0.858 * this.Bicondyles.Humerus             // Excel D21
                            +
                            0.601 * this.Bicondyles.Femur               // Excel D22
                            +
                            0.188 * circumference_arm_upper_corercted   // Excel D28
                            +
                            0.161 * circumference_calf_corercted        // Excel D26
                            +
                            -0.131 * this.Height                       // Excel D12
                            +
                            4.5
                            ;

            return mesomorphic;
        }




    }
}

