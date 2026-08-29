using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CaptureDocumentsUploadResponseStatus.PostV1CaptureDocumentsUploadResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1CaptureDocumentsUploadResponseStatus : IStringEnum
{
    public static readonly PostV1CaptureDocumentsUploadResponseStatus Pending = new(Values.Pending);

    public static readonly PostV1CaptureDocumentsUploadResponseStatus Extracted = new(
        Values.Extracted
    );

    public static readonly PostV1CaptureDocumentsUploadResponseStatus Failed = new(Values.Failed);

    public static readonly PostV1CaptureDocumentsUploadResponseStatus Linked = new(Values.Linked);

    public PostV1CaptureDocumentsUploadResponseStatus(string value)
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
    public static PostV1CaptureDocumentsUploadResponseStatus FromCustom(string value)
    {
        return new PostV1CaptureDocumentsUploadResponseStatus(value);
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
        PostV1CaptureDocumentsUploadResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1CaptureDocumentsUploadResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CaptureDocumentsUploadResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1CaptureDocumentsUploadResponseStatus(string value) =>
        new(value);

    internal class PostV1CaptureDocumentsUploadResponseStatusSerializer
        : JsonConverter<PostV1CaptureDocumentsUploadResponseStatus>
    {
        public override PostV1CaptureDocumentsUploadResponseStatus Read(
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
            return new PostV1CaptureDocumentsUploadResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CaptureDocumentsUploadResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CaptureDocumentsUploadResponseStatus ReadAsPropertyName(
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
            return new PostV1CaptureDocumentsUploadResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CaptureDocumentsUploadResponseStatus value,
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
