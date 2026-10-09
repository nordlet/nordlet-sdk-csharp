using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RunsReversePayrollResponseComponentTotalsItemKind.RunsReversePayrollResponseComponentTotalsItemKindSerializer)
)]
[Serializable]
public readonly record struct RunsReversePayrollResponseComponentTotalsItemKind : IStringEnum
{
    public static readonly RunsReversePayrollResponseComponentTotalsItemKind Allowance = new(
        Values.Allowance
    );

    public static readonly RunsReversePayrollResponseComponentTotalsItemKind EmployeeTax = new(
        Values.EmployeeTax
    );

    public static readonly RunsReversePayrollResponseComponentTotalsItemKind EmployeeContribution =
        new(Values.EmployeeContribution);

    public static readonly RunsReversePayrollResponseComponentTotalsItemKind EmployerContribution =
        new(Values.EmployerContribution);

    public static readonly RunsReversePayrollResponseComponentTotalsItemKind EmployerPayment = new(
        Values.EmployerPayment
    );

    public RunsReversePayrollResponseComponentTotalsItemKind(string value)
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
    public static RunsReversePayrollResponseComponentTotalsItemKind FromCustom(string value)
    {
        return new RunsReversePayrollResponseComponentTotalsItemKind(value);
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
        RunsReversePayrollResponseComponentTotalsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RunsReversePayrollResponseComponentTotalsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RunsReversePayrollResponseComponentTotalsItemKind value
    ) => value.Value;

    public static explicit operator RunsReversePayrollResponseComponentTotalsItemKind(
        string value
    ) => new(value);

    internal class RunsReversePayrollResponseComponentTotalsItemKindSerializer
        : JsonConverter<RunsReversePayrollResponseComponentTotalsItemKind>
    {
        public override RunsReversePayrollResponseComponentTotalsItemKind Read(
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
            return new RunsReversePayrollResponseComponentTotalsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RunsReversePayrollResponseComponentTotalsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RunsReversePayrollResponseComponentTotalsItemKind ReadAsPropertyName(
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
            return new RunsReversePayrollResponseComponentTotalsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RunsReversePayrollResponseComponentTotalsItemKind value,
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
