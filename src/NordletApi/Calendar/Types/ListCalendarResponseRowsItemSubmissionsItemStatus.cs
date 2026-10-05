using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ListCalendarResponseRowsItemSubmissionsItemStatus.ListCalendarResponseRowsItemSubmissionsItemStatusSerializer)
)]
[Serializable]
public readonly record struct ListCalendarResponseRowsItemSubmissionsItemStatus : IStringEnum
{
    public static readonly ListCalendarResponseRowsItemSubmissionsItemStatus Generated = new(
        Values.Generated
    );

    public static readonly ListCalendarResponseRowsItemSubmissionsItemStatus Submitted = new(
        Values.Submitted
    );

    public static readonly ListCalendarResponseRowsItemSubmissionsItemStatus Accepted = new(
        Values.Accepted
    );

    public static readonly ListCalendarResponseRowsItemSubmissionsItemStatus Rejected = new(
        Values.Rejected
    );

    public ListCalendarResponseRowsItemSubmissionsItemStatus(string value)
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
    public static ListCalendarResponseRowsItemSubmissionsItemStatus FromCustom(string value)
    {
        return new ListCalendarResponseRowsItemSubmissionsItemStatus(value);
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
        ListCalendarResponseRowsItemSubmissionsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListCalendarResponseRowsItemSubmissionsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListCalendarResponseRowsItemSubmissionsItemStatus value
    ) => value.Value;

    public static explicit operator ListCalendarResponseRowsItemSubmissionsItemStatus(
        string value
    ) => new(value);

    internal class ListCalendarResponseRowsItemSubmissionsItemStatusSerializer
        : JsonConverter<ListCalendarResponseRowsItemSubmissionsItemStatus>
    {
        public override ListCalendarResponseRowsItemSubmissionsItemStatus Read(
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
            return new ListCalendarResponseRowsItemSubmissionsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListCalendarResponseRowsItemSubmissionsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListCalendarResponseRowsItemSubmissionsItemStatus ReadAsPropertyName(
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
            return new ListCalendarResponseRowsItemSubmissionsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListCalendarResponseRowsItemSubmissionsItemStatus value,
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
