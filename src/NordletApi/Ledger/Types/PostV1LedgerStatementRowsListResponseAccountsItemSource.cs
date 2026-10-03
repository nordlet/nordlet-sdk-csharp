using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerStatementRowsListResponseAccountsItemSource.PostV1LedgerStatementRowsListResponseAccountsItemSourceSerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerStatementRowsListResponseAccountsItemSource : IStringEnum
{
    public static readonly PostV1LedgerStatementRowsListResponseAccountsItemSource Mapping = new(
        Values.Mapping
    );

    public static readonly PostV1LedgerStatementRowsListResponseAccountsItemSource Default = new(
        Values.Default
    );

    public PostV1LedgerStatementRowsListResponseAccountsItemSource(string value)
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
    public static PostV1LedgerStatementRowsListResponseAccountsItemSource FromCustom(string value)
    {
        return new PostV1LedgerStatementRowsListResponseAccountsItemSource(value);
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
        PostV1LedgerStatementRowsListResponseAccountsItemSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1LedgerStatementRowsListResponseAccountsItemSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1LedgerStatementRowsListResponseAccountsItemSource value
    ) => value.Value;

    public static explicit operator PostV1LedgerStatementRowsListResponseAccountsItemSource(
        string value
    ) => new(value);

    internal class PostV1LedgerStatementRowsListResponseAccountsItemSourceSerializer
        : JsonConverter<PostV1LedgerStatementRowsListResponseAccountsItemSource>
    {
        public override PostV1LedgerStatementRowsListResponseAccountsItemSource Read(
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
            return new PostV1LedgerStatementRowsListResponseAccountsItemSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerStatementRowsListResponseAccountsItemSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerStatementRowsListResponseAccountsItemSource ReadAsPropertyName(
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
            return new PostV1LedgerStatementRowsListResponseAccountsItemSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerStatementRowsListResponseAccountsItemSource value,
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
        public const string Mapping = "mapping";

        public const string Default = "default";
    }
}
