using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubmissionsRetryDeclarationsResponseEnvironment.SubmissionsRetryDeclarationsResponseEnvironmentSerializer)
)]
[Serializable]
public readonly record struct SubmissionsRetryDeclarationsResponseEnvironment : IStringEnum
{
    public static readonly SubmissionsRetryDeclarationsResponseEnvironment Test = new(Values.Test);

    public static readonly SubmissionsRetryDeclarationsResponseEnvironment Production = new(
        Values.Production
    );

    public SubmissionsRetryDeclarationsResponseEnvironment(string value)
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
    public static SubmissionsRetryDeclarationsResponseEnvironment FromCustom(string value)
    {
        return new SubmissionsRetryDeclarationsResponseEnvironment(value);
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
        SubmissionsRetryDeclarationsResponseEnvironment value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SubmissionsRetryDeclarationsResponseEnvironment value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SubmissionsRetryDeclarationsResponseEnvironment value) =>
        value.Value;

    public static explicit operator SubmissionsRetryDeclarationsResponseEnvironment(string value) =>
        new(value);

    internal class SubmissionsRetryDeclarationsResponseEnvironmentSerializer
        : JsonConverter<SubmissionsRetryDeclarationsResponseEnvironment>
    {
        public override SubmissionsRetryDeclarationsResponseEnvironment Read(
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
            return new SubmissionsRetryDeclarationsResponseEnvironment(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubmissionsRetryDeclarationsResponseEnvironment value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubmissionsRetryDeclarationsResponseEnvironment ReadAsPropertyName(
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
            return new SubmissionsRetryDeclarationsResponseEnvironment(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubmissionsRetryDeclarationsResponseEnvironment value,
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
