using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersListPurchasesRequestFilterItemOp.OrdersListPurchasesRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct OrdersListPurchasesRequestFilterItemOp : IStringEnum
{
    public static readonly OrdersListPurchasesRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly OrdersListPurchasesRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly OrdersListPurchasesRequestFilterItemOp Contains = new(Values.Contains);

    public static readonly OrdersListPurchasesRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly OrdersListPurchasesRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly OrdersListPurchasesRequestFilterItemOp In = new(Values.In);

    public OrdersListPurchasesRequestFilterItemOp(string value)
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
    public static OrdersListPurchasesRequestFilterItemOp FromCustom(string value)
    {
        return new OrdersListPurchasesRequestFilterItemOp(value);
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

    public static bool operator ==(OrdersListPurchasesRequestFilterItemOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersListPurchasesRequestFilterItemOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersListPurchasesRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator OrdersListPurchasesRequestFilterItemOp(string value) =>
        new(value);

    internal class OrdersListPurchasesRequestFilterItemOpSerializer
        : JsonConverter<OrdersListPurchasesRequestFilterItemOp>
    {
        public override OrdersListPurchasesRequestFilterItemOp Read(
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
            return new OrdersListPurchasesRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersListPurchasesRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersListPurchasesRequestFilterItemOp ReadAsPropertyName(
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
            return new OrdersListPurchasesRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersListPurchasesRequestFilterItemOp value,
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
