using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(GetProjectsResponseStatus.GetProjectsResponseStatusSerializer))]
[Serializable]
public readonly record struct GetProjectsResponseStatus : IStringEnum
{
    public static readonly GetProjectsResponseStatus Active = new(Values.Active);

    public static readonly GetProjectsResponseStatus Completed = new(Values.Completed);

    public static readonly GetProjectsResponseStatus Archived = new(Values.Archived);

    public GetProjectsResponseStatus(string value)
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
    public static GetProjectsResponseStatus FromCustom(string value)
    {
        return new GetProjectsResponseStatus(value);
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

    public static bool operator ==(GetProjectsResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetProjectsResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetProjectsResponseStatus value) => value.Value;

    public static explicit operator GetProjectsResponseStatus(string value) => new(value);

    internal class GetProjectsResponseStatusSerializer : JsonConverter<GetProjectsResponseStatus>
    {
        public override GetProjectsResponseStatus Read(
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
            return new GetProjectsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetProjectsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetProjectsResponseStatus ReadAsPropertyName(
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
            return new GetProjectsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetProjectsResponseStatus value,
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
