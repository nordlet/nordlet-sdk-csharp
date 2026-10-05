using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TaxAdjustmentsCreateDeclarationsResponseKind.TaxAdjustmentsCreateDeclarationsResponseKindSerializer)
)]
[Serializable]
public readonly record struct TaxAdjustmentsCreateDeclarationsResponseKind : IStringEnum
{
    public static readonly TaxAdjustmentsCreateDeclarationsResponseKind NonDeductible = new(
        Values.NonDeductible
    );

    public static readonly TaxAdjustmentsCreateDeclarationsResponseKind IncomeIncrease = new(
        Values.IncomeIncrease
    );

    public static readonly TaxAdjustmentsCreateDeclarationsResponseKind NonTaxableIncome = new(
        Values.NonTaxableIncome
    );

    public static readonly TaxAdjustmentsCreateDeclarationsResponseKind ExcludedIncome = new(
        Values.ExcludedIncome
    );

    public static readonly TaxAdjustmentsCreateDeclarationsResponseKind DeductibleAdjustment = new(
        Values.DeductibleAdjustment
    );

    public static readonly TaxAdjustmentsCreateDeclarationsResponseKind Donation = new(
        Values.Donation
    );

    public static readonly TaxAdjustmentsCreateDeclarationsResponseKind LossCarriedForward = new(
        Values.LossCarriedForward
    );

    public static readonly TaxAdjustmentsCreateDeclarationsResponseKind InvestmentRelief = new(
        Values.InvestmentRelief
    );

    public static readonly TaxAdjustmentsCreateDeclarationsResponseKind ForeignTaxCredit = new(
        Values.ForeignTaxCredit
    );

    public static readonly TaxAdjustmentsCreateDeclarationsResponseKind TaxReduction = new(
        Values.TaxReduction
    );

    public TaxAdjustmentsCreateDeclarationsResponseKind(string value)
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
    public static TaxAdjustmentsCreateDeclarationsResponseKind FromCustom(string value)
    {
        return new TaxAdjustmentsCreateDeclarationsResponseKind(value);
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
        TaxAdjustmentsCreateDeclarationsResponseKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TaxAdjustmentsCreateDeclarationsResponseKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TaxAdjustmentsCreateDeclarationsResponseKind value) =>
        value.Value;

    public static explicit operator TaxAdjustmentsCreateDeclarationsResponseKind(string value) =>
        new(value);

    internal class TaxAdjustmentsCreateDeclarationsResponseKindSerializer
        : JsonConverter<TaxAdjustmentsCreateDeclarationsResponseKind>
    {
        public override TaxAdjustmentsCreateDeclarationsResponseKind Read(
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
            return new TaxAdjustmentsCreateDeclarationsResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TaxAdjustmentsCreateDeclarationsResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TaxAdjustmentsCreateDeclarationsResponseKind ReadAsPropertyName(
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
            return new TaxAdjustmentsCreateDeclarationsResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TaxAdjustmentsCreateDeclarationsResponseKind value,
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
        public const string NonDeductible = "non_deductible";

        public const string IncomeIncrease = "income_increase";

        public const string NonTaxableIncome = "non_taxable_income";

        public const string ExcludedIncome = "excluded_income";

        public const string DeductibleAdjustment = "deductible_adjustment";

        public const string Donation = "donation";

        public const string LossCarriedForward = "loss_carried_forward";

        public const string InvestmentRelief = "investment_relief";

        public const string ForeignTaxCredit = "foreign_tax_credit";

        public const string TaxReduction = "tax_reduction";
    }
}
