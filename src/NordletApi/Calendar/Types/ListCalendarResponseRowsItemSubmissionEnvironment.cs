using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ListCalendarResponseRowsItemSubmissionEnvironment.ListCalendarResponseRowsItemSubmissionEnvironmentSerializer)
)]
[Serializable]
public readonly record struct ListCalendarResponseRowsItemSubmissionEnvironment : IStringEnum
{
    public static readonly ListCalendarResponseRowsItemSubmissionEnvironment Test = new(
        Values.Test
    );

    public static readonly ListCalendarResponseRowsItemSubmissionEnvironment Production = new(
        Values.Production
    );

    public ListCalendarResponseRowsItemSubmissionEnvironment(string value)
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
    public static ListCalendarResponseRowsItemSubmissionEnvironment FromCustom(string value)
    {
        return new ListCalendarResponseRowsItemSubmissionEnvironment(value);
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
        ListCalendarResponseRowsItemSubmissionEnvironment value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListCalendarResponseRowsItemSubmissionEnvironment value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListCalendarResponseRowsItemSubmissionEnvironment value
    ) => value.Value;

    public static explicit operator ListCalendarResponseRowsItemSubmissionEnvironment(
        string value
    ) => new(value);

    internal class ListCalendarResponseRowsItemSubmissionEnvironmentSerializer
        : JsonConverter<ListCalendarResponseRowsItemSubmissionEnvironment>
    {
        public override ListCalendarResponseRowsItemSubmissionEnvironment Read(
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
            return new ListCalendarResponseRowsItemSubmissionEnvironment(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListCalendarResponseRowsItemSubmissionEnvironment value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListCalendarResponseRowsItemSubmissionEnvironment ReadAsPropertyName(
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
            return new ListCalendarResponseRowsItemSubmissionEnvironment(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListCalendarResponseRowsItemSubmissionEnvironment value,
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
        public const string Test = "test";

        public const string Production = "production";
    }
}
