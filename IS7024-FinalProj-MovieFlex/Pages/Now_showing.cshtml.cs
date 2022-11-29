using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Numerics;
using MovieShows;

namespace IS7024_FinalProj_MovieFlex.Pages
{
    public class ContactUsModel : PageModel
    {
        static readonly HttpClient client = new HttpClient();

        public void OnGet()
        {

            var task = client.GetAsync("https://imdb-api.com/en/API/BoxOffice/k_dr1ok248");
            HttpResponseMessage result = task.Result;
            ShowingMovies Show_movie_list = new ShowingMovies();
            if (result.IsSuccessStatusCode)
            {
                Task<string> readString = result.Content.ReadAsStringAsync();
                string jsonString = readString.Result;
                Show_movie_list = ShowingMovies.FromJson(jsonString);
            }
            ViewData["Show_movie_list"] = Show_movie_list;

        }
    }
}
