using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CatalogItemsListResponseRowsItemTracking.PostV1CatalogItemsListResponseRowsItemTrackingSerializer)
)]
[Serializable]
public readonly record struct PostV1CatalogItemsListResponseRowsItemTracking : IStringEnum
{
    public static readonly PostV1CatalogItemsListResponseRowsItemTracking None = new(Values.None);

    public static readonly PostV1CatalogItemsListResponseRowsItemTracking Lot = new(Values.Lot);

    public static readonly PostV1CatalogItemsListResponseRowsItemTracking Serial = new(
        Values.Serial
    );

    public PostV1CatalogItemsListResponseRowsItemTracking(string value)
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
    public static PostV1CatalogItemsListResponseRowsItemTracking FromCustom(string value)
    {
        return new PostV1CatalogItemsListResponseRowsItemTracking(value);
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
        PostV1CatalogItemsListResponseRowsItemTracking value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1CatalogItemsListResponseRowsItemTracking value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CatalogItemsListResponseRowsItemTracking value) =>
        value.Value;

    public static explicit operator PostV1CatalogItemsListResponseRowsItemTracking(string value) =>
        new(value);

    internal class PostV1CatalogItemsListResponseRowsItemTrackingSerializer
        : JsonConverter<PostV1CatalogItemsListResponseRowsItemTracking>
    {
        public override PostV1CatalogItemsListResponseRowsItemTracking Read(
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
            return new PostV1CatalogItemsListResponseRowsItemTracking(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CatalogItemsListResponseRowsItemTracking value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CatalogItemsListResponseRowsItemTracking ReadAsPropertyName(
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
            return new PostV1CatalogItemsListResponseRowsItemTracking(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CatalogItemsListResponseRowsItemTracking value,
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
        public const string None = "none";

        public const string Lot = "lot";

        public const string Serial = "serial";
    }
}
