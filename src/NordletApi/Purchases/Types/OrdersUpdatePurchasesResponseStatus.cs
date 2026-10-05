using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersUpdatePurchasesResponseStatus.OrdersUpdatePurchasesResponseStatusSerializer)
)]
[Serializable]
public readonly record struct OrdersUpdatePurchasesResponseStatus : IStringEnum
{
    public static readonly OrdersUpdatePurchasesResponseStatus Draft = new(Values.Draft);

    public static readonly OrdersUpdatePurchasesResponseStatus Submitted = new(Values.Submitted);

    public static readonly OrdersUpdatePurchasesResponseStatus Approved = new(Values.Approved);

    public static readonly OrdersUpdatePurchasesResponseStatus PartiallyReceived = new(
        Values.PartiallyReceived
    );

    public static readonly OrdersUpdatePurchasesResponseStatus Received = new(Values.Received);

    public static readonly OrdersUpdatePurchasesResponseStatus Closed = new(Values.Closed);

    public static readonly OrdersUpdatePurchasesResponseStatus Cancelled = new(Values.Cancelled);

    public OrdersUpdatePurchasesResponseStatus(string value)
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
    public static OrdersUpdatePurchasesResponseStatus FromCustom(string value)
    {
        return new OrdersUpdatePurchasesResponseStatus(value);
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

    public static bool operator ==(OrdersUpdatePurchasesResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersUpdatePurchasesResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersUpdatePurchasesResponseStatus value) =>
        value.Value;

    public static explicit operator OrdersUpdatePurchasesResponseStatus(string value) => new(value);

    internal class OrdersUpdatePurchasesResponseStatusSerializer
        : JsonConverter<OrdersUpdatePurchasesResponseStatus>
    {
        public override OrdersUpdatePurchasesResponseStatus Read(
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
            return new OrdersUpdatePurchasesResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersUpdatePurchasesResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersUpdatePurchasesResponseStatus ReadAsPropertyName(
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
            return new OrdersUpdatePurchasesResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersUpdatePurchasesResponseStatus value,
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
