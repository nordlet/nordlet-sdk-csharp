using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersSubmitPurchasesResponseStatus.OrdersSubmitPurchasesResponseStatusSerializer)
)]
[Serializable]
public readonly record struct OrdersSubmitPurchasesResponseStatus : IStringEnum
{
    public static readonly OrdersSubmitPurchasesResponseStatus Draft = new(Values.Draft);

    public static readonly OrdersSubmitPurchasesResponseStatus Submitted = new(Values.Submitted);

    public static readonly OrdersSubmitPurchasesResponseStatus Approved = new(Values.Approved);

    public static readonly OrdersSubmitPurchasesResponseStatus PartiallyReceived = new(
        Values.PartiallyReceived
    );

    public static readonly OrdersSubmitPurchasesResponseStatus Received = new(Values.Received);

    public static readonly OrdersSubmitPurchasesResponseStatus Closed = new(Values.Closed);

    public static readonly OrdersSubmitPurchasesResponseStatus Cancelled = new(Values.Cancelled);

    public OrdersSubmitPurchasesResponseStatus(string value)
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
    public static OrdersSubmitPurchasesResponseStatus FromCustom(string value)
    {
        return new OrdersSubmitPurchasesResponseStatus(value);
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

    public static bool operator ==(OrdersSubmitPurchasesResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersSubmitPurchasesResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersSubmitPurchasesResponseStatus value) =>
        value.Value;

    public static explicit operator OrdersSubmitPurchasesResponseStatus(string value) => new(value);

    internal class OrdersSubmitPurchasesResponseStatusSerializer
        : JsonConverter<OrdersSubmitPurchasesResponseStatus>
    {
        public override OrdersSubmitPurchasesResponseStatus Read(
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
            return new OrdersSubmitPurchasesResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersSubmitPurchasesResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersSubmitPurchasesResponseStatus ReadAsPropertyName(
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
            return new OrdersSubmitPurchasesResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersSubmitPurchasesResponseStatus value,
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
