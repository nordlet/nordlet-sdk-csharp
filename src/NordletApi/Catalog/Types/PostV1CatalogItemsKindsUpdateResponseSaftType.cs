using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CatalogItemsKindsUpdateResponseSaftType.PostV1CatalogItemsKindsUpdateResponseSaftTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1CatalogItemsKindsUpdateResponseSaftType : IStringEnum
{
    public static readonly PostV1CatalogItemsKindsUpdateResponseSaftType Goods = new(Values.Goods);

    public static readonly PostV1CatalogItemsKindsUpdateResponseSaftType Service = new(
        Values.Service
    );

    public static readonly PostV1CatalogItemsKindsUpdateResponseSaftType FixedAsset = new(
        Values.FixedAsset
    );

    public static readonly PostV1CatalogItemsKindsUpdateResponseSaftType Other = new(Values.Other);

    public PostV1CatalogItemsKindsUpdateResponseSaftType(string value)
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
    public static PostV1CatalogItemsKindsUpdateResponseSaftType FromCustom(string value)
    {
        return new PostV1CatalogItemsKindsUpdateResponseSaftType(value);
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
        PostV1CatalogItemsKindsUpdateResponseSaftType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1CatalogItemsKindsUpdateResponseSaftType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CatalogItemsKindsUpdateResponseSaftType value) =>
        value.Value;

    public static explicit operator PostV1CatalogItemsKindsUpdateResponseSaftType(string value) =>
        new(value);

    internal class PostV1CatalogItemsKindsUpdateResponseSaftTypeSerializer
        : JsonConverter<PostV1CatalogItemsKindsUpdateResponseSaftType>
    {
        public override PostV1CatalogItemsKindsUpdateResponseSaftType Read(
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
            return new PostV1CatalogItemsKindsUpdateResponseSaftType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CatalogItemsKindsUpdateResponseSaftType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CatalogItemsKindsUpdateResponseSaftType ReadAsPropertyName(
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
            return new PostV1CatalogItemsKindsUpdateResponseSaftType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CatalogItemsKindsUpdateResponseSaftType value,
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
