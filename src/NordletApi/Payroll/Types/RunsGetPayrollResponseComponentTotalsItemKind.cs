using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RunsGetPayrollResponseComponentTotalsItemKind.RunsGetPayrollResponseComponentTotalsItemKindSerializer)
)]
[Serializable]
public readonly record struct RunsGetPayrollResponseComponentTotalsItemKind : IStringEnum
{
    public static readonly RunsGetPayrollResponseComponentTotalsItemKind Allowance = new(
        Values.Allowance
    );

    public static readonly RunsGetPayrollResponseComponentTotalsItemKind EmployeeTax = new(
        Values.EmployeeTax
    );

    public static readonly RunsGetPayrollResponseComponentTotalsItemKind EmployeeContribution = new(
        Values.EmployeeContribution
    );

    public static readonly RunsGetPayrollResponseComponentTotalsItemKind EmployerContribution = new(
        Values.EmployerContribution
    );

    public static readonly RunsGetPayrollResponseComponentTotalsItemKind EmployerPayment = new(
        Values.EmployerPayment
    );

    public RunsGetPayrollResponseComponentTotalsItemKind(string value)
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
    public static RunsGetPayrollResponseComponentTotalsItemKind FromCustom(string value)
    {
        return new RunsGetPayrollResponseComponentTotalsItemKind(value);
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
        RunsGetPayrollResponseComponentTotalsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RunsGetPayrollResponseComponentTotalsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RunsGetPayrollResponseComponentTotalsItemKind value) =>
        value.Value;

    public static explicit operator RunsGetPayrollResponseComponentTotalsItemKind(string value) =>
        new(value);

    internal class RunsGetPayrollResponseComponentTotalsItemKindSerializer
        : JsonConverter<RunsGetPayrollResponseComponentTotalsItemKind>
    {
        public override RunsGetPayrollResponseComponentTotalsItemKind Read(
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
            return new RunsGetPayrollResponseComponentTotalsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RunsGetPayrollResponseComponentTotalsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RunsGetPayrollResponseComponentTotalsItemKind ReadAsPropertyName(
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
            return new RunsGetPayrollResponseComponentTotalsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RunsGetPayrollResponseComponentTotalsItemKind value,
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
