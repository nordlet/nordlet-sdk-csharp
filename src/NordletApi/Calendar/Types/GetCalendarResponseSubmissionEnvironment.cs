using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GetCalendarResponseSubmissionEnvironment.GetCalendarResponseSubmissionEnvironmentSerializer)
)]
[Serializable]
public readonly record struct GetCalendarResponseSubmissionEnvironment : IStringEnum
{
    public static readonly GetCalendarResponseSubmissionEnvironment Test = new(Values.Test);

    public static readonly GetCalendarResponseSubmissionEnvironment Production = new(
        Values.Production
    );

    public GetCalendarResponseSubmissionEnvironment(string value)
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
    public static GetCalendarResponseSubmissionEnvironment FromCustom(string value)
    {
        return new GetCalendarResponseSubmissionEnvironment(value);
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
        GetCalendarResponseSubmissionEnvironment value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetCalendarResponseSubmissionEnvironment value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetCalendarResponseSubmissionEnvironment value) =>
        value.Value;

    public static explicit operator GetCalendarResponseSubmissionEnvironment(string value) =>
        new(value);

    internal class GetCalendarResponseSubmissionEnvironmentSerializer
        : JsonConverter<GetCalendarResponseSubmissionEnvironment>
    {
        public override GetCalendarResponseSubmissionEnvironment Read(
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
            return new GetCalendarResponseSubmissionEnvironment(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetCalendarResponseSubmissionEnvironment value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetCalendarResponseSubmissionEnvironment ReadAsPropertyName(
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
            return new GetCalendarResponseSubmissionEnvironment(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetCalendarResponseSubmissionEnvironment value,
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
