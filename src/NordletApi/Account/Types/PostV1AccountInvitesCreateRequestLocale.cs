using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AccountInvitesCreateRequestLocale.PostV1AccountInvitesCreateRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct PostV1AccountInvitesCreateRequestLocale : IStringEnum
{
    public static readonly PostV1AccountInvitesCreateRequestLocale Lt = new(Values.Lt);

    public static readonly PostV1AccountInvitesCreateRequestLocale En = new(Values.En);

    public static readonly PostV1AccountInvitesCreateRequestLocale Ru = new(Values.Ru);

    public PostV1AccountInvitesCreateRequestLocale(string value)
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
    public static PostV1AccountInvitesCreateRequestLocale FromCustom(string value)
    {
        return new PostV1AccountInvitesCreateRequestLocale(value);
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

    public static bool operator ==(PostV1AccountInvitesCreateRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1AccountInvitesCreateRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AccountInvitesCreateRequestLocale value) =>
        value.Value;

    public static explicit operator PostV1AccountInvitesCreateRequestLocale(string value) =>
        new(value);

    internal class PostV1AccountInvitesCreateRequestLocaleSerializer
        : JsonConverter<PostV1AccountInvitesCreateRequestLocale>
    {
        public override PostV1AccountInvitesCreateRequestLocale Read(
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
            return new PostV1AccountInvitesCreateRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AccountInvitesCreateRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AccountInvitesCreateRequestLocale ReadAsPropertyName(
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
            return new PostV1AccountInvitesCreateRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AccountInvitesCreateRequestLocale value,
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
