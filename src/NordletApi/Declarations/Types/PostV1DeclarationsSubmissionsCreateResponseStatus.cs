using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsSubmissionsCreateResponseStatus.PostV1DeclarationsSubmissionsCreateResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsSubmissionsCreateResponseStatus : IStringEnum
{
    public static readonly PostV1DeclarationsSubmissionsCreateResponseStatus Generated = new(
        Values.Generated
    );

    public static readonly PostV1DeclarationsSubmissionsCreateResponseStatus Submitted = new(
        Values.Submitted
    );

    public static readonly PostV1DeclarationsSubmissionsCreateResponseStatus Accepted = new(
        Values.Accepted
    );

    public static readonly PostV1DeclarationsSubmissionsCreateResponseStatus Rejected = new(
        Values.Rejected
    );

    public PostV1DeclarationsSubmissionsCreateResponseStatus(string value)
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
    public static PostV1DeclarationsSubmissionsCreateResponseStatus FromCustom(string value)
    {
        return new PostV1DeclarationsSubmissionsCreateResponseStatus(value);
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
        PostV1DeclarationsSubmissionsCreateResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsSubmissionsCreateResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsSubmissionsCreateResponseStatus value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsSubmissionsCreateResponseStatus(
        string value
    ) => new(value);

    internal class PostV1DeclarationsSubmissionsCreateResponseStatusSerializer
        : JsonConverter<PostV1DeclarationsSubmissionsCreateResponseStatus>
    {
        public override PostV1DeclarationsSubmissionsCreateResponseStatus Read(
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
            return new PostV1DeclarationsSubmissionsCreateResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsSubmissionsCreateResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsSubmissionsCreateResponseStatus ReadAsPropertyName(
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
            return new PostV1DeclarationsSubmissionsCreateResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsSubmissionsCreateResponseStatus value,
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
