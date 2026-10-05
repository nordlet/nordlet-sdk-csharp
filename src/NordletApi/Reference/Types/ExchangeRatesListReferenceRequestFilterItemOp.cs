using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ExchangeRatesListReferenceRequestFilterItemOp.ExchangeRatesListReferenceRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct ExchangeRatesListReferenceRequestFilterItemOp : IStringEnum
{
    public static readonly ExchangeRatesListReferenceRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly ExchangeRatesListReferenceRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly ExchangeRatesListReferenceRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly ExchangeRatesListReferenceRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly ExchangeRatesListReferenceRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly ExchangeRatesListReferenceRequestFilterItemOp In = new(Values.In);

    public ExchangeRatesListReferenceRequestFilterItemOp(string value)
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
    public static ExchangeRatesListReferenceRequestFilterItemOp FromCustom(string value)
    {
        return new ExchangeRatesListReferenceRequestFilterItemOp(value);
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
        ExchangeRatesListReferenceRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ExchangeRatesListReferenceRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ExchangeRatesListReferenceRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator ExchangeRatesListReferenceRequestFilterItemOp(string value) =>
        new(value);

    internal class ExchangeRatesListReferenceRequestFilterItemOpSerializer
        : JsonConverter<ExchangeRatesListReferenceRequestFilterItemOp>
    {
        public override ExchangeRatesListReferenceRequestFilterItemOp Read(
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
            return new ExchangeRatesListReferenceRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ExchangeRatesListReferenceRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ExchangeRatesListReferenceRequestFilterItemOp ReadAsPropertyName(
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
            return new ExchangeRatesListReferenceRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ExchangeRatesListReferenceRequestFilterItemOp value,
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
