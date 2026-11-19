using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PaymentsExportBankResponseFormat.PaymentsExportBankResponseFormatSerializer))]
[Serializable]
public readonly record struct PaymentsExportBankResponseFormat : IStringEnum
{
    public static readonly PaymentsExportBankResponseFormat Pain00100103 = new(Values.Pain00100103);

    public static readonly PaymentsExportBankResponseFormat Pain00800102 = new(Values.Pain00800102);

    public static readonly PaymentsExportBankResponseFormat BacsStandard18 = new(
        Values.BacsStandard18
    );

    public static readonly PaymentsExportBankResponseFormat Nacha = new(Values.Nacha);

    public PaymentsExportBankResponseFormat(string value)
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
    public static PaymentsExportBankResponseFormat FromCustom(string value)
    {
        return new PaymentsExportBankResponseFormat(value);
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

    public static bool operator ==(PaymentsExportBankResponseFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PaymentsExportBankResponseFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PaymentsExportBankResponseFormat value) => value.Value;

    public static explicit operator PaymentsExportBankResponseFormat(string value) => new(value);

    internal class PaymentsExportBankResponseFormatSerializer
        : JsonConverter<PaymentsExportBankResponseFormat>
    {
        public override PaymentsExportBankResponseFormat Read(
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
            return new PaymentsExportBankResponseFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PaymentsExportBankResponseFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PaymentsExportBankResponseFormat ReadAsPropertyName(
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
            return new PaymentsExportBankResponseFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PaymentsExportBankResponseFormat value,
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
        public const string Pain00100103 = "pain.001.001.03";

        public const string Pain00800102 = "pain.008.001.02";

        public const string BacsStandard18 = "bacs-standard-18";

        public const string Nacha = "nacha";
    }
}
