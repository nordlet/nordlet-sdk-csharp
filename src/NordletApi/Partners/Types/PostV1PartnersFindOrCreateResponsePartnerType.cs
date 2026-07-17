using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersFindOrCreateResponsePartnerType.PostV1PartnersFindOrCreateResponsePartnerTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersFindOrCreateResponsePartnerType : IStringEnum
{
    public static readonly PostV1PartnersFindOrCreateResponsePartnerType Company = new(
        Values.Company
    );

    public static readonly PostV1PartnersFindOrCreateResponsePartnerType Person = new(
        Values.Person
    );

    public PostV1PartnersFindOrCreateResponsePartnerType(string value)
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
    public static PostV1PartnersFindOrCreateResponsePartnerType FromCustom(string value)
    {
        return new PostV1PartnersFindOrCreateResponsePartnerType(value);
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

    public static bool operator ==(
        PostV1PartnersFindOrCreateResponsePartnerType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersFindOrCreateResponsePartnerType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersFindOrCreateResponsePartnerType value) =>
        value.Value;

    public static explicit operator PostV1PartnersFindOrCreateResponsePartnerType(string value) =>
        new(value);

    internal class PostV1PartnersFindOrCreateResponsePartnerTypeSerializer
        : JsonConverter<PostV1PartnersFindOrCreateResponsePartnerType>
    {
        public override PostV1PartnersFindOrCreateResponsePartnerType Read(
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
            return new PostV1PartnersFindOrCreateResponsePartnerType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersFindOrCreateResponsePartnerType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersFindOrCreateResponsePartnerType ReadAsPropertyName(
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
            return new PostV1PartnersFindOrCreateResponsePartnerType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersFindOrCreateResponsePartnerType value,
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
