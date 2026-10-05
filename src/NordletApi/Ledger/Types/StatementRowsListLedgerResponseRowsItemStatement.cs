using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(StatementRowsListLedgerResponseRowsItemStatement.StatementRowsListLedgerResponseRowsItemStatementSerializer)
)]
[Serializable]
public readonly record struct StatementRowsListLedgerResponseRowsItemStatement : IStringEnum
{
    public static readonly StatementRowsListLedgerResponseRowsItemStatement BalanceSheet = new(
        Values.BalanceSheet
    );

    public static readonly StatementRowsListLedgerResponseRowsItemStatement IncomeStatement = new(
        Values.IncomeStatement
    );

    public StatementRowsListLedgerResponseRowsItemStatement(string value)
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
    public static StatementRowsListLedgerResponseRowsItemStatement FromCustom(string value)
    {
        return new StatementRowsListLedgerResponseRowsItemStatement(value);
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
        StatementRowsListLedgerResponseRowsItemStatement value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        StatementRowsListLedgerResponseRowsItemStatement value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        StatementRowsListLedgerResponseRowsItemStatement value
    ) => value.Value;

    public static explicit operator StatementRowsListLedgerResponseRowsItemStatement(
        string value
    ) => new(value);

    internal class StatementRowsListLedgerResponseRowsItemStatementSerializer
        : JsonConverter<StatementRowsListLedgerResponseRowsItemStatement>
    {
        public override StatementRowsListLedgerResponseRowsItemStatement Read(
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
            return new StatementRowsListLedgerResponseRowsItemStatement(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            StatementRowsListLedgerResponseRowsItemStatement value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override StatementRowsListLedgerResponseRowsItemStatement ReadAsPropertyName(
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
            return new StatementRowsListLedgerResponseRowsItemStatement(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            StatementRowsListLedgerResponseRowsItemStatement value,
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
