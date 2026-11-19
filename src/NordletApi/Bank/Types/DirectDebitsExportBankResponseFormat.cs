using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DirectDebitsExportBankResponseFormat.DirectDebitsExportBankResponseFormatSerializer)
)]
[Serializable]
public readonly record struct DirectDebitsExportBankResponseFormat : IStringEnum
{
    public static readonly DirectDebitsExportBankResponseFormat Pain00100103 = new(
        Values.Pain00100103
    );

    public static readonly DirectDebitsExportBankResponseFormat Pain00800102 = new(
        Values.Pain00800102
    );

    public static readonly DirectDebitsExportBankResponseFormat BacsStandard18 = new(
        Values.BacsStandard18
    );

    public static readonly DirectDebitsExportBankResponseFormat Nacha = new(Values.Nacha);

    public DirectDebitsExportBankResponseFormat(string value)
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
    public static DirectDebitsExportBankResponseFormat FromCustom(string value)
    {
        return new DirectDebitsExportBankResponseFormat(value);
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

    public static bool operator ==(DirectDebitsExportBankResponseFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DirectDebitsExportBankResponseFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DirectDebitsExportBankResponseFormat value) =>
        value.Value;

    public static explicit operator DirectDebitsExportBankResponseFormat(string value) =>
        new(value);

    internal class DirectDebitsExportBankResponseFormatSerializer
        : JsonConverter<DirectDebitsExportBankResponseFormat>
    {
        public override DirectDebitsExportBankResponseFormat Read(
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
            return new DirectDebitsExportBankResponseFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DirectDebitsExportBankResponseFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DirectDebitsExportBankResponseFormat ReadAsPropertyName(
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
            return new DirectDebitsExportBankResponseFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DirectDebitsExportBankResponseFormat value,
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
