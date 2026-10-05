using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ActsListSalesRequestFilterItemOp.ActsListSalesRequestFilterItemOpSerializer))]
[Serializable]
public readonly record struct ActsListSalesRequestFilterItemOp : IStringEnum
{
    public static readonly ActsListSalesRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly ActsListSalesRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly ActsListSalesRequestFilterItemOp Contains = new(Values.Contains);

    public static readonly ActsListSalesRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly ActsListSalesRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly ActsListSalesRequestFilterItemOp In = new(Values.In);

    public ActsListSalesRequestFilterItemOp(string value)
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
    public static ActsListSalesRequestFilterItemOp FromCustom(string value)
    {
        return new ActsListSalesRequestFilterItemOp(value);
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

    public static bool operator ==(ActsListSalesRequestFilterItemOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ActsListSalesRequestFilterItemOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ActsListSalesRequestFilterItemOp value) => value.Value;

    public static explicit operator ActsListSalesRequestFilterItemOp(string value) => new(value);

    internal class ActsListSalesRequestFilterItemOpSerializer
        : JsonConverter<ActsListSalesRequestFilterItemOp>
    {
        public override ActsListSalesRequestFilterItemOp Read(
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
            return new ActsListSalesRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ActsListSalesRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ActsListSalesRequestFilterItemOp ReadAsPropertyName(
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
            return new ActsListSalesRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ActsListSalesRequestFilterItemOp value,
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
