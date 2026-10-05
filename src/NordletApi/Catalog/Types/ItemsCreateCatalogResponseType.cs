using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ItemsCreateCatalogResponseType.ItemsCreateCatalogResponseTypeSerializer))]
[Serializable]
public readonly record struct ItemsCreateCatalogResponseType : IStringEnum
{
    public static readonly ItemsCreateCatalogResponseType Product = new(Values.Product);

    public static readonly ItemsCreateCatalogResponseType Service = new(Values.Service);

    public static readonly ItemsCreateCatalogResponseType Set = new(Values.Set);

    public ItemsCreateCatalogResponseType(string value)
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
    public static ItemsCreateCatalogResponseType FromCustom(string value)
    {
        return new ItemsCreateCatalogResponseType(value);
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

    public static bool operator ==(ItemsCreateCatalogResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsCreateCatalogResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsCreateCatalogResponseType value) => value.Value;

    public static explicit operator ItemsCreateCatalogResponseType(string value) => new(value);

    internal class ItemsCreateCatalogResponseTypeSerializer
        : JsonConverter<ItemsCreateCatalogResponseType>
    {
        public override ItemsCreateCatalogResponseType Read(
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
            return new ItemsCreateCatalogResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItemsCreateCatalogResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItemsCreateCatalogResponseType ReadAsPropertyName(
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
            return new ItemsCreateCatalogResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItemsCreateCatalogResponseType value,
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
