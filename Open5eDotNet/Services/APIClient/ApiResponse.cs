using System.Text.Json.Serialization;

namespace Open5eDotNet.Services.APIClient
{
    public class ApiResponse<T>
    {
        [JsonPropertyName("results")]
        public T Results { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("next")]
        public string Next { get; set; }

        [JsonPropertyName("previous")]
        public string Previous { get; set; }
    }
}