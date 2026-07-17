using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrContractsCreateResponseType.PostV1HrContractsCreateResponseTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1HrContractsCreateResponseType : IStringEnum
{
    public static readonly PostV1HrContractsCreateResponseType Permanent = new(Values.Permanent);

    public static readonly PostV1HrContractsCreateResponseType FixedTerm = new(Values.FixedTerm);

    public PostV1HrContractsCreateResponseType(string value)
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
    public static PostV1HrContractsCreateResponseType FromCustom(string value)
    {
        return new PostV1HrContractsCreateResponseType(value);
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

    public static bool operator ==(PostV1HrContractsCreateResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1HrContractsCreateResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrContractsCreateResponseType value) =>
        value.Value;

    public static explicit operator PostV1HrContractsCreateResponseType(string value) => new(value);

    internal class PostV1HrContractsCreateResponseTypeSerializer
        : JsonConverter<PostV1HrContractsCreateResponseType>
    {
        public override PostV1HrContractsCreateResponseType Read(
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
            return new PostV1HrContractsCreateResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrContractsCreateResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrContractsCreateResponseType ReadAsPropertyName(
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
            return new PostV1HrContractsCreateResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrContractsCreateResponseType value,
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
