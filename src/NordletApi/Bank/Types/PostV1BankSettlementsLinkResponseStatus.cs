using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankSettlementsLinkResponseStatus.PostV1BankSettlementsLinkResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1BankSettlementsLinkResponseStatus : IStringEnum
{
    public static readonly PostV1BankSettlementsLinkResponseStatus Imported = new(Values.Imported);

    public static readonly PostV1BankSettlementsLinkResponseStatus Posted = new(Values.Posted);

    public PostV1BankSettlementsLinkResponseStatus(string value)
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
    public static PostV1BankSettlementsLinkResponseStatus FromCustom(string value)
    {
        return new PostV1BankSettlementsLinkResponseStatus(value);
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

    public static bool operator ==(PostV1BankSettlementsLinkResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1BankSettlementsLinkResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankSettlementsLinkResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1BankSettlementsLinkResponseStatus(string value) =>
        new(value);

    internal class PostV1BankSettlementsLinkResponseStatusSerializer
        : JsonConverter<PostV1BankSettlementsLinkResponseStatus>
    {
        public override PostV1BankSettlementsLinkResponseStatus Read(
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
            return new PostV1BankSettlementsLinkResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankSettlementsLinkResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankSettlementsLinkResponseStatus ReadAsPropertyName(
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
            return new PostV1BankSettlementsLinkResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankSettlementsLinkResponseStatus value,
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
        public const string Imported = "imported";

        public const string Posted = "posted";
    }
}
