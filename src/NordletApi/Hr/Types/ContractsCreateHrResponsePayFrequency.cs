using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ContractsCreateHrResponsePayFrequency.ContractsCreateHrResponsePayFrequencySerializer)
)]
[Serializable]
public readonly record struct ContractsCreateHrResponsePayFrequency : IStringEnum
{
    public static readonly ContractsCreateHrResponsePayFrequency Monthly = new(Values.Monthly);

    public static readonly ContractsCreateHrResponsePayFrequency Semimonthly = new(
        Values.Semimonthly
    );

    public static readonly ContractsCreateHrResponsePayFrequency FourWeekly = new(
        Values.FourWeekly
    );

    public static readonly ContractsCreateHrResponsePayFrequency Biweekly = new(Values.Biweekly);

    public static readonly ContractsCreateHrResponsePayFrequency Weekly = new(Values.Weekly);

    public ContractsCreateHrResponsePayFrequency(string value)
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
    public static ContractsCreateHrResponsePayFrequency FromCustom(string value)
    {
        return new ContractsCreateHrResponsePayFrequency(value);
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

    public static bool operator ==(ContractsCreateHrResponsePayFrequency value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContractsCreateHrResponsePayFrequency value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContractsCreateHrResponsePayFrequency value) =>
        value.Value;

    public static explicit operator ContractsCreateHrResponsePayFrequency(string value) =>
        new(value);

    internal class ContractsCreateHrResponsePayFrequencySerializer
        : JsonConverter<ContractsCreateHrResponsePayFrequency>
    {
        public override ContractsCreateHrResponsePayFrequency Read(
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
            return new ContractsCreateHrResponsePayFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractsCreateHrResponsePayFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContractsCreateHrResponsePayFrequency ReadAsPropertyName(
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
            return new ContractsCreateHrResponsePayFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractsCreateHrResponsePayFrequency value,
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
