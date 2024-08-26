using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Open5eDotNet.Models.Spells
{
    [JsonConverter(typeof(SchoolTypeConverter))]
    public enum SchoolType
    {
        Abjuration,
        Conjuration,
        Divination,
        Enchantment,
        Evocation,
        Illusion,
        Necromancy,
        Transmutation
    }

    public class School
    {
        [JsonPropertyName("key")]
        public SchoolType Key { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("desc")]
        public string Description { get; set; }

        [JsonPropertyName("document")]
        public string Document { get; set; }
    }

    public class SchoolTypeConverter : JsonConverter<SchoolType>
    {
        public override SchoolType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "abjuration" => SchoolType.Abjuration,
                "conjuration" => SchoolType.Conjuration,
                "divination" => SchoolType.Divination,
                "enchantment" => SchoolType.Enchantment,
                "evocation" => SchoolType.Evocation,
                "illusion" => SchoolType.Illusion,
                "necromancy" => SchoolType.Necromancy,
                "transmutation" => SchoolType.Transmutation,
                _ => throw new ArgumentException($"Invalid school type: {value}")
            };
        }

        public override void Write(Utf8JsonWriter writer, SchoolType value, JsonSerializerOptions options)
        {
            var jsonValue = value switch
            {
                SchoolType.Abjuration => "abjuration",
                SchoolType.Conjuration => "conjuration",
                SchoolType.Divination => "divination",
                SchoolType.Enchantment => "enchantment",
                SchoolType.Evocation => "evocation",
                SchoolType.Illusion => "illusion",
                SchoolType.Necromancy => "necromancy",
                SchoolType.Transmutation => "transmutation",
                _ => throw new ArgumentException($"Invalid school type: {value}")
            };

            writer.WriteStringValue(jsonValue);
        }
    }
}
