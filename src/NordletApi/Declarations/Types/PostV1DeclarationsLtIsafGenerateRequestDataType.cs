using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsLtIsafGenerateRequestDataType.PostV1DeclarationsLtIsafGenerateRequestDataTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsLtIsafGenerateRequestDataType : IStringEnum
{
    public static readonly PostV1DeclarationsLtIsafGenerateRequestDataType F = new(Values.F);

    public static readonly PostV1DeclarationsLtIsafGenerateRequestDataType S = new(Values.S);

    public static readonly PostV1DeclarationsLtIsafGenerateRequestDataType P = new(Values.P);

    public PostV1DeclarationsLtIsafGenerateRequestDataType(string value)
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
    public static PostV1DeclarationsLtIsafGenerateRequestDataType FromCustom(string value)
    {
        return new PostV1DeclarationsLtIsafGenerateRequestDataType(value);
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
        PostV1DeclarationsLtIsafGenerateRequestDataType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsLtIsafGenerateRequestDataType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1DeclarationsLtIsafGenerateRequestDataType value) =>
        value.Value;

    public static explicit operator PostV1DeclarationsLtIsafGenerateRequestDataType(string value) =>
        new(value);

    internal class PostV1DeclarationsLtIsafGenerateRequestDataTypeSerializer
        : JsonConverter<PostV1DeclarationsLtIsafGenerateRequestDataType>
    {
        public override PostV1DeclarationsLtIsafGenerateRequestDataType Read(
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
            return new PostV1DeclarationsLtIsafGenerateRequestDataType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtIsafGenerateRequestDataType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsLtIsafGenerateRequestDataType ReadAsPropertyName(
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
            return new PostV1DeclarationsLtIsafGenerateRequestDataType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtIsafGenerateRequestDataType value,
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
        public const string F = "F";

        public const string S = "S";

        public const string P = "P";
    }
}
