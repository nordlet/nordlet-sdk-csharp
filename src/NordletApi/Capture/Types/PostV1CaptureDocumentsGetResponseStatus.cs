using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CaptureDocumentsGetResponseStatus.PostV1CaptureDocumentsGetResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1CaptureDocumentsGetResponseStatus : IStringEnum
{
    public static readonly PostV1CaptureDocumentsGetResponseStatus Pending = new(Values.Pending);

    public static readonly PostV1CaptureDocumentsGetResponseStatus Extracted = new(
        Values.Extracted
    );

    public static readonly PostV1CaptureDocumentsGetResponseStatus Failed = new(Values.Failed);

    public static readonly PostV1CaptureDocumentsGetResponseStatus Linked = new(Values.Linked);

    public PostV1CaptureDocumentsGetResponseStatus(string value)
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
    public static PostV1CaptureDocumentsGetResponseStatus FromCustom(string value)
    {
        return new PostV1CaptureDocumentsGetResponseStatus(value);
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

    public static bool operator ==(PostV1CaptureDocumentsGetResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1CaptureDocumentsGetResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CaptureDocumentsGetResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1CaptureDocumentsGetResponseStatus(string value) =>
        new(value);

    internal class PostV1CaptureDocumentsGetResponseStatusSerializer
        : JsonConverter<PostV1CaptureDocumentsGetResponseStatus>
    {
        public override PostV1CaptureDocumentsGetResponseStatus Read(
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
            return new PostV1CaptureDocumentsGetResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CaptureDocumentsGetResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CaptureDocumentsGetResponseStatus ReadAsPropertyName(
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
            return new PostV1CaptureDocumentsGetResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CaptureDocumentsGetResponseStatus value,
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
        public const string Pending = "pending";

        public const string Extracted = "extracted";

        public const string Failed = "failed";

        public const string Linked = "linked";
    }
}
