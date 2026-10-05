using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(StatementRowsListLedgerResponseAccountsItemSource.StatementRowsListLedgerResponseAccountsItemSourceSerializer)
)]
[Serializable]
public readonly record struct StatementRowsListLedgerResponseAccountsItemSource : IStringEnum
{
    public static readonly StatementRowsListLedgerResponseAccountsItemSource Mapping = new(
        Values.Mapping
    );

    public static readonly StatementRowsListLedgerResponseAccountsItemSource Default = new(
        Values.Default
    );

    public StatementRowsListLedgerResponseAccountsItemSource(string value)
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
    public static StatementRowsListLedgerResponseAccountsItemSource FromCustom(string value)
    {
        return new StatementRowsListLedgerResponseAccountsItemSource(value);
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
        StatementRowsListLedgerResponseAccountsItemSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        StatementRowsListLedgerResponseAccountsItemSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        StatementRowsListLedgerResponseAccountsItemSource value
    ) => value.Value;

    public static explicit operator StatementRowsListLedgerResponseAccountsItemSource(
        string value
    ) => new(value);

    internal class StatementRowsListLedgerResponseAccountsItemSourceSerializer
        : JsonConverter<StatementRowsListLedgerResponseAccountsItemSource>
    {
        public override StatementRowsListLedgerResponseAccountsItemSource Read(
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
            return new StatementRowsListLedgerResponseAccountsItemSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            StatementRowsListLedgerResponseAccountsItemSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override StatementRowsListLedgerResponseAccountsItemSource ReadAsPropertyName(
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
            return new StatementRowsListLedgerResponseAccountsItemSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            StatementRowsListLedgerResponseAccountsItemSource value,
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
