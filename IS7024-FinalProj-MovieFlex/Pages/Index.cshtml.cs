using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieFlex;
using Newtonsoft.Json;

namespace IS7024_FinalProj_MovieFlex.Pages
{
    public class IndexModel : PageModel
    {
        static readonly HttpClient client = new HttpClient();
        private readonly ILogger<IndexModel> _logger;

        [BindProperty(SupportsGet = true)]
        public string searchString { get; set; }

        public bool SearchCompleted { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                SearchCompleted = true;
                var httpTask = client.GetAsync("https://imdb-api.com/en/API/Search/k_dr1ok248/" + searchString);
                HttpResponseMessage httpTaskResult = httpTask.Result;
                SearchResult searchResults = new SearchResult();
                if (httpTaskResult.IsSuccessStatusCode)
                {
                    Task<string> readString = httpTaskResult.Content.ReadAsStringAsync();
                    string jsonString = readString.Result;
                    searchResults = SearchResult.FromJson(jsonString);
                }

                ViewData["searchResult"] = searchResults.Results;
            } else
            {
                SearchCompleted = false;
                SearchResult searchResults = new SearchResult();
            }
        
    }
}
    }