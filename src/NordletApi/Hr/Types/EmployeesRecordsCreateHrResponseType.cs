using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EmployeesRecordsCreateHrResponseType.EmployeesRecordsCreateHrResponseTypeSerializer)
)]
[Serializable]
public readonly record struct EmployeesRecordsCreateHrResponseType : IStringEnum
{
    public static readonly EmployeesRecordsCreateHrResponseType Education = new(Values.Education);

    public static readonly EmployeesRecordsCreateHrResponseType Qualification = new(
        Values.Qualification
    );

    public static readonly EmployeesRecordsCreateHrResponseType Certificate = new(
        Values.Certificate
    );

    public static readonly EmployeesRecordsCreateHrResponseType Training = new(Values.Training);

    public EmployeesRecordsCreateHrResponseType(string value)
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
    public static EmployeesRecordsCreateHrResponseType FromCustom(string value)
    {
        return new EmployeesRecordsCreateHrResponseType(value);
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

    public static bool operator ==(EmployeesRecordsCreateHrResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmployeesRecordsCreateHrResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesRecordsCreateHrResponseType value) =>
        value.Value;

    public static explicit operator EmployeesRecordsCreateHrResponseType(string value) =>
        new(value);

    internal class EmployeesRecordsCreateHrResponseTypeSerializer
        : JsonConverter<EmployeesRecordsCreateHrResponseType>
    {
        public override EmployeesRecordsCreateHrResponseType Read(
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
            return new EmployeesRecordsCreateHrResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EmployeesRecordsCreateHrResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EmployeesRecordsCreateHrResponseType ReadAsPropertyName(
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
            return new EmployeesRecordsCreateHrResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EmployeesRecordsCreateHrResponseType value,
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
        public const string Education = "education";

        public const string Qualification = "qualification";

        public const string Certificate = "certificate";

        public const string Training = "training";
    }
}
