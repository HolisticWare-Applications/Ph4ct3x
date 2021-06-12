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
    public class HeathCarter : HeathCarterBase
    {
        public HeathCarter() : base()
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


        public
            Dictionary
                    <
                        double,
                        (
                            double Height,
                            double HumerusBicondyle,
                            double FemurBicondyle,
                            double ArmUpperCircumference,
                            double CalfCircumference
                        )
                    >
                        MesomorphicTable
        {
            get;
            set;
        } = null;

        /// <summary>
        /// 
        /// </summary>
        public
            Dictionary
                    <
                        double,
                        (
                            double Lower,
                            double Upper
                        )
                    >
                        EctomorphicTable
        {
            get;
            set;
        } = null;

        public void Initialize()
        {
            this.Skinfolds = new Skinfolds();
            this.Bicondyles = new Bicondyles();
            this.Circumferences = new Circumferences();

            return;
        }

        public double EndomorphicComponent()
        {
            double endomorphic_sum = 
                            (
                                Skinfolds.SubTriceps
                                +
                                Skinfolds.SubScapular
                                +
                                Skinfolds.SupraIliac
                            )
                            * 170.18 / Height
                            ;

            double endomorhpic_X = 
                                    -0.7182
                                    +
                                    0.1451 * endomorphic_sum
                                    +
                                    - 0.00068 * (endomorphic_sum * endomorphic_sum)
                                    +
                                    0.0000014 * (endomorphic_sum * endomorphic_sum * endomorphic_sum)
                                    ;

            return endomorhpic_X;
        }

        public double EctomorphicComponent()
        {
            double ectomorphic = Height / Math.Pow(Mass, 1.0 / 3.0);
            double HWR_weight_index = ectomorphic;

            double ectomorphy = double.NaN;

            if (HWR_weight_index >= 40.75) 
            {
                ectomorphy = 0.732 * HWR_weight_index - 28.58;
            }
            else if (HWR_weight_index < 40.75 && HWR_weight_index > 38.25) 
            {
                ectomorphy = 0.463 * HWR_weight_index - 17.63;
            }
            else if ( HWR_weight_index <= 38.25)
            {
                ectomorphy = 0.1;
            }

            return ectomorphy;
        }

        public double MesomorphicComponent()
        {
            double girth_arm_upper_corrected = double.NaN;
            double girth_calf_corrected = double.NaN;

            girth_arm_upper_corrected = Circumferences.ArmUpper - Skinfolds.SubTriceps;
            girth_calf_corrected = Circumferences.Calf - Skinfolds.Calf;

            double mesomorphy =
                                0.858 * Bicondyles.Humerus 
                                + 
                                0.601 * Bicondyles.Femur 
                                + 
                                0.188 * girth_arm_upper_corrected 
                                + 
                                0.161 * girth_calf_corrected 
                                +
                                - 0.131 * Height
                                + 
                                4.5
                                ;

            return mesomorphy;
        }





        // stuff below currently not used

        protected
            (
                double Approximation,
                int Index
            )
                MesomorphicComponentHeight()
        {
            double mesomorphic_height_approx;

            // https://stackoverflow.com/questions/3723321/linq-to-get-closest-value
            mesomorphic_height_approx = MesomorphicTable
                                                    .OrderBy
                                                    (
                                                        row_height => 
                                                        {
                                                            return 
                                                                Math.Abs
                                                                        (
                                                                            row_height.Value.Height 
                                                                            - 
                                                                            Height
                                                                        );
                                                        }
                                                    )
                                                    .First()
                                                    .Value.Height
                                                    ;
            // https://stackoverflow.com/questions/17995706/how-to-get-the-index-of-an-item-in-a-list-in-a-single-step
            int height_index = MesomorphicTable
                                            .Select((Value, Index) => new { Value, Index })
                                            .Single(p => p.Value.Value.Height == mesomorphic_height_approx)
                                            .Index
                                            ;

            return
                    (
                        Approximation: mesomorphic_height_approx,
                        Index: height_index
                    );
        }

        protected
            (
                double Approximation,
                int Index
            )
                MesomorphicComponentHumerus()
        {
            double mesomorphic_humerus_bicondyle_approx;

            mesomorphic_humerus_bicondyle_approx = MesomorphicTable
                                                        .OrderBy
                                                        (
                                                            row_height => 
                                                            {
                                                                return 
                                                                    Math.Abs
                                                                            (
                                                                                row_height.Value.HumerusBicondyle 
                                                                                - 
                                                                                Bicondyles.Humerus
                                                                            );
                                                            }
                                                        )
                                                        .First()
                                                        .Value.HumerusBicondyle
                                                        ;
            int humerus_index = MesomorphicTable
                                            .Select((Value, Index) => new { Value, Index })
                                            .Single(p => p.Value.Value.HumerusBicondyle == mesomorphic_humerus_bicondyle_approx)
                                            .Index
                                            ;

            return
                    (
                        Approximation: mesomorphic_humerus_bicondyle_approx,
                        Index: humerus_index
                    );
        }

        protected
            (
                double Approximation,
                int Index
            )
                MesomorphicComponentFemur()
        {
            double mesomorphic_femur_bicondyle_approx;

            mesomorphic_femur_bicondyle_approx = MesomorphicTable
                                                        .OrderBy
                                                        (
                                                            row_height => 
                                                            {
                                                                return 
                                                                    Math.Abs
                                                                            (
                                                                                row_height.Value.FemurBicondyle 
                                                                                - 
                                                                                Bicondyles.Femur
                                                                            );
                                                            }
                                                        )
                                                        .First()
                                                        .Value.FemurBicondyle
                                                        ;
            int femur_index = MesomorphicTable
                                    .Select((Value, Index) => new { Value, Index })
                                    .Single(p => p.Value.Value.FemurBicondyle == mesomorphic_femur_bicondyle_approx)
                                    .Index
                                    ;

            return
                    (
                        Approximation: mesomorphic_femur_bicondyle_approx,
                        Index: femur_index
                    );
        }

        protected
            (
                double Approximation,
                int Index
            )
                MesomorphicComponentArmUper()
        {
            double mesomorphic_upper_arm_circumference_approx;

            mesomorphic_upper_arm_circumference_approx = MesomorphicTable
                                            .OrderBy
                                            (
                                                row_height => 
                                                {
                                                    return 
                                                        Math.Abs
                                                                (
                                                                    row_height.Value.ArmUpperCircumference
                                                                    - 
                                                                    Circumferences.ArmUpper
                                                                );
                                                }
                                            )
                                            .First()
                                            .Value.ArmUpperCircumference
                                            ;
            int upper_arm_index = MesomorphicTable
                                    .Select((Value, Index) => new { Value, Index })
                                    .Single(p => p.Value.Value.ArmUpperCircumference == mesomorphic_upper_arm_circumference_approx)
                                    .Index
                                    ;

            return
                    (
                        Approximation: mesomorphic_upper_arm_circumference_approx,
                        Index: upper_arm_index
                    );
        }

        protected
            (
                double Approximation,
                int Index
            )
                MesomorphicComponentCalf()
        {
            double mesomorphic_calf_circumference_approx;

            mesomorphic_calf_circumference_approx = MesomorphicTable
                                            .OrderBy
                                            (
                                                row_height => 
                                                {
                                                    return 
                                                        Math.Abs
                                                                (
                                                                    row_height.Value.CalfCircumference
                                                                    - 
                                                                    Circumferences.Calf
                                                                    -
                                                                    Skinfolds.Calf
                                                                );
                                                }
                                            )
                                            .First()
                                            .Value.CalfCircumference
                                            ;
            int calf_index = MesomorphicTable
                                    .Select((Value, Index) => new { Value, Index })
                                    .Single(p => p.Value.Value.CalfCircumference == mesomorphic_calf_circumference_approx)
                                    .Index
                                    ;

            return
                    (
                        Approximation: mesomorphic_calf_circumference_approx,
                        Index: calf_index
                    );
        }
    }
}

