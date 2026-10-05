using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CreatePartnersRequestLegalCountryClass.CreatePartnersRequestLegalCountryClassSerializer)
)]
[Serializable]
public readonly record struct CreatePartnersRequestLegalCountryClass : IStringEnum
{
    public static readonly CreatePartnersRequestLegalCountryClass Lt = new(Values.Lt);

    public static readonly CreatePartnersRequestLegalCountryClass Eu = new(Values.Eu);

    public static readonly CreatePartnersRequestLegalCountryClass NonEu = new(Values.NonEu);

    public CreatePartnersRequestLegalCountryClass(string value)
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
    public static CreatePartnersRequestLegalCountryClass FromCustom(string value)
    {
        return new CreatePartnersRequestLegalCountryClass(value);
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

    public static bool operator ==(CreatePartnersRequestLegalCountryClass value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreatePartnersRequestLegalCountryClass value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreatePartnersRequestLegalCountryClass value) =>
        value.Value;

    public static explicit operator CreatePartnersRequestLegalCountryClass(string value) =>
        new(value);

    internal class CreatePartnersRequestLegalCountryClassSerializer
        : JsonConverter<CreatePartnersRequestLegalCountryClass>
    {
        public override CreatePartnersRequestLegalCountryClass Read(
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
            return new CreatePartnersRequestLegalCountryClass(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreatePartnersRequestLegalCountryClass value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreatePartnersRequestLegalCountryClass ReadAsPropertyName(
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
            return new CreatePartnersRequestLegalCountryClass(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreatePartnersRequestLegalCountryClass value,
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
