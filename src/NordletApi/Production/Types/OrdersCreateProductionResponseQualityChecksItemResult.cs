using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersCreateProductionResponseQualityChecksItemResult.OrdersCreateProductionResponseQualityChecksItemResultSerializer)
)]
[Serializable]
public readonly record struct OrdersCreateProductionResponseQualityChecksItemResult : IStringEnum
{
    public static readonly OrdersCreateProductionResponseQualityChecksItemResult Pending = new(
        Values.Pending
    );

    public static readonly OrdersCreateProductionResponseQualityChecksItemResult Passed = new(
        Values.Passed
    );

    public static readonly OrdersCreateProductionResponseQualityChecksItemResult Failed = new(
        Values.Failed
    );

    public OrdersCreateProductionResponseQualityChecksItemResult(string value)
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
    public static OrdersCreateProductionResponseQualityChecksItemResult FromCustom(string value)
    {
        return new OrdersCreateProductionResponseQualityChecksItemResult(value);
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

    public static bool operator ==(
        OrdersCreateProductionResponseQualityChecksItemResult value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        OrdersCreateProductionResponseQualityChecksItemResult value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        OrdersCreateProductionResponseQualityChecksItemResult value
    ) => value.Value;

    public static explicit operator OrdersCreateProductionResponseQualityChecksItemResult(
        string value
    ) => new(value);

    internal class OrdersCreateProductionResponseQualityChecksItemResultSerializer
        : JsonConverter<OrdersCreateProductionResponseQualityChecksItemResult>
    {
        public override OrdersCreateProductionResponseQualityChecksItemResult Read(
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
            return new OrdersCreateProductionResponseQualityChecksItemResult(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersCreateProductionResponseQualityChecksItemResult value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersCreateProductionResponseQualityChecksItemResult ReadAsPropertyName(
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
            return new OrdersCreateProductionResponseQualityChecksItemResult(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersCreateProductionResponseQualityChecksItemResult value,
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
        public const string Pending = "pending";

        public const string Passed = "passed";

        public const string Failed = "failed";
    }
}
