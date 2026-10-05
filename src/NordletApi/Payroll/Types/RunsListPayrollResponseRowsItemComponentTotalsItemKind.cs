using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RunsListPayrollResponseRowsItemComponentTotalsItemKind.RunsListPayrollResponseRowsItemComponentTotalsItemKindSerializer)
)]
[Serializable]
public readonly record struct RunsListPayrollResponseRowsItemComponentTotalsItemKind : IStringEnum
{
    public static readonly RunsListPayrollResponseRowsItemComponentTotalsItemKind Allowance = new(
        Values.Allowance
    );

    public static readonly RunsListPayrollResponseRowsItemComponentTotalsItemKind EmployeeTax = new(
        Values.EmployeeTax
    );

    public static readonly RunsListPayrollResponseRowsItemComponentTotalsItemKind EmployeeContribution =
        new(Values.EmployeeContribution);

    public static readonly RunsListPayrollResponseRowsItemComponentTotalsItemKind EmployerContribution =
        new(Values.EmployerContribution);

    public static readonly RunsListPayrollResponseRowsItemComponentTotalsItemKind EmployerPayment =
        new(Values.EmployerPayment);

    public RunsListPayrollResponseRowsItemComponentTotalsItemKind(string value)
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
    public static RunsListPayrollResponseRowsItemComponentTotalsItemKind FromCustom(string value)
    {
        return new RunsListPayrollResponseRowsItemComponentTotalsItemKind(value);
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
        RunsListPayrollResponseRowsItemComponentTotalsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RunsListPayrollResponseRowsItemComponentTotalsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RunsListPayrollResponseRowsItemComponentTotalsItemKind value
    ) => value.Value;

    public static explicit operator RunsListPayrollResponseRowsItemComponentTotalsItemKind(
        string value
    ) => new(value);

    internal class RunsListPayrollResponseRowsItemComponentTotalsItemKindSerializer
        : JsonConverter<RunsListPayrollResponseRowsItemComponentTotalsItemKind>
    {
        public override RunsListPayrollResponseRowsItemComponentTotalsItemKind Read(
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
            return new RunsListPayrollResponseRowsItemComponentTotalsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RunsListPayrollResponseRowsItemComponentTotalsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RunsListPayrollResponseRowsItemComponentTotalsItemKind ReadAsPropertyName(
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
            return new RunsListPayrollResponseRowsItemComponentTotalsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RunsListPayrollResponseRowsItemComponentTotalsItemKind value,
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
