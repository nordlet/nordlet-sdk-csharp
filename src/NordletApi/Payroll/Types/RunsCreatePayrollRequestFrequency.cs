using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RunsCreatePayrollRequestFrequency.RunsCreatePayrollRequestFrequencySerializer)
)]
[Serializable]
public readonly record struct RunsCreatePayrollRequestFrequency : IStringEnum
{
    public static readonly RunsCreatePayrollRequestFrequency Monthly = new(Values.Monthly);

    public static readonly RunsCreatePayrollRequestFrequency Semimonthly = new(Values.Semimonthly);

    public static readonly RunsCreatePayrollRequestFrequency FourWeekly = new(Values.FourWeekly);

    public static readonly RunsCreatePayrollRequestFrequency Biweekly = new(Values.Biweekly);

    public static readonly RunsCreatePayrollRequestFrequency Weekly = new(Values.Weekly);

    public RunsCreatePayrollRequestFrequency(string value)
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
    public static RunsCreatePayrollRequestFrequency FromCustom(string value)
    {
        return new RunsCreatePayrollRequestFrequency(value);
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

    public static bool operator ==(RunsCreatePayrollRequestFrequency value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RunsCreatePayrollRequestFrequency value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RunsCreatePayrollRequestFrequency value) => value.Value;

    public static explicit operator RunsCreatePayrollRequestFrequency(string value) => new(value);

    internal class RunsCreatePayrollRequestFrequencySerializer
        : JsonConverter<RunsCreatePayrollRequestFrequency>
    {
        public override RunsCreatePayrollRequestFrequency Read(
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
            return new RunsCreatePayrollRequestFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RunsCreatePayrollRequestFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RunsCreatePayrollRequestFrequency ReadAsPropertyName(
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
            return new RunsCreatePayrollRequestFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RunsCreatePayrollRequestFrequency value,
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
        public const string Monthly = "monthly";

        public const string Semimonthly = "semimonthly";

        public const string FourWeekly = "four_weekly";

        public const string Biweekly = "biweekly";

        public const string Weekly = "weekly";
    }
}
