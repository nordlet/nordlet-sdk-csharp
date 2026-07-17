using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerJournalTransactionsListRequestSortItemDir.PostV1LedgerJournalTransactionsListRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerJournalTransactionsListRequestSortItemDir : IStringEnum
{
    public static readonly PostV1LedgerJournalTransactionsListRequestSortItemDir Asc = new(
        Values.Asc
    );

    public static readonly PostV1LedgerJournalTransactionsListRequestSortItemDir Desc = new(
        Values.Desc
    );

    public PostV1LedgerJournalTransactionsListRequestSortItemDir(string value)
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
    public static PostV1LedgerJournalTransactionsListRequestSortItemDir FromCustom(string value)
    {
        return new PostV1LedgerJournalTransactionsListRequestSortItemDir(value);
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
        PostV1LedgerJournalTransactionsListRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1LedgerJournalTransactionsListRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1LedgerJournalTransactionsListRequestSortItemDir value
    ) => value.Value;

    public static explicit operator PostV1LedgerJournalTransactionsListRequestSortItemDir(
        string value
    ) => new(value);

    internal class PostV1LedgerJournalTransactionsListRequestSortItemDirSerializer
        : JsonConverter<PostV1LedgerJournalTransactionsListRequestSortItemDir>
    {
        public override PostV1LedgerJournalTransactionsListRequestSortItemDir Read(
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
            return new PostV1LedgerJournalTransactionsListRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerJournalTransactionsListRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerJournalTransactionsListRequestSortItemDir ReadAsPropertyName(
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
            return new PostV1LedgerJournalTransactionsListRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerJournalTransactionsListRequestSortItemDir value,
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
        public const string Asc = "asc";

        public const string Desc = "desc";
    }
}
