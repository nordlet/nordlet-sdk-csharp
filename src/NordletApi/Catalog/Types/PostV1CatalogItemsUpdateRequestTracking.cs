using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CatalogItemsUpdateRequestTracking.PostV1CatalogItemsUpdateRequestTrackingSerializer)
)]
[Serializable]
public readonly record struct PostV1CatalogItemsUpdateRequestTracking : IStringEnum
{
    public static readonly PostV1CatalogItemsUpdateRequestTracking None = new(Values.None);

    public static readonly PostV1CatalogItemsUpdateRequestTracking Lot = new(Values.Lot);

    public static readonly PostV1CatalogItemsUpdateRequestTracking Serial = new(Values.Serial);

    public PostV1CatalogItemsUpdateRequestTracking(string value)
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
    public static PostV1CatalogItemsUpdateRequestTracking FromCustom(string value)
    {
        return new PostV1CatalogItemsUpdateRequestTracking(value);
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

    public static bool operator ==(PostV1CatalogItemsUpdateRequestTracking value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1CatalogItemsUpdateRequestTracking value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CatalogItemsUpdateRequestTracking value) =>
        value.Value;

    public static explicit operator PostV1CatalogItemsUpdateRequestTracking(string value) =>
        new(value);

    internal class PostV1CatalogItemsUpdateRequestTrackingSerializer
        : JsonConverter<PostV1CatalogItemsUpdateRequestTracking>
    {
        public override PostV1CatalogItemsUpdateRequestTracking Read(
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
            return new PostV1CatalogItemsUpdateRequestTracking(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CatalogItemsUpdateRequestTracking value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CatalogItemsUpdateRequestTracking ReadAsPropertyName(
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
            return new PostV1CatalogItemsUpdateRequestTracking(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CatalogItemsUpdateRequestTracking value,
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
