using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod.PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethodSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod
    : IStringEnum
{
    public static readonly PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod PointInTime =
        new(Values.PointInTime);

    public static readonly PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod Ratable =
        new(Values.Ratable);

    public static readonly PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod Milestone =
        new(Values.Milestone);

    public static readonly PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod PercentComplete =
        new(Values.PercentComplete);

    public PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod(string value)
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
    public static PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod FromCustom(
        string value
    )
    {
        return new PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod(value);
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
        PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod value
    ) => value.Value;

    public static explicit operator PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod(
        string value
    ) => new(value);

    internal class PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethodSerializer
        : JsonConverter<PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod>
    {
        public override PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod Read(
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
            return new PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod ReadAsPropertyName(
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
            return new PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesApplyAdvanceResponseLinesItemRecognitionMethod value,
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
