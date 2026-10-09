using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostingRulesUpdateLedgerRequestRulesItemKey.PostingRulesUpdateLedgerRequestRulesItemKeySerializer)
)]
[Serializable]
public readonly record struct PostingRulesUpdateLedgerRequestRulesItemKey : IStringEnum
{
    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey SalesReceivable = new(
        Values.SalesReceivable
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey SalesRevenueProducts = new(
        Values.SalesRevenueProducts
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey SalesRevenueServices = new(
        Values.SalesRevenueServices
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey SalesVatPayable = new(
        Values.SalesVatPayable
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey SalesAdvancesReceived = new(
        Values.SalesAdvancesReceived
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey PurchasesPayables = new(
        Values.PurchasesPayables
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey PurchasesVatReceivable = new(
        Values.PurchasesVatReceivable
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey PurchasesGoodsForResale =
        new(Values.PurchasesGoodsForResale);

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey PurchasesDefaultExpense =
        new(Values.PurchasesDefaultExpense);

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey PurchasesPrepaidExpenses =
        new(Values.PurchasesPrepaidExpenses);

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey InventoryCogs = new(
        Values.InventoryCogs
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey InventoryStock = new(
        Values.InventoryStock
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey ProductionLaborApplied = new(
        Values.ProductionLaborApplied
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey ProductionScrap = new(
        Values.ProductionScrap
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey BankFxGain = new(
        Values.BankFxGain
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey BankFxLoss = new(
        Values.BankFxLoss
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey SettlementsFees = new(
        Values.SettlementsFees
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey SettlementsCommissionRevenue =
        new(Values.SettlementsCommissionRevenue);

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey SettlementsSellerPayable =
        new(Values.SettlementsSellerPayable);

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey SettlementsSuspense = new(
        Values.SettlementsSuspense
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey RevenueDeferredIncome = new(
        Values.RevenueDeferredIncome
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey RevenueContractAsset = new(
        Values.RevenueContractAsset
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey RevenueRefundLiability = new(
        Values.RevenueRefundLiability
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey AssetsDisposalGain = new(
        Values.AssetsDisposalGain
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey AssetsDisposalLoss = new(
        Values.AssetsDisposalLoss
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey AssetsDisposalProceeds = new(
        Values.AssetsDisposalProceeds
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey CashAdvances = new(
        Values.CashAdvances
    );

    public static readonly PostingRulesUpdateLedgerRequestRulesItemKey ClosingRetainedEarnings =
        new(Values.ClosingRetainedEarnings);

    public PostingRulesUpdateLedgerRequestRulesItemKey(string value)
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
    public static PostingRulesUpdateLedgerRequestRulesItemKey FromCustom(string value)
    {
        return new PostingRulesUpdateLedgerRequestRulesItemKey(value);
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
        PostingRulesUpdateLedgerRequestRulesItemKey value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostingRulesUpdateLedgerRequestRulesItemKey value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostingRulesUpdateLedgerRequestRulesItemKey value) =>
        value.Value;

    public static explicit operator PostingRulesUpdateLedgerRequestRulesItemKey(string value) =>
        new(value);

    internal class PostingRulesUpdateLedgerRequestRulesItemKeySerializer
        : JsonConverter<PostingRulesUpdateLedgerRequestRulesItemKey>
    {
        public override PostingRulesUpdateLedgerRequestRulesItemKey Read(
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
            return new PostingRulesUpdateLedgerRequestRulesItemKey(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostingRulesUpdateLedgerRequestRulesItemKey value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostingRulesUpdateLedgerRequestRulesItemKey ReadAsPropertyName(
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
            return new PostingRulesUpdateLedgerRequestRulesItemKey(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostingRulesUpdateLedgerRequestRulesItemKey value,
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
        public const string SalesReceivable = "sales.receivable";

        public const string SalesRevenueProducts = "sales.revenueProducts";

        public const string SalesRevenueServices = "sales.revenueServices";

        public const string SalesVatPayable = "sales.vatPayable";

        public const string SalesAdvancesReceived = "sales.advancesReceived";

        public const string PurchasesPayables = "purchases.payables";

        public const string PurchasesVatReceivable = "purchases.vatReceivable";

        public const string PurchasesGoodsForResale = "purchases.goodsForResale";

        public const string PurchasesDefaultExpense = "purchases.defaultExpense";

        public const string PurchasesPrepaidExpenses = "purchases.prepaidExpenses";

        public const string InventoryCogs = "inventory.cogs";

        public const string InventoryStock = "inventory.stock";

        public const string ProductionLaborApplied = "production.laborApplied";

        public const string ProductionScrap = "production.scrap";

        public const string BankFxGain = "bank.fxGain";

        public const string BankFxLoss = "bank.fxLoss";

        public const string SettlementsFees = "settlements.fees";

        public const string SettlementsCommissionRevenue = "settlements.commissionRevenue";

        public const string SettlementsSellerPayable = "settlements.sellerPayable";

        public const string SettlementsSuspense = "settlements.suspense";

        public const string RevenueDeferredIncome = "revenue.deferredIncome";

        public const string RevenueContractAsset = "revenue.contractAsset";

        public const string RevenueRefundLiability = "revenue.refundLiability";

        public const string AssetsDisposalGain = "assets.disposalGain";

        public const string AssetsDisposalLoss = "assets.disposalLoss";

        public const string AssetsDisposalProceeds = "assets.disposalProceeds";

        public const string CashAdvances = "cash.advances";

        public const string ClosingRetainedEarnings = "closing.retainedEarnings";
    }
}
