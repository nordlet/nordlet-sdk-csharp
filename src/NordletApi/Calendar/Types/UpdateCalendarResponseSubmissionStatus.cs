using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(UpdateCalendarResponseSubmissionStatus.UpdateCalendarResponseSubmissionStatusSerializer)
)]
[Serializable]
public readonly record struct UpdateCalendarResponseSubmissionStatus : IStringEnum
{
    public static readonly UpdateCalendarResponseSubmissionStatus Generated = new(Values.Generated);

    public static readonly UpdateCalendarResponseSubmissionStatus Submitted = new(Values.Submitted);

    public static readonly UpdateCalendarResponseSubmissionStatus Accepted = new(Values.Accepted);

    public static readonly UpdateCalendarResponseSubmissionStatus Rejected = new(Values.Rejected);

    public UpdateCalendarResponseSubmissionStatus(string value)
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
    public static UpdateCalendarResponseSubmissionStatus FromCustom(string value)
    {
        return new UpdateCalendarResponseSubmissionStatus(value);
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

    public static bool operator ==(UpdateCalendarResponseSubmissionStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateCalendarResponseSubmissionStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateCalendarResponseSubmissionStatus value) =>
        value.Value;

    public static explicit operator UpdateCalendarResponseSubmissionStatus(string value) =>
        new(value);

    internal class UpdateCalendarResponseSubmissionStatusSerializer
        : JsonConverter<UpdateCalendarResponseSubmissionStatus>
    {
        public override UpdateCalendarResponseSubmissionStatus Read(
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
            return new UpdateCalendarResponseSubmissionStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateCalendarResponseSubmissionStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateCalendarResponseSubmissionStatus ReadAsPropertyName(
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
            return new UpdateCalendarResponseSubmissionStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateCalendarResponseSubmissionStatus value,
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
