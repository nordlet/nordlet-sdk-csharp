using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CatalogItemsGetResponseTracking.PostV1CatalogItemsGetResponseTrackingSerializer)
)]
[Serializable]
public readonly record struct PostV1CatalogItemsGetResponseTracking : IStringEnum
{
    public static readonly PostV1CatalogItemsGetResponseTracking None = new(Values.None);

    public static readonly PostV1CatalogItemsGetResponseTracking Lot = new(Values.Lot);

    public static readonly PostV1CatalogItemsGetResponseTracking Serial = new(Values.Serial);

    public PostV1CatalogItemsGetResponseTracking(string value)
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
    public static PostV1CatalogItemsGetResponseTracking FromCustom(string value)
    {
        return new PostV1CatalogItemsGetResponseTracking(value);
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

    public static bool operator ==(PostV1CatalogItemsGetResponseTracking value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1CatalogItemsGetResponseTracking value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CatalogItemsGetResponseTracking value) =>
        value.Value;

    public static explicit operator PostV1CatalogItemsGetResponseTracking(string value) =>
        new(value);

    internal class PostV1CatalogItemsGetResponseTrackingSerializer
        : JsonConverter<PostV1CatalogItemsGetResponseTracking>
    {
        public override PostV1CatalogItemsGetResponseTracking Read(
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
            return new PostV1CatalogItemsGetResponseTracking(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CatalogItemsGetResponseTracking value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CatalogItemsGetResponseTracking ReadAsPropertyName(
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
            return new PostV1CatalogItemsGetResponseTracking(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CatalogItemsGetResponseTracking value,
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
