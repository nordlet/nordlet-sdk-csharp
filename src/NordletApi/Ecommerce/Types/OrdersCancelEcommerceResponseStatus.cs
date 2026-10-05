using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersCancelEcommerceResponseStatus.OrdersCancelEcommerceResponseStatusSerializer)
)]
[Serializable]
public readonly record struct OrdersCancelEcommerceResponseStatus : IStringEnum
{
    public static readonly OrdersCancelEcommerceResponseStatus New = new(Values.New);

    public static readonly OrdersCancelEcommerceResponseStatus Reserved = new(Values.Reserved);

    public static readonly OrdersCancelEcommerceResponseStatus Fulfilled = new(Values.Fulfilled);

    public static readonly OrdersCancelEcommerceResponseStatus Cancelled = new(Values.Cancelled);

    public OrdersCancelEcommerceResponseStatus(string value)
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
    public static OrdersCancelEcommerceResponseStatus FromCustom(string value)
    {
        return new OrdersCancelEcommerceResponseStatus(value);
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

    public static bool operator ==(OrdersCancelEcommerceResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersCancelEcommerceResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersCancelEcommerceResponseStatus value) =>
        value.Value;

    public static explicit operator OrdersCancelEcommerceResponseStatus(string value) => new(value);

    internal class OrdersCancelEcommerceResponseStatusSerializer
        : JsonConverter<OrdersCancelEcommerceResponseStatus>
    {
        public override OrdersCancelEcommerceResponseStatus Read(
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
            return new OrdersCancelEcommerceResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersCancelEcommerceResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersCancelEcommerceResponseStatus ReadAsPropertyName(
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
            return new OrdersCancelEcommerceResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersCancelEcommerceResponseStatus value,
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
