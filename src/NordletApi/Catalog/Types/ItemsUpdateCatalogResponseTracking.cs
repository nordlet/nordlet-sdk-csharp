using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ItemsUpdateCatalogResponseTracking.ItemsUpdateCatalogResponseTrackingSerializer)
)]
[Serializable]
public readonly record struct ItemsUpdateCatalogResponseTracking : IStringEnum
{
    public static readonly ItemsUpdateCatalogResponseTracking None = new(Values.None);

    public static readonly ItemsUpdateCatalogResponseTracking Lot = new(Values.Lot);

    public static readonly ItemsUpdateCatalogResponseTracking Serial = new(Values.Serial);

    public ItemsUpdateCatalogResponseTracking(string value)
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
    public static ItemsUpdateCatalogResponseTracking FromCustom(string value)
    {
        return new ItemsUpdateCatalogResponseTracking(value);
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

    public static bool operator ==(ItemsUpdateCatalogResponseTracking value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsUpdateCatalogResponseTracking value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsUpdateCatalogResponseTracking value) => value.Value;

    public static explicit operator ItemsUpdateCatalogResponseTracking(string value) => new(value);

    internal class ItemsUpdateCatalogResponseTrackingSerializer
        : JsonConverter<ItemsUpdateCatalogResponseTracking>
    {
        public override ItemsUpdateCatalogResponseTracking Read(
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
            return new ItemsUpdateCatalogResponseTracking(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItemsUpdateCatalogResponseTracking value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItemsUpdateCatalogResponseTracking ReadAsPropertyName(
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
            return new ItemsUpdateCatalogResponseTracking(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItemsUpdateCatalogResponseTracking value,
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
