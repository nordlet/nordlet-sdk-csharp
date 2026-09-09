using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CatalogItemsKindsCreateResponseSaftType.PostV1CatalogItemsKindsCreateResponseSaftTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1CatalogItemsKindsCreateResponseSaftType : IStringEnum
{
    public static readonly PostV1CatalogItemsKindsCreateResponseSaftType Goods = new(Values.Goods);

    public static readonly PostV1CatalogItemsKindsCreateResponseSaftType Service = new(
        Values.Service
    );

    public static readonly PostV1CatalogItemsKindsCreateResponseSaftType FixedAsset = new(
        Values.FixedAsset
    );

    public static readonly PostV1CatalogItemsKindsCreateResponseSaftType Other = new(Values.Other);

    public PostV1CatalogItemsKindsCreateResponseSaftType(string value)
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
    public static PostV1CatalogItemsKindsCreateResponseSaftType FromCustom(string value)
    {
        return new PostV1CatalogItemsKindsCreateResponseSaftType(value);
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
        PostV1CatalogItemsKindsCreateResponseSaftType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1CatalogItemsKindsCreateResponseSaftType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CatalogItemsKindsCreateResponseSaftType value) =>
        value.Value;

    public static explicit operator PostV1CatalogItemsKindsCreateResponseSaftType(string value) =>
        new(value);

    internal class PostV1CatalogItemsKindsCreateResponseSaftTypeSerializer
        : JsonConverter<PostV1CatalogItemsKindsCreateResponseSaftType>
    {
        public override PostV1CatalogItemsKindsCreateResponseSaftType Read(
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
            return new PostV1CatalogItemsKindsCreateResponseSaftType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CatalogItemsKindsCreateResponseSaftType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CatalogItemsKindsCreateResponseSaftType ReadAsPropertyName(
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
            return new PostV1CatalogItemsKindsCreateResponseSaftType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CatalogItemsKindsCreateResponseSaftType value,
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
