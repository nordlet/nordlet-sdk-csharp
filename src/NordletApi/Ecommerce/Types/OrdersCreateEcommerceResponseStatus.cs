using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersCreateEcommerceResponseStatus.OrdersCreateEcommerceResponseStatusSerializer)
)]
[Serializable]
public readonly record struct OrdersCreateEcommerceResponseStatus : IStringEnum
{
    public static readonly OrdersCreateEcommerceResponseStatus New = new(Values.New);

    public static readonly OrdersCreateEcommerceResponseStatus Reserved = new(Values.Reserved);

    public static readonly OrdersCreateEcommerceResponseStatus Fulfilled = new(Values.Fulfilled);

    public static readonly OrdersCreateEcommerceResponseStatus Cancelled = new(Values.Cancelled);

    public OrdersCreateEcommerceResponseStatus(string value)
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
    public static OrdersCreateEcommerceResponseStatus FromCustom(string value)
    {
        return new OrdersCreateEcommerceResponseStatus(value);
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

    public static bool operator ==(OrdersCreateEcommerceResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersCreateEcommerceResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersCreateEcommerceResponseStatus value) =>
        value.Value;

    public static explicit operator OrdersCreateEcommerceResponseStatus(string value) => new(value);

    internal class OrdersCreateEcommerceResponseStatusSerializer
        : JsonConverter<OrdersCreateEcommerceResponseStatus>
    {
        public override OrdersCreateEcommerceResponseStatus Read(
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
            return new OrdersCreateEcommerceResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersCreateEcommerceResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersCreateEcommerceResponseStatus ReadAsPropertyName(
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
            return new OrdersCreateEcommerceResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersCreateEcommerceResponseStatus value,
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
