using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersListEcommerceResponseRowsItemStatus.OrdersListEcommerceResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct OrdersListEcommerceResponseRowsItemStatus : IStringEnum
{
    public static readonly OrdersListEcommerceResponseRowsItemStatus New = new(Values.New);

    public static readonly OrdersListEcommerceResponseRowsItemStatus Reserved = new(
        Values.Reserved
    );

    public static readonly OrdersListEcommerceResponseRowsItemStatus Fulfilled = new(
        Values.Fulfilled
    );

    public static readonly OrdersListEcommerceResponseRowsItemStatus Cancelled = new(
        Values.Cancelled
    );

    public OrdersListEcommerceResponseRowsItemStatus(string value)
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
    public static OrdersListEcommerceResponseRowsItemStatus FromCustom(string value)
    {
        return new OrdersListEcommerceResponseRowsItemStatus(value);
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
        OrdersListEcommerceResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        OrdersListEcommerceResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(OrdersListEcommerceResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator OrdersListEcommerceResponseRowsItemStatus(string value) =>
        new(value);

    internal class OrdersListEcommerceResponseRowsItemStatusSerializer
        : JsonConverter<OrdersListEcommerceResponseRowsItemStatus>
    {
        public override OrdersListEcommerceResponseRowsItemStatus Read(
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
            return new OrdersListEcommerceResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersListEcommerceResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersListEcommerceResponseRowsItemStatus ReadAsPropertyName(
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
            return new OrdersListEcommerceResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersListEcommerceResponseRowsItemStatus value,
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
        public const string New = "new";

        public const string Reserved = "reserved";

        public const string Fulfilled = "fulfilled";

        public const string Cancelled = "cancelled";
    }
}
