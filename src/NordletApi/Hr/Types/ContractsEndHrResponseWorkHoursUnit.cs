using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ContractsEndHrResponseWorkHoursUnit.ContractsEndHrResponseWorkHoursUnitSerializer)
)]
[Serializable]
public readonly record struct ContractsEndHrResponseWorkHoursUnit : IStringEnum
{
    public static readonly ContractsEndHrResponseWorkHoursUnit Day = new(Values.Day);

    public static readonly ContractsEndHrResponseWorkHoursUnit Week = new(Values.Week);

    public ContractsEndHrResponseWorkHoursUnit(string value)
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
    public static ContractsEndHrResponseWorkHoursUnit FromCustom(string value)
    {
        return new ContractsEndHrResponseWorkHoursUnit(value);
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

    public static bool operator ==(ContractsEndHrResponseWorkHoursUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContractsEndHrResponseWorkHoursUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContractsEndHrResponseWorkHoursUnit value) =>
        value.Value;

    public static explicit operator ContractsEndHrResponseWorkHoursUnit(string value) => new(value);

    internal class ContractsEndHrResponseWorkHoursUnitSerializer
        : JsonConverter<ContractsEndHrResponseWorkHoursUnit>
    {
        public override ContractsEndHrResponseWorkHoursUnit Read(
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
            return new ContractsEndHrResponseWorkHoursUnit(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractsEndHrResponseWorkHoursUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContractsEndHrResponseWorkHoursUnit ReadAsPropertyName(
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
            return new ContractsEndHrResponseWorkHoursUnit(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractsEndHrResponseWorkHoursUnit value,
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
        public const string Day = "day";

        public const string Week = "week";
    }
}
