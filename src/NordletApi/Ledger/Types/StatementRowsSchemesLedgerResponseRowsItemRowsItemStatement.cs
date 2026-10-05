using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement.StatementRowsSchemesLedgerResponseRowsItemRowsItemStatementSerializer)
)]
[Serializable]
public readonly record struct StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement
    : IStringEnum
{
    public static readonly StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement BalanceSheet =
        new(Values.BalanceSheet);

    public static readonly StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement IncomeStatement =
        new(Values.IncomeStatement);

    public StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement(string value)
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
    public static StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement FromCustom(
        string value
    )
    {
        return new StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement(value);
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
        StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement value
    ) => value.Value;

    public static explicit operator StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement(
        string value
    ) => new(value);

    internal class StatementRowsSchemesLedgerResponseRowsItemRowsItemStatementSerializer
        : JsonConverter<StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement>
    {
        public override StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement Read(
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
            return new StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement ReadAsPropertyName(
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
            return new StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            StatementRowsSchemesLedgerResponseRowsItemRowsItemStatement value,
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
