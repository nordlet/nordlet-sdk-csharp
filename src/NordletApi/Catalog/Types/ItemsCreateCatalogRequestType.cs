using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ItemsCreateCatalogRequestType.ItemsCreateCatalogRequestTypeSerializer))]
[Serializable]
public readonly record struct ItemsCreateCatalogRequestType : IStringEnum
{
    public static readonly ItemsCreateCatalogRequestType Product = new(Values.Product);

    public static readonly ItemsCreateCatalogRequestType Service = new(Values.Service);

    public static readonly ItemsCreateCatalogRequestType Set = new(Values.Set);

    public ItemsCreateCatalogRequestType(string value)
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
    public static ItemsCreateCatalogRequestType FromCustom(string value)
    {
        return new ItemsCreateCatalogRequestType(value);
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

    public static bool operator ==(ItemsCreateCatalogRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsCreateCatalogRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsCreateCatalogRequestType value) => value.Value;

    public static explicit operator ItemsCreateCatalogRequestType(string value) => new(value);

    internal class ItemsCreateCatalogRequestTypeSerializer
        : JsonConverter<ItemsCreateCatalogRequestType>
    {
        public override ItemsCreateCatalogRequestType Read(
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
            return new ItemsCreateCatalogRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItemsCreateCatalogRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItemsCreateCatalogRequestType ReadAsPropertyName(
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
            return new ItemsCreateCatalogRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItemsCreateCatalogRequestType value,
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
