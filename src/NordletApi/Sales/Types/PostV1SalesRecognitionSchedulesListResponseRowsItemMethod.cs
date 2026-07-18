using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesRecognitionSchedulesListResponseRowsItemMethod.PostV1SalesRecognitionSchedulesListResponseRowsItemMethodSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesRecognitionSchedulesListResponseRowsItemMethod
    : IStringEnum
{
    public static readonly PostV1SalesRecognitionSchedulesListResponseRowsItemMethod PointInTime =
        new(Values.PointInTime);

    public static readonly PostV1SalesRecognitionSchedulesListResponseRowsItemMethod Ratable = new(
        Values.Ratable
    );

    public static readonly PostV1SalesRecognitionSchedulesListResponseRowsItemMethod Milestone =
        new(Values.Milestone);

    public static readonly PostV1SalesRecognitionSchedulesListResponseRowsItemMethod PercentComplete =
        new(Values.PercentComplete);

    public PostV1SalesRecognitionSchedulesListResponseRowsItemMethod(string value)
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
    public static PostV1SalesRecognitionSchedulesListResponseRowsItemMethod FromCustom(string value)
    {
        return new PostV1SalesRecognitionSchedulesListResponseRowsItemMethod(value);
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
        PostV1SalesRecognitionSchedulesListResponseRowsItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesRecognitionSchedulesListResponseRowsItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1SalesRecognitionSchedulesListResponseRowsItemMethod value
    ) => value.Value;

    public static explicit operator PostV1SalesRecognitionSchedulesListResponseRowsItemMethod(
        string value
    ) => new(value);

    internal class PostV1SalesRecognitionSchedulesListResponseRowsItemMethodSerializer
        : JsonConverter<PostV1SalesRecognitionSchedulesListResponseRowsItemMethod>
    {
        public override PostV1SalesRecognitionSchedulesListResponseRowsItemMethod Read(
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
            return new PostV1SalesRecognitionSchedulesListResponseRowsItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesRecognitionSchedulesListResponseRowsItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesRecognitionSchedulesListResponseRowsItemMethod ReadAsPropertyName(
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
            return new PostV1SalesRecognitionSchedulesListResponseRowsItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesRecognitionSchedulesListResponseRowsItemMethod value,
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
        public const string PointInTime = "point_in_time";

        public const string Ratable = "ratable";

        public const string Milestone = "milestone";

        public const string PercentComplete = "percent_complete";
    }
}
