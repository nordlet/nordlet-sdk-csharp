using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsTaxAdjustmentsCreateResponseKind.PostV1DeclarationsTaxAdjustmentsCreateResponseKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsTaxAdjustmentsCreateResponseKind : IStringEnum
{
    public static readonly PostV1DeclarationsTaxAdjustmentsCreateResponseKind NonDeductible = new(
        Values.NonDeductible
    );

    public static readonly PostV1DeclarationsTaxAdjustmentsCreateResponseKind IncomeIncrease = new(
        Values.IncomeIncrease
    );

    public static readonly PostV1DeclarationsTaxAdjustmentsCreateResponseKind NonTaxableIncome =
        new(Values.NonTaxableIncome);

    public static readonly PostV1DeclarationsTaxAdjustmentsCreateResponseKind ExcludedIncome = new(
        Values.ExcludedIncome
    );

    public static readonly PostV1DeclarationsTaxAdjustmentsCreateResponseKind DeductibleAdjustment =
        new(Values.DeductibleAdjustment);

    public static readonly PostV1DeclarationsTaxAdjustmentsCreateResponseKind Donation = new(
        Values.Donation
    );

    public static readonly PostV1DeclarationsTaxAdjustmentsCreateResponseKind LossCarriedForward =
        new(Values.LossCarriedForward);

    public static readonly PostV1DeclarationsTaxAdjustmentsCreateResponseKind InvestmentRelief =
        new(Values.InvestmentRelief);

    public static readonly PostV1DeclarationsTaxAdjustmentsCreateResponseKind ForeignTaxCredit =
        new(Values.ForeignTaxCredit);

    public static readonly PostV1DeclarationsTaxAdjustmentsCreateResponseKind TaxReduction = new(
        Values.TaxReduction
    );

    public PostV1DeclarationsTaxAdjustmentsCreateResponseKind(string value)
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
    public static PostV1DeclarationsTaxAdjustmentsCreateResponseKind FromCustom(string value)
    {
        return new PostV1DeclarationsTaxAdjustmentsCreateResponseKind(value);
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
        PostV1DeclarationsTaxAdjustmentsCreateResponseKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsTaxAdjustmentsCreateResponseKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsTaxAdjustmentsCreateResponseKind value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsTaxAdjustmentsCreateResponseKind(
        string value
    ) => new(value);

    internal class PostV1DeclarationsTaxAdjustmentsCreateResponseKindSerializer
        : JsonConverter<PostV1DeclarationsTaxAdjustmentsCreateResponseKind>
    {
        public override PostV1DeclarationsTaxAdjustmentsCreateResponseKind Read(
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
            return new PostV1DeclarationsTaxAdjustmentsCreateResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsTaxAdjustmentsCreateResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsTaxAdjustmentsCreateResponseKind ReadAsPropertyName(
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
            return new PostV1DeclarationsTaxAdjustmentsCreateResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsTaxAdjustmentsCreateResponseKind value,
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
