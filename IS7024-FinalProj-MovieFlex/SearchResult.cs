

namespace MovieFlex
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class SearchResult
    {
        [JsonProperty("searchType")]
        public string SearchType { get; set; }

        [JsonProperty("expression")]
        public string Expression { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resultType")]
        public string ResultType { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public partial class SearchResult
    {
        public static SearchResult FromJson(string json) => JsonConvert.DeserializeObject<SearchResult>(json, MovieFlex.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this SearchResult self) => JsonConvert.SerializeObject(self, MovieFlex.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
