using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersCompleteProductionResponseType.OrdersCompleteProductionResponseTypeSerializer)
)]
[Serializable]
public readonly record struct OrdersCompleteProductionResponseType : IStringEnum
{
    public static readonly OrdersCompleteProductionResponseType Assembly = new(Values.Assembly);

    public static readonly OrdersCompleteProductionResponseType Disassembly = new(
        Values.Disassembly
    );

    public OrdersCompleteProductionResponseType(string value)
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
    public static OrdersCompleteProductionResponseType FromCustom(string value)
    {
        return new OrdersCompleteProductionResponseType(value);
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

    public static bool operator ==(OrdersCompleteProductionResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersCompleteProductionResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersCompleteProductionResponseType value) =>
        value.Value;

    public static explicit operator OrdersCompleteProductionResponseType(string value) =>
        new(value);

    internal class OrdersCompleteProductionResponseTypeSerializer
        : JsonConverter<OrdersCompleteProductionResponseType>
    {
        public override OrdersCompleteProductionResponseType Read(
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
            return new OrdersCompleteProductionResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersCompleteProductionResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersCompleteProductionResponseType ReadAsPropertyName(
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
            return new OrdersCompleteProductionResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersCompleteProductionResponseType value,
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
