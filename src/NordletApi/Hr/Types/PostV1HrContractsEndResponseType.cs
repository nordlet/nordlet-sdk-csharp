using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PostV1HrContractsEndResponseType.PostV1HrContractsEndResponseTypeSerializer))]
[Serializable]
public readonly record struct PostV1HrContractsEndResponseType : IStringEnum
{
    public static readonly PostV1HrContractsEndResponseType Permanent = new(Values.Permanent);

    public static readonly PostV1HrContractsEndResponseType FixedTerm = new(Values.FixedTerm);

    public PostV1HrContractsEndResponseType(string value)
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
    public static PostV1HrContractsEndResponseType FromCustom(string value)
    {
        return new PostV1HrContractsEndResponseType(value);
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

    public static bool operator ==(PostV1HrContractsEndResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1HrContractsEndResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrContractsEndResponseType value) => value.Value;

    public static explicit operator PostV1HrContractsEndResponseType(string value) => new(value);

    internal class PostV1HrContractsEndResponseTypeSerializer
        : JsonConverter<PostV1HrContractsEndResponseType>
    {
        public override PostV1HrContractsEndResponseType Read(
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
            return new PostV1HrContractsEndResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrContractsEndResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrContractsEndResponseType ReadAsPropertyName(
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
            return new PostV1HrContractsEndResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrContractsEndResponseType value,
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
