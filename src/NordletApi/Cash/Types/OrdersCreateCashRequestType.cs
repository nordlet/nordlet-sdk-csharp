using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(OrdersCreateCashRequestType.OrdersCreateCashRequestTypeSerializer))]
[Serializable]
public readonly record struct OrdersCreateCashRequestType : IStringEnum
{
    public static readonly OrdersCreateCashRequestType Receipt = new(Values.Receipt);

    public static readonly OrdersCreateCashRequestType Disbursement = new(Values.Disbursement);

    public OrdersCreateCashRequestType(string value)
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
    public static OrdersCreateCashRequestType FromCustom(string value)
    {
        return new OrdersCreateCashRequestType(value);
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

    public static bool operator ==(OrdersCreateCashRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersCreateCashRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersCreateCashRequestType value) => value.Value;

    public static explicit operator OrdersCreateCashRequestType(string value) => new(value);

    internal class OrdersCreateCashRequestTypeSerializer
        : JsonConverter<OrdersCreateCashRequestType>
    {
        public override OrdersCreateCashRequestType Read(
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
            return new OrdersCreateCashRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersCreateCashRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersCreateCashRequestType ReadAsPropertyName(
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
            return new OrdersCreateCashRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersCreateCashRequestType value,
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
