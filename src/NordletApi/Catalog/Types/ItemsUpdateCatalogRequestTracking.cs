using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ItemsUpdateCatalogRequestTracking.ItemsUpdateCatalogRequestTrackingSerializer)
)]
[Serializable]
public readonly record struct ItemsUpdateCatalogRequestTracking : IStringEnum
{
    public static readonly ItemsUpdateCatalogRequestTracking None = new(Values.None);

    public static readonly ItemsUpdateCatalogRequestTracking Lot = new(Values.Lot);

    public static readonly ItemsUpdateCatalogRequestTracking Serial = new(Values.Serial);

    public ItemsUpdateCatalogRequestTracking(string value)
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
    public static ItemsUpdateCatalogRequestTracking FromCustom(string value)
    {
        return new ItemsUpdateCatalogRequestTracking(value);
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

    public static bool operator ==(ItemsUpdateCatalogRequestTracking value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsUpdateCatalogRequestTracking value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsUpdateCatalogRequestTracking value) => value.Value;

    public static explicit operator ItemsUpdateCatalogRequestTracking(string value) => new(value);

    internal class ItemsUpdateCatalogRequestTrackingSerializer
        : JsonConverter<ItemsUpdateCatalogRequestTracking>
    {
        public override ItemsUpdateCatalogRequestTracking Read(
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
            return new ItemsUpdateCatalogRequestTracking(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItemsUpdateCatalogRequestTracking value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItemsUpdateCatalogRequestTracking ReadAsPropertyName(
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
            return new ItemsUpdateCatalogRequestTracking(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItemsUpdateCatalogRequestTracking value,
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
