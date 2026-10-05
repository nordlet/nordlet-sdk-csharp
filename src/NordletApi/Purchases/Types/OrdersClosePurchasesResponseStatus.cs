using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersClosePurchasesResponseStatus.OrdersClosePurchasesResponseStatusSerializer)
)]
[Serializable]
public readonly record struct OrdersClosePurchasesResponseStatus : IStringEnum
{
    public static readonly OrdersClosePurchasesResponseStatus Draft = new(Values.Draft);

    public static readonly OrdersClosePurchasesResponseStatus Submitted = new(Values.Submitted);

    public static readonly OrdersClosePurchasesResponseStatus Approved = new(Values.Approved);

    public static readonly OrdersClosePurchasesResponseStatus PartiallyReceived = new(
        Values.PartiallyReceived
    );

    public static readonly OrdersClosePurchasesResponseStatus Received = new(Values.Received);

    public static readonly OrdersClosePurchasesResponseStatus Closed = new(Values.Closed);

    public static readonly OrdersClosePurchasesResponseStatus Cancelled = new(Values.Cancelled);

    public OrdersClosePurchasesResponseStatus(string value)
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
    public static OrdersClosePurchasesResponseStatus FromCustom(string value)
    {
        return new OrdersClosePurchasesResponseStatus(value);
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

    public static bool operator ==(OrdersClosePurchasesResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersClosePurchasesResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersClosePurchasesResponseStatus value) => value.Value;

    public static explicit operator OrdersClosePurchasesResponseStatus(string value) => new(value);

    internal class OrdersClosePurchasesResponseStatusSerializer
        : JsonConverter<OrdersClosePurchasesResponseStatus>
    {
        public override OrdersClosePurchasesResponseStatus Read(
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
            return new OrdersClosePurchasesResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersClosePurchasesResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersClosePurchasesResponseStatus ReadAsPropertyName(
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
            return new OrdersClosePurchasesResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersClosePurchasesResponseStatus value,
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

        public const string Submitted = "submitted";

        public const string Approved = "approved";

        public const string PartiallyReceived = "partially_received";

        public const string Received = "received";

        public const string Closed = "closed";

        public const string Cancelled = "cancelled";
    }
}
