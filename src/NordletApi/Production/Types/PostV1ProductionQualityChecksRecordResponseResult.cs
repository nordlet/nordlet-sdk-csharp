using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProductionQualityChecksRecordResponseResult.PostV1ProductionQualityChecksRecordResponseResultSerializer)
)]
[Serializable]
public readonly record struct PostV1ProductionQualityChecksRecordResponseResult : IStringEnum
{
    public static readonly PostV1ProductionQualityChecksRecordResponseResult Pending = new(
        Values.Pending
    );

    public static readonly PostV1ProductionQualityChecksRecordResponseResult Passed = new(
        Values.Passed
    );

    public static readonly PostV1ProductionQualityChecksRecordResponseResult Failed = new(
        Values.Failed
    );

    public PostV1ProductionQualityChecksRecordResponseResult(string value)
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
    public static PostV1ProductionQualityChecksRecordResponseResult FromCustom(string value)
    {
        return new PostV1ProductionQualityChecksRecordResponseResult(value);
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
        PostV1ProductionQualityChecksRecordResponseResult value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ProductionQualityChecksRecordResponseResult value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ProductionQualityChecksRecordResponseResult value
    ) => value.Value;

    public static explicit operator PostV1ProductionQualityChecksRecordResponseResult(
        string value
    ) => new(value);

    internal class PostV1ProductionQualityChecksRecordResponseResultSerializer
        : JsonConverter<PostV1ProductionQualityChecksRecordResponseResult>
    {
        public override PostV1ProductionQualityChecksRecordResponseResult Read(
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
            return new PostV1ProductionQualityChecksRecordResponseResult(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProductionQualityChecksRecordResponseResult value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProductionQualityChecksRecordResponseResult ReadAsPropertyName(
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
            return new PostV1ProductionQualityChecksRecordResponseResult(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProductionQualityChecksRecordResponseResult value,
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

        public const string Passed = "passed";

        public const string Failed = "failed";
    }
}
