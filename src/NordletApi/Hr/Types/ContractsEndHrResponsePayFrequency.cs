using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ContractsEndHrResponsePayFrequency.ContractsEndHrResponsePayFrequencySerializer)
)]
[Serializable]
public readonly record struct ContractsEndHrResponsePayFrequency : IStringEnum
{
    public static readonly ContractsEndHrResponsePayFrequency Monthly = new(Values.Monthly);

    public static readonly ContractsEndHrResponsePayFrequency Semimonthly = new(Values.Semimonthly);

    public static readonly ContractsEndHrResponsePayFrequency FourWeekly = new(Values.FourWeekly);

    public static readonly ContractsEndHrResponsePayFrequency Biweekly = new(Values.Biweekly);

    public static readonly ContractsEndHrResponsePayFrequency Weekly = new(Values.Weekly);

    public ContractsEndHrResponsePayFrequency(string value)
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
    public static ContractsEndHrResponsePayFrequency FromCustom(string value)
    {
        return new ContractsEndHrResponsePayFrequency(value);
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

    public static bool operator ==(ContractsEndHrResponsePayFrequency value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContractsEndHrResponsePayFrequency value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContractsEndHrResponsePayFrequency value) => value.Value;

    public static explicit operator ContractsEndHrResponsePayFrequency(string value) => new(value);

    internal class ContractsEndHrResponsePayFrequencySerializer
        : JsonConverter<ContractsEndHrResponsePayFrequency>
    {
        public override ContractsEndHrResponsePayFrequency Read(
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
            return new ContractsEndHrResponsePayFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractsEndHrResponsePayFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContractsEndHrResponsePayFrequency ReadAsPropertyName(
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
            return new ContractsEndHrResponsePayFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractsEndHrResponsePayFrequency value,
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
