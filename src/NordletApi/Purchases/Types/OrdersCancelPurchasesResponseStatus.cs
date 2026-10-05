using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersCancelPurchasesResponseStatus.OrdersCancelPurchasesResponseStatusSerializer)
)]
[Serializable]
public readonly record struct OrdersCancelPurchasesResponseStatus : IStringEnum
{
    public static readonly OrdersCancelPurchasesResponseStatus Draft = new(Values.Draft);

    public static readonly OrdersCancelPurchasesResponseStatus Submitted = new(Values.Submitted);

    public static readonly OrdersCancelPurchasesResponseStatus Approved = new(Values.Approved);

    public static readonly OrdersCancelPurchasesResponseStatus PartiallyReceived = new(
        Values.PartiallyReceived
    );

    public static readonly OrdersCancelPurchasesResponseStatus Received = new(Values.Received);

    public static readonly OrdersCancelPurchasesResponseStatus Closed = new(Values.Closed);

    public static readonly OrdersCancelPurchasesResponseStatus Cancelled = new(Values.Cancelled);

    public OrdersCancelPurchasesResponseStatus(string value)
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
    public static OrdersCancelPurchasesResponseStatus FromCustom(string value)
    {
        return new OrdersCancelPurchasesResponseStatus(value);
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

    public static bool operator ==(OrdersCancelPurchasesResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersCancelPurchasesResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersCancelPurchasesResponseStatus value) =>
        value.Value;

    public static explicit operator OrdersCancelPurchasesResponseStatus(string value) => new(value);

    internal class OrdersCancelPurchasesResponseStatusSerializer
        : JsonConverter<OrdersCancelPurchasesResponseStatus>
    {
        public override OrdersCancelPurchasesResponseStatus Read(
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
            return new OrdersCancelPurchasesResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersCancelPurchasesResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersCancelPurchasesResponseStatus ReadAsPropertyName(
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
            return new OrdersCancelPurchasesResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersCancelPurchasesResponseStatus value,
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
