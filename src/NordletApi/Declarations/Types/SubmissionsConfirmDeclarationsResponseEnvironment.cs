using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubmissionsConfirmDeclarationsResponseEnvironment.SubmissionsConfirmDeclarationsResponseEnvironmentSerializer)
)]
[Serializable]
public readonly record struct SubmissionsConfirmDeclarationsResponseEnvironment : IStringEnum
{
    public static readonly SubmissionsConfirmDeclarationsResponseEnvironment Test = new(
        Values.Test
    );

    public static readonly SubmissionsConfirmDeclarationsResponseEnvironment Production = new(
        Values.Production
    );

    public SubmissionsConfirmDeclarationsResponseEnvironment(string value)
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
    public static SubmissionsConfirmDeclarationsResponseEnvironment FromCustom(string value)
    {
        return new SubmissionsConfirmDeclarationsResponseEnvironment(value);
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
        SubmissionsConfirmDeclarationsResponseEnvironment value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SubmissionsConfirmDeclarationsResponseEnvironment value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SubmissionsConfirmDeclarationsResponseEnvironment value
    ) => value.Value;

    public static explicit operator SubmissionsConfirmDeclarationsResponseEnvironment(
        string value
    ) => new(value);

    internal class SubmissionsConfirmDeclarationsResponseEnvironmentSerializer
        : JsonConverter<SubmissionsConfirmDeclarationsResponseEnvironment>
    {
        public override SubmissionsConfirmDeclarationsResponseEnvironment Read(
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
            return new SubmissionsConfirmDeclarationsResponseEnvironment(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubmissionsConfirmDeclarationsResponseEnvironment value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubmissionsConfirmDeclarationsResponseEnvironment ReadAsPropertyName(
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
            return new SubmissionsConfirmDeclarationsResponseEnvironment(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubmissionsConfirmDeclarationsResponseEnvironment value,
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
