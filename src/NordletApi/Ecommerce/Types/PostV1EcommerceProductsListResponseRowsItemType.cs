using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1EcommerceProductsListResponseRowsItemType.PostV1EcommerceProductsListResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1EcommerceProductsListResponseRowsItemType : IStringEnum
{
    public static readonly PostV1EcommerceProductsListResponseRowsItemType Product = new(
        Values.Product
    );

    public static readonly PostV1EcommerceProductsListResponseRowsItemType Service = new(
        Values.Service
    );

    public static readonly PostV1EcommerceProductsListResponseRowsItemType Set = new(Values.Set);

    public PostV1EcommerceProductsListResponseRowsItemType(string value)
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
    public static PostV1EcommerceProductsListResponseRowsItemType FromCustom(string value)
    {
        return new PostV1EcommerceProductsListResponseRowsItemType(value);
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
        PostV1EcommerceProductsListResponseRowsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1EcommerceProductsListResponseRowsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1EcommerceProductsListResponseRowsItemType value) =>
        value.Value;

    public static explicit operator PostV1EcommerceProductsListResponseRowsItemType(string value) =>
        new(value);

    internal class PostV1EcommerceProductsListResponseRowsItemTypeSerializer
        : JsonConverter<PostV1EcommerceProductsListResponseRowsItemType>
    {
        public override PostV1EcommerceProductsListResponseRowsItemType Read(
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
            return new PostV1EcommerceProductsListResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1EcommerceProductsListResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1EcommerceProductsListResponseRowsItemType ReadAsPropertyName(
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
            return new PostV1EcommerceProductsListResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1EcommerceProductsListResponseRowsItemType value,
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
