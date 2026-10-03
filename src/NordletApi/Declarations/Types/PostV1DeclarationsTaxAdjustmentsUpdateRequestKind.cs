using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsTaxAdjustmentsUpdateRequestKind.PostV1DeclarationsTaxAdjustmentsUpdateRequestKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsTaxAdjustmentsUpdateRequestKind : IStringEnum
{
    public static readonly PostV1DeclarationsTaxAdjustmentsUpdateRequestKind NonDeductible = new(
        Values.NonDeductible
    );

    public static readonly PostV1DeclarationsTaxAdjustmentsUpdateRequestKind IncomeIncrease = new(
        Values.IncomeIncrease
    );

    public static readonly PostV1DeclarationsTaxAdjustmentsUpdateRequestKind NonTaxableIncome = new(
        Values.NonTaxableIncome
    );

    public static readonly PostV1DeclarationsTaxAdjustmentsUpdateRequestKind ExcludedIncome = new(
        Values.ExcludedIncome
    );

    public static readonly PostV1DeclarationsTaxAdjustmentsUpdateRequestKind DeductibleAdjustment =
        new(Values.DeductibleAdjustment);

    public static readonly PostV1DeclarationsTaxAdjustmentsUpdateRequestKind Donation = new(
        Values.Donation
    );

    public static readonly PostV1DeclarationsTaxAdjustmentsUpdateRequestKind LossCarriedForward =
        new(Values.LossCarriedForward);

    public static readonly PostV1DeclarationsTaxAdjustmentsUpdateRequestKind InvestmentRelief = new(
        Values.InvestmentRelief
    );

    public static readonly PostV1DeclarationsTaxAdjustmentsUpdateRequestKind ForeignTaxCredit = new(
        Values.ForeignTaxCredit
    );

    public static readonly PostV1DeclarationsTaxAdjustmentsUpdateRequestKind TaxReduction = new(
        Values.TaxReduction
    );

    public PostV1DeclarationsTaxAdjustmentsUpdateRequestKind(string value)
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
    public static PostV1DeclarationsTaxAdjustmentsUpdateRequestKind FromCustom(string value)
    {
        return new PostV1DeclarationsTaxAdjustmentsUpdateRequestKind(value);
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
        PostV1DeclarationsTaxAdjustmentsUpdateRequestKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsTaxAdjustmentsUpdateRequestKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsTaxAdjustmentsUpdateRequestKind value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsTaxAdjustmentsUpdateRequestKind(
        string value
    ) => new(value);

    internal class PostV1DeclarationsTaxAdjustmentsUpdateRequestKindSerializer
        : JsonConverter<PostV1DeclarationsTaxAdjustmentsUpdateRequestKind>
    {
        public override PostV1DeclarationsTaxAdjustmentsUpdateRequestKind Read(
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
            return new PostV1DeclarationsTaxAdjustmentsUpdateRequestKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsTaxAdjustmentsUpdateRequestKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsTaxAdjustmentsUpdateRequestKind ReadAsPropertyName(
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
            return new PostV1DeclarationsTaxAdjustmentsUpdateRequestKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsTaxAdjustmentsUpdateRequestKind value,
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
