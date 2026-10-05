using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ActsPdfSalesRequestLocale.ActsPdfSalesRequestLocaleSerializer))]
[Serializable]
public readonly record struct ActsPdfSalesRequestLocale : IStringEnum
{
    public static readonly ActsPdfSalesRequestLocale En = new(Values.En);

    public static readonly ActsPdfSalesRequestLocale Lt = new(Values.Lt);

    public static readonly ActsPdfSalesRequestLocale De = new(Values.De);

    public ActsPdfSalesRequestLocale(string value)
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
    public static ActsPdfSalesRequestLocale FromCustom(string value)
    {
        return new ActsPdfSalesRequestLocale(value);
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

    public static bool operator ==(ActsPdfSalesRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ActsPdfSalesRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ActsPdfSalesRequestLocale value) => value.Value;

    public static explicit operator ActsPdfSalesRequestLocale(string value) => new(value);

    internal class ActsPdfSalesRequestLocaleSerializer : JsonConverter<ActsPdfSalesRequestLocale>
    {
        public override ActsPdfSalesRequestLocale Read(
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
            return new ActsPdfSalesRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ActsPdfSalesRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ActsPdfSalesRequestLocale ReadAsPropertyName(
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
            return new ActsPdfSalesRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ActsPdfSalesRequestLocale value,
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
