using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind.PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKindSerializer)
)]
[Serializable]
public readonly record struct PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind
    : IStringEnum
{
    public static readonly PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind Allowance =
        new(Values.Allowance);

    public static readonly PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind EmployeeTax =
        new(Values.EmployeeTax);

    public static readonly PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind EmployeeContribution =
        new(Values.EmployeeContribution);

    public static readonly PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind EmployerContribution =
        new(Values.EmployerContribution);

    public static readonly PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind EmployerPayment =
        new(Values.EmployerPayment);

    public PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind(string value)
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
    public static PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind FromCustom(
        string value
    )
    {
        return new PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind(value);
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
        PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind value
    ) => value.Value;

    public static explicit operator PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind(
        string value
    ) => new(value);

    internal class PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKindSerializer
        : JsonConverter<PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind>
    {
        public override PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind Read(
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
            return new PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind ReadAsPropertyName(
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
            return new PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PayrollRunsListResponseRowsItemComponentTotalsItemKind value,
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
