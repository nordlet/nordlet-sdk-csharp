using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(JournalTemplatesListLedgerResponseRowsItemLinesItemSide.JournalTemplatesListLedgerResponseRowsItemLinesItemSideSerializer)
)]
[Serializable]
public readonly record struct JournalTemplatesListLedgerResponseRowsItemLinesItemSide : IStringEnum
{
    public static readonly JournalTemplatesListLedgerResponseRowsItemLinesItemSide Debit = new(
        Values.Debit
    );

    public static readonly JournalTemplatesListLedgerResponseRowsItemLinesItemSide Credit = new(
        Values.Credit
    );

    public JournalTemplatesListLedgerResponseRowsItemLinesItemSide(string value)
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
    public static JournalTemplatesListLedgerResponseRowsItemLinesItemSide FromCustom(string value)
    {
        return new JournalTemplatesListLedgerResponseRowsItemLinesItemSide(value);
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
        JournalTemplatesListLedgerResponseRowsItemLinesItemSide value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        JournalTemplatesListLedgerResponseRowsItemLinesItemSide value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        JournalTemplatesListLedgerResponseRowsItemLinesItemSide value
    ) => value.Value;

    public static explicit operator JournalTemplatesListLedgerResponseRowsItemLinesItemSide(
        string value
    ) => new(value);

    internal class JournalTemplatesListLedgerResponseRowsItemLinesItemSideSerializer
        : JsonConverter<JournalTemplatesListLedgerResponseRowsItemLinesItemSide>
    {
        public override JournalTemplatesListLedgerResponseRowsItemLinesItemSide Read(
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
            return new JournalTemplatesListLedgerResponseRowsItemLinesItemSide(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            JournalTemplatesListLedgerResponseRowsItemLinesItemSide value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override JournalTemplatesListLedgerResponseRowsItemLinesItemSide ReadAsPropertyName(
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
            return new JournalTemplatesListLedgerResponseRowsItemLinesItemSide(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            JournalTemplatesListLedgerResponseRowsItemLinesItemSide value,
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
        public const string Debit = "debit";

        public const string Credit = "credit";
    }
}
