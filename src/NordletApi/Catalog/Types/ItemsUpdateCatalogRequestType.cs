using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ItemsUpdateCatalogRequestType.ItemsUpdateCatalogRequestTypeSerializer))]
[Serializable]
public readonly record struct ItemsUpdateCatalogRequestType : IStringEnum
{
    public static readonly ItemsUpdateCatalogRequestType Product = new(Values.Product);

    public static readonly ItemsUpdateCatalogRequestType Service = new(Values.Service);

    public static readonly ItemsUpdateCatalogRequestType Set = new(Values.Set);

    public ItemsUpdateCatalogRequestType(string value)
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
    public static ItemsUpdateCatalogRequestType FromCustom(string value)
    {
        return new ItemsUpdateCatalogRequestType(value);
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

    public static bool operator ==(ItemsUpdateCatalogRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsUpdateCatalogRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsUpdateCatalogRequestType value) => value.Value;

    public static explicit operator ItemsUpdateCatalogRequestType(string value) => new(value);

    internal class ItemsUpdateCatalogRequestTypeSerializer
        : JsonConverter<ItemsUpdateCatalogRequestType>
    {
        public override ItemsUpdateCatalogRequestType Read(
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
            return new ItemsUpdateCatalogRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItemsUpdateCatalogRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItemsUpdateCatalogRequestType ReadAsPropertyName(
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
            return new ItemsUpdateCatalogRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItemsUpdateCatalogRequestType value,
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
        public const string Product = "product";

        public const string Service = "service";

        public const string Set = "set";
    }
}
