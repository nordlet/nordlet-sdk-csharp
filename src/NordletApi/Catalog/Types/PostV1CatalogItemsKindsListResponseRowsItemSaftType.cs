using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CatalogItemsKindsListResponseRowsItemSaftType.PostV1CatalogItemsKindsListResponseRowsItemSaftTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1CatalogItemsKindsListResponseRowsItemSaftType : IStringEnum
{
    public static readonly PostV1CatalogItemsKindsListResponseRowsItemSaftType Goods = new(
        Values.Goods
    );

    public static readonly PostV1CatalogItemsKindsListResponseRowsItemSaftType Service = new(
        Values.Service
    );

    public static readonly PostV1CatalogItemsKindsListResponseRowsItemSaftType FixedAsset = new(
        Values.FixedAsset
    );

    public static readonly PostV1CatalogItemsKindsListResponseRowsItemSaftType Other = new(
        Values.Other
    );

    public PostV1CatalogItemsKindsListResponseRowsItemSaftType(string value)
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
    public static PostV1CatalogItemsKindsListResponseRowsItemSaftType FromCustom(string value)
    {
        return new PostV1CatalogItemsKindsListResponseRowsItemSaftType(value);
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
        PostV1CatalogItemsKindsListResponseRowsItemSaftType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1CatalogItemsKindsListResponseRowsItemSaftType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1CatalogItemsKindsListResponseRowsItemSaftType value
    ) => value.Value;

    public static explicit operator PostV1CatalogItemsKindsListResponseRowsItemSaftType(
        string value
    ) => new(value);

    internal class PostV1CatalogItemsKindsListResponseRowsItemSaftTypeSerializer
        : JsonConverter<PostV1CatalogItemsKindsListResponseRowsItemSaftType>
    {
        public override PostV1CatalogItemsKindsListResponseRowsItemSaftType Read(
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
            return new PostV1CatalogItemsKindsListResponseRowsItemSaftType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CatalogItemsKindsListResponseRowsItemSaftType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CatalogItemsKindsListResponseRowsItemSaftType ReadAsPropertyName(
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
            return new PostV1CatalogItemsKindsListResponseRowsItemSaftType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CatalogItemsKindsListResponseRowsItemSaftType value,
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
