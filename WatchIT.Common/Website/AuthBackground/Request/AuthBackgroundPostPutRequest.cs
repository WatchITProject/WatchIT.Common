using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WatchIT.Common.Website.AuthBackground.Request
{
    public class AuthBackgroundPostPutRequest
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("image")]
        public byte[] Image { get; set; }
    }
}
