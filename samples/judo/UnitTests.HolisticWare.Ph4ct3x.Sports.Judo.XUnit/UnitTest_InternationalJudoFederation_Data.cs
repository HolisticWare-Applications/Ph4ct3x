using System;
using System.IO;
using Xunit;

using Newtonsoft.Json;

using HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Internal;

namespace UnitTests.HolisticWare.Ph4ct3x.Sports.Judo.XUnit
{
    public class UnitTest_InternationalJudoFederation_Data
    {
        global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Data data = null;

        [InlineData("cvjetko")]
        [InlineData("cvjetko lara")]
        [InlineData("kristo")]
        [InlineData("oberan")]
        [InlineData("croatia")]
        [InlineData("island")]
        [InlineData("iceland")]
        [Theory]
        public void TestData_Search_General_01(string search)
        {

            data = new global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Data();

            string result = null;

            result = data.GetDataSearchGeneral(search).Result;

            File.WriteAllText($"./ijf_data_general_01_{search}.json", result);

            return;
        }

        [InlineData("croatia")]
        [InlineData("island")]
        [InlineData("iceland")]
        [Theory]
        public void TestData_Search_Country_01(string search)
        {

            data = new global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Data();

            string result = null;

            result = data.GetDataSearchCountry(search).Result;

            File.WriteAllText($"./ijf_data_country_01_{search}.json", result);

            return;
        }

        [InlineData(2019, 06, null)]
        [InlineData(2019, 06, "")]
        [Theory]
        public void TestData_Search_Competition_01(int year, int month, string rank)
        {

            data = new global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Data();

            string result = null;

            result = data.GetDataSearchCompetition(year, month, rank).Result;

            File.WriteAllText($"./ijf_data_competition_01_{year}{month}-{rank}.json", result);

            return;
        }

        [Fact]
        public void TestData_Search_Competition_Ranks()
        {

            data = new global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Data();

            string result = null;

            result = data.GetDataSearchCompetitionRanks().Result;

            File.WriteAllText($"./ijf_data_competition_ranks.json", result);

            Categories c = JsonConvert.DeserializeObject<Categories>(result);

            return;
        }

        [InlineData("zagreb")]
        [InlineData("cvjetko")]
        [InlineData("bela")]
        [InlineData("che")]
        [InlineData("croatia")]
        [Theory]
        public void TestData_Search_GetAll(string search_query)
        {
            data = new global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Data();

            string result = null;

            result = data.GetDataSearchGenerallSearchAll(search_query).Result;

            File.WriteAllText($"./ijf_data_search_all_{search_query}.json", result);

            return;
        }

        [InlineData("competition", "zagreb")]
        [InlineData("competitor", "cvjetko")]
        [InlineData("competitor", "bela")]
        [InlineData("competitor", "che")]
        [InlineData("competiton", "che")]
        [InlineData("country", "che")]
        [InlineData("country", "croatia")]
        [Theory]
        public void TestData_Search_GetOne(string module, string search_query)
        {
            data = new global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Data();

            string result = null;

            result = data.GetDataSearchGenerallSearchAll(search_query).Result;

            File.WriteAllText($"./ijf_data_search_one_module_{module}_guery_{search_query}.json", result);

            SearchAllResult[] results_search_all = SearchAllResult.FromJson(result);

            return;
        }
    }
}
