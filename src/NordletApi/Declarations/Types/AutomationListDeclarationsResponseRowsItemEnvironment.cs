using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AutomationListDeclarationsResponseRowsItemEnvironment.AutomationListDeclarationsResponseRowsItemEnvironmentSerializer)
)]
[Serializable]
public readonly record struct AutomationListDeclarationsResponseRowsItemEnvironment : IStringEnum
{
    public static readonly AutomationListDeclarationsResponseRowsItemEnvironment Test = new(
        Values.Test
    );

    public static readonly AutomationListDeclarationsResponseRowsItemEnvironment Production = new(
        Values.Production
    );

    public AutomationListDeclarationsResponseRowsItemEnvironment(string value)
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
    public static AutomationListDeclarationsResponseRowsItemEnvironment FromCustom(string value)
    {
        return new AutomationListDeclarationsResponseRowsItemEnvironment(value);
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
        AutomationListDeclarationsResponseRowsItemEnvironment value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AutomationListDeclarationsResponseRowsItemEnvironment value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AutomationListDeclarationsResponseRowsItemEnvironment value
    ) => value.Value;

    public static explicit operator AutomationListDeclarationsResponseRowsItemEnvironment(
        string value
    ) => new(value);

    internal class AutomationListDeclarationsResponseRowsItemEnvironmentSerializer
        : JsonConverter<AutomationListDeclarationsResponseRowsItemEnvironment>
    {
        public override AutomationListDeclarationsResponseRowsItemEnvironment Read(
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
            return new AutomationListDeclarationsResponseRowsItemEnvironment(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AutomationListDeclarationsResponseRowsItemEnvironment value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AutomationListDeclarationsResponseRowsItemEnvironment ReadAsPropertyName(
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
            return new AutomationListDeclarationsResponseRowsItemEnvironment(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AutomationListDeclarationsResponseRowsItemEnvironment value,
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
