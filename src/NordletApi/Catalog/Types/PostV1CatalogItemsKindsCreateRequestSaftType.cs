using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CatalogItemsKindsCreateRequestSaftType.PostV1CatalogItemsKindsCreateRequestSaftTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1CatalogItemsKindsCreateRequestSaftType : IStringEnum
{
    public static readonly PostV1CatalogItemsKindsCreateRequestSaftType Goods = new(Values.Goods);

    public static readonly PostV1CatalogItemsKindsCreateRequestSaftType Service = new(
        Values.Service
    );

    public static readonly PostV1CatalogItemsKindsCreateRequestSaftType FixedAsset = new(
        Values.FixedAsset
    );

    public static readonly PostV1CatalogItemsKindsCreateRequestSaftType Other = new(Values.Other);

    public PostV1CatalogItemsKindsCreateRequestSaftType(string value)
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
    public static PostV1CatalogItemsKindsCreateRequestSaftType FromCustom(string value)
    {
        return new PostV1CatalogItemsKindsCreateRequestSaftType(value);
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
        PostV1CatalogItemsKindsCreateRequestSaftType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1CatalogItemsKindsCreateRequestSaftType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CatalogItemsKindsCreateRequestSaftType value) =>
        value.Value;

    public static explicit operator PostV1CatalogItemsKindsCreateRequestSaftType(string value) =>
        new(value);

    internal class PostV1CatalogItemsKindsCreateRequestSaftTypeSerializer
        : JsonConverter<PostV1CatalogItemsKindsCreateRequestSaftType>
    {
        public override PostV1CatalogItemsKindsCreateRequestSaftType Read(
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
            return new PostV1CatalogItemsKindsCreateRequestSaftType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CatalogItemsKindsCreateRequestSaftType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CatalogItemsKindsCreateRequestSaftType ReadAsPropertyName(
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
            return new PostV1CatalogItemsKindsCreateRequestSaftType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CatalogItemsKindsCreateRequestSaftType value,
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
