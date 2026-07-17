using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsSubmissionsMarkResponseStatus.PostV1DeclarationsSubmissionsMarkResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsSubmissionsMarkResponseStatus : IStringEnum
{
    public static readonly PostV1DeclarationsSubmissionsMarkResponseStatus Generated = new(
        Values.Generated
    );

    public static readonly PostV1DeclarationsSubmissionsMarkResponseStatus Submitted = new(
        Values.Submitted
    );

    public static readonly PostV1DeclarationsSubmissionsMarkResponseStatus Accepted = new(
        Values.Accepted
    );

    public static readonly PostV1DeclarationsSubmissionsMarkResponseStatus Rejected = new(
        Values.Rejected
    );

    public PostV1DeclarationsSubmissionsMarkResponseStatus(string value)
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
    public static PostV1DeclarationsSubmissionsMarkResponseStatus FromCustom(string value)
    {
        return new PostV1DeclarationsSubmissionsMarkResponseStatus(value);
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
        PostV1DeclarationsSubmissionsMarkResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsSubmissionsMarkResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1DeclarationsSubmissionsMarkResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1DeclarationsSubmissionsMarkResponseStatus(string value) =>
        new(value);

    internal class PostV1DeclarationsSubmissionsMarkResponseStatusSerializer
        : JsonConverter<PostV1DeclarationsSubmissionsMarkResponseStatus>
    {
        public override PostV1DeclarationsSubmissionsMarkResponseStatus Read(
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
            return new PostV1DeclarationsSubmissionsMarkResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsSubmissionsMarkResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsSubmissionsMarkResponseStatus ReadAsPropertyName(
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
            return new PostV1DeclarationsSubmissionsMarkResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsSubmissionsMarkResponseStatus value,
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
