using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DocumentsUploadCaptureResponseStatus.DocumentsUploadCaptureResponseStatusSerializer)
)]
[Serializable]
public readonly record struct DocumentsUploadCaptureResponseStatus : IStringEnum
{
    public static readonly DocumentsUploadCaptureResponseStatus Pending = new(Values.Pending);

    public static readonly DocumentsUploadCaptureResponseStatus Extracted = new(Values.Extracted);

    public static readonly DocumentsUploadCaptureResponseStatus Failed = new(Values.Failed);

    public static readonly DocumentsUploadCaptureResponseStatus Linked = new(Values.Linked);

    public DocumentsUploadCaptureResponseStatus(string value)
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
    public static DocumentsUploadCaptureResponseStatus FromCustom(string value)
    {
        return new DocumentsUploadCaptureResponseStatus(value);
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

    public static bool operator ==(DocumentsUploadCaptureResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocumentsUploadCaptureResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsUploadCaptureResponseStatus value) =>
        value.Value;

    public static explicit operator DocumentsUploadCaptureResponseStatus(string value) =>
        new(value);

    internal class DocumentsUploadCaptureResponseStatusSerializer
        : JsonConverter<DocumentsUploadCaptureResponseStatus>
    {
        public override DocumentsUploadCaptureResponseStatus Read(
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
            return new DocumentsUploadCaptureResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsUploadCaptureResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsUploadCaptureResponseStatus ReadAsPropertyName(
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
            return new DocumentsUploadCaptureResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsUploadCaptureResponseStatus value,
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
