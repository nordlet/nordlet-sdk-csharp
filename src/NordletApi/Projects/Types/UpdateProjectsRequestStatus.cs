using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(UpdateProjectsRequestStatus.UpdateProjectsRequestStatusSerializer))]
[Serializable]
public readonly record struct UpdateProjectsRequestStatus : IStringEnum
{
    public static readonly UpdateProjectsRequestStatus Active = new(Values.Active);

    public static readonly UpdateProjectsRequestStatus Completed = new(Values.Completed);

    public static readonly UpdateProjectsRequestStatus Archived = new(Values.Archived);

    public UpdateProjectsRequestStatus(string value)
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
    public static UpdateProjectsRequestStatus FromCustom(string value)
    {
        return new UpdateProjectsRequestStatus(value);
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

    public static bool operator ==(UpdateProjectsRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateProjectsRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateProjectsRequestStatus value) => value.Value;

    public static explicit operator UpdateProjectsRequestStatus(string value) => new(value);

    internal class UpdateProjectsRequestStatusSerializer
        : JsonConverter<UpdateProjectsRequestStatus>
    {
        public override UpdateProjectsRequestStatus Read(
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
            return new UpdateProjectsRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateProjectsRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateProjectsRequestStatus ReadAsPropertyName(
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
            return new UpdateProjectsRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateProjectsRequestStatus value,
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
