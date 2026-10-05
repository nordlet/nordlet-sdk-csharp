using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(OrdersListCashRequestSortItemDir.OrdersListCashRequestSortItemDirSerializer))]
[Serializable]
public readonly record struct OrdersListCashRequestSortItemDir : IStringEnum
{
    public static readonly OrdersListCashRequestSortItemDir Asc = new(Values.Asc);

    public static readonly OrdersListCashRequestSortItemDir Desc = new(Values.Desc);

    public OrdersListCashRequestSortItemDir(string value)
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
    public static OrdersListCashRequestSortItemDir FromCustom(string value)
    {
        return new OrdersListCashRequestSortItemDir(value);
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

    public static bool operator ==(OrdersListCashRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrdersListCashRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrdersListCashRequestSortItemDir value) => value.Value;

    public static explicit operator OrdersListCashRequestSortItemDir(string value) => new(value);

    internal class OrdersListCashRequestSortItemDirSerializer
        : JsonConverter<OrdersListCashRequestSortItemDir>
    {
        public override OrdersListCashRequestSortItemDir Read(
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
            return new OrdersListCashRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrdersListCashRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrdersListCashRequestSortItemDir ReadAsPropertyName(
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
            return new OrdersListCashRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrdersListCashRequestSortItemDir value,
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
        public const string Asc = "asc";

        public const string Desc = "desc";
    }
}
