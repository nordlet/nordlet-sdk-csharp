using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CatalogItemsCreateRequestTracking.PostV1CatalogItemsCreateRequestTrackingSerializer)
)]
[Serializable]
public readonly record struct PostV1CatalogItemsCreateRequestTracking : IStringEnum
{
    public static readonly PostV1CatalogItemsCreateRequestTracking None = new(Values.None);

    public static readonly PostV1CatalogItemsCreateRequestTracking Lot = new(Values.Lot);

    public static readonly PostV1CatalogItemsCreateRequestTracking Serial = new(Values.Serial);

    public PostV1CatalogItemsCreateRequestTracking(string value)
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
    public static PostV1CatalogItemsCreateRequestTracking FromCustom(string value)
    {
        return new PostV1CatalogItemsCreateRequestTracking(value);
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

    public static bool operator ==(PostV1CatalogItemsCreateRequestTracking value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1CatalogItemsCreateRequestTracking value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CatalogItemsCreateRequestTracking value) =>
        value.Value;

    public static explicit operator PostV1CatalogItemsCreateRequestTracking(string value) =>
        new(value);

    internal class PostV1CatalogItemsCreateRequestTrackingSerializer
        : JsonConverter<PostV1CatalogItemsCreateRequestTracking>
    {
        public override PostV1CatalogItemsCreateRequestTracking Read(
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
            return new PostV1CatalogItemsCreateRequestTracking(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CatalogItemsCreateRequestTracking value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CatalogItemsCreateRequestTracking ReadAsPropertyName(
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
            return new PostV1CatalogItemsCreateRequestTracking(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CatalogItemsCreateRequestTracking value,
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
