using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PostV1ProjectsGetResponseStatus.PostV1ProjectsGetResponseStatusSerializer))]
[Serializable]
public readonly record struct PostV1ProjectsGetResponseStatus : IStringEnum
{
    public static readonly PostV1ProjectsGetResponseStatus Active = new(Values.Active);

    public static readonly PostV1ProjectsGetResponseStatus Completed = new(Values.Completed);

    public static readonly PostV1ProjectsGetResponseStatus Archived = new(Values.Archived);

    public PostV1ProjectsGetResponseStatus(string value)
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
    public static PostV1ProjectsGetResponseStatus FromCustom(string value)
    {
        return new PostV1ProjectsGetResponseStatus(value);
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

    public static bool operator ==(PostV1ProjectsGetResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1ProjectsGetResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ProjectsGetResponseStatus value) => value.Value;

    public static explicit operator PostV1ProjectsGetResponseStatus(string value) => new(value);

    internal class PostV1ProjectsGetResponseStatusSerializer
        : JsonConverter<PostV1ProjectsGetResponseStatus>
    {
        public override PostV1ProjectsGetResponseStatus Read(
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
            return new PostV1ProjectsGetResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProjectsGetResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProjectsGetResponseStatus ReadAsPropertyName(
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
            return new PostV1ProjectsGetResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProjectsGetResponseStatus value,
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
