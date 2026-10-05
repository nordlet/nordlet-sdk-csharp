using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersFulfillEcommerceResponseStatus.OrdersFulfillEcommerceResponseStatusSerializer)
)]
[Serializable]
public readonly record struct OrdersFulfillEcommerceResponseStatus : IStringEnum
{
    public static readonly OrdersFulfillEcommerceResponseStatus New = new(Values.New);

    public static readonly OrdersFulfillEcommerceResponseStatus Reserved = new(Values.Reserved);

    public static readonly OrdersFulfillEcommerceResponseStatus Fulfilled = new(Values.Fulfilled);

    public static readonly OrdersFulfillEcommerceResponseStatus Cancelled = new(Values.Cancelled);

    public OrdersFulfillEcommerceResponseStatus(string value)
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
    public static OrdersFulfillEcommerceResponseStatus FromCustom(string value)
    {
        return new OrdersFulfillEcommerceResponseStatus(value);
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

    public static bool operator ==(OrdersFulfillEcommerceResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersFulfillEcommerceResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersFulfillEcommerceResponseStatus value) =>
        value.Value;

    public static explicit operator OrdersFulfillEcommerceResponseStatus(string value) =>
        new(value);

    internal class OrdersFulfillEcommerceResponseStatusSerializer
        : JsonConverter<OrdersFulfillEcommerceResponseStatus>
    {
        public override OrdersFulfillEcommerceResponseStatus Read(
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
            return new OrdersFulfillEcommerceResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersFulfillEcommerceResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersFulfillEcommerceResponseStatus ReadAsPropertyName(
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
            return new OrdersFulfillEcommerceResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersFulfillEcommerceResponseStatus value,
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
