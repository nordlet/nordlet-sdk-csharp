using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(UnitsOptionsCatalogRequestLocale.UnitsOptionsCatalogRequestLocaleSerializer))]
[Serializable]
public readonly record struct UnitsOptionsCatalogRequestLocale : IStringEnum
{
    public static readonly UnitsOptionsCatalogRequestLocale En = new(Values.En);

    public static readonly UnitsOptionsCatalogRequestLocale Lt = new(Values.Lt);

    public static readonly UnitsOptionsCatalogRequestLocale De = new(Values.De);

    public UnitsOptionsCatalogRequestLocale(string value)
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
    public static UnitsOptionsCatalogRequestLocale FromCustom(string value)
    {
        return new UnitsOptionsCatalogRequestLocale(value);
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

    public static bool operator ==(UnitsOptionsCatalogRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UnitsOptionsCatalogRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UnitsOptionsCatalogRequestLocale value) => value.Value;

    public static explicit operator UnitsOptionsCatalogRequestLocale(string value) => new(value);

    internal class UnitsOptionsCatalogRequestLocaleSerializer
        : JsonConverter<UnitsOptionsCatalogRequestLocale>
    {
        public override UnitsOptionsCatalogRequestLocale Read(
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
            return new UnitsOptionsCatalogRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UnitsOptionsCatalogRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UnitsOptionsCatalogRequestLocale ReadAsPropertyName(
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
            return new UnitsOptionsCatalogRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UnitsOptionsCatalogRequestLocale value,
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
        public const string En = "en";

        public const string Lt = "lt";

        public const string De = "de";
    }
}
