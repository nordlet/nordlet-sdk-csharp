using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SettlementsImportBankResponseFormat.SettlementsImportBankResponseFormatSerializer)
)]
[Serializable]
public readonly record struct SettlementsImportBankResponseFormat : IStringEnum
{
    public static readonly SettlementsImportBankResponseFormat PayoutReconciliation = new(
        Values.PayoutReconciliation
    );

    public static readonly SettlementsImportBankResponseFormat UnifiedPayments = new(
        Values.UnifiedPayments
    );

    public SettlementsImportBankResponseFormat(string value)
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
    public static SettlementsImportBankResponseFormat FromCustom(string value)
    {
        return new SettlementsImportBankResponseFormat(value);
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

    public static bool operator ==(SettlementsImportBankResponseFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SettlementsImportBankResponseFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SettlementsImportBankResponseFormat value) =>
        value.Value;

    public static explicit operator SettlementsImportBankResponseFormat(string value) => new(value);

    internal class SettlementsImportBankResponseFormatSerializer
        : JsonConverter<SettlementsImportBankResponseFormat>
    {
        public override SettlementsImportBankResponseFormat Read(
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
            return new SettlementsImportBankResponseFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SettlementsImportBankResponseFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SettlementsImportBankResponseFormat ReadAsPropertyName(
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
            return new SettlementsImportBankResponseFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SettlementsImportBankResponseFormat value,
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
        public const string PayoutReconciliation = "payout_reconciliation";

        public const string UnifiedPayments = "unified_payments";
    }
}
