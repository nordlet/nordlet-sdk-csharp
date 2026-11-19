using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EmployeesUpdateHrRequestBankAccountType.EmployeesUpdateHrRequestBankAccountTypeSerializer)
)]
[Serializable]
public readonly record struct EmployeesUpdateHrRequestBankAccountType : IStringEnum
{
    public static readonly EmployeesUpdateHrRequestBankAccountType Checking = new(Values.Checking);

    public static readonly EmployeesUpdateHrRequestBankAccountType Savings = new(Values.Savings);

    public EmployeesUpdateHrRequestBankAccountType(string value)
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
    public static EmployeesUpdateHrRequestBankAccountType FromCustom(string value)
    {
        return new EmployeesUpdateHrRequestBankAccountType(value);
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

    public static bool operator ==(EmployeesUpdateHrRequestBankAccountType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmployeesUpdateHrRequestBankAccountType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesUpdateHrRequestBankAccountType value) =>
        value.Value;

    public static explicit operator EmployeesUpdateHrRequestBankAccountType(string value) =>
        new(value);

    internal class EmployeesUpdateHrRequestBankAccountTypeSerializer
        : JsonConverter<EmployeesUpdateHrRequestBankAccountType>
    {
        public override EmployeesUpdateHrRequestBankAccountType Read(
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
            return new EmployeesUpdateHrRequestBankAccountType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EmployeesUpdateHrRequestBankAccountType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EmployeesUpdateHrRequestBankAccountType ReadAsPropertyName(
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
            return new EmployeesUpdateHrRequestBankAccountType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EmployeesUpdateHrRequestBankAccountType value,
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
