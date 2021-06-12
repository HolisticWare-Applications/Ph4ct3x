using System;
using System.Collections.Generic;
using System.Linq;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes.Configurable
{
    /// <summary>
    ///
    ///
    ///
    /// <a href="http://stackoverflow.com">here</a>
    /// </summary>
    public class HeathCarterModified : HeathCarterBase
    {
        public HeathCarterModified() : base()
        {
            Initialize();

            return;
        }



        public
            Dictionary
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
            EndomorphicTable = new Dictionary
                                        <
                                            double,
                                            (
                                                double Lower,
                                                double Upper
                                            )
                                        >
                                        {
                                            {0.5, (Lower:  7.0, Upper: 10.9)},
                                            {1.0, (Lower: 11.0, Upper: 14.9)},
                                            {1.5, (Lower: 15.0, Upper: 18.9)},
                                            {2.0, (Lower: 19.0, Upper: 22.9)},
                                            {2.5, (Lower: 23.0, Upper: 26.9)},
                                            {3.0, (Lower: 27.0, Upper: 31.2)},
                                            {3.5, (Lower: 31.3, Upper: 35.8)},
                                            {4.0, (Lower: 35.9, Upper: 40.7)},
                                            {4.5, (Lower: 40.8, Upper: 46.2)},
                                            {5.0, (Lower: 46.3, Upper: 52.2)},
                                            {5.5, (Lower: 52.3, Upper: 58.7)},
                                            {6.0, (Lower: 58.8, Upper: 65.7)},
                                            {6.5, (Lower: 65.8, Upper: 73.2)},
                                            {7.0, (Lower: 73.3, Upper: 81.2)},
                                            {7.5, (Lower: 81.3, Upper: 89.7)},
                                            {8.0, (Lower: 89.8, Upper: 98.9)},
                                        };

            MesomorphicTable = new Dictionary
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
                                        {
                                            {0.0, (139.7, 5.19, 7.41, 23.7, 27.7)},
                                            {0.5, (143.5, 5.34, 7.62, 24.4, 28.5)},
                                            {1.0, (147.3, 5.49, 7.83, 25.0, 29.3)},
                                            {1.5, (151.1, 5.64, 8.04, 25.7, 30.1)},
                                            {2.0, (154.9, 5.78, 8.24, 26.3, 30.8)},
                                            {2.5, (158.9, 5.93, 8.45, 27.0, 31.6)},
                                            {3.0, (162.6, 6.07, 8.66, 27.7, 32.4)},
                                            {3.5, (166.4, 6.22, 8.87, 28.3, 33.2)},
                                            {4.0, (170.2, 6.37, 9.08, 29.0, 33.9)},
                                            {4.5, (174.9, 6.51, 9.28, 29.7, 34.7)},
                                            {5.0, (177.9, 6.65, 9.49, 30.3, 35.5)},
                                            {5.5, (181.6, 6.80, 9.70, 31.0, 36.3)},
                                            {6.0, (185.4, 6.95, 9.91, 31.6, 37.1)},
                                            {6.5, (189.6, 7.09, 10.12, 32.2, 37.8)},
                                            {7.0, (193.0, 7.24, 10.33, 33.0, 38.6)},
                                            {7.5, (196.9, 7.38, 10.53, 33.6, 39.4)},
                                            {8.0, (200.3, 7.53, 10.74, 34.3, 40.2)},
                                        };

            EctomorphicTable = new Dictionary
                                        <
                                            double, 
                                            (
                                                double Lower, 
                                                double Upper
                                            )
                                        > 
                                        {
                                            {0.5, (Lower: 0.0, Upper: 39.65)},
                                            {1.0, (Lower: 39.66, Upper: 40.74)},
                                            {1.5, (Lower: 40.75, Upper: 41.43)},
                                            {2.0, (Lower: 41.44, Upper: 42.13)},
                                            {2.5, (Lower: 42.14, Upper: 42.82)},
                                            {3.0, (Lower: 42.83, Upper: 43.48)},
                                            {3.5, (Lower: 43.49, Upper: 44.18)},
                                            {4.0, (Lower: 44.19, Upper: 44.84)},
                                            {4.5, (Lower: 44.85, Upper: 45.53)},
                                            {5.0, (Lower: 45.54, Upper: 46.23)},
                                            {5.5, (Lower: 46.24, Upper: 46.92)},
                                            {6.0, (Lower: 46.93, Upper: 47.58)},
                                            {6.5, (Lower: 47.59, Upper: 48.25)},
                                            {7.0, (Lower: 48.26, Upper: 48.94)},
                                            {7.5, (Lower: 48.95, Upper: 49.63)},
                                        };
            return;
        }

        public double EndomorphicComponent()
        {
            double endomorphic_sum = 
                                        this.Skinfolds.SubTriceps
                                        +
                                        this.Skinfolds.SubScapular
                                        +
                                        this.Skinfolds.SupraIliac
                                        -
                                        this.Skinfolds.Calf
                                        ;

            double endomorphic_result = EndomorphicTable
                                                .Where
                                                (
                                                    row => 
                                                    {
                                                        return 
                                                            endomorphic_sum >= row.Value.Lower 
                                                            && 
                                                            endomorphic_sum <= row.Value.Upper;
                                                    }
                                                )
                                                .Select(row => row.Key)
                                                .FirstOrDefault()
                                                ;

            return endomorphic_sum;
        }

        public double EctomorphicComponent()
        {
            double ectomorphic = Height / Math.Pow(Mass, 1.0 / 3.0);

            double ectomorphic_result = EctomorphicTable
                                                .Where
                                                (row => 
                                                    {
                                                        return 
                                                            ectomorphic >= row.Value.Lower 
                                                            && 
                                                            ectomorphic <= row.Value.Upper;
                                                    }
                                                )
                                                .Select(row => row.Key)
                                                .FirstOrDefault()
                                                ;

            return ectomorphic_result;
        }

        public double MesomorphicComponent()
        {
            (
                double Approximation,
                int Index
            )
                component_height     = MesomorphicComponentHeight();
            (
                double Approximation,
                int Index
            )
                component_humerus    = MesomorphicComponentHumerus();
            (
                double Approximation,
                int Index
            )
                component_femur     = MesomorphicComponentFemur();
            (
                double Approximation,
                int Index
            )
                component_arm_upper    = MesomorphicComponentArmUper();

            (
                double Approximation,
                int Index
            )
                component_calf    = MesomorphicComponentCalf();

            int dev_height = component_height.Index - component_height.Index;
            int dev_humerus = component_humerus.Index - component_height.Index;
            int dev_femur = component_femur.Index - component_height.Index;
            int dev_arm_upper = component_arm_upper.Index - component_height.Index;
            int dev_calf = component_calf.Index - component_height.Index;

            int dev_sum = dev_humerus + dev_femur + dev_arm_upper + dev_calf;

            return dev_sum;
        }

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
