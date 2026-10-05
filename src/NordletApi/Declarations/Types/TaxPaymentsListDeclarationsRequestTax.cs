using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TaxPaymentsListDeclarationsRequestTax.TaxPaymentsListDeclarationsRequestTaxSerializer)
)]
[Serializable]
public readonly record struct TaxPaymentsListDeclarationsRequestTax : IStringEnum
{
    public static readonly TaxPaymentsListDeclarationsRequestTax CorporateIncomeTax = new(
        Values.CorporateIncomeTax
    );

    public static readonly TaxPaymentsListDeclarationsRequestTax PayrollWithholding = new(
        Values.PayrollWithholding
    );

    public static readonly TaxPaymentsListDeclarationsRequestTax Vat = new(Values.Vat);

    public static readonly TaxPaymentsListDeclarationsRequestTax SocialInsurance = new(
        Values.SocialInsurance
    );

    public static readonly TaxPaymentsListDeclarationsRequestTax Other = new(Values.Other);

    public TaxPaymentsListDeclarationsRequestTax(string value)
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
    public static TaxPaymentsListDeclarationsRequestTax FromCustom(string value)
    {
        return new TaxPaymentsListDeclarationsRequestTax(value);
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

    public static bool operator ==(TaxPaymentsListDeclarationsRequestTax value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TaxPaymentsListDeclarationsRequestTax value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TaxPaymentsListDeclarationsRequestTax value) =>
        value.Value;

    public static explicit operator TaxPaymentsListDeclarationsRequestTax(string value) =>
        new(value);

    internal class TaxPaymentsListDeclarationsRequestTaxSerializer
        : JsonConverter<TaxPaymentsListDeclarationsRequestTax>
    {
        public override TaxPaymentsListDeclarationsRequestTax Read(
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
            return new TaxPaymentsListDeclarationsRequestTax(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TaxPaymentsListDeclarationsRequestTax value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TaxPaymentsListDeclarationsRequestTax ReadAsPropertyName(
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
            return new TaxPaymentsListDeclarationsRequestTax(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TaxPaymentsListDeclarationsRequestTax value,
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
        public const string CorporateIncomeTax = "corporate_income_tax";

        public const string PayrollWithholding = "payroll_withholding";

        public const string Vat = "vat";

        public const string SocialInsurance = "social_insurance";

        public const string Other = "other";
    }
}
