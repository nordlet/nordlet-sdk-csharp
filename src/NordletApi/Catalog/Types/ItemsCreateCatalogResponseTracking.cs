using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ItemsCreateCatalogResponseTracking.ItemsCreateCatalogResponseTrackingSerializer)
)]
[Serializable]
public readonly record struct ItemsCreateCatalogResponseTracking : IStringEnum
{
    public static readonly ItemsCreateCatalogResponseTracking None = new(Values.None);

    public static readonly ItemsCreateCatalogResponseTracking Lot = new(Values.Lot);

    public static readonly ItemsCreateCatalogResponseTracking Serial = new(Values.Serial);

    public ItemsCreateCatalogResponseTracking(string value)
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
    public static ItemsCreateCatalogResponseTracking FromCustom(string value)
    {
        return new ItemsCreateCatalogResponseTracking(value);
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

    public static bool operator ==(ItemsCreateCatalogResponseTracking value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsCreateCatalogResponseTracking value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsCreateCatalogResponseTracking value) => value.Value;

    public static explicit operator ItemsCreateCatalogResponseTracking(string value) => new(value);

    internal class ItemsCreateCatalogResponseTrackingSerializer
        : JsonConverter<ItemsCreateCatalogResponseTracking>
    {
        public override ItemsCreateCatalogResponseTracking Read(
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
            return new ItemsCreateCatalogResponseTracking(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItemsCreateCatalogResponseTracking value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItemsCreateCatalogResponseTracking ReadAsPropertyName(
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
            return new ItemsCreateCatalogResponseTracking(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItemsCreateCatalogResponseTracking value,
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
