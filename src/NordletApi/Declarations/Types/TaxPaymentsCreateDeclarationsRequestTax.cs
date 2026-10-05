using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TaxPaymentsCreateDeclarationsRequestTax.TaxPaymentsCreateDeclarationsRequestTaxSerializer)
)]
[Serializable]
public readonly record struct TaxPaymentsCreateDeclarationsRequestTax : IStringEnum
{
    public static readonly TaxPaymentsCreateDeclarationsRequestTax CorporateIncomeTax = new(
        Values.CorporateIncomeTax
    );

    public static readonly TaxPaymentsCreateDeclarationsRequestTax PayrollWithholding = new(
        Values.PayrollWithholding
    );

    public static readonly TaxPaymentsCreateDeclarationsRequestTax Vat = new(Values.Vat);

    public static readonly TaxPaymentsCreateDeclarationsRequestTax SocialInsurance = new(
        Values.SocialInsurance
    );

    public static readonly TaxPaymentsCreateDeclarationsRequestTax Other = new(Values.Other);

    public TaxPaymentsCreateDeclarationsRequestTax(string value)
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
    public static TaxPaymentsCreateDeclarationsRequestTax FromCustom(string value)
    {
        return new TaxPaymentsCreateDeclarationsRequestTax(value);
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

    public static bool operator ==(TaxPaymentsCreateDeclarationsRequestTax value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TaxPaymentsCreateDeclarationsRequestTax value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TaxPaymentsCreateDeclarationsRequestTax value) =>
        value.Value;

    public static explicit operator TaxPaymentsCreateDeclarationsRequestTax(string value) =>
        new(value);

    internal class TaxPaymentsCreateDeclarationsRequestTaxSerializer
        : JsonConverter<TaxPaymentsCreateDeclarationsRequestTax>
    {
        public override TaxPaymentsCreateDeclarationsRequestTax Read(
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
            return new TaxPaymentsCreateDeclarationsRequestTax(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TaxPaymentsCreateDeclarationsRequestTax value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TaxPaymentsCreateDeclarationsRequestTax ReadAsPropertyName(
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
            return new TaxPaymentsCreateDeclarationsRequestTax(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TaxPaymentsCreateDeclarationsRequestTax value,
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
