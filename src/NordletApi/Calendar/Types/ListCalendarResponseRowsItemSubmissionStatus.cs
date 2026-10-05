using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ListCalendarResponseRowsItemSubmissionStatus.ListCalendarResponseRowsItemSubmissionStatusSerializer)
)]
[Serializable]
public readonly record struct ListCalendarResponseRowsItemSubmissionStatus : IStringEnum
{
    public static readonly ListCalendarResponseRowsItemSubmissionStatus Generated = new(
        Values.Generated
    );

    public static readonly ListCalendarResponseRowsItemSubmissionStatus Submitted = new(
        Values.Submitted
    );

    public static readonly ListCalendarResponseRowsItemSubmissionStatus Accepted = new(
        Values.Accepted
    );

    public static readonly ListCalendarResponseRowsItemSubmissionStatus Rejected = new(
        Values.Rejected
    );

    public ListCalendarResponseRowsItemSubmissionStatus(string value)
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
    public static ListCalendarResponseRowsItemSubmissionStatus FromCustom(string value)
    {
        return new ListCalendarResponseRowsItemSubmissionStatus(value);
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
        ListCalendarResponseRowsItemSubmissionStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListCalendarResponseRowsItemSubmissionStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListCalendarResponseRowsItemSubmissionStatus value) =>
        value.Value;

    public static explicit operator ListCalendarResponseRowsItemSubmissionStatus(string value) =>
        new(value);

    internal class ListCalendarResponseRowsItemSubmissionStatusSerializer
        : JsonConverter<ListCalendarResponseRowsItemSubmissionStatus>
    {
        public override ListCalendarResponseRowsItemSubmissionStatus Read(
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
            return new ListCalendarResponseRowsItemSubmissionStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListCalendarResponseRowsItemSubmissionStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListCalendarResponseRowsItemSubmissionStatus ReadAsPropertyName(
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
            return new ListCalendarResponseRowsItemSubmissionStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListCalendarResponseRowsItemSubmissionStatus value,
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
        public const string Generated = "generated";

        public const string Submitted = "submitted";

        public const string Accepted = "accepted";

        public const string Rejected = "rejected";
    }
}
