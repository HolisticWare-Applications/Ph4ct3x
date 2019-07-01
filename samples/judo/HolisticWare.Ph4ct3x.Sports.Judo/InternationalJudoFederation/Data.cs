using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation
{
    public class Data
    {
        protected static HttpClient client = new HttpClient();

        protected string search_term = null;
        protected string module = null;

        protected string url = "https://data.ijf.org";
        protected string url_search_general = null;
        protected string url_search_module = null;

        public Data()
        {

            return;
        }

        public async Task<string> GetDataSearchGeneral
                                            (
                                                string search
                                            )
        {
            search_term = search;

            // ... Target URL endpoint.
            string page = string.Concat
                                        (
                                            $"{url}/api/get_json",
                                            $"?",
                                            $"params[q]={search_term}",
                                            $"&",
                                            $"params[action]=general.search_all"
                                        );
            string result = null;

            result = await GetDataAsync(page);

            return result;
        }

        
        public async Task<string> GetDataSearchCountry
                                            (
                                                string country
                                            )
        {
            search_term = country;
            module = "country";

            // ... Target URL endpoint.
            string page = string.Concat
                                    (
                                        $"{url}/api/get_json",
                                        $"?",
                                        $"params[q]={search_term}",
                                        $"&",
                                        $"params[module]={module}",
                                        $"&",
                                        $"params[action]=general.search_all"
                                    );
            string result = null;

            result = await GetDataAsync(page);

            return result;
        }

        // https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=country.get_list&params%5B__ust%5D=
        public async Task<string> GetDataCountries
                                            (
                                            )
        {
            // ... Target URL endpoint.
            string page = string.Concat
                                    (
                                        $"{url}/api/get_json",
                                        $"?",
                                        $"params[action]=country.get_list"
                                    );
            string result = null;

            result = await GetDataAsync(page);

            return result;
        }

        // https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competition.all_categories&params%5B__ust%5D=


        public async Task<string> GetDataSearchGenerallSearchAll
                                            (
                                                string search_query
                                            )
        {
            // ... Target URL endpoint.
            string page = string.Concat
                                    (
                                        $"{url}/api/get_json",
                                        $"?",
                                        $"params[action]=general.search_all",
                                        "&",
                                        $"params[g]={search_query}"
                                    );
            string result = null;

            result = await GetDataAsync(page);

            return result;

        }

        public async Task<string> GetDataSearchGenerallGetOne
                                            (
                                                string module,
                                                string search_query
                                            )
        {
            // ... Target URL endpoint.
            string page = string.Concat
                                    (
                                        $"{url}/api/get_json",
                                        $"?",
                                        $"params[action]=general.get_one",
                                        "&",
                                        $"params[g]={search_query}",
                                        "&",
                                        $"params[module]={module}"
                                    );
            string result = null;

            result = await GetDataAsync(page);

            return result;

        }

        public async Task<string> GetDataSearchCompetitionRanks
                                            (
                                            )
        {
            // ... Target URL endpoint.
            string page = string.Concat
                                    (
                                        $"{url}/api/get_json",
                                        $"?",
                                        $"params[action]=competition.all_categories"
                                    );
            string result = null;

            result = await GetDataAsync(page);

            return result;
        }

        public async Task<string> GetDataSearchCompetition
                                            (
                                                int year,
                                                int month,
                                                string rank_group = ""
                                            )
        {
            // ... Target URL endpoint.
            string page = string.Concat
                                    (
                                        $"{url}/api/get_json",
                                        $"?",
                                        $"params[action]=competition.get_list",
                                        $"&",
                                        $"params[q]={search_term}",
                                        $"&",
                                        $"params[rank_group]={rank_group}",
                                        $"&",
                                        $"params[year]={year}",
                                        $"&",
                                        $"params[month]={month}"
                                    );
            string result = null;

            result = await GetDataAsync(page);

            return result;
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
