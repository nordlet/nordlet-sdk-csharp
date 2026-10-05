using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ItemsKindsCreateCatalogResponseSaftType.ItemsKindsCreateCatalogResponseSaftTypeSerializer)
)]
[Serializable]
public readonly record struct ItemsKindsCreateCatalogResponseSaftType : IStringEnum
{
    public static readonly ItemsKindsCreateCatalogResponseSaftType Goods = new(Values.Goods);

    public static readonly ItemsKindsCreateCatalogResponseSaftType Service = new(Values.Service);

    public static readonly ItemsKindsCreateCatalogResponseSaftType FixedAsset = new(
        Values.FixedAsset
    );

    public static readonly ItemsKindsCreateCatalogResponseSaftType Other = new(Values.Other);

    public ItemsKindsCreateCatalogResponseSaftType(string value)
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
    public static ItemsKindsCreateCatalogResponseSaftType FromCustom(string value)
    {
        return new ItemsKindsCreateCatalogResponseSaftType(value);
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

    public static bool operator ==(ItemsKindsCreateCatalogResponseSaftType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsKindsCreateCatalogResponseSaftType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsKindsCreateCatalogResponseSaftType value) =>
        value.Value;

    public static explicit operator ItemsKindsCreateCatalogResponseSaftType(string value) =>
        new(value);

    internal class ItemsKindsCreateCatalogResponseSaftTypeSerializer
        : JsonConverter<ItemsKindsCreateCatalogResponseSaftType>
    {
        public override ItemsKindsCreateCatalogResponseSaftType Read(
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
            return new ItemsKindsCreateCatalogResponseSaftType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItemsKindsCreateCatalogResponseSaftType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItemsKindsCreateCatalogResponseSaftType ReadAsPropertyName(
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
            return new ItemsKindsCreateCatalogResponseSaftType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItemsKindsCreateCatalogResponseSaftType value,
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
