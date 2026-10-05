using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ConvertLeadsRequestPartnerType.ConvertLeadsRequestPartnerTypeSerializer))]
[Serializable]
public readonly record struct ConvertLeadsRequestPartnerType : IStringEnum
{
    public static readonly ConvertLeadsRequestPartnerType Company = new(Values.Company);

    public static readonly ConvertLeadsRequestPartnerType Person = new(Values.Person);

    public ConvertLeadsRequestPartnerType(string value)
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
    public static ConvertLeadsRequestPartnerType FromCustom(string value)
    {
        return new ConvertLeadsRequestPartnerType(value);
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

    public static bool operator ==(ConvertLeadsRequestPartnerType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ConvertLeadsRequestPartnerType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ConvertLeadsRequestPartnerType value) => value.Value;

    public static explicit operator ConvertLeadsRequestPartnerType(string value) => new(value);

    internal class ConvertLeadsRequestPartnerTypeSerializer
        : JsonConverter<ConvertLeadsRequestPartnerType>
    {
        public override ConvertLeadsRequestPartnerType Read(
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
            return new ConvertLeadsRequestPartnerType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ConvertLeadsRequestPartnerType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ConvertLeadsRequestPartnerType ReadAsPropertyName(
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
            return new ConvertLeadsRequestPartnerType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ConvertLeadsRequestPartnerType value,
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
