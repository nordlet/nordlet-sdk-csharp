using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(OrdersCreateCashResponseType.OrdersCreateCashResponseTypeSerializer))]
[Serializable]
public readonly record struct OrdersCreateCashResponseType : IStringEnum
{
    public static readonly OrdersCreateCashResponseType Receipt = new(Values.Receipt);

    public static readonly OrdersCreateCashResponseType Disbursement = new(Values.Disbursement);

    public OrdersCreateCashResponseType(string value)
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
    public static OrdersCreateCashResponseType FromCustom(string value)
    {
        return new OrdersCreateCashResponseType(value);
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

    public static bool operator ==(OrdersCreateCashResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersCreateCashResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersCreateCashResponseType value) => value.Value;

    public static explicit operator OrdersCreateCashResponseType(string value) => new(value);

    internal class OrdersCreateCashResponseTypeSerializer
        : JsonConverter<OrdersCreateCashResponseType>
    {
        public override OrdersCreateCashResponseType Read(
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
            return new OrdersCreateCashResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersCreateCashResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersCreateCashResponseType ReadAsPropertyName(
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
            return new OrdersCreateCashResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersCreateCashResponseType value,
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
