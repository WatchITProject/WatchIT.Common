using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WatchIT.Common.Accounts.Request
{
    public class RegisterRequest
    {
        [JsonProperty("username")]
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
