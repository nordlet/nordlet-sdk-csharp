using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersGetProductionResponseQualityChecksItemResult.OrdersGetProductionResponseQualityChecksItemResultSerializer)
)]
[Serializable]
public readonly record struct OrdersGetProductionResponseQualityChecksItemResult : IStringEnum
{
    public static readonly OrdersGetProductionResponseQualityChecksItemResult Pending = new(
        Values.Pending
    );

    public static readonly OrdersGetProductionResponseQualityChecksItemResult Passed = new(
        Values.Passed
    );

    public static readonly OrdersGetProductionResponseQualityChecksItemResult Failed = new(
        Values.Failed
    );

    public OrdersGetProductionResponseQualityChecksItemResult(string value)
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
    public static OrdersGetProductionResponseQualityChecksItemResult FromCustom(string value)
    {
        return new OrdersGetProductionResponseQualityChecksItemResult(value);
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
        OrdersGetProductionResponseQualityChecksItemResult value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        OrdersGetProductionResponseQualityChecksItemResult value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        OrdersGetProductionResponseQualityChecksItemResult value
    ) => value.Value;

    public static explicit operator OrdersGetProductionResponseQualityChecksItemResult(
        string value
    ) => new(value);

    internal class OrdersGetProductionResponseQualityChecksItemResultSerializer
        : JsonConverter<OrdersGetProductionResponseQualityChecksItemResult>
    {
        public override OrdersGetProductionResponseQualityChecksItemResult Read(
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
            return new OrdersGetProductionResponseQualityChecksItemResult(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersGetProductionResponseQualityChecksItemResult value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersGetProductionResponseQualityChecksItemResult ReadAsPropertyName(
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
            return new OrdersGetProductionResponseQualityChecksItemResult(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersGetProductionResponseQualityChecksItemResult value,
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
