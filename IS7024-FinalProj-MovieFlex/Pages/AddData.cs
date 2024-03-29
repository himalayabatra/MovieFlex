﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Join;
//
//    var dataJoin = DataJoin.FromJson(jsonString);

namespace Join
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class DataJoin
    {
        [JsonProperty("searchType")]
        public string SearchType { get; set; }

        [JsonProperty("expression")]
        public string Expression { get; set; }

        [JsonProperty("results")]
        public List<Result1> Results { get; set; }
    }

    public partial class Result1
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

    public partial class DataJoin
    {
        public static DataJoin FromJson(string json) => JsonConvert.DeserializeObject<DataJoin>(json, Join.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this DataJoin self) => JsonConvert.SerializeObject(self, Join.Converter.Settings);
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
