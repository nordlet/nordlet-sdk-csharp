using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsLtSdGenerateRequestType.PostV1DeclarationsLtSdGenerateRequestTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsLtSdGenerateRequestType : IStringEnum
{
    public static readonly PostV1DeclarationsLtSdGenerateRequestType OneSd = new(Values.OneSd);

    public static readonly PostV1DeclarationsLtSdGenerateRequestType TwoSd = new(Values.TwoSd);

    public PostV1DeclarationsLtSdGenerateRequestType(string value)
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
    public static PostV1DeclarationsLtSdGenerateRequestType FromCustom(string value)
    {
        return new PostV1DeclarationsLtSdGenerateRequestType(value);
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
        PostV1DeclarationsLtSdGenerateRequestType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsLtSdGenerateRequestType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1DeclarationsLtSdGenerateRequestType value) =>
        value.Value;

    public static explicit operator PostV1DeclarationsLtSdGenerateRequestType(string value) =>
        new(value);

    internal class PostV1DeclarationsLtSdGenerateRequestTypeSerializer
        : JsonConverter<PostV1DeclarationsLtSdGenerateRequestType>
    {
        public override PostV1DeclarationsLtSdGenerateRequestType Read(
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
            return new PostV1DeclarationsLtSdGenerateRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtSdGenerateRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsLtSdGenerateRequestType ReadAsPropertyName(
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
            return new PostV1DeclarationsLtSdGenerateRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtSdGenerateRequestType value,
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
