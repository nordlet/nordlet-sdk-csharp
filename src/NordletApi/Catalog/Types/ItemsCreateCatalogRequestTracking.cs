using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ItemsCreateCatalogRequestTracking.ItemsCreateCatalogRequestTrackingSerializer)
)]
[Serializable]
public readonly record struct ItemsCreateCatalogRequestTracking : IStringEnum
{
    public static readonly ItemsCreateCatalogRequestTracking None = new(Values.None);

    public static readonly ItemsCreateCatalogRequestTracking Lot = new(Values.Lot);

    public static readonly ItemsCreateCatalogRequestTracking Serial = new(Values.Serial);

    public ItemsCreateCatalogRequestTracking(string value)
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
    public static ItemsCreateCatalogRequestTracking FromCustom(string value)
    {
        return new ItemsCreateCatalogRequestTracking(value);
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

    public static bool operator ==(ItemsCreateCatalogRequestTracking value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsCreateCatalogRequestTracking value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsCreateCatalogRequestTracking value) => value.Value;

    public static explicit operator ItemsCreateCatalogRequestTracking(string value) => new(value);

    internal class ItemsCreateCatalogRequestTrackingSerializer
        : JsonConverter<ItemsCreateCatalogRequestTracking>
    {
        public override ItemsCreateCatalogRequestTracking Read(
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
            return new ItemsCreateCatalogRequestTracking(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItemsCreateCatalogRequestTracking value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItemsCreateCatalogRequestTracking ReadAsPropertyName(
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
            return new ItemsCreateCatalogRequestTracking(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItemsCreateCatalogRequestTracking value,
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
