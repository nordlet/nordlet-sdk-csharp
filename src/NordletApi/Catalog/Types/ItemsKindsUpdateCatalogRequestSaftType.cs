using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ItemsKindsUpdateCatalogRequestSaftType.ItemsKindsUpdateCatalogRequestSaftTypeSerializer)
)]
[Serializable]
public readonly record struct ItemsKindsUpdateCatalogRequestSaftType : IStringEnum
{
    public static readonly ItemsKindsUpdateCatalogRequestSaftType Goods = new(Values.Goods);

    public static readonly ItemsKindsUpdateCatalogRequestSaftType Service = new(Values.Service);

    public static readonly ItemsKindsUpdateCatalogRequestSaftType FixedAsset = new(
        Values.FixedAsset
    );

    public static readonly ItemsKindsUpdateCatalogRequestSaftType Other = new(Values.Other);

    public ItemsKindsUpdateCatalogRequestSaftType(string value)
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
    public static ItemsKindsUpdateCatalogRequestSaftType FromCustom(string value)
    {
        return new ItemsKindsUpdateCatalogRequestSaftType(value);
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

    public static bool operator ==(ItemsKindsUpdateCatalogRequestSaftType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsKindsUpdateCatalogRequestSaftType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsKindsUpdateCatalogRequestSaftType value) =>
        value.Value;

    public static explicit operator ItemsKindsUpdateCatalogRequestSaftType(string value) =>
        new(value);

    internal class ItemsKindsUpdateCatalogRequestSaftTypeSerializer
        : JsonConverter<ItemsKindsUpdateCatalogRequestSaftType>
    {
        public override ItemsKindsUpdateCatalogRequestSaftType Read(
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
            return new ItemsKindsUpdateCatalogRequestSaftType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItemsKindsUpdateCatalogRequestSaftType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItemsKindsUpdateCatalogRequestSaftType ReadAsPropertyName(
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
            return new ItemsKindsUpdateCatalogRequestSaftType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItemsKindsUpdateCatalogRequestSaftType value,
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
