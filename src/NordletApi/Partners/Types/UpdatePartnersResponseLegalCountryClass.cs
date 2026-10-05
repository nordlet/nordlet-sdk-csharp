using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(UpdatePartnersResponseLegalCountryClass.UpdatePartnersResponseLegalCountryClassSerializer)
)]
[Serializable]
public readonly record struct UpdatePartnersResponseLegalCountryClass : IStringEnum
{
    public static readonly UpdatePartnersResponseLegalCountryClass Lt = new(Values.Lt);

    public static readonly UpdatePartnersResponseLegalCountryClass Eu = new(Values.Eu);

    public static readonly UpdatePartnersResponseLegalCountryClass NonEu = new(Values.NonEu);

    public UpdatePartnersResponseLegalCountryClass(string value)
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
    public static UpdatePartnersResponseLegalCountryClass FromCustom(string value)
    {
        return new UpdatePartnersResponseLegalCountryClass(value);
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

    public static bool operator ==(UpdatePartnersResponseLegalCountryClass value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdatePartnersResponseLegalCountryClass value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdatePartnersResponseLegalCountryClass value) =>
        value.Value;

    public static explicit operator UpdatePartnersResponseLegalCountryClass(string value) =>
        new(value);

    internal class UpdatePartnersResponseLegalCountryClassSerializer
        : JsonConverter<UpdatePartnersResponseLegalCountryClass>
    {
        public override UpdatePartnersResponseLegalCountryClass Read(
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
            return new UpdatePartnersResponseLegalCountryClass(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdatePartnersResponseLegalCountryClass value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdatePartnersResponseLegalCountryClass ReadAsPropertyName(
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
            return new UpdatePartnersResponseLegalCountryClass(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdatePartnersResponseLegalCountryClass value,
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
