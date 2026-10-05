using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ItemsKindsListCatalogResponseRowsItemSaftType.ItemsKindsListCatalogResponseRowsItemSaftTypeSerializer)
)]
[Serializable]
public readonly record struct ItemsKindsListCatalogResponseRowsItemSaftType : IStringEnum
{
    public static readonly ItemsKindsListCatalogResponseRowsItemSaftType Goods = new(Values.Goods);

    public static readonly ItemsKindsListCatalogResponseRowsItemSaftType Service = new(
        Values.Service
    );

    public static readonly ItemsKindsListCatalogResponseRowsItemSaftType FixedAsset = new(
        Values.FixedAsset
    );

    public static readonly ItemsKindsListCatalogResponseRowsItemSaftType Other = new(Values.Other);

    public ItemsKindsListCatalogResponseRowsItemSaftType(string value)
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
    public static ItemsKindsListCatalogResponseRowsItemSaftType FromCustom(string value)
    {
        return new ItemsKindsListCatalogResponseRowsItemSaftType(value);
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

    public static bool operator ==(
        ItemsKindsListCatalogResponseRowsItemSaftType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ItemsKindsListCatalogResponseRowsItemSaftType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ItemsKindsListCatalogResponseRowsItemSaftType value) =>
        value.Value;

    public static explicit operator ItemsKindsListCatalogResponseRowsItemSaftType(string value) =>
        new(value);

    internal class ItemsKindsListCatalogResponseRowsItemSaftTypeSerializer
        : JsonConverter<ItemsKindsListCatalogResponseRowsItemSaftType>
    {
        public override ItemsKindsListCatalogResponseRowsItemSaftType Read(
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
            return new ItemsKindsListCatalogResponseRowsItemSaftType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItemsKindsListCatalogResponseRowsItemSaftType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItemsKindsListCatalogResponseRowsItemSaftType ReadAsPropertyName(
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
            return new ItemsKindsListCatalogResponseRowsItemSaftType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItemsKindsListCatalogResponseRowsItemSaftType value,
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
        public const string Goods = "goods";

        public const string Service = "service";

        public const string FixedAsset = "fixed_asset";

        public const string Other = "other";
    }
}
