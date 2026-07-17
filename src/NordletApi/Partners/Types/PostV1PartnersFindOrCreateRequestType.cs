using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersFindOrCreateRequestType.PostV1PartnersFindOrCreateRequestTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersFindOrCreateRequestType : IStringEnum
{
    public static readonly PostV1PartnersFindOrCreateRequestType Company = new(Values.Company);

    public static readonly PostV1PartnersFindOrCreateRequestType Person = new(Values.Person);

    public PostV1PartnersFindOrCreateRequestType(string value)
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
    public static PostV1PartnersFindOrCreateRequestType FromCustom(string value)
    {
        return new PostV1PartnersFindOrCreateRequestType(value);
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

    public static bool operator ==(PostV1PartnersFindOrCreateRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1PartnersFindOrCreateRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersFindOrCreateRequestType value) =>
        value.Value;

    public static explicit operator PostV1PartnersFindOrCreateRequestType(string value) =>
        new(value);

    internal class PostV1PartnersFindOrCreateRequestTypeSerializer
        : JsonConverter<PostV1PartnersFindOrCreateRequestType>
    {
        public override PostV1PartnersFindOrCreateRequestType Read(
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
            return new PostV1PartnersFindOrCreateRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersFindOrCreateRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersFindOrCreateRequestType ReadAsPropertyName(
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
            return new PostV1PartnersFindOrCreateRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersFindOrCreateRequestType value,
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
