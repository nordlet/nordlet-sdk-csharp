using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesRecognitionSchedulesListResponseRowsItemStatus.PostV1SalesRecognitionSchedulesListResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesRecognitionSchedulesListResponseRowsItemStatus
    : IStringEnum
{
    public static readonly PostV1SalesRecognitionSchedulesListResponseRowsItemStatus Pending = new(
        Values.Pending
    );

    public static readonly PostV1SalesRecognitionSchedulesListResponseRowsItemStatus Recognized =
        new(Values.Recognized);

    public static readonly PostV1SalesRecognitionSchedulesListResponseRowsItemStatus Cancelled =
        new(Values.Cancelled);

    public PostV1SalesRecognitionSchedulesListResponseRowsItemStatus(string value)
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
    public static PostV1SalesRecognitionSchedulesListResponseRowsItemStatus FromCustom(string value)
    {
        return new PostV1SalesRecognitionSchedulesListResponseRowsItemStatus(value);
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
        PostV1SalesRecognitionSchedulesListResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesRecognitionSchedulesListResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1SalesRecognitionSchedulesListResponseRowsItemStatus value
    ) => value.Value;

    public static explicit operator PostV1SalesRecognitionSchedulesListResponseRowsItemStatus(
        string value
    ) => new(value);

    internal class PostV1SalesRecognitionSchedulesListResponseRowsItemStatusSerializer
        : JsonConverter<PostV1SalesRecognitionSchedulesListResponseRowsItemStatus>
    {
        public override PostV1SalesRecognitionSchedulesListResponseRowsItemStatus Read(
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
            return new PostV1SalesRecognitionSchedulesListResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesRecognitionSchedulesListResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesRecognitionSchedulesListResponseRowsItemStatus ReadAsPropertyName(
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
            return new PostV1SalesRecognitionSchedulesListResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesRecognitionSchedulesListResponseRowsItemStatus value,
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

        public const string Recognized = "recognized";

        public const string Cancelled = "cancelled";
    }
}
