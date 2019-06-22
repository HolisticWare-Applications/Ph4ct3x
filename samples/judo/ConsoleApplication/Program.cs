using System;
using System.Net.Http;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Data data = null;

            data = new HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Data();

            string general = null;

            general = data.GetDataSearchGeneral("kristo").Result;

            general = data.GetDataSearchGeneral("cvjetko").Result;

            string country = null;

            country = data.GetDataSearchCountry("croatia").Result;

            country = data.GetDataSearchCountry("japan").Result;

            string countries = null;

            countries = data.GetDataCountries().Result;

            string competition = null;

            competition = data.GetDataSearchCompetition(2019, 6).Result;

            return;
        }
    }
}
