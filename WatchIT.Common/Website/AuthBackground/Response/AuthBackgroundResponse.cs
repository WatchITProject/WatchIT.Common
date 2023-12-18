﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WatchIT.Common.Website.AuthBackground.Response
{
    public class AuthBackgroundResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("image")]
        public byte[] Image { get; set; }

        [JsonPropertyName("upload_date")]
        public byte[] Image { get; set; }
    }
}
