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
        [JsonPropertyName("username_or_email")]
        public string UsernameOrEmail { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("remember_me")]
        public bool RememberMe {  get; set; }
    }
}
