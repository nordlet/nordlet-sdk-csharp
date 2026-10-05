using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OrdersListCashResponseRowsItemType.OrdersListCashResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct OrdersListCashResponseRowsItemType : IStringEnum
{
    public static readonly OrdersListCashResponseRowsItemType Receipt = new(Values.Receipt);

    public static readonly OrdersListCashResponseRowsItemType Disbursement = new(
        Values.Disbursement
    );

    public OrdersListCashResponseRowsItemType(string value)
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
    public static OrdersListCashResponseRowsItemType FromCustom(string value)
    {
        return new OrdersListCashResponseRowsItemType(value);
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

    public static bool operator ==(OrdersListCashResponseRowsItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersListCashResponseRowsItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersListCashResponseRowsItemType value) => value.Value;

    public static explicit operator OrdersListCashResponseRowsItemType(string value) => new(value);

    internal class OrdersListCashResponseRowsItemTypeSerializer
        : JsonConverter<OrdersListCashResponseRowsItemType>
    {
        public override OrdersListCashResponseRowsItemType Read(
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
            return new OrdersListCashResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersListCashResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersListCashResponseRowsItemType ReadAsPropertyName(
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
            return new OrdersListCashResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersListCashResponseRowsItemType value,
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
        public const string Receipt = "receipt";

        public const string Disbursement = "disbursement";
    }
}
