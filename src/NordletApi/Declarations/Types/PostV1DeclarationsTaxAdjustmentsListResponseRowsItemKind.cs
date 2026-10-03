using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind.PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind : IStringEnum
{
    public static readonly PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind NonDeductible =
        new(Values.NonDeductible);

    public static readonly PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind IncomeIncrease =
        new(Values.IncomeIncrease);

    public static readonly PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind NonTaxableIncome =
        new(Values.NonTaxableIncome);

    public static readonly PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind ExcludedIncome =
        new(Values.ExcludedIncome);

    public static readonly PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind DeductibleAdjustment =
        new(Values.DeductibleAdjustment);

    public static readonly PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind Donation = new(
        Values.Donation
    );

    public static readonly PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind LossCarriedForward =
        new(Values.LossCarriedForward);

    public static readonly PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind InvestmentRelief =
        new(Values.InvestmentRelief);

    public static readonly PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind ForeignTaxCredit =
        new(Values.ForeignTaxCredit);

    public static readonly PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind TaxReduction =
        new(Values.TaxReduction);

    public PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind(string value)
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
    public static PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind FromCustom(string value)
    {
        return new PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind(value);
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
        PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind(
        string value
    ) => new(value);

    internal class PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKindSerializer
        : JsonConverter<PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind>
    {
        public override PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind Read(
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
            return new PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind ReadAsPropertyName(
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
            return new PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsTaxAdjustmentsListResponseRowsItemKind value,
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
