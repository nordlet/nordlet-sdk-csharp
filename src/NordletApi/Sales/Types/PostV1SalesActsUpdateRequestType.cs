using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PostV1SalesActsUpdateRequestType.PostV1SalesActsUpdateRequestTypeSerializer))]
[Serializable]
public readonly record struct PostV1SalesActsUpdateRequestType : IStringEnum
{
    public static readonly PostV1SalesActsUpdateRequestType Goods = new(Values.Goods);

    public static readonly PostV1SalesActsUpdateRequestType Services = new(Values.Services);

    public PostV1SalesActsUpdateRequestType(string value)
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
    public static PostV1SalesActsUpdateRequestType FromCustom(string value)
    {
        return new PostV1SalesActsUpdateRequestType(value);
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

    public static bool operator ==(PostV1SalesActsUpdateRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1SalesActsUpdateRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesActsUpdateRequestType value) => value.Value;

    public static explicit operator PostV1SalesActsUpdateRequestType(string value) => new(value);

    internal class PostV1SalesActsUpdateRequestTypeSerializer
        : JsonConverter<PostV1SalesActsUpdateRequestType>
    {
        public override PostV1SalesActsUpdateRequestType Read(
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
            return new PostV1SalesActsUpdateRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesActsUpdateRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesActsUpdateRequestType ReadAsPropertyName(
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
            return new PostV1SalesActsUpdateRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesActsUpdateRequestType value,
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
