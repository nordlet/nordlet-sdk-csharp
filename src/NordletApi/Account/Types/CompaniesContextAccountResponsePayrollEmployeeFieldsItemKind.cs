using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind.CompaniesContextAccountResponsePayrollEmployeeFieldsItemKindSerializer)
)]
[Serializable]
public readonly record struct CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind
    : IStringEnum
{
    public static readonly CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind Text = new(
        Values.Text
    );

    public static readonly CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind Select =
        new(Values.Select);

    public static readonly CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind Date = new(
        Values.Date
    );

    public CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind(string value)
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
    public static CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind FromCustom(
        string value
    )
    {
        return new CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind(value);
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
        CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind value
    ) => value.Value;

    public static explicit operator CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind(
        string value
    ) => new(value);

    internal class CompaniesContextAccountResponsePayrollEmployeeFieldsItemKindSerializer
        : JsonConverter<CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind>
    {
        public override CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind Read(
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
            return new CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind ReadAsPropertyName(
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
            return new CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesContextAccountResponsePayrollEmployeeFieldsItemKind value,
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
        public const string Text = "text";

        public const string Select = "select";

        public const string Date = "date";
    }
}
