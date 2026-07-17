using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesActsIssueResponseStatus.PostV1SalesActsIssueResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesActsIssueResponseStatus : IStringEnum
{
    public static readonly PostV1SalesActsIssueResponseStatus Draft = new(Values.Draft);

    public static readonly PostV1SalesActsIssueResponseStatus Issued = new(Values.Issued);

    public static readonly PostV1SalesActsIssueResponseStatus Cancelled = new(Values.Cancelled);

    public PostV1SalesActsIssueResponseStatus(string value)
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
    public static PostV1SalesActsIssueResponseStatus FromCustom(string value)
    {
        return new PostV1SalesActsIssueResponseStatus(value);
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

    public static bool operator ==(PostV1SalesActsIssueResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1SalesActsIssueResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesActsIssueResponseStatus value) => value.Value;

    public static explicit operator PostV1SalesActsIssueResponseStatus(string value) => new(value);

    internal class PostV1SalesActsIssueResponseStatusSerializer
        : JsonConverter<PostV1SalesActsIssueResponseStatus>
    {
        public override PostV1SalesActsIssueResponseStatus Read(
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
            return new PostV1SalesActsIssueResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesActsIssueResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesActsIssueResponseStatus ReadAsPropertyName(
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
            return new PostV1SalesActsIssueResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesActsIssueResponseStatus value,
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
        public const string Draft = "draft";

        public const string Issued = "issued";

        public const string Cancelled = "cancelled";
    }
}
