using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReportsJobsGetResponseStatus.PostV1ReportsJobsGetResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1ReportsJobsGetResponseStatus : IStringEnum
{
    public static readonly PostV1ReportsJobsGetResponseStatus Queued = new(Values.Queued);

    public static readonly PostV1ReportsJobsGetResponseStatus Running = new(Values.Running);

    public static readonly PostV1ReportsJobsGetResponseStatus Completed = new(Values.Completed);

    public static readonly PostV1ReportsJobsGetResponseStatus Failed = new(Values.Failed);

    public PostV1ReportsJobsGetResponseStatus(string value)
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
    public static PostV1ReportsJobsGetResponseStatus FromCustom(string value)
    {
        return new PostV1ReportsJobsGetResponseStatus(value);
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

    public static bool operator ==(PostV1ReportsJobsGetResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1ReportsJobsGetResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ReportsJobsGetResponseStatus value) => value.Value;

    public static explicit operator PostV1ReportsJobsGetResponseStatus(string value) => new(value);

    internal class PostV1ReportsJobsGetResponseStatusSerializer
        : JsonConverter<PostV1ReportsJobsGetResponseStatus>
    {
        public override PostV1ReportsJobsGetResponseStatus Read(
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
            return new PostV1ReportsJobsGetResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReportsJobsGetResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReportsJobsGetResponseStatus ReadAsPropertyName(
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
            return new PostV1ReportsJobsGetResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReportsJobsGetResponseStatus value,
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
        public const string Queued = "queued";

        public const string Running = "running";

        public const string Completed = "completed";

        public const string Failed = "failed";
    }
}
