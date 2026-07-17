using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AccountLocaleSetRequestLocale.PostV1AccountLocaleSetRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct PostV1AccountLocaleSetRequestLocale : IStringEnum
{
    public static readonly PostV1AccountLocaleSetRequestLocale Lt = new(Values.Lt);

    public static readonly PostV1AccountLocaleSetRequestLocale En = new(Values.En);

    public static readonly PostV1AccountLocaleSetRequestLocale Ru = new(Values.Ru);

    public PostV1AccountLocaleSetRequestLocale(string value)
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
    public static PostV1AccountLocaleSetRequestLocale FromCustom(string value)
    {
        return new PostV1AccountLocaleSetRequestLocale(value);
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

    public static bool operator ==(PostV1AccountLocaleSetRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1AccountLocaleSetRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AccountLocaleSetRequestLocale value) =>
        value.Value;

    public static explicit operator PostV1AccountLocaleSetRequestLocale(string value) => new(value);

    internal class PostV1AccountLocaleSetRequestLocaleSerializer
        : JsonConverter<PostV1AccountLocaleSetRequestLocale>
    {
        public override PostV1AccountLocaleSetRequestLocale Read(
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
            return new PostV1AccountLocaleSetRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AccountLocaleSetRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AccountLocaleSetRequestLocale ReadAsPropertyName(
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
            return new PostV1AccountLocaleSetRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AccountLocaleSetRequestLocale value,
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
