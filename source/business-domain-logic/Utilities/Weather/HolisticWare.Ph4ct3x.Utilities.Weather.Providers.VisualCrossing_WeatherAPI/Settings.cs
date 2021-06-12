using System;

namespace HolisticWare.Ph4ct3x.Utilities.Weather.Providers.VisualCrossing_WeatherAPI
{
    public partial class Settings
    {
        static string file = "HolisticWare.Ph4ct3x.Utilities.Weather.Providers.VisualCrossing_WeatherAPI.Settings.json";

        static Settings()
        {

            return;
        }

        public Settings()
        {
            return;
        }

        public string ApiKey
        {
            get;
            set;
        } = "Visit VisualCrossing WeatherAPI Website and obtain API Key";
    }
}
