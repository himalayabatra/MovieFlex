﻿

namespace MovieShows
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ShowingMovies
    {
        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("rank")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Rank { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("weekend")]
        public string Weekend { get; set; }

        [JsonProperty("gross")]
        public string Gross { get; set; }

        [JsonProperty("weeks")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Weeks { get; set; }
    }

    public partial class ShowingMovies
    {
        public static ShowingMovies FromJson(string json) => JsonConvert.DeserializeObject<ShowingMovies>(json, MovieShows.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ShowingMovies self) => JsonConvert.SerializeObject(self, MovieShows.Converter.Settings);
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

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
