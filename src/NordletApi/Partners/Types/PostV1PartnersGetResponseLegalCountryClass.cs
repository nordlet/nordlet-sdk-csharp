using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersGetResponseLegalCountryClass.PostV1PartnersGetResponseLegalCountryClassSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersGetResponseLegalCountryClass : IStringEnum
{
    public static readonly PostV1PartnersGetResponseLegalCountryClass Lt = new(Values.Lt);

    public static readonly PostV1PartnersGetResponseLegalCountryClass Eu = new(Values.Eu);

    public static readonly PostV1PartnersGetResponseLegalCountryClass NonEu = new(Values.NonEu);

    public PostV1PartnersGetResponseLegalCountryClass(string value)
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
    public static PostV1PartnersGetResponseLegalCountryClass FromCustom(string value)
    {
        return new PostV1PartnersGetResponseLegalCountryClass(value);
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
        PostV1PartnersGetResponseLegalCountryClass value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersGetResponseLegalCountryClass value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersGetResponseLegalCountryClass value) =>
        value.Value;

    public static explicit operator PostV1PartnersGetResponseLegalCountryClass(string value) =>
        new(value);

    internal class PostV1PartnersGetResponseLegalCountryClassSerializer
        : JsonConverter<PostV1PartnersGetResponseLegalCountryClass>
    {
        public override PostV1PartnersGetResponseLegalCountryClass Read(
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
            return new PostV1PartnersGetResponseLegalCountryClass(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersGetResponseLegalCountryClass value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersGetResponseLegalCountryClass ReadAsPropertyName(
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
            return new PostV1PartnersGetResponseLegalCountryClass(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersGetResponseLegalCountryClass value,
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
