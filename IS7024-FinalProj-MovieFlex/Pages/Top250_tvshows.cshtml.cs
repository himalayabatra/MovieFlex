using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shows;

namespace IS7024_FinalProj_MovieFlex.Pages
{
    public class Top250_tvshowsModel : PageModel
    {
        static readonly HttpClient client= new HttpClient();
        public void OnGet()
        {
            var task = client.GetAsync("https://imdb-api.com/en/API/Top250TVs/k_dr1ok248");
            HttpResponseMessage result = task.Result;
            Tvshows tvshows = new Tvshows();
            if (result.IsSuccessStatusCode)
            {
                Task<string> readstring = result.Content.ReadAsStringAsync();
                string jsonString = readstring.Result;
                tvshows = Tvshows.FromJson(jsonString);
            }
            ViewData["Tvshows"] = tvshows;
        }
    }
}
