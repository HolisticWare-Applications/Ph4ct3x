using System;
using System.Collections.Generic;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes.Configurable
{
    public class HeathCarterAlgorithmConfiguration
    {
        public HeathCarterAlgorithmConfiguration()
        {
        }

        public Dictionary<string, double> ConstantsAndParameters
        {
            get;
            set;
        }

        public static Dictionary<string, HeathCarterAlgorithmConfiguration> AlgorithmConfigurations
        {
            get;
            set;
        }

        static HeathCarterAlgorithmConfiguration()
        {
            AlgorithmConfigurations = new Dictionary<string, HeathCarterAlgorithmConfiguration>()
            {
                {
                    "HeathCarterEastonUniversityOfExeter",
                    new HeathCarterAlgorithmConfiguration
                    {
                        ConstantsAndParameters = new Dictionary<string, double>
                        {
                            {
                                "PartEq1End 0.00068",
                                0.00068
                            },
                            {
                                "PartEq1End 0.0000014",
                                0.0000014
                            },
                            {
                                "PartEq1End 16",
                                16
                            },
                            {
                                "PartEq1End 3",
                                3
                            },
                        }                        
                    }
                },
            };

            return;
        }
    }
}
