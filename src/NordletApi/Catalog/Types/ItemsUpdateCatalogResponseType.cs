using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ItemsUpdateCatalogResponseType.ItemsUpdateCatalogResponseTypeSerializer))]
[Serializable]
public readonly record struct ItemsUpdateCatalogResponseType : IStringEnum
{
    public static readonly ItemsUpdateCatalogResponseType Product = new(Values.Product);

    public static readonly ItemsUpdateCatalogResponseType Service = new(Values.Service);

    public static readonly ItemsUpdateCatalogResponseType Set = new(Values.Set);

    public ItemsUpdateCatalogResponseType(string value)
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
    public static ItemsUpdateCatalogResponseType FromCustom(string value)
    {
        return new ItemsUpdateCatalogResponseType(value);
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

    public static bool operator ==(ItemsUpdateCatalogResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsUpdateCatalogResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsUpdateCatalogResponseType value) => value.Value;

    public static explicit operator ItemsUpdateCatalogResponseType(string value) => new(value);

    internal class ItemsUpdateCatalogResponseTypeSerializer
        : JsonConverter<ItemsUpdateCatalogResponseType>
    {
        public override ItemsUpdateCatalogResponseType Read(
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
            return new ItemsUpdateCatalogResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItemsUpdateCatalogResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItemsUpdateCatalogResponseType ReadAsPropertyName(
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
            return new ItemsUpdateCatalogResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItemsUpdateCatalogResponseType value,
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
