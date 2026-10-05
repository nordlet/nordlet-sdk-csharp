using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(UpdateProjectsResponseStatus.UpdateProjectsResponseStatusSerializer))]
[Serializable]
public readonly record struct UpdateProjectsResponseStatus : IStringEnum
{
    public static readonly UpdateProjectsResponseStatus Active = new(Values.Active);

    public static readonly UpdateProjectsResponseStatus Completed = new(Values.Completed);

    public static readonly UpdateProjectsResponseStatus Archived = new(Values.Archived);

    public UpdateProjectsResponseStatus(string value)
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
    public static UpdateProjectsResponseStatus FromCustom(string value)
    {
        return new UpdateProjectsResponseStatus(value);
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

    public static bool operator ==(UpdateProjectsResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateProjectsResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateProjectsResponseStatus value) => value.Value;

    public static explicit operator UpdateProjectsResponseStatus(string value) => new(value);

    internal class UpdateProjectsResponseStatusSerializer
        : JsonConverter<UpdateProjectsResponseStatus>
    {
        public override UpdateProjectsResponseStatus Read(
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
            return new UpdateProjectsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateProjectsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateProjectsResponseStatus ReadAsPropertyName(
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
            return new UpdateProjectsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateProjectsResponseStatus value,
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
