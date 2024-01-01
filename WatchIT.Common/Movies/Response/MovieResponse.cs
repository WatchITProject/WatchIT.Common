using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WatchIT.Common.Movies.Response
{
    public class MovieResponse
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonProperty("original_title")]
        [JsonPropertyName("original_title")]
        public string? OriginalTitle { get; set; }

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonProperty("release_date")]
        [JsonPropertyName("release_date")]
        public DateOnly? ReleaseDate { get; set; }

        [JsonProperty("length")]
        [JsonPropertyName("length")]
        public short? Length { get; set; }

        [JsonProperty("average_rating")]
        [JsonPropertyName("average_rating")]
        public double? AverageRating { get; set; }

        [JsonProperty("rating_count")]
        [JsonPropertyName("rating_count")]
        public int RatingCount { get; set; }

        [JsonProperty("poster_image")]
        [JsonPropertyName("poster_image")]
        public byte[]? PosterImage { get; set; }
    }
}
