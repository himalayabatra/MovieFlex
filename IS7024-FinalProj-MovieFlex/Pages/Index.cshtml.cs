using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieFlex;
using Newtonsoft.Json;

namespace IS7024_FinalProj_MovieFlex.Pages
{
    public class IndexModel : PageModel
    {
        static readonly HttpClient client = new();
        private readonly ILogger<IndexModel> _logger;

        [BindProperty(SupportsGet = true)]
        public string searchString { get; set; }

        public bool ShowResults { get; set; } 
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            ShowResults = false;
            SearchResult searchResults = new();
            if (string.IsNullOrEmpty(searchString)) return;

            
            var httpTask = client.GetAsync("https://imdb-api.com/en/API/Search/k_thj97up3/" + searchString);
            HttpResponseMessage httpTaskResult = httpTask.Result;

            if (!httpTaskResult.IsSuccessStatusCode) return;
           
            Task<string> readString = httpTaskResult.Content.ReadAsStringAsync();
            string jsonString = readString.Result;
            searchResults = SearchResult.FromJson(jsonString);

            ViewData["searchResult"] = searchResults.Results;
            ShowResults = true; 

        }
            
        
    }
}
    