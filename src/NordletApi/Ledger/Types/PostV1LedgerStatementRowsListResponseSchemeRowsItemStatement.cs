using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement.PostV1LedgerStatementRowsListResponseSchemeRowsItemStatementSerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement
    : IStringEnum
{
    public static readonly PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement BalanceSheet =
        new(Values.BalanceSheet);

    public static readonly PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement IncomeStatement =
        new(Values.IncomeStatement);

    public PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement(string value)
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
    public static PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement FromCustom(
        string value
    )
    {
        return new PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement(value);
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
        PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement value
    ) => value.Value;

    public static explicit operator PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement(
        string value
    ) => new(value);

    internal class PostV1LedgerStatementRowsListResponseSchemeRowsItemStatementSerializer
        : JsonConverter<PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement>
    {
        public override PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement Read(
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
            return new PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement ReadAsPropertyName(
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
            return new PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerStatementRowsListResponseSchemeRowsItemStatement value,
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
