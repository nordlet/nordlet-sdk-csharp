using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CaptureDocumentsExtractResponseStatus.PostV1CaptureDocumentsExtractResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1CaptureDocumentsExtractResponseStatus : IStringEnum
{
    public static readonly PostV1CaptureDocumentsExtractResponseStatus Pending = new(
        Values.Pending
    );

    public static readonly PostV1CaptureDocumentsExtractResponseStatus Extracted = new(
        Values.Extracted
    );

    public static readonly PostV1CaptureDocumentsExtractResponseStatus Failed = new(Values.Failed);

    public static readonly PostV1CaptureDocumentsExtractResponseStatus Linked = new(Values.Linked);

    public PostV1CaptureDocumentsExtractResponseStatus(string value)
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
    public static PostV1CaptureDocumentsExtractResponseStatus FromCustom(string value)
    {
        return new PostV1CaptureDocumentsExtractResponseStatus(value);
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
        PostV1CaptureDocumentsExtractResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1CaptureDocumentsExtractResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CaptureDocumentsExtractResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1CaptureDocumentsExtractResponseStatus(string value) =>
        new(value);

    internal class PostV1CaptureDocumentsExtractResponseStatusSerializer
        : JsonConverter<PostV1CaptureDocumentsExtractResponseStatus>
    {
        public override PostV1CaptureDocumentsExtractResponseStatus Read(
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
            return new PostV1CaptureDocumentsExtractResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CaptureDocumentsExtractResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CaptureDocumentsExtractResponseStatus ReadAsPropertyName(
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
            return new PostV1CaptureDocumentsExtractResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CaptureDocumentsExtractResponseStatus value,
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
