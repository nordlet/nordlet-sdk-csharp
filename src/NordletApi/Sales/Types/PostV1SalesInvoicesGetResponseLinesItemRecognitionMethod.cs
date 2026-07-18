using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod.PostV1SalesInvoicesGetResponseLinesItemRecognitionMethodSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod : IStringEnum
{
    public static readonly PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod PointInTime =
        new(Values.PointInTime);

    public static readonly PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod Ratable = new(
        Values.Ratable
    );

    public static readonly PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod Milestone = new(
        Values.Milestone
    );

    public static readonly PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod PercentComplete =
        new(Values.PercentComplete);

    public PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod(string value)
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
    public static PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod FromCustom(string value)
    {
        return new PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod(value);
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
        PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod value
    ) => value.Value;

    public static explicit operator PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod(
        string value
    ) => new(value);

    internal class PostV1SalesInvoicesGetResponseLinesItemRecognitionMethodSerializer
        : JsonConverter<PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod>
    {
        public override PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod Read(
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
            return new PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod ReadAsPropertyName(
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
            return new PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesGetResponseLinesItemRecognitionMethod value,
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
