using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ActsListSalesResponseRowsItemType.ActsListSalesResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct ActsListSalesResponseRowsItemType : IStringEnum
{
    public static readonly ActsListSalesResponseRowsItemType Goods = new(Values.Goods);

    public static readonly ActsListSalesResponseRowsItemType Services = new(Values.Services);

    public ActsListSalesResponseRowsItemType(string value)
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
    public static ActsListSalesResponseRowsItemType FromCustom(string value)
    {
        return new ActsListSalesResponseRowsItemType(value);
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

    public static bool operator ==(ActsListSalesResponseRowsItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ActsListSalesResponseRowsItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ActsListSalesResponseRowsItemType value) => value.Value;

    public static explicit operator ActsListSalesResponseRowsItemType(string value) => new(value);

    internal class ActsListSalesResponseRowsItemTypeSerializer
        : JsonConverter<ActsListSalesResponseRowsItemType>
    {
        public override ActsListSalesResponseRowsItemType Read(
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
            return new ActsListSalesResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ActsListSalesResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ActsListSalesResponseRowsItemType ReadAsPropertyName(
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
            return new ActsListSalesResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ActsListSalesResponseRowsItemType value,
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
        public const string Goods = "goods";

        public const string Services = "services";
    }
}
