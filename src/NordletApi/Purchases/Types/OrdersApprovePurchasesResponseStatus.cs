using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersApprovePurchasesResponseStatus.OrdersApprovePurchasesResponseStatusSerializer)
)]
[Serializable]
public readonly record struct OrdersApprovePurchasesResponseStatus : IStringEnum
{
    public static readonly OrdersApprovePurchasesResponseStatus Draft = new(Values.Draft);

    public static readonly OrdersApprovePurchasesResponseStatus Submitted = new(Values.Submitted);

    public static readonly OrdersApprovePurchasesResponseStatus Approved = new(Values.Approved);

    public static readonly OrdersApprovePurchasesResponseStatus PartiallyReceived = new(
        Values.PartiallyReceived
    );

    public static readonly OrdersApprovePurchasesResponseStatus Received = new(Values.Received);

    public static readonly OrdersApprovePurchasesResponseStatus Closed = new(Values.Closed);

    public static readonly OrdersApprovePurchasesResponseStatus Cancelled = new(Values.Cancelled);

    public OrdersApprovePurchasesResponseStatus(string value)
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
    public static OrdersApprovePurchasesResponseStatus FromCustom(string value)
    {
        return new OrdersApprovePurchasesResponseStatus(value);
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

    public static bool operator ==(OrdersApprovePurchasesResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersApprovePurchasesResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersApprovePurchasesResponseStatus value) =>
        value.Value;

    public static explicit operator OrdersApprovePurchasesResponseStatus(string value) =>
        new(value);

    internal class OrdersApprovePurchasesResponseStatusSerializer
        : JsonConverter<OrdersApprovePurchasesResponseStatus>
    {
        public override OrdersApprovePurchasesResponseStatus Read(
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
            return new OrdersApprovePurchasesResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersApprovePurchasesResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersApprovePurchasesResponseStatus ReadAsPropertyName(
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
            return new OrdersApprovePurchasesResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersApprovePurchasesResponseStatus value,
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
