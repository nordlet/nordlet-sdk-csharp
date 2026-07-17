using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PostV1PartnersCreateResponseType.PostV1PartnersCreateResponseTypeSerializer))]
[Serializable]
public readonly record struct PostV1PartnersCreateResponseType : IStringEnum
{
    public static readonly PostV1PartnersCreateResponseType Company = new(Values.Company);

    public static readonly PostV1PartnersCreateResponseType Person = new(Values.Person);

    public PostV1PartnersCreateResponseType(string value)
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
    public static PostV1PartnersCreateResponseType FromCustom(string value)
    {
        return new PostV1PartnersCreateResponseType(value);
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

    public static bool operator ==(PostV1PartnersCreateResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1PartnersCreateResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersCreateResponseType value) => value.Value;

    public static explicit operator PostV1PartnersCreateResponseType(string value) => new(value);

    internal class PostV1PartnersCreateResponseTypeSerializer
        : JsonConverter<PostV1PartnersCreateResponseType>
    {
        public override PostV1PartnersCreateResponseType Read(
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
            return new PostV1PartnersCreateResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersCreateResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersCreateResponseType ReadAsPropertyName(
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
            return new PostV1PartnersCreateResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersCreateResponseType value,
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
        public const string Company = "company";

        public const string Person = "person";
    }
}
