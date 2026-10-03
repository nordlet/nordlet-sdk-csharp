using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PayrollLinesAttendanceResponseComponentsItemKind.PostV1PayrollLinesAttendanceResponseComponentsItemKindSerializer)
)]
[Serializable]
public readonly record struct PostV1PayrollLinesAttendanceResponseComponentsItemKind : IStringEnum
{
    public static readonly PostV1PayrollLinesAttendanceResponseComponentsItemKind Allowance = new(
        Values.Allowance
    );

    public static readonly PostV1PayrollLinesAttendanceResponseComponentsItemKind EmployeeTax = new(
        Values.EmployeeTax
    );

    public static readonly PostV1PayrollLinesAttendanceResponseComponentsItemKind EmployeeContribution =
        new(Values.EmployeeContribution);

    public static readonly PostV1PayrollLinesAttendanceResponseComponentsItemKind EmployerContribution =
        new(Values.EmployerContribution);

    public static readonly PostV1PayrollLinesAttendanceResponseComponentsItemKind EmployerPayment =
        new(Values.EmployerPayment);

    public PostV1PayrollLinesAttendanceResponseComponentsItemKind(string value)
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
    public static PostV1PayrollLinesAttendanceResponseComponentsItemKind FromCustom(string value)
    {
        return new PostV1PayrollLinesAttendanceResponseComponentsItemKind(value);
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
        PostV1PayrollLinesAttendanceResponseComponentsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PayrollLinesAttendanceResponseComponentsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1PayrollLinesAttendanceResponseComponentsItemKind value
    ) => value.Value;

    public static explicit operator PostV1PayrollLinesAttendanceResponseComponentsItemKind(
        string value
    ) => new(value);

    internal class PostV1PayrollLinesAttendanceResponseComponentsItemKindSerializer
        : JsonConverter<PostV1PayrollLinesAttendanceResponseComponentsItemKind>
    {
        public override PostV1PayrollLinesAttendanceResponseComponentsItemKind Read(
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
            return new PostV1PayrollLinesAttendanceResponseComponentsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PayrollLinesAttendanceResponseComponentsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PayrollLinesAttendanceResponseComponentsItemKind ReadAsPropertyName(
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
            return new PostV1PayrollLinesAttendanceResponseComponentsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PayrollLinesAttendanceResponseComponentsItemKind value,
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
