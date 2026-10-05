using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersReserveEcommerceResponseStatus.OrdersReserveEcommerceResponseStatusSerializer)
)]
[Serializable]
public readonly record struct OrdersReserveEcommerceResponseStatus : IStringEnum
{
    public static readonly OrdersReserveEcommerceResponseStatus New = new(Values.New);

    public static readonly OrdersReserveEcommerceResponseStatus Reserved = new(Values.Reserved);

    public static readonly OrdersReserveEcommerceResponseStatus Fulfilled = new(Values.Fulfilled);

    public static readonly OrdersReserveEcommerceResponseStatus Cancelled = new(Values.Cancelled);

    public OrdersReserveEcommerceResponseStatus(string value)
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
    public static OrdersReserveEcommerceResponseStatus FromCustom(string value)
    {
        return new OrdersReserveEcommerceResponseStatus(value);
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

    public static bool operator ==(OrdersReserveEcommerceResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersReserveEcommerceResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersReserveEcommerceResponseStatus value) =>
        value.Value;

    public static explicit operator OrdersReserveEcommerceResponseStatus(string value) =>
        new(value);

    internal class OrdersReserveEcommerceResponseStatusSerializer
        : JsonConverter<OrdersReserveEcommerceResponseStatus>
    {
        public override OrdersReserveEcommerceResponseStatus Read(
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
            return new OrdersReserveEcommerceResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersReserveEcommerceResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersReserveEcommerceResponseStatus ReadAsPropertyName(
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
            return new OrdersReserveEcommerceResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersReserveEcommerceResponseStatus value,
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
        public const string New = "new";

        public const string Reserved = "reserved";

        public const string Fulfilled = "fulfilled";

        public const string Cancelled = "cancelled";
    }
}
