using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ListCalendarResponseRowsItemSubmissionsItemEnvironment.ListCalendarResponseRowsItemSubmissionsItemEnvironmentSerializer)
)]
[Serializable]
public readonly record struct ListCalendarResponseRowsItemSubmissionsItemEnvironment : IStringEnum
{
    public static readonly ListCalendarResponseRowsItemSubmissionsItemEnvironment Test = new(
        Values.Test
    );

    public static readonly ListCalendarResponseRowsItemSubmissionsItemEnvironment Production = new(
        Values.Production
    );

    public ListCalendarResponseRowsItemSubmissionsItemEnvironment(string value)
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
    public static ListCalendarResponseRowsItemSubmissionsItemEnvironment FromCustom(string value)
    {
        return new ListCalendarResponseRowsItemSubmissionsItemEnvironment(value);
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
        ListCalendarResponseRowsItemSubmissionsItemEnvironment value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListCalendarResponseRowsItemSubmissionsItemEnvironment value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListCalendarResponseRowsItemSubmissionsItemEnvironment value
    ) => value.Value;

    public static explicit operator ListCalendarResponseRowsItemSubmissionsItemEnvironment(
        string value
    ) => new(value);

    internal class ListCalendarResponseRowsItemSubmissionsItemEnvironmentSerializer
        : JsonConverter<ListCalendarResponseRowsItemSubmissionsItemEnvironment>
    {
        public override ListCalendarResponseRowsItemSubmissionsItemEnvironment Read(
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
            return new ListCalendarResponseRowsItemSubmissionsItemEnvironment(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListCalendarResponseRowsItemSubmissionsItemEnvironment value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListCalendarResponseRowsItemSubmissionsItemEnvironment ReadAsPropertyName(
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
            return new ListCalendarResponseRowsItemSubmissionsItemEnvironment(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListCalendarResponseRowsItemSubmissionsItemEnvironment value,
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
