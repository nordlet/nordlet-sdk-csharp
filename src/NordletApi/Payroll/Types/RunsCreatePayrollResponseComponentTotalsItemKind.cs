using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RunsCreatePayrollResponseComponentTotalsItemKind.RunsCreatePayrollResponseComponentTotalsItemKindSerializer)
)]
[Serializable]
public readonly record struct RunsCreatePayrollResponseComponentTotalsItemKind : IStringEnum
{
    public static readonly RunsCreatePayrollResponseComponentTotalsItemKind Allowance = new(
        Values.Allowance
    );

    public static readonly RunsCreatePayrollResponseComponentTotalsItemKind EmployeeTax = new(
        Values.EmployeeTax
    );

    public static readonly RunsCreatePayrollResponseComponentTotalsItemKind EmployeeContribution =
        new(Values.EmployeeContribution);

    public static readonly RunsCreatePayrollResponseComponentTotalsItemKind EmployerContribution =
        new(Values.EmployerContribution);

    public static readonly RunsCreatePayrollResponseComponentTotalsItemKind EmployerPayment = new(
        Values.EmployerPayment
    );

    public RunsCreatePayrollResponseComponentTotalsItemKind(string value)
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
    public static RunsCreatePayrollResponseComponentTotalsItemKind FromCustom(string value)
    {
        return new RunsCreatePayrollResponseComponentTotalsItemKind(value);
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
        RunsCreatePayrollResponseComponentTotalsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RunsCreatePayrollResponseComponentTotalsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RunsCreatePayrollResponseComponentTotalsItemKind value
    ) => value.Value;

    public static explicit operator RunsCreatePayrollResponseComponentTotalsItemKind(
        string value
    ) => new(value);

    internal class RunsCreatePayrollResponseComponentTotalsItemKindSerializer
        : JsonConverter<RunsCreatePayrollResponseComponentTotalsItemKind>
    {
        public override RunsCreatePayrollResponseComponentTotalsItemKind Read(
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
            return new RunsCreatePayrollResponseComponentTotalsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RunsCreatePayrollResponseComponentTotalsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RunsCreatePayrollResponseComponentTotalsItemKind ReadAsPropertyName(
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
            return new RunsCreatePayrollResponseComponentTotalsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RunsCreatePayrollResponseComponentTotalsItemKind value,
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
        public const string Allowance = "allowance";

        public const string EmployeeTax = "employee_tax";

        public const string EmployeeContribution = "employee_contribution";

        public const string EmployerContribution = "employer_contribution";

        public const string EmployerPayment = "employer_payment";
    }
}
