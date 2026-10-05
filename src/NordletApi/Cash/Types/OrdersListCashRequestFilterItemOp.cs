using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersListCashRequestFilterItemOp.OrdersListCashRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct OrdersListCashRequestFilterItemOp : IStringEnum
{
    public static readonly OrdersListCashRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly OrdersListCashRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly OrdersListCashRequestFilterItemOp Contains = new(Values.Contains);

    public static readonly OrdersListCashRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly OrdersListCashRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly OrdersListCashRequestFilterItemOp In = new(Values.In);

    public OrdersListCashRequestFilterItemOp(string value)
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
    public static OrdersListCashRequestFilterItemOp FromCustom(string value)
    {
        return new OrdersListCashRequestFilterItemOp(value);
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

    public static bool operator ==(OrdersListCashRequestFilterItemOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersListCashRequestFilterItemOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersListCashRequestFilterItemOp value) => value.Value;

    public static explicit operator OrdersListCashRequestFilterItemOp(string value) => new(value);

    internal class OrdersListCashRequestFilterItemOpSerializer
        : JsonConverter<OrdersListCashRequestFilterItemOp>
    {
        public override OrdersListCashRequestFilterItemOp Read(
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
            return new OrdersListCashRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersListCashRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersListCashRequestFilterItemOp ReadAsPropertyName(
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
            return new OrdersListCashRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersListCashRequestFilterItemOp value,
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
