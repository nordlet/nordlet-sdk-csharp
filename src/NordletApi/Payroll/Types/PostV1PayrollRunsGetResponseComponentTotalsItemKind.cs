using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PayrollRunsGetResponseComponentTotalsItemKind.PostV1PayrollRunsGetResponseComponentTotalsItemKindSerializer)
)]
[Serializable]
public readonly record struct PostV1PayrollRunsGetResponseComponentTotalsItemKind : IStringEnum
{
    public static readonly PostV1PayrollRunsGetResponseComponentTotalsItemKind Allowance = new(
        Values.Allowance
    );

    public static readonly PostV1PayrollRunsGetResponseComponentTotalsItemKind EmployeeTax = new(
        Values.EmployeeTax
    );

    public static readonly PostV1PayrollRunsGetResponseComponentTotalsItemKind EmployeeContribution =
        new(Values.EmployeeContribution);

    public static readonly PostV1PayrollRunsGetResponseComponentTotalsItemKind EmployerContribution =
        new(Values.EmployerContribution);

    public static readonly PostV1PayrollRunsGetResponseComponentTotalsItemKind EmployerPayment =
        new(Values.EmployerPayment);

    public PostV1PayrollRunsGetResponseComponentTotalsItemKind(string value)
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
    public static PostV1PayrollRunsGetResponseComponentTotalsItemKind FromCustom(string value)
    {
        return new PostV1PayrollRunsGetResponseComponentTotalsItemKind(value);
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
        PostV1PayrollRunsGetResponseComponentTotalsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PayrollRunsGetResponseComponentTotalsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1PayrollRunsGetResponseComponentTotalsItemKind value
    ) => value.Value;

    public static explicit operator PostV1PayrollRunsGetResponseComponentTotalsItemKind(
        string value
    ) => new(value);

    internal class PostV1PayrollRunsGetResponseComponentTotalsItemKindSerializer
        : JsonConverter<PostV1PayrollRunsGetResponseComponentTotalsItemKind>
    {
        public override PostV1PayrollRunsGetResponseComponentTotalsItemKind Read(
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
            return new PostV1PayrollRunsGetResponseComponentTotalsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PayrollRunsGetResponseComponentTotalsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PayrollRunsGetResponseComponentTotalsItemKind ReadAsPropertyName(
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
            return new PostV1PayrollRunsGetResponseComponentTotalsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PayrollRunsGetResponseComponentTotalsItemKind value,
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
