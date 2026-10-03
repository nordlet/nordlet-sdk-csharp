using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerStatementRowsListResponseRowsItemStatement.PostV1LedgerStatementRowsListResponseRowsItemStatementSerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerStatementRowsListResponseRowsItemStatement : IStringEnum
{
    public static readonly PostV1LedgerStatementRowsListResponseRowsItemStatement BalanceSheet =
        new(Values.BalanceSheet);

    public static readonly PostV1LedgerStatementRowsListResponseRowsItemStatement IncomeStatement =
        new(Values.IncomeStatement);

    public PostV1LedgerStatementRowsListResponseRowsItemStatement(string value)
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
    public static PostV1LedgerStatementRowsListResponseRowsItemStatement FromCustom(string value)
    {
        return new PostV1LedgerStatementRowsListResponseRowsItemStatement(value);
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
        PostV1LedgerStatementRowsListResponseRowsItemStatement value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1LedgerStatementRowsListResponseRowsItemStatement value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1LedgerStatementRowsListResponseRowsItemStatement value
    ) => value.Value;

    public static explicit operator PostV1LedgerStatementRowsListResponseRowsItemStatement(
        string value
    ) => new(value);

    internal class PostV1LedgerStatementRowsListResponseRowsItemStatementSerializer
        : JsonConverter<PostV1LedgerStatementRowsListResponseRowsItemStatement>
    {
        public override PostV1LedgerStatementRowsListResponseRowsItemStatement Read(
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
            return new PostV1LedgerStatementRowsListResponseRowsItemStatement(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerStatementRowsListResponseRowsItemStatement value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerStatementRowsListResponseRowsItemStatement ReadAsPropertyName(
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
            return new PostV1LedgerStatementRowsListResponseRowsItemStatement(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerStatementRowsListResponseRowsItemStatement value,
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
        public const string BalanceSheet = "balance_sheet";

        public const string IncomeStatement = "income_statement";
    }
}
