using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Movie;

namespace IS7024_FinalProj_MovieFlex.Pages
{
    public class Top250MoviesModel : PageModel
    {
        static readonly HttpClient client = new HttpClient();
        public void OnGet()
        {
           var task = client.GetAsync("https://imdb-api.com/en/API/Top250Movies/k_thj97up3");
            HttpResponseMessage result =  task.Result;
            ////List<MovieList> movies = new List<MovieList>();
            MovieList movies = new MovieList();
            if (result.IsSuccessStatusCode)
            {
                Task<string> readString = result.Content.ReadAsStringAsync();
                string jsonString = readString.Result;
                movies = MovieList.FromJson(jsonString);
            }
            ViewData["Movies"] = movies;
        }
    }
}
