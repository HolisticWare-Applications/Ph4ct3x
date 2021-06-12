using System;

namespace HolisticWare.Ph4ct3x.Utilities.Weather.Core
{
    public partial class WeatherData
    {
        public Location Locatione
        {
            get;
            set;
        }

        public DateTime DateTime
        {
            get;
            set;
        }

        public double Temperature
        {
            get;
            set;
        }

        public double Pressure
        {
            get;
            set;
        }

        public double Humidity
        {
            get;
            set;
        }

        public double CloudCoverage
        {
            get;
            set;
        }

        public double UltraVioletIndex
        {
            get;
            set;
        }
    }
}
