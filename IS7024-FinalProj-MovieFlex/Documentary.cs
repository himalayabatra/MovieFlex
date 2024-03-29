﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using External;
//
//    var externalApi = ExternalApi.FromJson(jsonString);



namespace External
{
    using System;
    using System.Collections.Generic;



    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;



    public partial class ExternalApi
    {
        [JsonProperty("status")]
        public string Status { get; set; }



        [JsonProperty("copyright")]
        public string Copyright { get; set; }



        [JsonProperty("section")]
        public string Section { get; set; }



        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }



        [JsonProperty("num_results")]
        public long NumResults { get; set; }



        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }



    public partial class Result
    {
        [JsonProperty("section")]
        public string Section { get; set; }



        [JsonProperty("subsection")]
        public string Subsection { get; set; }



        [JsonProperty("title")]
        public string Title { get; set; }



        [JsonProperty("abstract")]
        public string Abstract { get; set; }



        [JsonProperty("url")]
        public Uri Url { get; set; }



        [JsonProperty("uri")]
        public string Uri { get; set; }



        [JsonProperty("byline")]
        public string Byline { get; set; }



        [JsonProperty("item_type")]
        public string ItemType { get; set; }



        [JsonProperty("updated_date")]
        public DateTimeOffset UpdatedDate { get; set; }



        [JsonProperty("created_date")]
        public DateTimeOffset CreatedDate { get; set; }



        [JsonProperty("published_date")]
        public DateTimeOffset PublishedDate { get; set; }



        [JsonProperty("material_type_facet")]
        public string MaterialTypeFacet { get; set; }



        [JsonProperty("kicker")]
        public string Kicker { get; set; }



        [JsonProperty("des_facet")]
        public List<string> DesFacet { get; set; }



        [JsonProperty("org_facet")]
        public List<string> OrgFacet { get; set; }



        [JsonProperty("per_facet")]
        public List<object> PerFacet { get; set; }



        [JsonProperty("geo_facet")]
        public List<object> GeoFacet { get; set; }



        [JsonProperty("multimedia")]
        public List<Multimedia> Multimedia { get; set; }



        [JsonProperty("short_url")]
        public Uri ShortUrl { get; set; }
    }



    public partial class Multimedia
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }



        [JsonProperty("format")]
        public string Format { get; set; }



        [JsonProperty("height")]
        public long Height { get; set; }



        [JsonProperty("width")]
        public long Width { get; set; }



        [JsonProperty("type")]
        public string Type { get; set; }



        [JsonProperty("subtype")]
        public string Subtype { get; set; }



        [JsonProperty("caption")]
        public string Caption { get; set; }



        [JsonProperty("copyright")]
        public string Copyright { get; set; }
    }



    public partial class ExternalApi
    {
        public static ExternalApi FromJson(string json) => JsonConvert.DeserializeObject<ExternalApi>(json, External.Converter.Settings);
    }



    public static class Serialize
    {
        public static string ToJson(this ExternalApi self) => JsonConvert.SerializeObject(self, External.Converter.Settings);
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