using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace HolisticWare.Ph4ct3x.Utilities.Weather.Providers.AccuWeather
{
    public class Settings
    {
        public string ApiKey
        {
            get;
            set;
        }

        public Settings
                                                (
                                                )
        {
            string name = this.GetType().FullName;


            return;
        }
    }
}
