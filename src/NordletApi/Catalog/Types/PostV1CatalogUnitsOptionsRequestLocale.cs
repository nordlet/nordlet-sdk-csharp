using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CatalogUnitsOptionsRequestLocale.PostV1CatalogUnitsOptionsRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct PostV1CatalogUnitsOptionsRequestLocale : IStringEnum
{
    public static readonly PostV1CatalogUnitsOptionsRequestLocale Lt = new(Values.Lt);

    public static readonly PostV1CatalogUnitsOptionsRequestLocale En = new(Values.En);

    public PostV1CatalogUnitsOptionsRequestLocale(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static PostV1CatalogUnitsOptionsRequestLocale FromCustom(string value)
    {
        return new PostV1CatalogUnitsOptionsRequestLocale(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(PostV1CatalogUnitsOptionsRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1CatalogUnitsOptionsRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CatalogUnitsOptionsRequestLocale value) =>
        value.Value;

    public static explicit operator PostV1CatalogUnitsOptionsRequestLocale(string value) =>
        new(value);

    internal class PostV1CatalogUnitsOptionsRequestLocaleSerializer
        : JsonConverter<PostV1CatalogUnitsOptionsRequestLocale>
    {
        public override PostV1CatalogUnitsOptionsRequestLocale Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new PostV1CatalogUnitsOptionsRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CatalogUnitsOptionsRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CatalogUnitsOptionsRequestLocale ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new PostV1CatalogUnitsOptionsRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CatalogUnitsOptionsRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Lt = "lt";

        public const string En = "en";
    }
}
