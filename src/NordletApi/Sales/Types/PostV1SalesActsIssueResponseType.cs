using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PostV1SalesActsIssueResponseType.PostV1SalesActsIssueResponseTypeSerializer))]
[Serializable]
public readonly record struct PostV1SalesActsIssueResponseType : IStringEnum
{
    public static readonly PostV1SalesActsIssueResponseType Goods = new(Values.Goods);

    public static readonly PostV1SalesActsIssueResponseType Services = new(Values.Services);

    public PostV1SalesActsIssueResponseType(string value)
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
    public static PostV1SalesActsIssueResponseType FromCustom(string value)
    {
        return new PostV1SalesActsIssueResponseType(value);
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

    public static bool operator ==(PostV1SalesActsIssueResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1SalesActsIssueResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesActsIssueResponseType value) => value.Value;

    public static explicit operator PostV1SalesActsIssueResponseType(string value) => new(value);

    internal class PostV1SalesActsIssueResponseTypeSerializer
        : JsonConverter<PostV1SalesActsIssueResponseType>
    {
        public override PostV1SalesActsIssueResponseType Read(
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
            return new PostV1SalesActsIssueResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesActsIssueResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesActsIssueResponseType ReadAsPropertyName(
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
            return new PostV1SalesActsIssueResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesActsIssueResponseType value,
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
