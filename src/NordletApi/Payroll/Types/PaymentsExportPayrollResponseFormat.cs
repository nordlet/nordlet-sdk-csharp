using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PaymentsExportPayrollResponseFormat.PaymentsExportPayrollResponseFormatSerializer)
)]
[Serializable]
public readonly record struct PaymentsExportPayrollResponseFormat : IStringEnum
{
    public static readonly PaymentsExportPayrollResponseFormat Pain00100103 = new(
        Values.Pain00100103
    );

    public static readonly PaymentsExportPayrollResponseFormat Pain00800102 = new(
        Values.Pain00800102
    );

    public static readonly PaymentsExportPayrollResponseFormat BacsStandard18 = new(
        Values.BacsStandard18
    );

    public static readonly PaymentsExportPayrollResponseFormat Nacha = new(Values.Nacha);

    public PaymentsExportPayrollResponseFormat(string value)
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
    public static PaymentsExportPayrollResponseFormat FromCustom(string value)
    {
        return new PaymentsExportPayrollResponseFormat(value);
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

    public static bool operator ==(PaymentsExportPayrollResponseFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PaymentsExportPayrollResponseFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PaymentsExportPayrollResponseFormat value) =>
        value.Value;

    public static explicit operator PaymentsExportPayrollResponseFormat(string value) => new(value);

    internal class PaymentsExportPayrollResponseFormatSerializer
        : JsonConverter<PaymentsExportPayrollResponseFormat>
    {
        public override PaymentsExportPayrollResponseFormat Read(
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
            return new PaymentsExportPayrollResponseFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PaymentsExportPayrollResponseFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PaymentsExportPayrollResponseFormat ReadAsPropertyName(
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
            return new PaymentsExportPayrollResponseFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PaymentsExportPayrollResponseFormat value,
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
