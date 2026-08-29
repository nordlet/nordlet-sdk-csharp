using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProjectsCreateResponseStatus.PostV1ProjectsCreateResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1ProjectsCreateResponseStatus : IStringEnum
{
    public static readonly PostV1ProjectsCreateResponseStatus Active = new(Values.Active);

    public static readonly PostV1ProjectsCreateResponseStatus Completed = new(Values.Completed);

    public static readonly PostV1ProjectsCreateResponseStatus Archived = new(Values.Archived);

    public PostV1ProjectsCreateResponseStatus(string value)
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
    public static PostV1ProjectsCreateResponseStatus FromCustom(string value)
    {
        return new PostV1ProjectsCreateResponseStatus(value);
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

    public static bool operator ==(PostV1ProjectsCreateResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1ProjectsCreateResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ProjectsCreateResponseStatus value) => value.Value;

    public static explicit operator PostV1ProjectsCreateResponseStatus(string value) => new(value);

    internal class PostV1ProjectsCreateResponseStatusSerializer
        : JsonConverter<PostV1ProjectsCreateResponseStatus>
    {
        public override PostV1ProjectsCreateResponseStatus Read(
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
            return new PostV1ProjectsCreateResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProjectsCreateResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProjectsCreateResponseStatus ReadAsPropertyName(
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
            return new PostV1ProjectsCreateResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProjectsCreateResponseStatus value,
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
        public const string Active = "active";

        public const string Completed = "completed";

        public const string Archived = "archived";
    }
}
