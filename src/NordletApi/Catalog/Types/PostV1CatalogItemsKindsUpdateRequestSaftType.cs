using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CatalogItemsKindsUpdateRequestSaftType.PostV1CatalogItemsKindsUpdateRequestSaftTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1CatalogItemsKindsUpdateRequestSaftType : IStringEnum
{
    public static readonly PostV1CatalogItemsKindsUpdateRequestSaftType Goods = new(Values.Goods);

    public static readonly PostV1CatalogItemsKindsUpdateRequestSaftType Service = new(
        Values.Service
    );

    public static readonly PostV1CatalogItemsKindsUpdateRequestSaftType FixedAsset = new(
        Values.FixedAsset
    );

    public static readonly PostV1CatalogItemsKindsUpdateRequestSaftType Other = new(Values.Other);

    public PostV1CatalogItemsKindsUpdateRequestSaftType(string value)
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
    public static PostV1CatalogItemsKindsUpdateRequestSaftType FromCustom(string value)
    {
        return new PostV1CatalogItemsKindsUpdateRequestSaftType(value);
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
        PostV1CatalogItemsKindsUpdateRequestSaftType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1CatalogItemsKindsUpdateRequestSaftType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CatalogItemsKindsUpdateRequestSaftType value) =>
        value.Value;

    public static explicit operator PostV1CatalogItemsKindsUpdateRequestSaftType(string value) =>
        new(value);

    internal class PostV1CatalogItemsKindsUpdateRequestSaftTypeSerializer
        : JsonConverter<PostV1CatalogItemsKindsUpdateRequestSaftType>
    {
        public override PostV1CatalogItemsKindsUpdateRequestSaftType Read(
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
            return new PostV1CatalogItemsKindsUpdateRequestSaftType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CatalogItemsKindsUpdateRequestSaftType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CatalogItemsKindsUpdateRequestSaftType ReadAsPropertyName(
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
            return new PostV1CatalogItemsKindsUpdateRequestSaftType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CatalogItemsKindsUpdateRequestSaftType value,
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
