using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CreatePartnersResponseLegalCountryClass.CreatePartnersResponseLegalCountryClassSerializer)
)]
[Serializable]
public readonly record struct CreatePartnersResponseLegalCountryClass : IStringEnum
{
    public static readonly CreatePartnersResponseLegalCountryClass Lt = new(Values.Lt);

    public static readonly CreatePartnersResponseLegalCountryClass Eu = new(Values.Eu);

    public static readonly CreatePartnersResponseLegalCountryClass NonEu = new(Values.NonEu);

    public CreatePartnersResponseLegalCountryClass(string value)
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
    public static CreatePartnersResponseLegalCountryClass FromCustom(string value)
    {
        return new CreatePartnersResponseLegalCountryClass(value);
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

    public static bool operator ==(CreatePartnersResponseLegalCountryClass value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreatePartnersResponseLegalCountryClass value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreatePartnersResponseLegalCountryClass value) =>
        value.Value;

    public static explicit operator CreatePartnersResponseLegalCountryClass(string value) =>
        new(value);

    internal class CreatePartnersResponseLegalCountryClassSerializer
        : JsonConverter<CreatePartnersResponseLegalCountryClass>
    {
        public override CreatePartnersResponseLegalCountryClass Read(
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
            return new CreatePartnersResponseLegalCountryClass(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreatePartnersResponseLegalCountryClass value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreatePartnersResponseLegalCountryClass ReadAsPropertyName(
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
            return new CreatePartnersResponseLegalCountryClass(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreatePartnersResponseLegalCountryClass value,
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
