using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PayrollRunsApproveResponseStatus.PostV1PayrollRunsApproveResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PayrollRunsApproveResponseStatus : IStringEnum
{
    public static readonly PostV1PayrollRunsApproveResponseStatus Draft = new(Values.Draft);

    public static readonly PostV1PayrollRunsApproveResponseStatus Approved = new(Values.Approved);

    public PostV1PayrollRunsApproveResponseStatus(string value)
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
    public static PostV1PayrollRunsApproveResponseStatus FromCustom(string value)
    {
        return new PostV1PayrollRunsApproveResponseStatus(value);
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

    public static bool operator ==(PostV1PayrollRunsApproveResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1PayrollRunsApproveResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PayrollRunsApproveResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1PayrollRunsApproveResponseStatus(string value) =>
        new(value);

    internal class PostV1PayrollRunsApproveResponseStatusSerializer
        : JsonConverter<PostV1PayrollRunsApproveResponseStatus>
    {
        public override PostV1PayrollRunsApproveResponseStatus Read(
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
            return new PostV1PayrollRunsApproveResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PayrollRunsApproveResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PayrollRunsApproveResponseStatus ReadAsPropertyName(
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
            return new PostV1PayrollRunsApproveResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PayrollRunsApproveResponseStatus value,
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

        public const string Approved = "approved";
    }
}
