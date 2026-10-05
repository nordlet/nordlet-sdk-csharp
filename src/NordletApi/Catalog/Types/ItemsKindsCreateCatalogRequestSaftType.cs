using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ItemsKindsCreateCatalogRequestSaftType.ItemsKindsCreateCatalogRequestSaftTypeSerializer)
)]
[Serializable]
public readonly record struct ItemsKindsCreateCatalogRequestSaftType : IStringEnum
{
    public static readonly ItemsKindsCreateCatalogRequestSaftType Goods = new(Values.Goods);

    public static readonly ItemsKindsCreateCatalogRequestSaftType Service = new(Values.Service);

    public static readonly ItemsKindsCreateCatalogRequestSaftType FixedAsset = new(
        Values.FixedAsset
    );

    public static readonly ItemsKindsCreateCatalogRequestSaftType Other = new(Values.Other);

    public ItemsKindsCreateCatalogRequestSaftType(string value)
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
    public static ItemsKindsCreateCatalogRequestSaftType FromCustom(string value)
    {
        return new ItemsKindsCreateCatalogRequestSaftType(value);
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

    public static bool operator ==(ItemsKindsCreateCatalogRequestSaftType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsKindsCreateCatalogRequestSaftType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsKindsCreateCatalogRequestSaftType value) =>
        value.Value;

    public static explicit operator ItemsKindsCreateCatalogRequestSaftType(string value) =>
        new(value);

    internal class ItemsKindsCreateCatalogRequestSaftTypeSerializer
        : JsonConverter<ItemsKindsCreateCatalogRequestSaftType>
    {
        public override ItemsKindsCreateCatalogRequestSaftType Read(
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
            return new ItemsKindsCreateCatalogRequestSaftType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItemsKindsCreateCatalogRequestSaftType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItemsKindsCreateCatalogRequestSaftType ReadAsPropertyName(
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
            return new ItemsKindsCreateCatalogRequestSaftType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItemsKindsCreateCatalogRequestSaftType value,
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
