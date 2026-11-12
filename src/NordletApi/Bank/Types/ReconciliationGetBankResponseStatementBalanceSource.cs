using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ReconciliationGetBankResponseStatementBalanceSource.ReconciliationGetBankResponseStatementBalanceSourceSerializer)
)]
[Serializable]
public readonly record struct ReconciliationGetBankResponseStatementBalanceSource : IStringEnum
{
    public static readonly ReconciliationGetBankResponseStatementBalanceSource Request = new(
        Values.Request
    );

    public static readonly ReconciliationGetBankResponseStatementBalanceSource Statement = new(
        Values.Statement
    );

    public ReconciliationGetBankResponseStatementBalanceSource(string value)
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
    public static ReconciliationGetBankResponseStatementBalanceSource FromCustom(string value)
    {
        return new ReconciliationGetBankResponseStatementBalanceSource(value);
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

    public static bool operator ==(
        ReconciliationGetBankResponseStatementBalanceSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ReconciliationGetBankResponseStatementBalanceSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ReconciliationGetBankResponseStatementBalanceSource value
    ) => value.Value;

    public static explicit operator ReconciliationGetBankResponseStatementBalanceSource(
        string value
    ) => new(value);

    internal class ReconciliationGetBankResponseStatementBalanceSourceSerializer
        : JsonConverter<ReconciliationGetBankResponseStatementBalanceSource>
    {
        public override ReconciliationGetBankResponseStatementBalanceSource Read(
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
            return new ReconciliationGetBankResponseStatementBalanceSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReconciliationGetBankResponseStatementBalanceSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReconciliationGetBankResponseStatementBalanceSource ReadAsPropertyName(
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
            return new ReconciliationGetBankResponseStatementBalanceSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReconciliationGetBankResponseStatementBalanceSource value,
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
        public const string Request = "request";

        public const string Statement = "statement";
    }
}
