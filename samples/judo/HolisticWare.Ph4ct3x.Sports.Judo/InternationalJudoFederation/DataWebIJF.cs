using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation
{
    public class DataWebIJF
    {
        protected static HttpClient client = new HttpClient();

        protected string search_term = null;


        protected string url = "https://www.ijf.org";

        public DataWebIJF()
        {

            return;
        }

        /// <summary>
        ///
        /// result_rank_group = new string[]
        /// {
        ///     "all",          // all
        ///     "wc",           // world championships
        ///     "cont_champ",   // continental championships
        ///     "cont_cup",     // continental cups
        /// };
        /// </summary>
        /// <param name="id"></param>
        /// <param name="result_rank_group"></param>
        /// <returns></returns>
        public async Task<string> GetDataCompetitorResults
                                            (
                                                int id,
                                                string result_rank_group
                                            )
        {                                        
            // https://www.ijf.org/judoka/29418/results?results_rank_group=all
            // ... Target URL endpoint.
            string page = string.Concat
                                        (
                                            $"{url}/judoka",
                                            $"/",
                                            $"{id}",
                                            $"/",
                                            $"results",
                                            $"?",
                                            $"result_rank_group=",
                                            result_rank_group
                                        );
            string result = null;

            result = await GetDataAsync(page);

            return result;

        }

        public async Task<string> GetDataCompetitorResults
                                            (
                                                int id
                                            )
        {
            return await GetDataCompetitorResults(id, "all");
        }

        private static async Task<string> GetDataAsync(string page)
        {
            string result = null;

            // ... Use HttpClient.
            // using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content)
            {
                // ... Read the string.
                result = await content.ReadAsStringAsync();
            }

            return result;
        }
    }
}
