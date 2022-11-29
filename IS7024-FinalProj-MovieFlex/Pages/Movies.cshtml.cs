using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieJoin;

namespace IS7024_FinalProj_MovieFlex.Pages
{
    public class MovieDemoModel : PageModel
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
        }
    }
}
