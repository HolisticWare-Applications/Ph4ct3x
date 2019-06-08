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

            string general = data.GetDataSearchGeneral("kristo").Result;

            string country = data.GetDataSearchGeneral("croatia").Result;

            return;
        }
    }
}
