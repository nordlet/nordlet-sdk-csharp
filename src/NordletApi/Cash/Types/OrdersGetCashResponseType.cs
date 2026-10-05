using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(OrdersGetCashResponseType.OrdersGetCashResponseTypeSerializer))]
[Serializable]
public readonly record struct OrdersGetCashResponseType : IStringEnum
{
    public static readonly OrdersGetCashResponseType Receipt = new(Values.Receipt);

    public static readonly OrdersGetCashResponseType Disbursement = new(Values.Disbursement);

    public OrdersGetCashResponseType(string value)
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
    public static OrdersGetCashResponseType FromCustom(string value)
    {
        return new OrdersGetCashResponseType(value);
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

    public static bool operator ==(OrdersGetCashResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersGetCashResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersGetCashResponseType value) => value.Value;

    public static explicit operator OrdersGetCashResponseType(string value) => new(value);

    internal class OrdersGetCashResponseTypeSerializer : JsonConverter<OrdersGetCashResponseType>
    {
        public override OrdersGetCashResponseType Read(
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
            return new OrdersGetCashResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersGetCashResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersGetCashResponseType ReadAsPropertyName(
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
            return new OrdersGetCashResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersGetCashResponseType value,
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
        public const string Receipt = "receipt";

        public const string Disbursement = "disbursement";
    }
}
