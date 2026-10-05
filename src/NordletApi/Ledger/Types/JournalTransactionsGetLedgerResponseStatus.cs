using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(JournalTransactionsGetLedgerResponseStatus.JournalTransactionsGetLedgerResponseStatusSerializer)
)]
[Serializable]
public readonly record struct JournalTransactionsGetLedgerResponseStatus : IStringEnum
{
    public static readonly JournalTransactionsGetLedgerResponseStatus Draft = new(Values.Draft);

    public static readonly JournalTransactionsGetLedgerResponseStatus Posted = new(Values.Posted);

    public JournalTransactionsGetLedgerResponseStatus(string value)
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
    public static JournalTransactionsGetLedgerResponseStatus FromCustom(string value)
    {
        return new JournalTransactionsGetLedgerResponseStatus(value);
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
        JournalTransactionsGetLedgerResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        JournalTransactionsGetLedgerResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(JournalTransactionsGetLedgerResponseStatus value) =>
        value.Value;

    public static explicit operator JournalTransactionsGetLedgerResponseStatus(string value) =>
        new(value);

    internal class JournalTransactionsGetLedgerResponseStatusSerializer
        : JsonConverter<JournalTransactionsGetLedgerResponseStatus>
    {
        public override JournalTransactionsGetLedgerResponseStatus Read(
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
            return new JournalTransactionsGetLedgerResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            JournalTransactionsGetLedgerResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override JournalTransactionsGetLedgerResponseStatus ReadAsPropertyName(
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
            return new JournalTransactionsGetLedgerResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            JournalTransactionsGetLedgerResponseStatus value,
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
