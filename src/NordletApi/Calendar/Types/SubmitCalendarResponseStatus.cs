using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(SubmitCalendarResponseStatus.SubmitCalendarResponseStatusSerializer))]
[Serializable]
public readonly record struct SubmitCalendarResponseStatus : IStringEnum
{
    public static readonly SubmitCalendarResponseStatus Generated = new(Values.Generated);

    public static readonly SubmitCalendarResponseStatus Submitted = new(Values.Submitted);

    public static readonly SubmitCalendarResponseStatus Accepted = new(Values.Accepted);

    public static readonly SubmitCalendarResponseStatus Rejected = new(Values.Rejected);

    public SubmitCalendarResponseStatus(string value)
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
    public static SubmitCalendarResponseStatus FromCustom(string value)
    {
        return new SubmitCalendarResponseStatus(value);
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

    public static bool operator ==(SubmitCalendarResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SubmitCalendarResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SubmitCalendarResponseStatus value) => value.Value;

    public static explicit operator SubmitCalendarResponseStatus(string value) => new(value);

    internal class SubmitCalendarResponseStatusSerializer
        : JsonConverter<SubmitCalendarResponseStatus>
    {
        public override SubmitCalendarResponseStatus Read(
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
            return new SubmitCalendarResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubmitCalendarResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubmitCalendarResponseStatus ReadAsPropertyName(
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
            return new SubmitCalendarResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubmitCalendarResponseStatus value,
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
