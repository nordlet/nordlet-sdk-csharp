using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsSubmissionsMarkRequestStatus.PostV1DeclarationsSubmissionsMarkRequestStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsSubmissionsMarkRequestStatus : IStringEnum
{
    public static readonly PostV1DeclarationsSubmissionsMarkRequestStatus Submitted = new(
        Values.Submitted
    );

    public static readonly PostV1DeclarationsSubmissionsMarkRequestStatus Accepted = new(
        Values.Accepted
    );

    public static readonly PostV1DeclarationsSubmissionsMarkRequestStatus Rejected = new(
        Values.Rejected
    );

    public PostV1DeclarationsSubmissionsMarkRequestStatus(string value)
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
    public static PostV1DeclarationsSubmissionsMarkRequestStatus FromCustom(string value)
    {
        return new PostV1DeclarationsSubmissionsMarkRequestStatus(value);
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
        PostV1DeclarationsSubmissionsMarkRequestStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsSubmissionsMarkRequestStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1DeclarationsSubmissionsMarkRequestStatus value) =>
        value.Value;

    public static explicit operator PostV1DeclarationsSubmissionsMarkRequestStatus(string value) =>
        new(value);

    internal class PostV1DeclarationsSubmissionsMarkRequestStatusSerializer
        : JsonConverter<PostV1DeclarationsSubmissionsMarkRequestStatus>
    {
        public override PostV1DeclarationsSubmissionsMarkRequestStatus Read(
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
            return new PostV1DeclarationsSubmissionsMarkRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsSubmissionsMarkRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsSubmissionsMarkRequestStatus ReadAsPropertyName(
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
            return new PostV1DeclarationsSubmissionsMarkRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsSubmissionsMarkRequestStatus value,
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
        public const string Submitted = "submitted";

        public const string Accepted = "accepted";

        public const string Rejected = "rejected";
    }
}
