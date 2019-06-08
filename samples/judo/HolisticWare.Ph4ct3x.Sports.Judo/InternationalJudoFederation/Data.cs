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
            url_search_general = $"{url}/api/get_json?params[q]={search_term}&params[action]=general.search_all";
            url_search_module = $"{url}/api/get_json?params[q]={search_term}&&params[module]={module}&params[action]=general.search_all";

            return;
        }

        public async Task<string> GetDataSearchGeneral(string search)
        {
            search_term = search;

            // ... Target page.
            string page = url_search_general;
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

        
        public async Task<string> GetDataSearchCountry(string country)
        {
            search_term = country;
            module = "country";
            string page = url_search_general;

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
