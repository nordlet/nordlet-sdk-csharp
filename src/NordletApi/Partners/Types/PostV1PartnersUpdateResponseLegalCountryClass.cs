using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersUpdateResponseLegalCountryClass.PostV1PartnersUpdateResponseLegalCountryClassSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersUpdateResponseLegalCountryClass : IStringEnum
{
    public static readonly PostV1PartnersUpdateResponseLegalCountryClass Lt = new(Values.Lt);

    public static readonly PostV1PartnersUpdateResponseLegalCountryClass Eu = new(Values.Eu);

    public static readonly PostV1PartnersUpdateResponseLegalCountryClass NonEu = new(Values.NonEu);

    public PostV1PartnersUpdateResponseLegalCountryClass(string value)
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
    public static PostV1PartnersUpdateResponseLegalCountryClass FromCustom(string value)
    {
        return new PostV1PartnersUpdateResponseLegalCountryClass(value);
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
        PostV1PartnersUpdateResponseLegalCountryClass value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersUpdateResponseLegalCountryClass value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersUpdateResponseLegalCountryClass value) =>
        value.Value;

    public static explicit operator PostV1PartnersUpdateResponseLegalCountryClass(string value) =>
        new(value);

    internal class PostV1PartnersUpdateResponseLegalCountryClassSerializer
        : JsonConverter<PostV1PartnersUpdateResponseLegalCountryClass>
    {
        public override PostV1PartnersUpdateResponseLegalCountryClass Read(
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
            return new PostV1PartnersUpdateResponseLegalCountryClass(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersUpdateResponseLegalCountryClass value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersUpdateResponseLegalCountryClass ReadAsPropertyName(
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
            return new PostV1PartnersUpdateResponseLegalCountryClass(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersUpdateResponseLegalCountryClass value,
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
