using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ContractsListHrResponseRowsItemPayFrequency.ContractsListHrResponseRowsItemPayFrequencySerializer)
)]
[Serializable]
public readonly record struct ContractsListHrResponseRowsItemPayFrequency : IStringEnum
{
    public static readonly ContractsListHrResponseRowsItemPayFrequency Monthly = new(
        Values.Monthly
    );

    public static readonly ContractsListHrResponseRowsItemPayFrequency Semimonthly = new(
        Values.Semimonthly
    );

    public static readonly ContractsListHrResponseRowsItemPayFrequency FourWeekly = new(
        Values.FourWeekly
    );

    public static readonly ContractsListHrResponseRowsItemPayFrequency Biweekly = new(
        Values.Biweekly
    );

    public static readonly ContractsListHrResponseRowsItemPayFrequency Weekly = new(Values.Weekly);

    public ContractsListHrResponseRowsItemPayFrequency(string value)
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
    public static ContractsListHrResponseRowsItemPayFrequency FromCustom(string value)
    {
        return new ContractsListHrResponseRowsItemPayFrequency(value);
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
        ContractsListHrResponseRowsItemPayFrequency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ContractsListHrResponseRowsItemPayFrequency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ContractsListHrResponseRowsItemPayFrequency value) =>
        value.Value;

    public static explicit operator ContractsListHrResponseRowsItemPayFrequency(string value) =>
        new(value);

    internal class ContractsListHrResponseRowsItemPayFrequencySerializer
        : JsonConverter<ContractsListHrResponseRowsItemPayFrequency>
    {
        public override ContractsListHrResponseRowsItemPayFrequency Read(
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
            return new ContractsListHrResponseRowsItemPayFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractsListHrResponseRowsItemPayFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContractsListHrResponseRowsItemPayFrequency ReadAsPropertyName(
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
            return new ContractsListHrResponseRowsItemPayFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractsListHrResponseRowsItemPayFrequency value,
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
