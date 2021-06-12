using System;
using System.Collections.Generic;

namespace Core.Collections.Generic
{
    public static class DictionaryExtensions
    {
        public static (double Min, double Max) RangeForValues(this Dictionary<string, double> data)
        {
            double max = double.NegativeInfinity;
            double min = double.PositiveInfinity;

            foreach(KeyValuePair<string, double> kvp in data)
            {
                double item = kvp.Value;
                if (item  < min)
                {
                    min = kvp.Value;
                }
                if (item  > max)
                {
                    max = kvp.Value;
                }

            }
            return (Min: min, Max: max);
        }
    }
}
