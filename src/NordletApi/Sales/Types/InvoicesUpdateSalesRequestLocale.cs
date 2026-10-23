using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(InvoicesUpdateSalesRequestLocale.InvoicesUpdateSalesRequestLocaleSerializer))]
[Serializable]
public readonly record struct InvoicesUpdateSalesRequestLocale : IStringEnum
{
    public static readonly InvoicesUpdateSalesRequestLocale En = new(Values.En);

    public static readonly InvoicesUpdateSalesRequestLocale Lt = new(Values.Lt);

    public static readonly InvoicesUpdateSalesRequestLocale De = new(Values.De);

    public InvoicesUpdateSalesRequestLocale(string value)
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
    public static InvoicesUpdateSalesRequestLocale FromCustom(string value)
    {
        return new InvoicesUpdateSalesRequestLocale(value);
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

    public static bool operator ==(InvoicesUpdateSalesRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesUpdateSalesRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesUpdateSalesRequestLocale value) => value.Value;

    public static explicit operator InvoicesUpdateSalesRequestLocale(string value) => new(value);

    internal class InvoicesUpdateSalesRequestLocaleSerializer
        : JsonConverter<InvoicesUpdateSalesRequestLocale>
    {
        public override InvoicesUpdateSalesRequestLocale Read(
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
            return new InvoicesUpdateSalesRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesUpdateSalesRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesUpdateSalesRequestLocale ReadAsPropertyName(
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
            return new InvoicesUpdateSalesRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesUpdateSalesRequestLocale value,
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
