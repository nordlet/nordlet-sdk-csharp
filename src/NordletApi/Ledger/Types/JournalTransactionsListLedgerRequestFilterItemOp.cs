using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(JournalTransactionsListLedgerRequestFilterItemOp.JournalTransactionsListLedgerRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct JournalTransactionsListLedgerRequestFilterItemOp : IStringEnum
{
    public static readonly JournalTransactionsListLedgerRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly JournalTransactionsListLedgerRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly JournalTransactionsListLedgerRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly JournalTransactionsListLedgerRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly JournalTransactionsListLedgerRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly JournalTransactionsListLedgerRequestFilterItemOp In = new(Values.In);

    public JournalTransactionsListLedgerRequestFilterItemOp(string value)
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
    public static JournalTransactionsListLedgerRequestFilterItemOp FromCustom(string value)
    {
        return new JournalTransactionsListLedgerRequestFilterItemOp(value);
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
        JournalTransactionsListLedgerRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        JournalTransactionsListLedgerRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        JournalTransactionsListLedgerRequestFilterItemOp value
    ) => value.Value;

    public static explicit operator JournalTransactionsListLedgerRequestFilterItemOp(
        string value
    ) => new(value);

    internal class JournalTransactionsListLedgerRequestFilterItemOpSerializer
        : JsonConverter<JournalTransactionsListLedgerRequestFilterItemOp>
    {
        public override JournalTransactionsListLedgerRequestFilterItemOp Read(
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
            return new JournalTransactionsListLedgerRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            JournalTransactionsListLedgerRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override JournalTransactionsListLedgerRequestFilterItemOp ReadAsPropertyName(
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
            return new JournalTransactionsListLedgerRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            JournalTransactionsListLedgerRequestFilterItemOp value,
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
        public const string Eq = "eq";

        public const string Ne = "ne";

        public const string Contains = "contains";

        public const string Gte = "gte";

        public const string Lte = "lte";

        public const string In = "in";
    }
}
