using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ExportsMonthSalesRequestFormat.ExportsMonthSalesRequestFormatSerializer))]
[Serializable]
public readonly record struct ExportsMonthSalesRequestFormat : IStringEnum
{
    public static readonly ExportsMonthSalesRequestFormat Csv = new(Values.Csv);

    public static readonly ExportsMonthSalesRequestFormat Pdf = new(Values.Pdf);

    public static readonly ExportsMonthSalesRequestFormat Nordlet = new(Values.Nordlet);

    public ExportsMonthSalesRequestFormat(string value)
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
    public static ExportsMonthSalesRequestFormat FromCustom(string value)
    {
        return new ExportsMonthSalesRequestFormat(value);
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

    public static bool operator ==(ExportsMonthSalesRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ExportsMonthSalesRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ExportsMonthSalesRequestFormat value) => value.Value;

    public static explicit operator ExportsMonthSalesRequestFormat(string value) => new(value);

    internal class ExportsMonthSalesRequestFormatSerializer
        : JsonConverter<ExportsMonthSalesRequestFormat>
    {
        public override ExportsMonthSalesRequestFormat Read(
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
            return new ExportsMonthSalesRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ExportsMonthSalesRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ExportsMonthSalesRequestFormat ReadAsPropertyName(
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
            return new ExportsMonthSalesRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ExportsMonthSalesRequestFormat value,
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
        public const string Csv = "csv";

        public const string Pdf = "pdf";

        public const string Nordlet = "nordlet";
    }
}
