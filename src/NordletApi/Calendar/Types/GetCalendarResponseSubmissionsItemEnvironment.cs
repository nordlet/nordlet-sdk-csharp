using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GetCalendarResponseSubmissionsItemEnvironment.GetCalendarResponseSubmissionsItemEnvironmentSerializer)
)]
[Serializable]
public readonly record struct GetCalendarResponseSubmissionsItemEnvironment : IStringEnum
{
    public static readonly GetCalendarResponseSubmissionsItemEnvironment Test = new(Values.Test);

    public static readonly GetCalendarResponseSubmissionsItemEnvironment Production = new(
        Values.Production
    );

    public GetCalendarResponseSubmissionsItemEnvironment(string value)
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
    public static GetCalendarResponseSubmissionsItemEnvironment FromCustom(string value)
    {
        return new GetCalendarResponseSubmissionsItemEnvironment(value);
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
        GetCalendarResponseSubmissionsItemEnvironment value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetCalendarResponseSubmissionsItemEnvironment value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetCalendarResponseSubmissionsItemEnvironment value) =>
        value.Value;

    public static explicit operator GetCalendarResponseSubmissionsItemEnvironment(string value) =>
        new(value);

    internal class GetCalendarResponseSubmissionsItemEnvironmentSerializer
        : JsonConverter<GetCalendarResponseSubmissionsItemEnvironment>
    {
        public override GetCalendarResponseSubmissionsItemEnvironment Read(
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
            return new GetCalendarResponseSubmissionsItemEnvironment(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetCalendarResponseSubmissionsItemEnvironment value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetCalendarResponseSubmissionsItemEnvironment ReadAsPropertyName(
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
            return new GetCalendarResponseSubmissionsItemEnvironment(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetCalendarResponseSubmissionsItemEnvironment value,
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
