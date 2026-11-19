using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EmployeesUpdateHrResponseBankAccountType.EmployeesUpdateHrResponseBankAccountTypeSerializer)
)]
[Serializable]
public readonly record struct EmployeesUpdateHrResponseBankAccountType : IStringEnum
{
    public static readonly EmployeesUpdateHrResponseBankAccountType Checking = new(Values.Checking);

    public static readonly EmployeesUpdateHrResponseBankAccountType Savings = new(Values.Savings);

    public EmployeesUpdateHrResponseBankAccountType(string value)
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
    public static EmployeesUpdateHrResponseBankAccountType FromCustom(string value)
    {
        return new EmployeesUpdateHrResponseBankAccountType(value);
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
        EmployeesUpdateHrResponseBankAccountType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EmployeesUpdateHrResponseBankAccountType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesUpdateHrResponseBankAccountType value) =>
        value.Value;

    public static explicit operator EmployeesUpdateHrResponseBankAccountType(string value) =>
        new(value);

    internal class EmployeesUpdateHrResponseBankAccountTypeSerializer
        : JsonConverter<EmployeesUpdateHrResponseBankAccountType>
    {
        public override EmployeesUpdateHrResponseBankAccountType Read(
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
            return new EmployeesUpdateHrResponseBankAccountType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EmployeesUpdateHrResponseBankAccountType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EmployeesUpdateHrResponseBankAccountType ReadAsPropertyName(
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
            return new EmployeesUpdateHrResponseBankAccountType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EmployeesUpdateHrResponseBankAccountType value,
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
        public const string Checking = "checking";

        public const string Savings = "savings";
    }
}
