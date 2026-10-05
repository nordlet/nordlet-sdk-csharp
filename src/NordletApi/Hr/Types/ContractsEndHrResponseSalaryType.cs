using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ContractsEndHrResponseSalaryType.ContractsEndHrResponseSalaryTypeSerializer))]
[Serializable]
public readonly record struct ContractsEndHrResponseSalaryType : IStringEnum
{
    public static readonly ContractsEndHrResponseSalaryType Monthly = new(Values.Monthly);

    public static readonly ContractsEndHrResponseSalaryType Hourly = new(Values.Hourly);

    public static readonly ContractsEndHrResponseSalaryType Weekly = new(Values.Weekly);

    public static readonly ContractsEndHrResponseSalaryType Daily = new(Values.Daily);

    public static readonly ContractsEndHrResponseSalaryType Yearly = new(Values.Yearly);

    public ContractsEndHrResponseSalaryType(string value)
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
    public static ContractsEndHrResponseSalaryType FromCustom(string value)
    {
        return new ContractsEndHrResponseSalaryType(value);
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

    public static bool operator ==(ContractsEndHrResponseSalaryType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContractsEndHrResponseSalaryType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContractsEndHrResponseSalaryType value) => value.Value;

    public static explicit operator ContractsEndHrResponseSalaryType(string value) => new(value);

    internal class ContractsEndHrResponseSalaryTypeSerializer
        : JsonConverter<ContractsEndHrResponseSalaryType>
    {
        public override ContractsEndHrResponseSalaryType Read(
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
            return new ContractsEndHrResponseSalaryType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractsEndHrResponseSalaryType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContractsEndHrResponseSalaryType ReadAsPropertyName(
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
            return new ContractsEndHrResponseSalaryType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractsEndHrResponseSalaryType value,
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

        public const string Hourly = "hourly";

        public const string Weekly = "weekly";

        public const string Daily = "daily";

        public const string Yearly = "yearly";
    }
}
