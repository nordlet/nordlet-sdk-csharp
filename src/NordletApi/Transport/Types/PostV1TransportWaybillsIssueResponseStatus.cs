using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1TransportWaybillsIssueResponseStatus.PostV1TransportWaybillsIssueResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1TransportWaybillsIssueResponseStatus : IStringEnum
{
    public static readonly PostV1TransportWaybillsIssueResponseStatus Draft = new(Values.Draft);

    public static readonly PostV1TransportWaybillsIssueResponseStatus Issued = new(Values.Issued);

    public static readonly PostV1TransportWaybillsIssueResponseStatus Cancelled = new(
        Values.Cancelled
    );

    public PostV1TransportWaybillsIssueResponseStatus(string value)
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
    public static PostV1TransportWaybillsIssueResponseStatus FromCustom(string value)
    {
        return new PostV1TransportWaybillsIssueResponseStatus(value);
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
        PostV1TransportWaybillsIssueResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1TransportWaybillsIssueResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1TransportWaybillsIssueResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1TransportWaybillsIssueResponseStatus(string value) =>
        new(value);

    internal class PostV1TransportWaybillsIssueResponseStatusSerializer
        : JsonConverter<PostV1TransportWaybillsIssueResponseStatus>
    {
        public override PostV1TransportWaybillsIssueResponseStatus Read(
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
            return new PostV1TransportWaybillsIssueResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1TransportWaybillsIssueResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1TransportWaybillsIssueResponseStatus ReadAsPropertyName(
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
            return new PostV1TransportWaybillsIssueResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1TransportWaybillsIssueResponseStatus value,
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
