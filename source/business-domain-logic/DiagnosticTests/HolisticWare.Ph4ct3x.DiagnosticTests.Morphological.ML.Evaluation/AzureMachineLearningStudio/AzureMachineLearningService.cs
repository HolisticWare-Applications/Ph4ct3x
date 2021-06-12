using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.ML.Evaluation;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes.ML.Evaluation.AzureMachineLearningStudio
{
    public static class AzureMachineLearningService
    {
        static AzureMachineLearningService()
        {
        }

        public static double Request
                                (
                                    double height,
                                    double mass,
                                    double skinfoldTriceps,
                                    double skinfoldSubscapular,
                                    double skinfoldSupraspinale,
                                    double skinfoldMedialCalf,
                                    double girthArmUpper,
                                    double girthCalfStanding,
                                    double breadthFemur,
                                    double breadthHumerus
                                )
        {
            double endomorphic = InvokeRequestResponseService
                                            (
                                                height,
                                                mass,
                                                skinfoldTriceps,
                                                skinfoldSubscapular,
                                                skinfoldSupraspinale,
                                                skinfoldMedialCalf,
                                                girthArmUpper,
                                                girthCalfStanding,
                                                breadthFemur,
                                                breadthHumerus
                                            )
                                            .Result;

            return endomorphic;
        }

        static async
                Task<double>
                        InvokeRequestResponseService
                                (
                                    double height,
                                    double mass,
                                    double skinfoldTriceps,
                                    double skinfoldSubscapular,
                                    double skinfoldSupraspinale,
                                    double skinfoldMedialCalf,
                                    double girthArmUpper,
                                    double girthCalfStanding,
                                    double breadthFemur,
                                    double breadthHumerus
                                )
        {
            double endomorphic = double.NaN;

            using (HttpClient client = new HttpClient())
            {
                var scoreRequest = new
                {
                    Inputs = new Dictionary<string, StringTable> () 
                    { 
                        { 
                            "input1", 
                            new StringTable() 
                            {
                                ColumnNames = new string[]
                                {
                                    "Endomorphic",
                                    "Mesomorphic",
                                    "EctoMorphic",
                                    "Id",
                                    "Mass",
                                    "Height",
                                    "SkinfoldTriceps",
                                    "SkinfoldSubscapular",
                                    "SkinfoldSupraspinale",
                                    "SkinfoldMedialCalf",
                                    "BreadthHumerus",
                                    "BreadthFemur",
                                    "GirthArmUpper",
                                    "GirthCalfStanding"
                                },
                                Values = new string[,]
                                {
                                    {
                                        "0",
                                        "0",
                                        "0",
                                        "0",
                                        mass.ToString(),
                                        height.ToString(),
                                        skinfoldTriceps.ToString(),
                                        skinfoldSubscapular.ToString(),
                                        skinfoldSupraspinale.ToString(),
                                        skinfoldMedialCalf.ToString(),
                                        breadthHumerus.ToString(),
                                        breadthFemur.ToString(),
                                        girthArmUpper.ToString(),
                                        girthCalfStanding.ToString()
                                    },
                                }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };

                // Replace this with the API key for the web service
                const string apiKey = "d0tjWXXsga0nPXWBDyrdJii17ItC+bDtw70VZXSnQw6W3l4gb/Cr+kJJqLPm/VNp04eRl62qnjEYPVSCeru3ww=="; 
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "Bearer", apiKey);

                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/f923495916604ddfb1a42a0098161ea9/services/4be76583ccd247bdb00a88ad2888e783/execute?api-version=2.0&details=true");

                // WARNING: The 'await' statement below can result in a deadlock if you are calling this code
                // from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false) so that the execution does not
                // attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)


                // System.Net.Http.Formatting.Extension
                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Console.WriteLine("Result: {0}", result);

                    // result = result.Replace(@"\", "");
                    Newtonsoft.Json.Linq.JObject json_object = Newtonsoft.Json.Linq.JObject.Parse(result);

                    string string_endo = json_object["Results"]["output1"]["value"]["Values"][0][13].ToString();

                    endomorphic = double.Parse(string_endo);
                }
                else
                {
                    Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

                    // Print the headers - they include the requert ID and the timestamp, which are useful for debugging the failure
                    Console.WriteLine(response.Headers.ToString());

                    string responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Console.WriteLine(responseContent);
                }
            }

            return endomorphic;
        }

    }
}
