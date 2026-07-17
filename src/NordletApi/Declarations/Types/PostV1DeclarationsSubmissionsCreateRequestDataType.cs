using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsSubmissionsCreateRequestDataType.PostV1DeclarationsSubmissionsCreateRequestDataTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsSubmissionsCreateRequestDataType : IStringEnum
{
    public static readonly PostV1DeclarationsSubmissionsCreateRequestDataType F = new(Values.F);

    public static readonly PostV1DeclarationsSubmissionsCreateRequestDataType S = new(Values.S);

    public static readonly PostV1DeclarationsSubmissionsCreateRequestDataType P = new(Values.P);

    public PostV1DeclarationsSubmissionsCreateRequestDataType(string value)
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
    public static PostV1DeclarationsSubmissionsCreateRequestDataType FromCustom(string value)
    {
        return new PostV1DeclarationsSubmissionsCreateRequestDataType(value);
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
        PostV1DeclarationsSubmissionsCreateRequestDataType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsSubmissionsCreateRequestDataType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsSubmissionsCreateRequestDataType value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsSubmissionsCreateRequestDataType(
        string value
    ) => new(value);

    internal class PostV1DeclarationsSubmissionsCreateRequestDataTypeSerializer
        : JsonConverter<PostV1DeclarationsSubmissionsCreateRequestDataType>
    {
        public override PostV1DeclarationsSubmissionsCreateRequestDataType Read(
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
            return new PostV1DeclarationsSubmissionsCreateRequestDataType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsSubmissionsCreateRequestDataType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsSubmissionsCreateRequestDataType ReadAsPropertyName(
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
            return new PostV1DeclarationsSubmissionsCreateRequestDataType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsSubmissionsCreateRequestDataType value,
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
