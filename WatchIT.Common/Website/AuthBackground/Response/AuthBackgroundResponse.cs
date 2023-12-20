using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WatchIT.Common.Website.AuthBackground.Response
{
    public class AuthBackgroundResponse
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public short Id { get; set; }

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonProperty("content_type")]
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("image")]
        [JsonPropertyName("image")]
        public byte[] Image { get; set; }
    }
}
