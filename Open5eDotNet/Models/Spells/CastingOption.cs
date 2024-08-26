using System.Text.Json.Serialization;

namespace Open5eDotNet.Models.Spells
{
    public class CastingOption
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("damage_roll")]
        public string DamageRoll { get; set; }

        [JsonPropertyName("target_count")]
        public int? TargetCount { get; set; }

        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        [JsonPropertyName("range")]
        public string Range { get; set; }
    }
}