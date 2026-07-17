using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrContractsCreateRequestType.PostV1HrContractsCreateRequestTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1HrContractsCreateRequestType : IStringEnum
{
    public static readonly PostV1HrContractsCreateRequestType Permanent = new(Values.Permanent);

    public static readonly PostV1HrContractsCreateRequestType FixedTerm = new(Values.FixedTerm);

    public PostV1HrContractsCreateRequestType(string value)
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
    public static PostV1HrContractsCreateRequestType FromCustom(string value)
    {
        return new PostV1HrContractsCreateRequestType(value);
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

    public static bool operator ==(PostV1HrContractsCreateRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1HrContractsCreateRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrContractsCreateRequestType value) => value.Value;

    public static explicit operator PostV1HrContractsCreateRequestType(string value) => new(value);

    internal class PostV1HrContractsCreateRequestTypeSerializer
        : JsonConverter<PostV1HrContractsCreateRequestType>
    {
        public override PostV1HrContractsCreateRequestType Read(
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
            return new PostV1HrContractsCreateRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrContractsCreateRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrContractsCreateRequestType ReadAsPropertyName(
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
            return new PostV1HrContractsCreateRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrContractsCreateRequestType value,
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
        public const string Permanent = "permanent";

        public const string FixedTerm = "fixed_term";
    }
}
