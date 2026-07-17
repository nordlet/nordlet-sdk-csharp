using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankSettlementsPostResponseStatus.PostV1BankSettlementsPostResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1BankSettlementsPostResponseStatus : IStringEnum
{
    public static readonly PostV1BankSettlementsPostResponseStatus Imported = new(Values.Imported);

    public static readonly PostV1BankSettlementsPostResponseStatus Posted = new(Values.Posted);

    public PostV1BankSettlementsPostResponseStatus(string value)
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
    public static PostV1BankSettlementsPostResponseStatus FromCustom(string value)
    {
        return new PostV1BankSettlementsPostResponseStatus(value);
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

    public static bool operator ==(PostV1BankSettlementsPostResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1BankSettlementsPostResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankSettlementsPostResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1BankSettlementsPostResponseStatus(string value) =>
        new(value);

    internal class PostV1BankSettlementsPostResponseStatusSerializer
        : JsonConverter<PostV1BankSettlementsPostResponseStatus>
    {
        public override PostV1BankSettlementsPostResponseStatus Read(
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
            return new PostV1BankSettlementsPostResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankSettlementsPostResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankSettlementsPostResponseStatus ReadAsPropertyName(
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
            return new PostV1BankSettlementsPostResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankSettlementsPostResponseStatus value,
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
