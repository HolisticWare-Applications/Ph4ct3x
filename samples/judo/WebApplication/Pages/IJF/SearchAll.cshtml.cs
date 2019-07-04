using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Internal;

namespace WebApplication.Pages.IJF
{
    public class SearchAllModel : PageModel
    {
        [BindProperty]
        public SearchAllResult[] SearchAllResults
        {
            get;
            set;
        }

        global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Data data = null;

        public void OnGet(string module, string search_query)
        {
            SearchAll(module, search_query);

            return;
        }

        public void OnPost(string module, string search_query)
        {
            SearchAll(module, search_query);

            return;
        }

        public void SearchAll(string module, string search_query)
        {

            data = new global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Data();

            string result = null;

            result = data.GetDataSearchGenerallSearchAll(search_query).Result;

            System.IO.File.WriteAllText($"./ijf_data_search_one_module_{module}_guery_{search_query}.json", result);

            if (module != null && search_query != null)
            {
                SearchAllResult[] results_search_all = SearchAllResult.FromJson(result);
                SearchAllResults = results_search_all;
            }

            return;
        }
    }
}
