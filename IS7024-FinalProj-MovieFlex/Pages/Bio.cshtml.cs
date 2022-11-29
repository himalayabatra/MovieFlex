using External;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IS7024_FinalProj_MovieFlex.Pages
{
    public class BioModel : PageModel
    {
        static readonly HttpClient client = new HttpClient();
        public async Task OnGet()
        {
            ExternalApi data = await GetData();
            ViewData["ExternalAPI"] = data;

        }



        private async Task<ExternalApi> GetData()
        {
            HttpRequestMessage request2 = new HttpRequestMessage();
            request2.RequestUri = new Uri("https://is7024fall22finalproject20221104125806.azurewebsites.net/api/v1");
            request2.Method = HttpMethod.Get;
            HttpResponseMessage response2 = await client.SendAsync(request2);
            ExternalApi data = new ExternalApi();
            if (response2.IsSuccessStatusCode)
            {
                Task<string> readString = response2.Content.ReadAsStringAsync();
                string jsonString = readString.Result;
                data = ExternalApi.FromJson(jsonString);
            }



            return data;
        }
    }
    }
