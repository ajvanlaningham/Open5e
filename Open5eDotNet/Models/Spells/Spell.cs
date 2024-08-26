using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Open5eDotNet.Models.Spells
{
    public class Spell
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("casting_options")]
        public List<CastingOption> CastingOptions { get; set; }

        [JsonPropertyName("school")]
        public School School { get; set; }

        [JsonPropertyName("range_unit")]
        public string RangeUnit { get; set; }

        [JsonPropertyName("shape_size_unit")]
        public string ShapeSizeUnit { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("desc")]
        public string Description { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }

        [JsonPropertyName("higher_level")]
        public string HigherLevel { get; set; }

        [JsonPropertyName("target_type")]
        public string TargetType { get; set; }

        [JsonPropertyName("range_text")]
        public string RangeText { get; set; }

        [JsonPropertyName("range")]
        public double? Range { get; set; }

        [JsonPropertyName("ritual")]
        public bool Ritual { get; set; }

        [JsonPropertyName("casting_time")]
        public string CastingTime { get; set; }

        [JsonPropertyName("verbal")]
        public bool Verbal { get; set; }

        [JsonPropertyName("somatic")]
        public bool Somatic { get; set; }

        [JsonPropertyName("material")]
        public bool Material { get; set; }

        [JsonPropertyName("material_specified")]
        public string MaterialSpecified { get; set; }

        [JsonPropertyName("material_cost")]
        public object MaterialCost { get; set; }

        [JsonPropertyName("material_consumed")]
        public bool MaterialConsumed { get; set; }

        [JsonPropertyName("target_count")]
        public int? TargetCount { get; set; }

        [JsonPropertyName("saving_throw_ability")]
        public string SavingThrowAbility { get; set; }

        [JsonPropertyName("attack_roll")]
        public bool AttackRoll { get; set; }

        [JsonPropertyName("damage_roll")]
        public string DamageRoll { get; set; }

        [JsonPropertyName("damage_types")]
        public List<string> DamageTypes { get; set; }

        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        [JsonPropertyName("shape_type")]
        public string ShapeType { get; set; }

        [JsonPropertyName("shape_size")]
        public string ShapeSize { get; set; }

        [JsonPropertyName("concentration")]
        public bool Concentration { get; set; }

        [JsonPropertyName("document")]
        public string Document { get; set; }
    }
}
