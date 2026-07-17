using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CatalogItemsUpdateResponseType.PostV1CatalogItemsUpdateResponseTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1CatalogItemsUpdateResponseType : IStringEnum
{
    public static readonly PostV1CatalogItemsUpdateResponseType Product = new(Values.Product);

    public static readonly PostV1CatalogItemsUpdateResponseType Service = new(Values.Service);

    public static readonly PostV1CatalogItemsUpdateResponseType Set = new(Values.Set);

    public PostV1CatalogItemsUpdateResponseType(string value)
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
    public static PostV1CatalogItemsUpdateResponseType FromCustom(string value)
    {
        return new PostV1CatalogItemsUpdateResponseType(value);
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

    public static bool operator ==(PostV1CatalogItemsUpdateResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1CatalogItemsUpdateResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CatalogItemsUpdateResponseType value) =>
        value.Value;

    public static explicit operator PostV1CatalogItemsUpdateResponseType(string value) =>
        new(value);

    internal class PostV1CatalogItemsUpdateResponseTypeSerializer
        : JsonConverter<PostV1CatalogItemsUpdateResponseType>
    {
        public override PostV1CatalogItemsUpdateResponseType Read(
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
            return new PostV1CatalogItemsUpdateResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CatalogItemsUpdateResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CatalogItemsUpdateResponseType ReadAsPropertyName(
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
            return new PostV1CatalogItemsUpdateResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CatalogItemsUpdateResponseType value,
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
