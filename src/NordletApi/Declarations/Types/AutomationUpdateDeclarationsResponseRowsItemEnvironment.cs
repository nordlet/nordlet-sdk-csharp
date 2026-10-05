using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AutomationUpdateDeclarationsResponseRowsItemEnvironment.AutomationUpdateDeclarationsResponseRowsItemEnvironmentSerializer)
)]
[Serializable]
public readonly record struct AutomationUpdateDeclarationsResponseRowsItemEnvironment : IStringEnum
{
    public static readonly AutomationUpdateDeclarationsResponseRowsItemEnvironment Test = new(
        Values.Test
    );

    public static readonly AutomationUpdateDeclarationsResponseRowsItemEnvironment Production = new(
        Values.Production
    );

    public AutomationUpdateDeclarationsResponseRowsItemEnvironment(string value)
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
    public static AutomationUpdateDeclarationsResponseRowsItemEnvironment FromCustom(string value)
    {
        return new AutomationUpdateDeclarationsResponseRowsItemEnvironment(value);
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
        AutomationUpdateDeclarationsResponseRowsItemEnvironment value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AutomationUpdateDeclarationsResponseRowsItemEnvironment value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AutomationUpdateDeclarationsResponseRowsItemEnvironment value
    ) => value.Value;

    public static explicit operator AutomationUpdateDeclarationsResponseRowsItemEnvironment(
        string value
    ) => new(value);

    internal class AutomationUpdateDeclarationsResponseRowsItemEnvironmentSerializer
        : JsonConverter<AutomationUpdateDeclarationsResponseRowsItemEnvironment>
    {
        public override AutomationUpdateDeclarationsResponseRowsItemEnvironment Read(
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
            return new AutomationUpdateDeclarationsResponseRowsItemEnvironment(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AutomationUpdateDeclarationsResponseRowsItemEnvironment value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AutomationUpdateDeclarationsResponseRowsItemEnvironment ReadAsPropertyName(
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
            return new AutomationUpdateDeclarationsResponseRowsItemEnvironment(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AutomationUpdateDeclarationsResponseRowsItemEnvironment value,
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
