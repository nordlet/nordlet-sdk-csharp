using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PostV1SalesActsPdfRequestLocale.PostV1SalesActsPdfRequestLocaleSerializer))]
[Serializable]
public readonly record struct PostV1SalesActsPdfRequestLocale : IStringEnum
{
    public static readonly PostV1SalesActsPdfRequestLocale Lt = new(Values.Lt);

    public static readonly PostV1SalesActsPdfRequestLocale En = new(Values.En);

    public static readonly PostV1SalesActsPdfRequestLocale Ru = new(Values.Ru);

    public PostV1SalesActsPdfRequestLocale(string value)
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
    public static PostV1SalesActsPdfRequestLocale FromCustom(string value)
    {
        return new PostV1SalesActsPdfRequestLocale(value);
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

    public static bool operator ==(PostV1SalesActsPdfRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1SalesActsPdfRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesActsPdfRequestLocale value) => value.Value;

    public static explicit operator PostV1SalesActsPdfRequestLocale(string value) => new(value);

    internal class PostV1SalesActsPdfRequestLocaleSerializer
        : JsonConverter<PostV1SalesActsPdfRequestLocale>
    {
        public override PostV1SalesActsPdfRequestLocale Read(
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
            return new PostV1SalesActsPdfRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesActsPdfRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesActsPdfRequestLocale ReadAsPropertyName(
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
            return new PostV1SalesActsPdfRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesActsPdfRequestLocale value,
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
        public const string Lt = "lt";

        public const string En = "en";

        public const string Ru = "ru";
    }
}
