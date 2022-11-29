using Join;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieJoin;

namespace IS7024_FinalProj_MovieFlex.Pages
{
    public class MoviesModel : PageModel
    {
        static readonly HttpClient client = new HttpClient();
        public void OnGet()
        {
            var task = client.GetAsync("https://api.nytimes.com/svc/movies/v2/reviews/search.json?query=Batman&api-key=15eEBZbWGGBOuqWJ2IV9ErRmx9q8ZqXj");
            HttpResponseMessage result = task.Result;
            MovieDemo moviedemos = new MovieDemo();
            if (result.IsSuccessStatusCode)
            {
                Task<string> readstring = result.Content.ReadAsStringAsync();
                string jsonString = readstring.Result;
                moviedemos = MovieDemo.FromJson(jsonString);
            }
            ViewData["moviedemos"] = moviedemos;

            var task1 = client.GetAsync("https://imdb-api.com/en/API/SearchMovie/k_dr1ok248/batman");
            HttpResponseMessage result2 = task1.Result;
            DataJoin data = new DataJoin();
            if (result.IsSuccessStatusCode)
            {
                Task<string> readstring = result2.Content.ReadAsStringAsync();
                string jsonString = readstring.Result;
                data = DataJoin.FromJson(jsonString);
            }
            ViewData["JoinData"] = data;
        }
    }
}