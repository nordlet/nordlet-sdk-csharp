using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProductionQualityChecksRecordRequestResult.PostV1ProductionQualityChecksRecordRequestResultSerializer)
)]
[Serializable]
public readonly record struct PostV1ProductionQualityChecksRecordRequestResult : IStringEnum
{
    public static readonly PostV1ProductionQualityChecksRecordRequestResult Passed = new(
        Values.Passed
    );

    public static readonly PostV1ProductionQualityChecksRecordRequestResult Failed = new(
        Values.Failed
    );

    public PostV1ProductionQualityChecksRecordRequestResult(string value)
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
    public static PostV1ProductionQualityChecksRecordRequestResult FromCustom(string value)
    {
        return new PostV1ProductionQualityChecksRecordRequestResult(value);
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
        PostV1ProductionQualityChecksRecordRequestResult value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ProductionQualityChecksRecordRequestResult value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ProductionQualityChecksRecordRequestResult value
    ) => value.Value;

    public static explicit operator PostV1ProductionQualityChecksRecordRequestResult(
        string value
    ) => new(value);

    internal class PostV1ProductionQualityChecksRecordRequestResultSerializer
        : JsonConverter<PostV1ProductionQualityChecksRecordRequestResult>
    {
        public override PostV1ProductionQualityChecksRecordRequestResult Read(
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
            return new PostV1ProductionQualityChecksRecordRequestResult(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProductionQualityChecksRecordRequestResult value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProductionQualityChecksRecordRequestResult ReadAsPropertyName(
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
            return new PostV1ProductionQualityChecksRecordRequestResult(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProductionQualityChecksRecordRequestResult value,
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
        public const string Passed = "passed";

        public const string Failed = "failed";
    }
}
