using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TaxAdjustmentsListDeclarationsResponseRowsItemKind.TaxAdjustmentsListDeclarationsResponseRowsItemKindSerializer)
)]
[Serializable]
public readonly record struct TaxAdjustmentsListDeclarationsResponseRowsItemKind : IStringEnum
{
    public static readonly TaxAdjustmentsListDeclarationsResponseRowsItemKind NonDeductible = new(
        Values.NonDeductible
    );

    public static readonly TaxAdjustmentsListDeclarationsResponseRowsItemKind IncomeIncrease = new(
        Values.IncomeIncrease
    );

    public static readonly TaxAdjustmentsListDeclarationsResponseRowsItemKind NonTaxableIncome =
        new(Values.NonTaxableIncome);

    public static readonly TaxAdjustmentsListDeclarationsResponseRowsItemKind ExcludedIncome = new(
        Values.ExcludedIncome
    );

    public static readonly TaxAdjustmentsListDeclarationsResponseRowsItemKind DeductibleAdjustment =
        new(Values.DeductibleAdjustment);

    public static readonly TaxAdjustmentsListDeclarationsResponseRowsItemKind Donation = new(
        Values.Donation
    );

    public static readonly TaxAdjustmentsListDeclarationsResponseRowsItemKind LossCarriedForward =
        new(Values.LossCarriedForward);

    public static readonly TaxAdjustmentsListDeclarationsResponseRowsItemKind InvestmentRelief =
        new(Values.InvestmentRelief);

    public static readonly TaxAdjustmentsListDeclarationsResponseRowsItemKind ForeignTaxCredit =
        new(Values.ForeignTaxCredit);

    public static readonly TaxAdjustmentsListDeclarationsResponseRowsItemKind TaxReduction = new(
        Values.TaxReduction
    );

    public TaxAdjustmentsListDeclarationsResponseRowsItemKind(string value)
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
    public static TaxAdjustmentsListDeclarationsResponseRowsItemKind FromCustom(string value)
    {
        return new TaxAdjustmentsListDeclarationsResponseRowsItemKind(value);
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
        TaxAdjustmentsListDeclarationsResponseRowsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TaxAdjustmentsListDeclarationsResponseRowsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        TaxAdjustmentsListDeclarationsResponseRowsItemKind value
    ) => value.Value;

    public static explicit operator TaxAdjustmentsListDeclarationsResponseRowsItemKind(
        string value
    ) => new(value);

    internal class TaxAdjustmentsListDeclarationsResponseRowsItemKindSerializer
        : JsonConverter<TaxAdjustmentsListDeclarationsResponseRowsItemKind>
    {
        public override TaxAdjustmentsListDeclarationsResponseRowsItemKind Read(
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
            return new TaxAdjustmentsListDeclarationsResponseRowsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TaxAdjustmentsListDeclarationsResponseRowsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TaxAdjustmentsListDeclarationsResponseRowsItemKind ReadAsPropertyName(
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
            return new TaxAdjustmentsListDeclarationsResponseRowsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TaxAdjustmentsListDeclarationsResponseRowsItemKind value,
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
