using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PostV1SalesActsGetResponseType.PostV1SalesActsGetResponseTypeSerializer))]
[Serializable]
public readonly record struct PostV1SalesActsGetResponseType : IStringEnum
{
    public static readonly PostV1SalesActsGetResponseType Goods = new(Values.Goods);

    public static readonly PostV1SalesActsGetResponseType Services = new(Values.Services);

    public PostV1SalesActsGetResponseType(string value)
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
    public static PostV1SalesActsGetResponseType FromCustom(string value)
    {
        return new PostV1SalesActsGetResponseType(value);
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

    public static bool operator ==(PostV1SalesActsGetResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1SalesActsGetResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesActsGetResponseType value) => value.Value;

    public static explicit operator PostV1SalesActsGetResponseType(string value) => new(value);

    internal class PostV1SalesActsGetResponseTypeSerializer
        : JsonConverter<PostV1SalesActsGetResponseType>
    {
        public override PostV1SalesActsGetResponseType Read(
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
            return new PostV1SalesActsGetResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesActsGetResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesActsGetResponseType ReadAsPropertyName(
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
            return new PostV1SalesActsGetResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesActsGetResponseType value,
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
        public const string Goods = "goods";

        public const string Services = "services";
    }
}
