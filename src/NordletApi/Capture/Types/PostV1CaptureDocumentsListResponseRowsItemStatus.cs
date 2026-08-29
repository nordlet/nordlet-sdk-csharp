using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CaptureDocumentsListResponseRowsItemStatus.PostV1CaptureDocumentsListResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1CaptureDocumentsListResponseRowsItemStatus : IStringEnum
{
    public static readonly PostV1CaptureDocumentsListResponseRowsItemStatus Pending = new(
        Values.Pending
    );

    public static readonly PostV1CaptureDocumentsListResponseRowsItemStatus Extracted = new(
        Values.Extracted
    );

    public static readonly PostV1CaptureDocumentsListResponseRowsItemStatus Failed = new(
        Values.Failed
    );

    public static readonly PostV1CaptureDocumentsListResponseRowsItemStatus Linked = new(
        Values.Linked
    );

    public PostV1CaptureDocumentsListResponseRowsItemStatus(string value)
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
    public static PostV1CaptureDocumentsListResponseRowsItemStatus FromCustom(string value)
    {
        return new PostV1CaptureDocumentsListResponseRowsItemStatus(value);
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
        PostV1CaptureDocumentsListResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1CaptureDocumentsListResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1CaptureDocumentsListResponseRowsItemStatus value
    ) => value.Value;

    public static explicit operator PostV1CaptureDocumentsListResponseRowsItemStatus(
        string value
    ) => new(value);

    internal class PostV1CaptureDocumentsListResponseRowsItemStatusSerializer
        : JsonConverter<PostV1CaptureDocumentsListResponseRowsItemStatus>
    {
        public override PostV1CaptureDocumentsListResponseRowsItemStatus Read(
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
            return new PostV1CaptureDocumentsListResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CaptureDocumentsListResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CaptureDocumentsListResponseRowsItemStatus ReadAsPropertyName(
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
            return new PostV1CaptureDocumentsListResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CaptureDocumentsListResponseRowsItemStatus value,
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
