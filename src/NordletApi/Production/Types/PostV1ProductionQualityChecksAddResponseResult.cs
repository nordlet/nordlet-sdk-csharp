using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProductionQualityChecksAddResponseResult.PostV1ProductionQualityChecksAddResponseResultSerializer)
)]
[Serializable]
public readonly record struct PostV1ProductionQualityChecksAddResponseResult : IStringEnum
{
    public static readonly PostV1ProductionQualityChecksAddResponseResult Pending = new(
        Values.Pending
    );

    public static readonly PostV1ProductionQualityChecksAddResponseResult Passed = new(
        Values.Passed
    );

    public static readonly PostV1ProductionQualityChecksAddResponseResult Failed = new(
        Values.Failed
    );

    public PostV1ProductionQualityChecksAddResponseResult(string value)
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
    public static PostV1ProductionQualityChecksAddResponseResult FromCustom(string value)
    {
        return new PostV1ProductionQualityChecksAddResponseResult(value);
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
        PostV1ProductionQualityChecksAddResponseResult value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ProductionQualityChecksAddResponseResult value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ProductionQualityChecksAddResponseResult value) =>
        value.Value;

    public static explicit operator PostV1ProductionQualityChecksAddResponseResult(string value) =>
        new(value);

    internal class PostV1ProductionQualityChecksAddResponseResultSerializer
        : JsonConverter<PostV1ProductionQualityChecksAddResponseResult>
    {
        public override PostV1ProductionQualityChecksAddResponseResult Read(
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
            return new PostV1ProductionQualityChecksAddResponseResult(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProductionQualityChecksAddResponseResult value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProductionQualityChecksAddResponseResult ReadAsPropertyName(
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
            return new PostV1ProductionQualityChecksAddResponseResult(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProductionQualityChecksAddResponseResult value,
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
