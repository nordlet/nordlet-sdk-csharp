using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PeriodChecklistReportsResponseItemsItemCode.PeriodChecklistReportsResponseItemsItemCodeSerializer)
)]
[Serializable]
public readonly record struct PeriodChecklistReportsResponseItemsItemCode : IStringEnum
{
    public static readonly PeriodChecklistReportsResponseItemsItemCode DraftSaleDocuments = new(
        Values.DraftSaleDocuments
    );

    public static readonly PeriodChecklistReportsResponseItemsItemCode DraftPurchaseDocuments = new(
        Values.DraftPurchaseDocuments
    );

    public static readonly PeriodChecklistReportsResponseItemsItemCode UnbookedBankLines = new(
        Values.UnbookedBankLines
    );

    public static readonly PeriodChecklistReportsResponseItemsItemCode DepreciationNotPosted = new(
        Values.DepreciationNotPosted
    );

    public static readonly PeriodChecklistReportsResponseItemsItemCode DeferralsNotPosted = new(
        Values.DeferralsNotPosted
    );

    public static readonly PeriodChecklistReportsResponseItemsItemCode RecurringInvoicesNotGenerated =
        new(Values.RecurringInvoicesNotGenerated);

    public static readonly PeriodChecklistReportsResponseItemsItemCode PayrollRunsNotApproved = new(
        Values.PayrollRunsNotApproved
    );

    public static readonly PeriodChecklistReportsResponseItemsItemCode OpenFxReceivables = new(
        Values.OpenFxReceivables
    );

    public static readonly PeriodChecklistReportsResponseItemsItemCode OpenFxPayables = new(
        Values.OpenFxPayables
    );

    public PeriodChecklistReportsResponseItemsItemCode(string value)
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
    public static PeriodChecklistReportsResponseItemsItemCode FromCustom(string value)
    {
        return new PeriodChecklistReportsResponseItemsItemCode(value);
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
        PeriodChecklistReportsResponseItemsItemCode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PeriodChecklistReportsResponseItemsItemCode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PeriodChecklistReportsResponseItemsItemCode value) =>
        value.Value;

    public static explicit operator PeriodChecklistReportsResponseItemsItemCode(string value) =>
        new(value);

    internal class PeriodChecklistReportsResponseItemsItemCodeSerializer
        : JsonConverter<PeriodChecklistReportsResponseItemsItemCode>
    {
        public override PeriodChecklistReportsResponseItemsItemCode Read(
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
            return new PeriodChecklistReportsResponseItemsItemCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PeriodChecklistReportsResponseItemsItemCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PeriodChecklistReportsResponseItemsItemCode ReadAsPropertyName(
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
            return new PeriodChecklistReportsResponseItemsItemCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PeriodChecklistReportsResponseItemsItemCode value,
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
        public const string DraftSaleDocuments = "draft_sale_documents";

        public const string DraftPurchaseDocuments = "draft_purchase_documents";

        public const string UnbookedBankLines = "unbooked_bank_lines";

        public const string DepreciationNotPosted = "depreciation_not_posted";

        public const string DeferralsNotPosted = "deferrals_not_posted";

        public const string RecurringInvoicesNotGenerated = "recurring_invoices_not_generated";

        public const string PayrollRunsNotApproved = "payroll_runs_not_approved";

        public const string OpenFxReceivables = "open_fx_receivables";

        public const string OpenFxPayables = "open_fx_payables";
    }
}
