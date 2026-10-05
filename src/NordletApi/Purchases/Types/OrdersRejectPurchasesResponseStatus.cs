using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersRejectPurchasesResponseStatus.OrdersRejectPurchasesResponseStatusSerializer)
)]
[Serializable]
public readonly record struct OrdersRejectPurchasesResponseStatus : IStringEnum
{
    public static readonly OrdersRejectPurchasesResponseStatus Draft = new(Values.Draft);

    public static readonly OrdersRejectPurchasesResponseStatus Submitted = new(Values.Submitted);

    public static readonly OrdersRejectPurchasesResponseStatus Approved = new(Values.Approved);

    public static readonly OrdersRejectPurchasesResponseStatus PartiallyReceived = new(
        Values.PartiallyReceived
    );

    public static readonly OrdersRejectPurchasesResponseStatus Received = new(Values.Received);

    public static readonly OrdersRejectPurchasesResponseStatus Closed = new(Values.Closed);

    public static readonly OrdersRejectPurchasesResponseStatus Cancelled = new(Values.Cancelled);

    public OrdersRejectPurchasesResponseStatus(string value)
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
    public static OrdersRejectPurchasesResponseStatus FromCustom(string value)
    {
        return new OrdersRejectPurchasesResponseStatus(value);
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

    public static bool operator ==(OrdersRejectPurchasesResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersRejectPurchasesResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersRejectPurchasesResponseStatus value) =>
        value.Value;

    public static explicit operator OrdersRejectPurchasesResponseStatus(string value) => new(value);

    internal class OrdersRejectPurchasesResponseStatusSerializer
        : JsonConverter<OrdersRejectPurchasesResponseStatus>
    {
        public override OrdersRejectPurchasesResponseStatus Read(
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
            return new OrdersRejectPurchasesResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersRejectPurchasesResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersRejectPurchasesResponseStatus ReadAsPropertyName(
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
            return new OrdersRejectPurchasesResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersRejectPurchasesResponseStatus value,
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
