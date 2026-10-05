using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersCompleteProductionResponseStatus.OrdersCompleteProductionResponseStatusSerializer)
)]
[Serializable]
public readonly record struct OrdersCompleteProductionResponseStatus : IStringEnum
{
    public static readonly OrdersCompleteProductionResponseStatus Draft = new(Values.Draft);

    public static readonly OrdersCompleteProductionResponseStatus Completed = new(Values.Completed);

    public OrdersCompleteProductionResponseStatus(string value)
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
    public static OrdersCompleteProductionResponseStatus FromCustom(string value)
    {
        return new OrdersCompleteProductionResponseStatus(value);
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

    public static bool operator ==(OrdersCompleteProductionResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersCompleteProductionResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersCompleteProductionResponseStatus value) =>
        value.Value;

    public static explicit operator OrdersCompleteProductionResponseStatus(string value) =>
        new(value);

    internal class OrdersCompleteProductionResponseStatusSerializer
        : JsonConverter<OrdersCompleteProductionResponseStatus>
    {
        public override OrdersCompleteProductionResponseStatus Read(
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
            return new OrdersCompleteProductionResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersCompleteProductionResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersCompleteProductionResponseStatus ReadAsPropertyName(
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
            return new OrdersCompleteProductionResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersCompleteProductionResponseStatus value,
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
        public const string Draft = "draft";

        public const string Completed = "completed";
    }
}
