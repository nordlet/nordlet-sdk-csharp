using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LeadsConvertRequestPartnerType.PostV1LeadsConvertRequestPartnerTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1LeadsConvertRequestPartnerType : IStringEnum
{
    public static readonly PostV1LeadsConvertRequestPartnerType Company = new(Values.Company);

    public static readonly PostV1LeadsConvertRequestPartnerType Person = new(Values.Person);

    public PostV1LeadsConvertRequestPartnerType(string value)
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
    public static PostV1LeadsConvertRequestPartnerType FromCustom(string value)
    {
        return new PostV1LeadsConvertRequestPartnerType(value);
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

    public static bool operator ==(PostV1LeadsConvertRequestPartnerType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1LeadsConvertRequestPartnerType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1LeadsConvertRequestPartnerType value) =>
        value.Value;

    public static explicit operator PostV1LeadsConvertRequestPartnerType(string value) =>
        new(value);

    internal class PostV1LeadsConvertRequestPartnerTypeSerializer
        : JsonConverter<PostV1LeadsConvertRequestPartnerType>
    {
        public override PostV1LeadsConvertRequestPartnerType Read(
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
            return new PostV1LeadsConvertRequestPartnerType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LeadsConvertRequestPartnerType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LeadsConvertRequestPartnerType ReadAsPropertyName(
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
            return new PostV1LeadsConvertRequestPartnerType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LeadsConvertRequestPartnerType value,
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
