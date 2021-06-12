using System;
using System.Collections.Generic;

namespace HolisticWare.Ph4ct3x.Utilities.Weather.Core
{
    public partial class Data
    {
        public WeatherData Current
        {
            get;
            set;
        }

        public IEnumerable<WeatherData> Forecast
        {
            get;
            set;
        }
    }
}
