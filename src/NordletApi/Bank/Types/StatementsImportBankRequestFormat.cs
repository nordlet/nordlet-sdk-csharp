using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(StatementsImportBankRequestFormat.StatementsImportBankRequestFormatSerializer)
)]
[Serializable]
public readonly record struct StatementsImportBankRequestFormat : IStringEnum
{
    public static readonly StatementsImportBankRequestFormat Camt053 = new(Values.Camt053);

    public static readonly StatementsImportBankRequestFormat Mt940 = new(Values.Mt940);

    public static readonly StatementsImportBankRequestFormat StripeCsv = new(Values.StripeCsv);

    public StatementsImportBankRequestFormat(string value)
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
    public static StatementsImportBankRequestFormat FromCustom(string value)
    {
        return new StatementsImportBankRequestFormat(value);
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

    public static bool operator ==(StatementsImportBankRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(StatementsImportBankRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(StatementsImportBankRequestFormat value) => value.Value;

    public static explicit operator StatementsImportBankRequestFormat(string value) => new(value);

    internal class StatementsImportBankRequestFormatSerializer
        : JsonConverter<StatementsImportBankRequestFormat>
    {
        public override StatementsImportBankRequestFormat Read(
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
            return new StatementsImportBankRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            StatementsImportBankRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override StatementsImportBankRequestFormat ReadAsPropertyName(
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
            return new StatementsImportBankRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            StatementsImportBankRequestFormat value,
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
        public const string Camt053 = "camt053";

        public const string Mt940 = "mt940";

        public const string StripeCsv = "stripe-csv";
    }
}
