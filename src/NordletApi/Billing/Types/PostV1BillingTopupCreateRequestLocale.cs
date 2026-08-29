using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BillingTopupCreateRequestLocale.PostV1BillingTopupCreateRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct PostV1BillingTopupCreateRequestLocale : IStringEnum
{
    public static readonly PostV1BillingTopupCreateRequestLocale Lt = new(Values.Lt);

    public static readonly PostV1BillingTopupCreateRequestLocale En = new(Values.En);

    public static readonly PostV1BillingTopupCreateRequestLocale Ru = new(Values.Ru);

    public PostV1BillingTopupCreateRequestLocale(string value)
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
    public static PostV1BillingTopupCreateRequestLocale FromCustom(string value)
    {
        return new PostV1BillingTopupCreateRequestLocale(value);
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

    public static bool operator ==(PostV1BillingTopupCreateRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1BillingTopupCreateRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BillingTopupCreateRequestLocale value) =>
        value.Value;

    public static explicit operator PostV1BillingTopupCreateRequestLocale(string value) =>
        new(value);

    internal class PostV1BillingTopupCreateRequestLocaleSerializer
        : JsonConverter<PostV1BillingTopupCreateRequestLocale>
    {
        public override PostV1BillingTopupCreateRequestLocale Read(
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
            return new PostV1BillingTopupCreateRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BillingTopupCreateRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BillingTopupCreateRequestLocale ReadAsPropertyName(
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
            return new PostV1BillingTopupCreateRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BillingTopupCreateRequestLocale value,
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
