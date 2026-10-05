using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RunsCreatePayrollResponseLinesItemComponentsItemKind.RunsCreatePayrollResponseLinesItemComponentsItemKindSerializer)
)]
[Serializable]
public readonly record struct RunsCreatePayrollResponseLinesItemComponentsItemKind : IStringEnum
{
    public static readonly RunsCreatePayrollResponseLinesItemComponentsItemKind Allowance = new(
        Values.Allowance
    );

    public static readonly RunsCreatePayrollResponseLinesItemComponentsItemKind EmployeeTax = new(
        Values.EmployeeTax
    );

    public static readonly RunsCreatePayrollResponseLinesItemComponentsItemKind EmployeeContribution =
        new(Values.EmployeeContribution);

    public static readonly RunsCreatePayrollResponseLinesItemComponentsItemKind EmployerContribution =
        new(Values.EmployerContribution);

    public static readonly RunsCreatePayrollResponseLinesItemComponentsItemKind EmployerPayment =
        new(Values.EmployerPayment);

    public RunsCreatePayrollResponseLinesItemComponentsItemKind(string value)
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
    public static RunsCreatePayrollResponseLinesItemComponentsItemKind FromCustom(string value)
    {
        return new RunsCreatePayrollResponseLinesItemComponentsItemKind(value);
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
        RunsCreatePayrollResponseLinesItemComponentsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RunsCreatePayrollResponseLinesItemComponentsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RunsCreatePayrollResponseLinesItemComponentsItemKind value
    ) => value.Value;

    public static explicit operator RunsCreatePayrollResponseLinesItemComponentsItemKind(
        string value
    ) => new(value);

    internal class RunsCreatePayrollResponseLinesItemComponentsItemKindSerializer
        : JsonConverter<RunsCreatePayrollResponseLinesItemComponentsItemKind>
    {
        public override RunsCreatePayrollResponseLinesItemComponentsItemKind Read(
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
            return new RunsCreatePayrollResponseLinesItemComponentsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RunsCreatePayrollResponseLinesItemComponentsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RunsCreatePayrollResponseLinesItemComponentsItemKind ReadAsPropertyName(
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
            return new RunsCreatePayrollResponseLinesItemComponentsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RunsCreatePayrollResponseLinesItemComponentsItemKind value,
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
