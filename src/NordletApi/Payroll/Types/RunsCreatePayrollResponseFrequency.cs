using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RunsCreatePayrollResponseFrequency.RunsCreatePayrollResponseFrequencySerializer)
)]
[Serializable]
public readonly record struct RunsCreatePayrollResponseFrequency : IStringEnum
{
    public static readonly RunsCreatePayrollResponseFrequency Monthly = new(Values.Monthly);

    public static readonly RunsCreatePayrollResponseFrequency Semimonthly = new(Values.Semimonthly);

    public static readonly RunsCreatePayrollResponseFrequency FourWeekly = new(Values.FourWeekly);

    public static readonly RunsCreatePayrollResponseFrequency Biweekly = new(Values.Biweekly);

    public static readonly RunsCreatePayrollResponseFrequency Weekly = new(Values.Weekly);

    public RunsCreatePayrollResponseFrequency(string value)
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
    public static RunsCreatePayrollResponseFrequency FromCustom(string value)
    {
        return new RunsCreatePayrollResponseFrequency(value);
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

    public static bool operator ==(RunsCreatePayrollResponseFrequency value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RunsCreatePayrollResponseFrequency value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RunsCreatePayrollResponseFrequency value) => value.Value;

    public static explicit operator RunsCreatePayrollResponseFrequency(string value) => new(value);

    internal class RunsCreatePayrollResponseFrequencySerializer
        : JsonConverter<RunsCreatePayrollResponseFrequency>
    {
        public override RunsCreatePayrollResponseFrequency Read(
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
            return new RunsCreatePayrollResponseFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RunsCreatePayrollResponseFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RunsCreatePayrollResponseFrequency ReadAsPropertyName(
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
            return new RunsCreatePayrollResponseFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RunsCreatePayrollResponseFrequency value,
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
