using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReportsJobsListResponseRowsItemStatus.PostV1ReportsJobsListResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1ReportsJobsListResponseRowsItemStatus : IStringEnum
{
    public static readonly PostV1ReportsJobsListResponseRowsItemStatus Queued = new(Values.Queued);

    public static readonly PostV1ReportsJobsListResponseRowsItemStatus Running = new(
        Values.Running
    );

    public static readonly PostV1ReportsJobsListResponseRowsItemStatus Completed = new(
        Values.Completed
    );

    public static readonly PostV1ReportsJobsListResponseRowsItemStatus Failed = new(Values.Failed);

    public PostV1ReportsJobsListResponseRowsItemStatus(string value)
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
    public static PostV1ReportsJobsListResponseRowsItemStatus FromCustom(string value)
    {
        return new PostV1ReportsJobsListResponseRowsItemStatus(value);
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
        PostV1ReportsJobsListResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReportsJobsListResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ReportsJobsListResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator PostV1ReportsJobsListResponseRowsItemStatus(string value) =>
        new(value);

    internal class PostV1ReportsJobsListResponseRowsItemStatusSerializer
        : JsonConverter<PostV1ReportsJobsListResponseRowsItemStatus>
    {
        public override PostV1ReportsJobsListResponseRowsItemStatus Read(
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
            return new PostV1ReportsJobsListResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReportsJobsListResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReportsJobsListResponseRowsItemStatus ReadAsPropertyName(
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
            return new PostV1ReportsJobsListResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReportsJobsListResponseRowsItemStatus value,
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
