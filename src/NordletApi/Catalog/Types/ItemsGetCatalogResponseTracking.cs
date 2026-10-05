using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ItemsGetCatalogResponseTracking.ItemsGetCatalogResponseTrackingSerializer))]
[Serializable]
public readonly record struct ItemsGetCatalogResponseTracking : IStringEnum
{
    public static readonly ItemsGetCatalogResponseTracking None = new(Values.None);

    public static readonly ItemsGetCatalogResponseTracking Lot = new(Values.Lot);

    public static readonly ItemsGetCatalogResponseTracking Serial = new(Values.Serial);

    public ItemsGetCatalogResponseTracking(string value)
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
    public static ItemsGetCatalogResponseTracking FromCustom(string value)
    {
        return new ItemsGetCatalogResponseTracking(value);
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

    public static bool operator ==(ItemsGetCatalogResponseTracking value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsGetCatalogResponseTracking value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsGetCatalogResponseTracking value) => value.Value;

    public static explicit operator ItemsGetCatalogResponseTracking(string value) => new(value);

    internal class ItemsGetCatalogResponseTrackingSerializer
        : JsonConverter<ItemsGetCatalogResponseTracking>
    {
        public override ItemsGetCatalogResponseTracking Read(
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
            return new ItemsGetCatalogResponseTracking(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItemsGetCatalogResponseTracking value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItemsGetCatalogResponseTracking ReadAsPropertyName(
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
            return new ItemsGetCatalogResponseTracking(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItemsGetCatalogResponseTracking value,
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
        public const string None = "none";

        public const string Lot = "lot";

        public const string Serial = "serial";
    }
}
