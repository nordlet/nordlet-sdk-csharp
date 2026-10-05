using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersListPurchasesResponseRowsItemStatus.OrdersListPurchasesResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct OrdersListPurchasesResponseRowsItemStatus : IStringEnum
{
    public static readonly OrdersListPurchasesResponseRowsItemStatus Draft = new(Values.Draft);

    public static readonly OrdersListPurchasesResponseRowsItemStatus Submitted = new(
        Values.Submitted
    );

    public static readonly OrdersListPurchasesResponseRowsItemStatus Approved = new(
        Values.Approved
    );

    public static readonly OrdersListPurchasesResponseRowsItemStatus PartiallyReceived = new(
        Values.PartiallyReceived
    );

    public static readonly OrdersListPurchasesResponseRowsItemStatus Received = new(
        Values.Received
    );

    public static readonly OrdersListPurchasesResponseRowsItemStatus Closed = new(Values.Closed);

    public static readonly OrdersListPurchasesResponseRowsItemStatus Cancelled = new(
        Values.Cancelled
    );

    public OrdersListPurchasesResponseRowsItemStatus(string value)
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
    public static OrdersListPurchasesResponseRowsItemStatus FromCustom(string value)
    {
        return new OrdersListPurchasesResponseRowsItemStatus(value);
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
        OrdersListPurchasesResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        OrdersListPurchasesResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(OrdersListPurchasesResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator OrdersListPurchasesResponseRowsItemStatus(string value) =>
        new(value);

    internal class OrdersListPurchasesResponseRowsItemStatusSerializer
        : JsonConverter<OrdersListPurchasesResponseRowsItemStatus>
    {
        public override OrdersListPurchasesResponseRowsItemStatus Read(
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
            return new OrdersListPurchasesResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersListPurchasesResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersListPurchasesResponseRowsItemStatus ReadAsPropertyName(
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
            return new OrdersListPurchasesResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersListPurchasesResponseRowsItemStatus value,
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
