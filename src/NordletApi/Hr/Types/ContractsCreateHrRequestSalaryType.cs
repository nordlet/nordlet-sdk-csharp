using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ContractsCreateHrRequestSalaryType.ContractsCreateHrRequestSalaryTypeSerializer)
)]
[Serializable]
public readonly record struct ContractsCreateHrRequestSalaryType : IStringEnum
{
    public static readonly ContractsCreateHrRequestSalaryType Monthly = new(Values.Monthly);

    public static readonly ContractsCreateHrRequestSalaryType Hourly = new(Values.Hourly);

    public static readonly ContractsCreateHrRequestSalaryType Weekly = new(Values.Weekly);

    public static readonly ContractsCreateHrRequestSalaryType Daily = new(Values.Daily);

    public static readonly ContractsCreateHrRequestSalaryType Yearly = new(Values.Yearly);

    public ContractsCreateHrRequestSalaryType(string value)
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
    public static ContractsCreateHrRequestSalaryType FromCustom(string value)
    {
        return new ContractsCreateHrRequestSalaryType(value);
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

    public static bool operator ==(ContractsCreateHrRequestSalaryType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContractsCreateHrRequestSalaryType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContractsCreateHrRequestSalaryType value) => value.Value;

    public static explicit operator ContractsCreateHrRequestSalaryType(string value) => new(value);

    internal class ContractsCreateHrRequestSalaryTypeSerializer
        : JsonConverter<ContractsCreateHrRequestSalaryType>
    {
        public override ContractsCreateHrRequestSalaryType Read(
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
            return new ContractsCreateHrRequestSalaryType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractsCreateHrRequestSalaryType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContractsCreateHrRequestSalaryType ReadAsPropertyName(
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
            return new ContractsCreateHrRequestSalaryType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractsCreateHrRequestSalaryType value,
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
