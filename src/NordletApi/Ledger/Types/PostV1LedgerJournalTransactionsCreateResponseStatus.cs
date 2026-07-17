using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerJournalTransactionsCreateResponseStatus.PostV1LedgerJournalTransactionsCreateResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerJournalTransactionsCreateResponseStatus : IStringEnum
{
    public static readonly PostV1LedgerJournalTransactionsCreateResponseStatus Draft = new(
        Values.Draft
    );

    public static readonly PostV1LedgerJournalTransactionsCreateResponseStatus Posted = new(
        Values.Posted
    );

    public PostV1LedgerJournalTransactionsCreateResponseStatus(string value)
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
    public static PostV1LedgerJournalTransactionsCreateResponseStatus FromCustom(string value)
    {
        return new PostV1LedgerJournalTransactionsCreateResponseStatus(value);
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
        PostV1LedgerJournalTransactionsCreateResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1LedgerJournalTransactionsCreateResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1LedgerJournalTransactionsCreateResponseStatus value
    ) => value.Value;

    public static explicit operator PostV1LedgerJournalTransactionsCreateResponseStatus(
        string value
    ) => new(value);

    internal class PostV1LedgerJournalTransactionsCreateResponseStatusSerializer
        : JsonConverter<PostV1LedgerJournalTransactionsCreateResponseStatus>
    {
        public override PostV1LedgerJournalTransactionsCreateResponseStatus Read(
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
            return new PostV1LedgerJournalTransactionsCreateResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerJournalTransactionsCreateResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerJournalTransactionsCreateResponseStatus ReadAsPropertyName(
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
            return new PostV1LedgerJournalTransactionsCreateResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerJournalTransactionsCreateResponseStatus value,
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
