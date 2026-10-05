using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(StatementRowsListLedgerResponseSchemeRowsItemStatement.StatementRowsListLedgerResponseSchemeRowsItemStatementSerializer)
)]
[Serializable]
public readonly record struct StatementRowsListLedgerResponseSchemeRowsItemStatement : IStringEnum
{
    public static readonly StatementRowsListLedgerResponseSchemeRowsItemStatement BalanceSheet =
        new(Values.BalanceSheet);

    public static readonly StatementRowsListLedgerResponseSchemeRowsItemStatement IncomeStatement =
        new(Values.IncomeStatement);

    public StatementRowsListLedgerResponseSchemeRowsItemStatement(string value)
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
    public static StatementRowsListLedgerResponseSchemeRowsItemStatement FromCustom(string value)
    {
        return new StatementRowsListLedgerResponseSchemeRowsItemStatement(value);
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
        StatementRowsListLedgerResponseSchemeRowsItemStatement value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        StatementRowsListLedgerResponseSchemeRowsItemStatement value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        StatementRowsListLedgerResponseSchemeRowsItemStatement value
    ) => value.Value;

    public static explicit operator StatementRowsListLedgerResponseSchemeRowsItemStatement(
        string value
    ) => new(value);

    internal class StatementRowsListLedgerResponseSchemeRowsItemStatementSerializer
        : JsonConverter<StatementRowsListLedgerResponseSchemeRowsItemStatement>
    {
        public override StatementRowsListLedgerResponseSchemeRowsItemStatement Read(
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
            return new StatementRowsListLedgerResponseSchemeRowsItemStatement(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            StatementRowsListLedgerResponseSchemeRowsItemStatement value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override StatementRowsListLedgerResponseSchemeRowsItemStatement ReadAsPropertyName(
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
            return new StatementRowsListLedgerResponseSchemeRowsItemStatement(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            StatementRowsListLedgerResponseSchemeRowsItemStatement value,
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
