using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsLtSdGenerateResponseType.PostV1DeclarationsLtSdGenerateResponseTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsLtSdGenerateResponseType : IStringEnum
{
    public static readonly PostV1DeclarationsLtSdGenerateResponseType OneSd = new(Values.OneSd);

    public static readonly PostV1DeclarationsLtSdGenerateResponseType TwoSd = new(Values.TwoSd);

    public PostV1DeclarationsLtSdGenerateResponseType(string value)
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
    public static PostV1DeclarationsLtSdGenerateResponseType FromCustom(string value)
    {
        return new PostV1DeclarationsLtSdGenerateResponseType(value);
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
        PostV1DeclarationsLtSdGenerateResponseType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsLtSdGenerateResponseType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1DeclarationsLtSdGenerateResponseType value) =>
        value.Value;

    public static explicit operator PostV1DeclarationsLtSdGenerateResponseType(string value) =>
        new(value);

    internal class PostV1DeclarationsLtSdGenerateResponseTypeSerializer
        : JsonConverter<PostV1DeclarationsLtSdGenerateResponseType>
    {
        public override PostV1DeclarationsLtSdGenerateResponseType Read(
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
            return new PostV1DeclarationsLtSdGenerateResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtSdGenerateResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsLtSdGenerateResponseType ReadAsPropertyName(
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
            return new PostV1DeclarationsLtSdGenerateResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtSdGenerateResponseType value,
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
        public const string OneSd = "1-SD";

        public const string TwoSd = "2-SD";
    }
}
