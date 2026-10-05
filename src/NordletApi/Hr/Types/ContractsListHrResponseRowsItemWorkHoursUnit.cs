using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ContractsListHrResponseRowsItemWorkHoursUnit.ContractsListHrResponseRowsItemWorkHoursUnitSerializer)
)]
[Serializable]
public readonly record struct ContractsListHrResponseRowsItemWorkHoursUnit : IStringEnum
{
    public static readonly ContractsListHrResponseRowsItemWorkHoursUnit Day = new(Values.Day);

    public static readonly ContractsListHrResponseRowsItemWorkHoursUnit Week = new(Values.Week);

    public ContractsListHrResponseRowsItemWorkHoursUnit(string value)
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
    public static ContractsListHrResponseRowsItemWorkHoursUnit FromCustom(string value)
    {
        return new ContractsListHrResponseRowsItemWorkHoursUnit(value);
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
        ContractsListHrResponseRowsItemWorkHoursUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ContractsListHrResponseRowsItemWorkHoursUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ContractsListHrResponseRowsItemWorkHoursUnit value) =>
        value.Value;

    public static explicit operator ContractsListHrResponseRowsItemWorkHoursUnit(string value) =>
        new(value);

    internal class ContractsListHrResponseRowsItemWorkHoursUnitSerializer
        : JsonConverter<ContractsListHrResponseRowsItemWorkHoursUnit>
    {
        public override ContractsListHrResponseRowsItemWorkHoursUnit Read(
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
            return new ContractsListHrResponseRowsItemWorkHoursUnit(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractsListHrResponseRowsItemWorkHoursUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContractsListHrResponseRowsItemWorkHoursUnit ReadAsPropertyName(
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
            return new ContractsListHrResponseRowsItemWorkHoursUnit(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractsListHrResponseRowsItemWorkHoursUnit value,
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
