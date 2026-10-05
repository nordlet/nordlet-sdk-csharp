using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(UpdatePartnersResponseType.UpdatePartnersResponseTypeSerializer))]
[Serializable]
public readonly record struct UpdatePartnersResponseType : IStringEnum
{
    public static readonly UpdatePartnersResponseType Company = new(Values.Company);

    public static readonly UpdatePartnersResponseType Person = new(Values.Person);

    public UpdatePartnersResponseType(string value)
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
    public static UpdatePartnersResponseType FromCustom(string value)
    {
        return new UpdatePartnersResponseType(value);
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

    public static bool operator ==(UpdatePartnersResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdatePartnersResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdatePartnersResponseType value) => value.Value;

    public static explicit operator UpdatePartnersResponseType(string value) => new(value);

    internal class UpdatePartnersResponseTypeSerializer : JsonConverter<UpdatePartnersResponseType>
    {
        public override UpdatePartnersResponseType Read(
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
            return new UpdatePartnersResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdatePartnersResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdatePartnersResponseType ReadAsPropertyName(
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
            return new UpdatePartnersResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdatePartnersResponseType value,
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
