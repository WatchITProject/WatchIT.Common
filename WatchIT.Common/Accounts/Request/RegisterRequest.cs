using System.Text.Json.Serialization;

namespace WatchIT.Common.Accounts.Request
{
    public class RegisterRequest
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
