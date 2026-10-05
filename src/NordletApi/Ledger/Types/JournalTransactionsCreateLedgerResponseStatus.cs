using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(JournalTransactionsCreateLedgerResponseStatus.JournalTransactionsCreateLedgerResponseStatusSerializer)
)]
[Serializable]
public readonly record struct JournalTransactionsCreateLedgerResponseStatus : IStringEnum
{
    public static readonly JournalTransactionsCreateLedgerResponseStatus Draft = new(Values.Draft);

    public static readonly JournalTransactionsCreateLedgerResponseStatus Posted = new(
        Values.Posted
    );

    public JournalTransactionsCreateLedgerResponseStatus(string value)
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
    public static JournalTransactionsCreateLedgerResponseStatus FromCustom(string value)
    {
        return new JournalTransactionsCreateLedgerResponseStatus(value);
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
        JournalTransactionsCreateLedgerResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        JournalTransactionsCreateLedgerResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(JournalTransactionsCreateLedgerResponseStatus value) =>
        value.Value;

    public static explicit operator JournalTransactionsCreateLedgerResponseStatus(string value) =>
        new(value);

    internal class JournalTransactionsCreateLedgerResponseStatusSerializer
        : JsonConverter<JournalTransactionsCreateLedgerResponseStatus>
    {
        public override JournalTransactionsCreateLedgerResponseStatus Read(
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
            return new JournalTransactionsCreateLedgerResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            JournalTransactionsCreateLedgerResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override JournalTransactionsCreateLedgerResponseStatus ReadAsPropertyName(
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
            return new JournalTransactionsCreateLedgerResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            JournalTransactionsCreateLedgerResponseStatus value,
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
        public const string Draft = "draft";

        public const string Posted = "posted";
    }
}
