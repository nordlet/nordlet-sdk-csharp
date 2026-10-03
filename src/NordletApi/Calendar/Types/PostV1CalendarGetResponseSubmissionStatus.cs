using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CalendarGetResponseSubmissionStatus.PostV1CalendarGetResponseSubmissionStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1CalendarGetResponseSubmissionStatus : IStringEnum
{
    public static readonly PostV1CalendarGetResponseSubmissionStatus Generated = new(
        Values.Generated
    );

    public static readonly PostV1CalendarGetResponseSubmissionStatus Submitted = new(
        Values.Submitted
    );

    public static readonly PostV1CalendarGetResponseSubmissionStatus Accepted = new(
        Values.Accepted
    );

    public static readonly PostV1CalendarGetResponseSubmissionStatus Rejected = new(
        Values.Rejected
    );

    public PostV1CalendarGetResponseSubmissionStatus(string value)
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
    public static PostV1CalendarGetResponseSubmissionStatus FromCustom(string value)
    {
        return new PostV1CalendarGetResponseSubmissionStatus(value);
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
        PostV1CalendarGetResponseSubmissionStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1CalendarGetResponseSubmissionStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CalendarGetResponseSubmissionStatus value) =>
        value.Value;

    public static explicit operator PostV1CalendarGetResponseSubmissionStatus(string value) =>
        new(value);

    internal class PostV1CalendarGetResponseSubmissionStatusSerializer
        : JsonConverter<PostV1CalendarGetResponseSubmissionStatus>
    {
        public override PostV1CalendarGetResponseSubmissionStatus Read(
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
            return new PostV1CalendarGetResponseSubmissionStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CalendarGetResponseSubmissionStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CalendarGetResponseSubmissionStatus ReadAsPropertyName(
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
            return new PostV1CalendarGetResponseSubmissionStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CalendarGetResponseSubmissionStatus value,
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
