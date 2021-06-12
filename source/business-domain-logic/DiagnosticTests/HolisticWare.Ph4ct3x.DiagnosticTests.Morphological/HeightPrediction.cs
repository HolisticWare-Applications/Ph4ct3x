 using System;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological
{
    /// <summary>
    /// 
    /// </summary>
    /// TODO: Func<> delegate + Dictionary
    /// <see href="https://www.calculator.net/height-calculator.html"/>
    /// <see href="https://www.thecalculator.co/health/Height-Predictor-222.html"/>
    /// <see href="https://www.mayoclinic.org/healthy-lifestyle/childrens-health/expert-answers/child-growth/faq-20057990"/>
    /// <see href="https://www.gigacalculator.com/calculators/height-calculator.php"/>
    /// <see href="https://www.topendsports.com/testing/height-prediction.htm"/>
    public partial class HeightPrediction
    {
        public double Calculate(double height_mother, double height_father, Gender gender)
        {
            double height_predicted = height_mother + height_father;

            if (gender == Gender.Female)
            {
                height_predicted = height_predicted - 13.0;
            }
            else if (gender == Gender.Male)
            {
                height_predicted = height_predicted + 13.0;
            }
            height_predicted = height_predicted / 2.0;

            return height_predicted;
        }

        /// <summary>
        ///  double a boy's height at age 2 or a girl's height at age 18 months.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public double CalculateMalesAtAge24MonthsFemalesAtAge18Months(double height)
        {
            double height_predicted = height * 2.0;

            return height_predicted;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="gender"></param>
        /// <returns></returns>
        /// <see href="https://howtoadult.com/predict-childs-adult-height-2099130.html"/>
        public double CalculateWolensMethod(double height, Gender gender)
        {
            double height_predicted = 0.0;

            if (gender == Gender.Female)
            {
                height_predicted = height * 1.29 + 0.423;
            }
            else if (gender == Gender.Male)
            {
                height_predicted = height * 1.29 + 0.549;
            }

            return height_predicted;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        /// <see href="https://howtoadult.com/predict-childs-adult-height-2099130.html"/>
        /// <see href="https://www.babymed.com/tools-tools-other/how-tall-will-your-baby-be-use-khamis-calculator-child-height-calculator-and-find"/>
        /// <see href="https://www.lifemeasure.com/calculators"/>
        /// <see href="https://www.momjunction.com/child-height-predictor/"/>
        /// <see href="https://www.inchcalculator.com/childs-height-prediction-calculator/"/>
        /// <see href="https://tall.life/height-calculator-how-tall-will-i-be/"/>
        /// <see href="https://www.infantchart.com/heightpredictor.php"/>
        /// <see href="http://www.wright.edu/~harry.khamis/stature_prediction/"/>
        public double CalculateKhamisRocheMethod(double height)
        {
            double height_predicted = height * 2.0;

            // Child’s height (multiplied by a coefficient) + child’s weight (multiplied by a coefficient) + midparents height (multiplied by a coefficient) (multiplied by a coefficient)

            return height_predicted;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        /// <see href="https://www.babymed.com/tools-tools-other/how-tall-will-your-baby-be-use-khamis-calculator-child-height-calculator-and-find"/>
        public double CalculateFelsLongitudinalMethod(double height)
        {
            double height_predicted = height * 2.0;


            return height_predicted;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        /// <see href="https://www.wikihow.com/Predict-Height"/> 
        public double CalculateGrayMethod(double height)
        {
            double height_predicted = height * 2.0;


            return height_predicted;
        }


        // https://www.etoolsage.com/Chart/CDC_Growth_Chart.asp?toolsort=1500
        // https://www.cdc.gov/growthcharts/html_charts/lenageinf.htm
        // http://heightpredictor.w3ec.com/

    }
}
