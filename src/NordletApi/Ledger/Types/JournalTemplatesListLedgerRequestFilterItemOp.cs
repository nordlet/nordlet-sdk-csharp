using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(JournalTemplatesListLedgerRequestFilterItemOp.JournalTemplatesListLedgerRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct JournalTemplatesListLedgerRequestFilterItemOp : IStringEnum
{
    public static readonly JournalTemplatesListLedgerRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly JournalTemplatesListLedgerRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly JournalTemplatesListLedgerRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly JournalTemplatesListLedgerRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly JournalTemplatesListLedgerRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly JournalTemplatesListLedgerRequestFilterItemOp In = new(Values.In);

    public JournalTemplatesListLedgerRequestFilterItemOp(string value)
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
    public static JournalTemplatesListLedgerRequestFilterItemOp FromCustom(string value)
    {
        return new JournalTemplatesListLedgerRequestFilterItemOp(value);
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
        JournalTemplatesListLedgerRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        JournalTemplatesListLedgerRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(JournalTemplatesListLedgerRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator JournalTemplatesListLedgerRequestFilterItemOp(string value) =>
        new(value);

    internal class JournalTemplatesListLedgerRequestFilterItemOpSerializer
        : JsonConverter<JournalTemplatesListLedgerRequestFilterItemOp>
    {
        public override JournalTemplatesListLedgerRequestFilterItemOp Read(
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
            return new JournalTemplatesListLedgerRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            JournalTemplatesListLedgerRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override JournalTemplatesListLedgerRequestFilterItemOp ReadAsPropertyName(
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
            return new JournalTemplatesListLedgerRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            JournalTemplatesListLedgerRequestFilterItemOp value,
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
