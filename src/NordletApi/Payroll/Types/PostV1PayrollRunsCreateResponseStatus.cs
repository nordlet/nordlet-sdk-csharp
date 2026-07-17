using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PayrollRunsCreateResponseStatus.PostV1PayrollRunsCreateResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PayrollRunsCreateResponseStatus : IStringEnum
{
    public static readonly PostV1PayrollRunsCreateResponseStatus Draft = new(Values.Draft);

    public static readonly PostV1PayrollRunsCreateResponseStatus Approved = new(Values.Approved);

    public PostV1PayrollRunsCreateResponseStatus(string value)
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
    public static PostV1PayrollRunsCreateResponseStatus FromCustom(string value)
    {
        return new PostV1PayrollRunsCreateResponseStatus(value);
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

    public static bool operator ==(PostV1PayrollRunsCreateResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1PayrollRunsCreateResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PayrollRunsCreateResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1PayrollRunsCreateResponseStatus(string value) =>
        new(value);

    internal class PostV1PayrollRunsCreateResponseStatusSerializer
        : JsonConverter<PostV1PayrollRunsCreateResponseStatus>
    {
        public override PostV1PayrollRunsCreateResponseStatus Read(
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
            return new PostV1PayrollRunsCreateResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PayrollRunsCreateResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PayrollRunsCreateResponseStatus ReadAsPropertyName(
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
            return new PostV1PayrollRunsCreateResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PayrollRunsCreateResponseStatus value,
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
