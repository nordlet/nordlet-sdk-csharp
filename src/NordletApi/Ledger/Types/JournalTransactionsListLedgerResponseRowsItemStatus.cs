using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(JournalTransactionsListLedgerResponseRowsItemStatus.JournalTransactionsListLedgerResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct JournalTransactionsListLedgerResponseRowsItemStatus : IStringEnum
{
    public static readonly JournalTransactionsListLedgerResponseRowsItemStatus Draft = new(
        Values.Draft
    );

    public static readonly JournalTransactionsListLedgerResponseRowsItemStatus Posted = new(
        Values.Posted
    );

    public JournalTransactionsListLedgerResponseRowsItemStatus(string value)
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
    public static JournalTransactionsListLedgerResponseRowsItemStatus FromCustom(string value)
    {
        return new JournalTransactionsListLedgerResponseRowsItemStatus(value);
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
        JournalTransactionsListLedgerResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        JournalTransactionsListLedgerResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        JournalTransactionsListLedgerResponseRowsItemStatus value
    ) => value.Value;

    public static explicit operator JournalTransactionsListLedgerResponseRowsItemStatus(
        string value
    ) => new(value);

    internal class JournalTransactionsListLedgerResponseRowsItemStatusSerializer
        : JsonConverter<JournalTransactionsListLedgerResponseRowsItemStatus>
    {
        public override JournalTransactionsListLedgerResponseRowsItemStatus Read(
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
            return new JournalTransactionsListLedgerResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            JournalTransactionsListLedgerResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override JournalTransactionsListLedgerResponseRowsItemStatus ReadAsPropertyName(
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
            return new JournalTransactionsListLedgerResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            JournalTransactionsListLedgerResponseRowsItemStatus value,
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
