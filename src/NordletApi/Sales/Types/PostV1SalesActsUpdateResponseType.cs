using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesActsUpdateResponseType.PostV1SalesActsUpdateResponseTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesActsUpdateResponseType : IStringEnum
{
    public static readonly PostV1SalesActsUpdateResponseType Goods = new(Values.Goods);

    public static readonly PostV1SalesActsUpdateResponseType Services = new(Values.Services);

    public PostV1SalesActsUpdateResponseType(string value)
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
    public static PostV1SalesActsUpdateResponseType FromCustom(string value)
    {
        return new PostV1SalesActsUpdateResponseType(value);
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

    public static bool operator ==(PostV1SalesActsUpdateResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1SalesActsUpdateResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesActsUpdateResponseType value) => value.Value;

    public static explicit operator PostV1SalesActsUpdateResponseType(string value) => new(value);

    internal class PostV1SalesActsUpdateResponseTypeSerializer
        : JsonConverter<PostV1SalesActsUpdateResponseType>
    {
        public override PostV1SalesActsUpdateResponseType Read(
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
            return new PostV1SalesActsUpdateResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesActsUpdateResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesActsUpdateResponseType ReadAsPropertyName(
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
            return new PostV1SalesActsUpdateResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesActsUpdateResponseType value,
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
