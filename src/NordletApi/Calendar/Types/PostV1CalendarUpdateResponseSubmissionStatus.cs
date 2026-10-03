using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CalendarUpdateResponseSubmissionStatus.PostV1CalendarUpdateResponseSubmissionStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1CalendarUpdateResponseSubmissionStatus : IStringEnum
{
    public static readonly PostV1CalendarUpdateResponseSubmissionStatus Generated = new(
        Values.Generated
    );

    public static readonly PostV1CalendarUpdateResponseSubmissionStatus Submitted = new(
        Values.Submitted
    );

    public static readonly PostV1CalendarUpdateResponseSubmissionStatus Accepted = new(
        Values.Accepted
    );

    public static readonly PostV1CalendarUpdateResponseSubmissionStatus Rejected = new(
        Values.Rejected
    );

    public PostV1CalendarUpdateResponseSubmissionStatus(string value)
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
    public static PostV1CalendarUpdateResponseSubmissionStatus FromCustom(string value)
    {
        return new PostV1CalendarUpdateResponseSubmissionStatus(value);
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
        PostV1CalendarUpdateResponseSubmissionStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1CalendarUpdateResponseSubmissionStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CalendarUpdateResponseSubmissionStatus value) =>
        value.Value;

    public static explicit operator PostV1CalendarUpdateResponseSubmissionStatus(string value) =>
        new(value);

    internal class PostV1CalendarUpdateResponseSubmissionStatusSerializer
        : JsonConverter<PostV1CalendarUpdateResponseSubmissionStatus>
    {
        public override PostV1CalendarUpdateResponseSubmissionStatus Read(
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
            return new PostV1CalendarUpdateResponseSubmissionStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CalendarUpdateResponseSubmissionStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CalendarUpdateResponseSubmissionStatus ReadAsPropertyName(
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
            return new PostV1CalendarUpdateResponseSubmissionStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CalendarUpdateResponseSubmissionStatus value,
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
