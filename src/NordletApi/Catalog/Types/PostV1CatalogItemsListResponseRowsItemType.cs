using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CatalogItemsListResponseRowsItemType.PostV1CatalogItemsListResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1CatalogItemsListResponseRowsItemType : IStringEnum
{
    public static readonly PostV1CatalogItemsListResponseRowsItemType Product = new(Values.Product);

    public static readonly PostV1CatalogItemsListResponseRowsItemType Service = new(Values.Service);

    public static readonly PostV1CatalogItemsListResponseRowsItemType Set = new(Values.Set);

    public PostV1CatalogItemsListResponseRowsItemType(string value)
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
    public static PostV1CatalogItemsListResponseRowsItemType FromCustom(string value)
    {
        return new PostV1CatalogItemsListResponseRowsItemType(value);
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
        PostV1CatalogItemsListResponseRowsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1CatalogItemsListResponseRowsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CatalogItemsListResponseRowsItemType value) =>
        value.Value;

    public static explicit operator PostV1CatalogItemsListResponseRowsItemType(string value) =>
        new(value);

    internal class PostV1CatalogItemsListResponseRowsItemTypeSerializer
        : JsonConverter<PostV1CatalogItemsListResponseRowsItemType>
    {
        public override PostV1CatalogItemsListResponseRowsItemType Read(
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
            return new PostV1CatalogItemsListResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CatalogItemsListResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CatalogItemsListResponseRowsItemType ReadAsPropertyName(
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
            return new PostV1CatalogItemsListResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CatalogItemsListResponseRowsItemType value,
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
