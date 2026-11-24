using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(JournalTemplatesPostLedgerResponseStatus.JournalTemplatesPostLedgerResponseStatusSerializer)
)]
[Serializable]
public readonly record struct JournalTemplatesPostLedgerResponseStatus : IStringEnum
{
    public static readonly JournalTemplatesPostLedgerResponseStatus Draft = new(Values.Draft);

    public static readonly JournalTemplatesPostLedgerResponseStatus Posted = new(Values.Posted);

    public JournalTemplatesPostLedgerResponseStatus(string value)
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
    public static JournalTemplatesPostLedgerResponseStatus FromCustom(string value)
    {
        return new JournalTemplatesPostLedgerResponseStatus(value);
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
        JournalTemplatesPostLedgerResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        JournalTemplatesPostLedgerResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(JournalTemplatesPostLedgerResponseStatus value) =>
        value.Value;

    public static explicit operator JournalTemplatesPostLedgerResponseStatus(string value) =>
        new(value);

    internal class JournalTemplatesPostLedgerResponseStatusSerializer
        : JsonConverter<JournalTemplatesPostLedgerResponseStatus>
    {
        public override JournalTemplatesPostLedgerResponseStatus Read(
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
            return new JournalTemplatesPostLedgerResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            JournalTemplatesPostLedgerResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override JournalTemplatesPostLedgerResponseStatus ReadAsPropertyName(
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
            return new JournalTemplatesPostLedgerResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            JournalTemplatesPostLedgerResponseStatus value,
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
