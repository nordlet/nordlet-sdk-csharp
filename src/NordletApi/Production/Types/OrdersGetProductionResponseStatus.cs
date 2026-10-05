using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersGetProductionResponseStatus.OrdersGetProductionResponseStatusSerializer)
)]
[Serializable]
public readonly record struct OrdersGetProductionResponseStatus : IStringEnum
{
    public static readonly OrdersGetProductionResponseStatus Draft = new(Values.Draft);

    public static readonly OrdersGetProductionResponseStatus Completed = new(Values.Completed);

    public OrdersGetProductionResponseStatus(string value)
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
    public static OrdersGetProductionResponseStatus FromCustom(string value)
    {
        return new OrdersGetProductionResponseStatus(value);
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

    public static bool operator ==(OrdersGetProductionResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersGetProductionResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersGetProductionResponseStatus value) => value.Value;

    public static explicit operator OrdersGetProductionResponseStatus(string value) => new(value);

    internal class OrdersGetProductionResponseStatusSerializer
        : JsonConverter<OrdersGetProductionResponseStatus>
    {
        public override OrdersGetProductionResponseStatus Read(
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
            return new OrdersGetProductionResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersGetProductionResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersGetProductionResponseStatus ReadAsPropertyName(
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
            return new OrdersGetProductionResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersGetProductionResponseStatus value,
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
