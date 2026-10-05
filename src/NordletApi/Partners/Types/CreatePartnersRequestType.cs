using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(CreatePartnersRequestType.CreatePartnersRequestTypeSerializer))]
[Serializable]
public readonly record struct CreatePartnersRequestType : IStringEnum
{
    public static readonly CreatePartnersRequestType Company = new(Values.Company);

    public static readonly CreatePartnersRequestType Person = new(Values.Person);

    public CreatePartnersRequestType(string value)
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
    public static CreatePartnersRequestType FromCustom(string value)
    {
        return new CreatePartnersRequestType(value);
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

    public static bool operator ==(CreatePartnersRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreatePartnersRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreatePartnersRequestType value) => value.Value;

    public static explicit operator CreatePartnersRequestType(string value) => new(value);

    internal class CreatePartnersRequestTypeSerializer : JsonConverter<CreatePartnersRequestType>
    {
        public override CreatePartnersRequestType Read(
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
            return new CreatePartnersRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreatePartnersRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreatePartnersRequestType ReadAsPropertyName(
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
            return new CreatePartnersRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreatePartnersRequestType value,
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
