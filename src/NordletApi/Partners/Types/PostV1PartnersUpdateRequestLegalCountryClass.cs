using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersUpdateRequestLegalCountryClass.PostV1PartnersUpdateRequestLegalCountryClassSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersUpdateRequestLegalCountryClass : IStringEnum
{
    public static readonly PostV1PartnersUpdateRequestLegalCountryClass Lt = new(Values.Lt);

    public static readonly PostV1PartnersUpdateRequestLegalCountryClass Eu = new(Values.Eu);

    public static readonly PostV1PartnersUpdateRequestLegalCountryClass NonEu = new(Values.NonEu);

    public PostV1PartnersUpdateRequestLegalCountryClass(string value)
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
    public static PostV1PartnersUpdateRequestLegalCountryClass FromCustom(string value)
    {
        return new PostV1PartnersUpdateRequestLegalCountryClass(value);
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

    public static bool operator ==(
        PostV1PartnersUpdateRequestLegalCountryClass value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersUpdateRequestLegalCountryClass value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersUpdateRequestLegalCountryClass value) =>
        value.Value;

    public static explicit operator PostV1PartnersUpdateRequestLegalCountryClass(string value) =>
        new(value);

    internal class PostV1PartnersUpdateRequestLegalCountryClassSerializer
        : JsonConverter<PostV1PartnersUpdateRequestLegalCountryClass>
    {
        public override PostV1PartnersUpdateRequestLegalCountryClass Read(
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
            return new PostV1PartnersUpdateRequestLegalCountryClass(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersUpdateRequestLegalCountryClass value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersUpdateRequestLegalCountryClass ReadAsPropertyName(
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
            return new PostV1PartnersUpdateRequestLegalCountryClass(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersUpdateRequestLegalCountryClass value,
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

        public const string Eu = "eu";

        public const string NonEu = "non_eu";
    }
}
