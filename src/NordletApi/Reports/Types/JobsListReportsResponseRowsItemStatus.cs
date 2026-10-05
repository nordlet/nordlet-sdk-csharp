using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(JobsListReportsResponseRowsItemStatus.JobsListReportsResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct JobsListReportsResponseRowsItemStatus : IStringEnum
{
    public static readonly JobsListReportsResponseRowsItemStatus Queued = new(Values.Queued);

    public static readonly JobsListReportsResponseRowsItemStatus Running = new(Values.Running);

    public static readonly JobsListReportsResponseRowsItemStatus Completed = new(Values.Completed);

    public static readonly JobsListReportsResponseRowsItemStatus Failed = new(Values.Failed);

    public JobsListReportsResponseRowsItemStatus(string value)
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
    public static JobsListReportsResponseRowsItemStatus FromCustom(string value)
    {
        return new JobsListReportsResponseRowsItemStatus(value);
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

    public static bool operator ==(JobsListReportsResponseRowsItemStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(JobsListReportsResponseRowsItemStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(JobsListReportsResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator JobsListReportsResponseRowsItemStatus(string value) =>
        new(value);

    internal class JobsListReportsResponseRowsItemStatusSerializer
        : JsonConverter<JobsListReportsResponseRowsItemStatus>
    {
        public override JobsListReportsResponseRowsItemStatus Read(
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
            return new JobsListReportsResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            JobsListReportsResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override JobsListReportsResponseRowsItemStatus ReadAsPropertyName(
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
            return new JobsListReportsResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            JobsListReportsResponseRowsItemStatus value,
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
