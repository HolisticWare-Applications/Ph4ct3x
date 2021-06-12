using System;
using System.IO;
using Xunit;

using Newtonsoft.Json;

using HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Internal;

namespace UnitTests.HolisticWare.Ph4ct3x.Sports.Judo.XUnit
{
    public class UnitTest_InternationalJudoFederation_DataWebIJF
    {
        global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.DataWebIJF data = null;

        [InlineData(29418)]
        [Theory]
        public void TestData_Search_Competitor_Results_01(int id)
        {

            data = new global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.DataWebIJF();

            string result = null;

            result = data.GetDataCompetitorResults(id).Result;

            File.WriteAllText($"./ijf_web_data_competitor_results_01_{id}.html", result);

            return;
        }

        [InlineData(29418, "all")]
        [InlineData(29418, "wc")]
        [InlineData(29418, "cont_champ")]
        [InlineData(29418, "cont_cup")]
        [Theory]
        public void TestData_Search_Competitor_Results_02(int id, string result_rank)
        {

            data = new global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.DataWebIJF();

            string result = null;

            result = data.GetDataCompetitorResults(id, result_rank).Result;

            File.WriteAllText($"./ijf_web_data_competitor_results_02_{id}_{result_rank}.html", result);

            return;
        }
    }
}
