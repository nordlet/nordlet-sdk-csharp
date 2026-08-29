using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CatalogItemsUpdateResponseTracking.PostV1CatalogItemsUpdateResponseTrackingSerializer)
)]
[Serializable]
public readonly record struct PostV1CatalogItemsUpdateResponseTracking : IStringEnum
{
    public static readonly PostV1CatalogItemsUpdateResponseTracking None = new(Values.None);

    public static readonly PostV1CatalogItemsUpdateResponseTracking Lot = new(Values.Lot);

    public static readonly PostV1CatalogItemsUpdateResponseTracking Serial = new(Values.Serial);

    public PostV1CatalogItemsUpdateResponseTracking(string value)
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
    public static PostV1CatalogItemsUpdateResponseTracking FromCustom(string value)
    {
        return new PostV1CatalogItemsUpdateResponseTracking(value);
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
        PostV1CatalogItemsUpdateResponseTracking value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1CatalogItemsUpdateResponseTracking value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CatalogItemsUpdateResponseTracking value) =>
        value.Value;

    public static explicit operator PostV1CatalogItemsUpdateResponseTracking(string value) =>
        new(value);

    internal class PostV1CatalogItemsUpdateResponseTrackingSerializer
        : JsonConverter<PostV1CatalogItemsUpdateResponseTracking>
    {
        public override PostV1CatalogItemsUpdateResponseTracking Read(
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
            return new PostV1CatalogItemsUpdateResponseTracking(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CatalogItemsUpdateResponseTracking value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CatalogItemsUpdateResponseTracking ReadAsPropertyName(
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
            return new PostV1CatalogItemsUpdateResponseTracking(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CatalogItemsUpdateResponseTracking value,
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
