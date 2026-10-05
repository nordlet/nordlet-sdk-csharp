using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersCreateProductionResponseType.OrdersCreateProductionResponseTypeSerializer)
)]
[Serializable]
public readonly record struct OrdersCreateProductionResponseType : IStringEnum
{
    public static readonly OrdersCreateProductionResponseType Assembly = new(Values.Assembly);

    public static readonly OrdersCreateProductionResponseType Disassembly = new(Values.Disassembly);

    public OrdersCreateProductionResponseType(string value)
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
    public static OrdersCreateProductionResponseType FromCustom(string value)
    {
        return new OrdersCreateProductionResponseType(value);
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

    public static bool operator ==(OrdersCreateProductionResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersCreateProductionResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersCreateProductionResponseType value) => value.Value;

    public static explicit operator OrdersCreateProductionResponseType(string value) => new(value);

    internal class OrdersCreateProductionResponseTypeSerializer
        : JsonConverter<OrdersCreateProductionResponseType>
    {
        public override OrdersCreateProductionResponseType Read(
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
            return new OrdersCreateProductionResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersCreateProductionResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersCreateProductionResponseType ReadAsPropertyName(
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
            return new OrdersCreateProductionResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersCreateProductionResponseType value,
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
        public const string Assembly = "assembly";

        public const string Disassembly = "disassembly";
    }
}
