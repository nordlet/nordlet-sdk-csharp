using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CreateCalendarResponseSubmissionEnvironment.CreateCalendarResponseSubmissionEnvironmentSerializer)
)]
[Serializable]
public readonly record struct CreateCalendarResponseSubmissionEnvironment : IStringEnum
{
    public static readonly CreateCalendarResponseSubmissionEnvironment Test = new(Values.Test);

    public static readonly CreateCalendarResponseSubmissionEnvironment Production = new(
        Values.Production
    );

    public CreateCalendarResponseSubmissionEnvironment(string value)
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
    public static CreateCalendarResponseSubmissionEnvironment FromCustom(string value)
    {
        return new CreateCalendarResponseSubmissionEnvironment(value);
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
        CreateCalendarResponseSubmissionEnvironment value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateCalendarResponseSubmissionEnvironment value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CreateCalendarResponseSubmissionEnvironment value) =>
        value.Value;

    public static explicit operator CreateCalendarResponseSubmissionEnvironment(string value) =>
        new(value);

    internal class CreateCalendarResponseSubmissionEnvironmentSerializer
        : JsonConverter<CreateCalendarResponseSubmissionEnvironment>
    {
        public override CreateCalendarResponseSubmissionEnvironment Read(
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
            return new CreateCalendarResponseSubmissionEnvironment(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateCalendarResponseSubmissionEnvironment value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateCalendarResponseSubmissionEnvironment ReadAsPropertyName(
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
            return new CreateCalendarResponseSubmissionEnvironment(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateCalendarResponseSubmissionEnvironment value,
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
