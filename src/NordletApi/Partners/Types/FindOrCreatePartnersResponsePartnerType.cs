using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FindOrCreatePartnersResponsePartnerType.FindOrCreatePartnersResponsePartnerTypeSerializer)
)]
[Serializable]
public readonly record struct FindOrCreatePartnersResponsePartnerType : IStringEnum
{
    public static readonly FindOrCreatePartnersResponsePartnerType Company = new(Values.Company);

    public static readonly FindOrCreatePartnersResponsePartnerType Person = new(Values.Person);

    public FindOrCreatePartnersResponsePartnerType(string value)
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
    public static FindOrCreatePartnersResponsePartnerType FromCustom(string value)
    {
        return new FindOrCreatePartnersResponsePartnerType(value);
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

    public static bool operator ==(FindOrCreatePartnersResponsePartnerType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FindOrCreatePartnersResponsePartnerType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FindOrCreatePartnersResponsePartnerType value) =>
        value.Value;

    public static explicit operator FindOrCreatePartnersResponsePartnerType(string value) =>
        new(value);

    internal class FindOrCreatePartnersResponsePartnerTypeSerializer
        : JsonConverter<FindOrCreatePartnersResponsePartnerType>
    {
        public override FindOrCreatePartnersResponsePartnerType Read(
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
            return new FindOrCreatePartnersResponsePartnerType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FindOrCreatePartnersResponsePartnerType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FindOrCreatePartnersResponsePartnerType ReadAsPropertyName(
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
            return new FindOrCreatePartnersResponsePartnerType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FindOrCreatePartnersResponsePartnerType value,
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
