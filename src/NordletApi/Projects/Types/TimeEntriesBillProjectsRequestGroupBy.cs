using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TimeEntriesBillProjectsRequestGroupBy.TimeEntriesBillProjectsRequestGroupBySerializer)
)]
[Serializable]
public readonly record struct TimeEntriesBillProjectsRequestGroupBy : IStringEnum
{
    public static readonly TimeEntriesBillProjectsRequestGroupBy Rate = new(Values.Rate);

    public static readonly TimeEntriesBillProjectsRequestGroupBy Entry = new(Values.Entry);

    public TimeEntriesBillProjectsRequestGroupBy(string value)
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
    public static TimeEntriesBillProjectsRequestGroupBy FromCustom(string value)
    {
        return new TimeEntriesBillProjectsRequestGroupBy(value);
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

    public static bool operator ==(TimeEntriesBillProjectsRequestGroupBy value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimeEntriesBillProjectsRequestGroupBy value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimeEntriesBillProjectsRequestGroupBy value) =>
        value.Value;

    public static explicit operator TimeEntriesBillProjectsRequestGroupBy(string value) =>
        new(value);

    internal class TimeEntriesBillProjectsRequestGroupBySerializer
        : JsonConverter<TimeEntriesBillProjectsRequestGroupBy>
    {
        public override TimeEntriesBillProjectsRequestGroupBy Read(
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
            return new TimeEntriesBillProjectsRequestGroupBy(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TimeEntriesBillProjectsRequestGroupBy value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TimeEntriesBillProjectsRequestGroupBy ReadAsPropertyName(
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
            return new TimeEntriesBillProjectsRequestGroupBy(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TimeEntriesBillProjectsRequestGroupBy value,
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
        public const string Rate = "rate";

        public const string Entry = "entry";
    }
}
