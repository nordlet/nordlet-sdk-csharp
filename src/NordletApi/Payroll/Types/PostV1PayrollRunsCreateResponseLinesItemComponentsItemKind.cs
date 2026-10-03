using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind.PostV1PayrollRunsCreateResponseLinesItemComponentsItemKindSerializer)
)]
[Serializable]
public readonly record struct PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind
    : IStringEnum
{
    public static readonly PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind Allowance =
        new(Values.Allowance);

    public static readonly PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind EmployeeTax =
        new(Values.EmployeeTax);

    public static readonly PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind EmployeeContribution =
        new(Values.EmployeeContribution);

    public static readonly PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind EmployerContribution =
        new(Values.EmployerContribution);

    public static readonly PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind EmployerPayment =
        new(Values.EmployerPayment);

    public PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind(string value)
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
    public static PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind FromCustom(
        string value
    )
    {
        return new PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind(value);
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
        PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind value
    ) => value.Value;

    public static explicit operator PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind(
        string value
    ) => new(value);

    internal class PostV1PayrollRunsCreateResponseLinesItemComponentsItemKindSerializer
        : JsonConverter<PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind>
    {
        public override PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind Read(
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
            return new PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind ReadAsPropertyName(
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
            return new PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PayrollRunsCreateResponseLinesItemComponentsItemKind value,
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
