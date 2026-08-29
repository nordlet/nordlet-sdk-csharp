using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CaptureDocumentsConfirmResponseCaptureStatus.PostV1CaptureDocumentsConfirmResponseCaptureStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1CaptureDocumentsConfirmResponseCaptureStatus : IStringEnum
{
    public static readonly PostV1CaptureDocumentsConfirmResponseCaptureStatus Pending = new(
        Values.Pending
    );

    public static readonly PostV1CaptureDocumentsConfirmResponseCaptureStatus Extracted = new(
        Values.Extracted
    );

    public static readonly PostV1CaptureDocumentsConfirmResponseCaptureStatus Failed = new(
        Values.Failed
    );

    public static readonly PostV1CaptureDocumentsConfirmResponseCaptureStatus Linked = new(
        Values.Linked
    );

    public PostV1CaptureDocumentsConfirmResponseCaptureStatus(string value)
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
    public static PostV1CaptureDocumentsConfirmResponseCaptureStatus FromCustom(string value)
    {
        return new PostV1CaptureDocumentsConfirmResponseCaptureStatus(value);
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
        PostV1CaptureDocumentsConfirmResponseCaptureStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1CaptureDocumentsConfirmResponseCaptureStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1CaptureDocumentsConfirmResponseCaptureStatus value
    ) => value.Value;

    public static explicit operator PostV1CaptureDocumentsConfirmResponseCaptureStatus(
        string value
    ) => new(value);

    internal class PostV1CaptureDocumentsConfirmResponseCaptureStatusSerializer
        : JsonConverter<PostV1CaptureDocumentsConfirmResponseCaptureStatus>
    {
        public override PostV1CaptureDocumentsConfirmResponseCaptureStatus Read(
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
            return new PostV1CaptureDocumentsConfirmResponseCaptureStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CaptureDocumentsConfirmResponseCaptureStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CaptureDocumentsConfirmResponseCaptureStatus ReadAsPropertyName(
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
            return new PostV1CaptureDocumentsConfirmResponseCaptureStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CaptureDocumentsConfirmResponseCaptureStatus value,
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
