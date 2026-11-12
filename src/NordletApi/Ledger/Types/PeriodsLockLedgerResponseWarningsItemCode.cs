using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PeriodsLockLedgerResponseWarningsItemCode.PeriodsLockLedgerResponseWarningsItemCodeSerializer)
)]
[Serializable]
public readonly record struct PeriodsLockLedgerResponseWarningsItemCode : IStringEnum
{
    public static readonly PeriodsLockLedgerResponseWarningsItemCode DraftSaleDocuments = new(
        Values.DraftSaleDocuments
    );

    public static readonly PeriodsLockLedgerResponseWarningsItemCode DraftPurchaseDocuments = new(
        Values.DraftPurchaseDocuments
    );

    public static readonly PeriodsLockLedgerResponseWarningsItemCode UnbookedBankLines = new(
        Values.UnbookedBankLines
    );

    public static readonly PeriodsLockLedgerResponseWarningsItemCode DepreciationNotPosted = new(
        Values.DepreciationNotPosted
    );

    public static readonly PeriodsLockLedgerResponseWarningsItemCode DeferralsNotPosted = new(
        Values.DeferralsNotPosted
    );

    public static readonly PeriodsLockLedgerResponseWarningsItemCode RecurringInvoicesNotGenerated =
        new(Values.RecurringInvoicesNotGenerated);

    public static readonly PeriodsLockLedgerResponseWarningsItemCode PayrollRunsNotApproved = new(
        Values.PayrollRunsNotApproved
    );

    public static readonly PeriodsLockLedgerResponseWarningsItemCode OpenFxReceivables = new(
        Values.OpenFxReceivables
    );

    public static readonly PeriodsLockLedgerResponseWarningsItemCode OpenFxPayables = new(
        Values.OpenFxPayables
    );

    public PeriodsLockLedgerResponseWarningsItemCode(string value)
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
    public static PeriodsLockLedgerResponseWarningsItemCode FromCustom(string value)
    {
        return new PeriodsLockLedgerResponseWarningsItemCode(value);
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
        PeriodsLockLedgerResponseWarningsItemCode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PeriodsLockLedgerResponseWarningsItemCode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PeriodsLockLedgerResponseWarningsItemCode value) =>
        value.Value;

    public static explicit operator PeriodsLockLedgerResponseWarningsItemCode(string value) =>
        new(value);

    internal class PeriodsLockLedgerResponseWarningsItemCodeSerializer
        : JsonConverter<PeriodsLockLedgerResponseWarningsItemCode>
    {
        public override PeriodsLockLedgerResponseWarningsItemCode Read(
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
            return new PeriodsLockLedgerResponseWarningsItemCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PeriodsLockLedgerResponseWarningsItemCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PeriodsLockLedgerResponseWarningsItemCode ReadAsPropertyName(
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
            return new PeriodsLockLedgerResponseWarningsItemCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PeriodsLockLedgerResponseWarningsItemCode value,
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
