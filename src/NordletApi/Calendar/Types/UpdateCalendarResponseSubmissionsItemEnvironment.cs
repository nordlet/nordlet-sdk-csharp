using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(UpdateCalendarResponseSubmissionsItemEnvironment.UpdateCalendarResponseSubmissionsItemEnvironmentSerializer)
)]
[Serializable]
public readonly record struct UpdateCalendarResponseSubmissionsItemEnvironment : IStringEnum
{
    public static readonly UpdateCalendarResponseSubmissionsItemEnvironment Test = new(Values.Test);

    public static readonly UpdateCalendarResponseSubmissionsItemEnvironment Production = new(
        Values.Production
    );

    public UpdateCalendarResponseSubmissionsItemEnvironment(string value)
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
    public static UpdateCalendarResponseSubmissionsItemEnvironment FromCustom(string value)
    {
        return new UpdateCalendarResponseSubmissionsItemEnvironment(value);
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
        UpdateCalendarResponseSubmissionsItemEnvironment value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateCalendarResponseSubmissionsItemEnvironment value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdateCalendarResponseSubmissionsItemEnvironment value
    ) => value.Value;

    public static explicit operator UpdateCalendarResponseSubmissionsItemEnvironment(
        string value
    ) => new(value);

    internal class UpdateCalendarResponseSubmissionsItemEnvironmentSerializer
        : JsonConverter<UpdateCalendarResponseSubmissionsItemEnvironment>
    {
        public override UpdateCalendarResponseSubmissionsItemEnvironment Read(
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
            return new UpdateCalendarResponseSubmissionsItemEnvironment(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateCalendarResponseSubmissionsItemEnvironment value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateCalendarResponseSubmissionsItemEnvironment ReadAsPropertyName(
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
            return new UpdateCalendarResponseSubmissionsItemEnvironment(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateCalendarResponseSubmissionsItemEnvironment value,
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
        public const string Test = "test";

        public const string Production = "production";
    }
}
