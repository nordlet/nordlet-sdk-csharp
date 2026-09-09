using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersFindOrCreateRequestLegalCountryClass.PostV1PartnersFindOrCreateRequestLegalCountryClassSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersFindOrCreateRequestLegalCountryClass : IStringEnum
{
    public static readonly PostV1PartnersFindOrCreateRequestLegalCountryClass Lt = new(Values.Lt);

    public static readonly PostV1PartnersFindOrCreateRequestLegalCountryClass Eu = new(Values.Eu);

    public static readonly PostV1PartnersFindOrCreateRequestLegalCountryClass NonEu = new(
        Values.NonEu
    );

    public PostV1PartnersFindOrCreateRequestLegalCountryClass(string value)
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
    public static PostV1PartnersFindOrCreateRequestLegalCountryClass FromCustom(string value)
    {
        return new PostV1PartnersFindOrCreateRequestLegalCountryClass(value);
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
        PostV1PartnersFindOrCreateRequestLegalCountryClass value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersFindOrCreateRequestLegalCountryClass value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1PartnersFindOrCreateRequestLegalCountryClass value
    ) => value.Value;

    public static explicit operator PostV1PartnersFindOrCreateRequestLegalCountryClass(
        string value
    ) => new(value);

    internal class PostV1PartnersFindOrCreateRequestLegalCountryClassSerializer
        : JsonConverter<PostV1PartnersFindOrCreateRequestLegalCountryClass>
    {
        public override PostV1PartnersFindOrCreateRequestLegalCountryClass Read(
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
            return new PostV1PartnersFindOrCreateRequestLegalCountryClass(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersFindOrCreateRequestLegalCountryClass value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersFindOrCreateRequestLegalCountryClass ReadAsPropertyName(
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
            return new PostV1PartnersFindOrCreateRequestLegalCountryClass(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersFindOrCreateRequestLegalCountryClass value,
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
