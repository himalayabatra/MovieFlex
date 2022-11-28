using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Movie;
using OmdbList;

namespace IS7024_FinalProj_MovieFlex.Pages
{
    public class Top250MoviesModel : PageModel
    {
        static readonly HttpClient client = new HttpClient();
        public async Task OnGetAsync()
        {
            
            MovieList movies = await GetMovie();
            ViewData["MovieList"] = movies;
            
        }

        private async Task<MovieList> GetMovie()
        {

            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://imdb-api.com/en/API/Top250Movies/k_thj97up3");
            request.Method = HttpMethod.Get;
            HttpResponseMessage response = await client.SendAsync(request);
            MovieList movies = new MovieList();
            if (response.IsSuccessStatusCode)
            {
                Task<string> readString = response.Content.ReadAsStringAsync();
                string jsonString = readString.Result;
                movies = MovieList.FromJson(jsonString);
            }

            return movies;
        }
        
        }
    }
