using Console.Cognitive.FormAnalyzer.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Console.Cognitive.FormAnalyzer
{
    class Program
    {
        static  async Task Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            ResultFormAnalyzer responseObj = new ResultFormAnalyzer();

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "chave-api-key-aqui");// Initialization.  
            string documentId = "id do documento aqui";

            HttpResponseMessage response = new HttpResponseMessage();

            // HTTP GET  
            response = await client.GetAsync($"https://brazilsouth.api.cognitive.microsoft.com/formrecognizer/v2.0-preview/layout/analyzeResults/{documentId}").ConfigureAwait(false);
            System.Console.WriteLine(response.StatusCode);

            if (response.IsSuccessStatusCode)
            {
                // Reading Response.  
                string result = response.Content.ReadAsStringAsync().Result;
                responseObj = JsonConvert.DeserializeObject<ResultFormAnalyzer>(result);
            }

            System.Console.WriteLine(responseObj);

            System.Console.ReadKey();
        }
    }
}
