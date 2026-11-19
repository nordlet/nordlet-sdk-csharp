using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FrequenciesListPayrollResponseFrequenciesItem.FrequenciesListPayrollResponseFrequenciesItemSerializer)
)]
[Serializable]
public readonly record struct FrequenciesListPayrollResponseFrequenciesItem : IStringEnum
{
    public static readonly FrequenciesListPayrollResponseFrequenciesItem Monthly = new(
        Values.Monthly
    );

    public static readonly FrequenciesListPayrollResponseFrequenciesItem Semimonthly = new(
        Values.Semimonthly
    );

    public static readonly FrequenciesListPayrollResponseFrequenciesItem FourWeekly = new(
        Values.FourWeekly
    );

    public static readonly FrequenciesListPayrollResponseFrequenciesItem Biweekly = new(
        Values.Biweekly
    );

    public static readonly FrequenciesListPayrollResponseFrequenciesItem Weekly = new(
        Values.Weekly
    );

    public FrequenciesListPayrollResponseFrequenciesItem(string value)
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
    public static FrequenciesListPayrollResponseFrequenciesItem FromCustom(string value)
    {
        return new FrequenciesListPayrollResponseFrequenciesItem(value);
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
        FrequenciesListPayrollResponseFrequenciesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FrequenciesListPayrollResponseFrequenciesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FrequenciesListPayrollResponseFrequenciesItem value) =>
        value.Value;

    public static explicit operator FrequenciesListPayrollResponseFrequenciesItem(string value) =>
        new(value);

    internal class FrequenciesListPayrollResponseFrequenciesItemSerializer
        : JsonConverter<FrequenciesListPayrollResponseFrequenciesItem>
    {
        public override FrequenciesListPayrollResponseFrequenciesItem Read(
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
            return new FrequenciesListPayrollResponseFrequenciesItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FrequenciesListPayrollResponseFrequenciesItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FrequenciesListPayrollResponseFrequenciesItem ReadAsPropertyName(
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
            return new FrequenciesListPayrollResponseFrequenciesItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FrequenciesListPayrollResponseFrequenciesItem value,
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
