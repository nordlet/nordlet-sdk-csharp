using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubmissionsCreateDeclarationsResponseEnvironment.SubmissionsCreateDeclarationsResponseEnvironmentSerializer)
)]
[Serializable]
public readonly record struct SubmissionsCreateDeclarationsResponseEnvironment : IStringEnum
{
    public static readonly SubmissionsCreateDeclarationsResponseEnvironment Test = new(Values.Test);

    public static readonly SubmissionsCreateDeclarationsResponseEnvironment Production = new(
        Values.Production
    );

    public SubmissionsCreateDeclarationsResponseEnvironment(string value)
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
    public static SubmissionsCreateDeclarationsResponseEnvironment FromCustom(string value)
    {
        return new SubmissionsCreateDeclarationsResponseEnvironment(value);
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
        SubmissionsCreateDeclarationsResponseEnvironment value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SubmissionsCreateDeclarationsResponseEnvironment value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SubmissionsCreateDeclarationsResponseEnvironment value
    ) => value.Value;

    public static explicit operator SubmissionsCreateDeclarationsResponseEnvironment(
        string value
    ) => new(value);

    internal class SubmissionsCreateDeclarationsResponseEnvironmentSerializer
        : JsonConverter<SubmissionsCreateDeclarationsResponseEnvironment>
    {
        public override SubmissionsCreateDeclarationsResponseEnvironment Read(
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
            return new SubmissionsCreateDeclarationsResponseEnvironment(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubmissionsCreateDeclarationsResponseEnvironment value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubmissionsCreateDeclarationsResponseEnvironment ReadAsPropertyName(
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
            return new SubmissionsCreateDeclarationsResponseEnvironment(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubmissionsCreateDeclarationsResponseEnvironment value,
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
