using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(OrdersGetEcommerceResponseStatus.OrdersGetEcommerceResponseStatusSerializer))]
[Serializable]
public readonly record struct OrdersGetEcommerceResponseStatus : IStringEnum
{
    public static readonly OrdersGetEcommerceResponseStatus New = new(Values.New);

    public static readonly OrdersGetEcommerceResponseStatus Reserved = new(Values.Reserved);

    public static readonly OrdersGetEcommerceResponseStatus Fulfilled = new(Values.Fulfilled);

    public static readonly OrdersGetEcommerceResponseStatus Cancelled = new(Values.Cancelled);

    public OrdersGetEcommerceResponseStatus(string value)
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
    public static OrdersGetEcommerceResponseStatus FromCustom(string value)
    {
        return new OrdersGetEcommerceResponseStatus(value);
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

    public static bool operator ==(OrdersGetEcommerceResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersGetEcommerceResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersGetEcommerceResponseStatus value) => value.Value;

    public static explicit operator OrdersGetEcommerceResponseStatus(string value) => new(value);

    internal class OrdersGetEcommerceResponseStatusSerializer
        : JsonConverter<OrdersGetEcommerceResponseStatus>
    {
        public override OrdersGetEcommerceResponseStatus Read(
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
            return new OrdersGetEcommerceResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersGetEcommerceResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersGetEcommerceResponseStatus ReadAsPropertyName(
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
            return new OrdersGetEcommerceResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersGetEcommerceResponseStatus value,
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
