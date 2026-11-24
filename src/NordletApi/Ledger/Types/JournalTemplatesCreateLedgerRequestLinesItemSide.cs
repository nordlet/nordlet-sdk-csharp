using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(JournalTemplatesCreateLedgerRequestLinesItemSide.JournalTemplatesCreateLedgerRequestLinesItemSideSerializer)
)]
[Serializable]
public readonly record struct JournalTemplatesCreateLedgerRequestLinesItemSide : IStringEnum
{
    public static readonly JournalTemplatesCreateLedgerRequestLinesItemSide Debit = new(
        Values.Debit
    );

    public static readonly JournalTemplatesCreateLedgerRequestLinesItemSide Credit = new(
        Values.Credit
    );

    public JournalTemplatesCreateLedgerRequestLinesItemSide(string value)
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
    public static JournalTemplatesCreateLedgerRequestLinesItemSide FromCustom(string value)
    {
        return new JournalTemplatesCreateLedgerRequestLinesItemSide(value);
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
        JournalTemplatesCreateLedgerRequestLinesItemSide value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        JournalTemplatesCreateLedgerRequestLinesItemSide value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        JournalTemplatesCreateLedgerRequestLinesItemSide value
    ) => value.Value;

    public static explicit operator JournalTemplatesCreateLedgerRequestLinesItemSide(
        string value
    ) => new(value);

    internal class JournalTemplatesCreateLedgerRequestLinesItemSideSerializer
        : JsonConverter<JournalTemplatesCreateLedgerRequestLinesItemSide>
    {
        public override JournalTemplatesCreateLedgerRequestLinesItemSide Read(
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
            return new JournalTemplatesCreateLedgerRequestLinesItemSide(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            JournalTemplatesCreateLedgerRequestLinesItemSide value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override JournalTemplatesCreateLedgerRequestLinesItemSide ReadAsPropertyName(
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
            return new JournalTemplatesCreateLedgerRequestLinesItemSide(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            JournalTemplatesCreateLedgerRequestLinesItemSide value,
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
