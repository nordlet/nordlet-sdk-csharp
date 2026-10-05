using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(CreatePartnersResponseType.CreatePartnersResponseTypeSerializer))]
[Serializable]
public readonly record struct CreatePartnersResponseType : IStringEnum
{
    public static readonly CreatePartnersResponseType Company = new(Values.Company);

    public static readonly CreatePartnersResponseType Person = new(Values.Person);

    public CreatePartnersResponseType(string value)
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
    public static CreatePartnersResponseType FromCustom(string value)
    {
        return new CreatePartnersResponseType(value);
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

    public static bool operator ==(CreatePartnersResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreatePartnersResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreatePartnersResponseType value) => value.Value;

    public static explicit operator CreatePartnersResponseType(string value) => new(value);

    internal class CreatePartnersResponseTypeSerializer : JsonConverter<CreatePartnersResponseType>
    {
        public override CreatePartnersResponseType Read(
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
            return new CreatePartnersResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreatePartnersResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreatePartnersResponseType ReadAsPropertyName(
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
            return new CreatePartnersResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreatePartnersResponseType value,
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
        public const string Company = "company";

        public const string Person = "person";
    }
}
