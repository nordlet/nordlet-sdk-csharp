using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DeReturnsGenerateDeclarationsRequestRuleKey.DeReturnsGenerateDeclarationsRequestRuleKeySerializer)
)]
[Serializable]
public readonly record struct DeReturnsGenerateDeclarationsRequestRuleKey : IStringEnum
{
    public static readonly DeReturnsGenerateDeclarationsRequestRuleKey DeEBilanz = new(
        Values.DeEBilanz
    );

    public static readonly DeReturnsGenerateDeclarationsRequestRuleKey DeCitReturn = new(
        Values.DeCitReturn
    );

    public static readonly DeReturnsGenerateDeclarationsRequestRuleKey DeTradeTax = new(
        Values.DeTradeTax
    );

    public static readonly DeReturnsGenerateDeclarationsRequestRuleKey DeTradeTaxApportionment =
        new(Values.DeTradeTaxApportionment);

    public static readonly DeReturnsGenerateDeclarationsRequestRuleKey DeAnnualVatReturn = new(
        Values.DeAnnualVatReturn
    );

    public static readonly DeReturnsGenerateDeclarationsRequestRuleKey DePayrollWithholding = new(
        Values.DePayrollWithholding
    );

    public static readonly DeReturnsGenerateDeclarationsRequestRuleKey DePayrollStatements = new(
        Values.DePayrollStatements
    );

    public DeReturnsGenerateDeclarationsRequestRuleKey(string value)
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
    public static DeReturnsGenerateDeclarationsRequestRuleKey FromCustom(string value)
    {
        return new DeReturnsGenerateDeclarationsRequestRuleKey(value);
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
        DeReturnsGenerateDeclarationsRequestRuleKey value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeReturnsGenerateDeclarationsRequestRuleKey value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DeReturnsGenerateDeclarationsRequestRuleKey value) =>
        value.Value;

    public static explicit operator DeReturnsGenerateDeclarationsRequestRuleKey(string value) =>
        new(value);

    internal class DeReturnsGenerateDeclarationsRequestRuleKeySerializer
        : JsonConverter<DeReturnsGenerateDeclarationsRequestRuleKey>
    {
        public override DeReturnsGenerateDeclarationsRequestRuleKey Read(
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
            return new DeReturnsGenerateDeclarationsRequestRuleKey(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DeReturnsGenerateDeclarationsRequestRuleKey value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DeReturnsGenerateDeclarationsRequestRuleKey ReadAsPropertyName(
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
            return new DeReturnsGenerateDeclarationsRequestRuleKey(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DeReturnsGenerateDeclarationsRequestRuleKey value,
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
        public const string DeEBilanz = "de-e-bilanz";

        public const string DeCitReturn = "de-cit-return";

        public const string DeTradeTax = "de-trade-tax";

        public const string DeTradeTaxApportionment = "de-trade-tax-apportionment";

        public const string DeAnnualVatReturn = "de-annual-vat-return";

        public const string DePayrollWithholding = "de-payroll-withholding";

        public const string DePayrollStatements = "de-payroll-statements";
    }
}
