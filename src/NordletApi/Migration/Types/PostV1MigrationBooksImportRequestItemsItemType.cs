using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1MigrationBooksImportRequestItemsItemType.PostV1MigrationBooksImportRequestItemsItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1MigrationBooksImportRequestItemsItemType : IStringEnum
{
    public static readonly PostV1MigrationBooksImportRequestItemsItemType Product = new(
        Values.Product
    );

    public static readonly PostV1MigrationBooksImportRequestItemsItemType Service = new(
        Values.Service
    );

    public PostV1MigrationBooksImportRequestItemsItemType(string value)
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
    public static PostV1MigrationBooksImportRequestItemsItemType FromCustom(string value)
    {
        return new PostV1MigrationBooksImportRequestItemsItemType(value);
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
        PostV1MigrationBooksImportRequestItemsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1MigrationBooksImportRequestItemsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1MigrationBooksImportRequestItemsItemType value) =>
        value.Value;

    public static explicit operator PostV1MigrationBooksImportRequestItemsItemType(string value) =>
        new(value);

    internal class PostV1MigrationBooksImportRequestItemsItemTypeSerializer
        : JsonConverter<PostV1MigrationBooksImportRequestItemsItemType>
    {
        public override PostV1MigrationBooksImportRequestItemsItemType Read(
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
            return new PostV1MigrationBooksImportRequestItemsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1MigrationBooksImportRequestItemsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1MigrationBooksImportRequestItemsItemType ReadAsPropertyName(
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
            return new PostV1MigrationBooksImportRequestItemsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1MigrationBooksImportRequestItemsItemType value,
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
    }
}
