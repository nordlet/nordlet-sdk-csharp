using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ItemsListCatalogResponseRowsItemType.ItemsListCatalogResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct ItemsListCatalogResponseRowsItemType : IStringEnum
{
    public static readonly ItemsListCatalogResponseRowsItemType Product = new(Values.Product);

    public static readonly ItemsListCatalogResponseRowsItemType Service = new(Values.Service);

    public static readonly ItemsListCatalogResponseRowsItemType Set = new(Values.Set);

    public ItemsListCatalogResponseRowsItemType(string value)
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
    public static ItemsListCatalogResponseRowsItemType FromCustom(string value)
    {
        return new ItemsListCatalogResponseRowsItemType(value);
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

    public static bool operator ==(ItemsListCatalogResponseRowsItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsListCatalogResponseRowsItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsListCatalogResponseRowsItemType value) =>
        value.Value;

    public static explicit operator ItemsListCatalogResponseRowsItemType(string value) =>
        new(value);

    internal class ItemsListCatalogResponseRowsItemTypeSerializer
        : JsonConverter<ItemsListCatalogResponseRowsItemType>
    {
        public override ItemsListCatalogResponseRowsItemType Read(
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
            return new ItemsListCatalogResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItemsListCatalogResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItemsListCatalogResponseRowsItemType ReadAsPropertyName(
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
            return new ItemsListCatalogResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItemsListCatalogResponseRowsItemType value,
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
