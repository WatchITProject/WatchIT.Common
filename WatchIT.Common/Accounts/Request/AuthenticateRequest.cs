using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WatchIT.Common.Accounts.Request
{
    public class AuthenticateRequest
    {
        [JsonProperty("username_or_email")]
        [JsonPropertyName("username_or_email")]
        public string UsernameOrEmail { get; set; }

        [JsonProperty("password")]
        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonProperty("remember_me")]
        [JsonPropertyName("remember_me")]
        public bool RememberMe {  get; set; }
    }
}
