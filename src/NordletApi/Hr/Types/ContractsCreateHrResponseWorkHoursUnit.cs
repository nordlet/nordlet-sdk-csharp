using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ContractsCreateHrResponseWorkHoursUnit.ContractsCreateHrResponseWorkHoursUnitSerializer)
)]
[Serializable]
public readonly record struct ContractsCreateHrResponseWorkHoursUnit : IStringEnum
{
    public static readonly ContractsCreateHrResponseWorkHoursUnit Day = new(Values.Day);

    public static readonly ContractsCreateHrResponseWorkHoursUnit Week = new(Values.Week);

    public ContractsCreateHrResponseWorkHoursUnit(string value)
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
    public static ContractsCreateHrResponseWorkHoursUnit FromCustom(string value)
    {
        return new ContractsCreateHrResponseWorkHoursUnit(value);
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

    public static bool operator ==(ContractsCreateHrResponseWorkHoursUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContractsCreateHrResponseWorkHoursUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContractsCreateHrResponseWorkHoursUnit value) =>
        value.Value;

    public static explicit operator ContractsCreateHrResponseWorkHoursUnit(string value) =>
        new(value);

    internal class ContractsCreateHrResponseWorkHoursUnitSerializer
        : JsonConverter<ContractsCreateHrResponseWorkHoursUnit>
    {
        public override ContractsCreateHrResponseWorkHoursUnit Read(
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
            return new ContractsCreateHrResponseWorkHoursUnit(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractsCreateHrResponseWorkHoursUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContractsCreateHrResponseWorkHoursUnit ReadAsPropertyName(
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
            return new ContractsCreateHrResponseWorkHoursUnit(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractsCreateHrResponseWorkHoursUnit value,
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
