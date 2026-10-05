using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(JobsCreateReportsResponseStatus.JobsCreateReportsResponseStatusSerializer))]
[Serializable]
public readonly record struct JobsCreateReportsResponseStatus : IStringEnum
{
    public static readonly JobsCreateReportsResponseStatus Queued = new(Values.Queued);

    public static readonly JobsCreateReportsResponseStatus Running = new(Values.Running);

    public static readonly JobsCreateReportsResponseStatus Completed = new(Values.Completed);

    public static readonly JobsCreateReportsResponseStatus Failed = new(Values.Failed);

    public JobsCreateReportsResponseStatus(string value)
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
    public static JobsCreateReportsResponseStatus FromCustom(string value)
    {
        return new JobsCreateReportsResponseStatus(value);
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

    public static bool operator ==(JobsCreateReportsResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(JobsCreateReportsResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(JobsCreateReportsResponseStatus value) => value.Value;

    public static explicit operator JobsCreateReportsResponseStatus(string value) => new(value);

    internal class JobsCreateReportsResponseStatusSerializer
        : JsonConverter<JobsCreateReportsResponseStatus>
    {
        public override JobsCreateReportsResponseStatus Read(
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
            return new JobsCreateReportsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            JobsCreateReportsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override JobsCreateReportsResponseStatus ReadAsPropertyName(
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
            return new JobsCreateReportsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            JobsCreateReportsResponseStatus value,
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
