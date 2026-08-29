using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerPostingRulesUpdateRequestRulesItemKey.PostV1LedgerPostingRulesUpdateRequestRulesItemKeySerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerPostingRulesUpdateRequestRulesItemKey : IStringEnum
{
    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey SalesReceivable = new(
        Values.SalesReceivable
    );

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey SalesRevenueProducts =
        new(Values.SalesRevenueProducts);

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey SalesRevenueServices =
        new(Values.SalesRevenueServices);

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey SalesVatPayable = new(
        Values.SalesVatPayable
    );

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey SalesAdvancesReceived =
        new(Values.SalesAdvancesReceived);

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey PurchasesPayables =
        new(Values.PurchasesPayables);

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey PurchasesVatReceivable =
        new(Values.PurchasesVatReceivable);

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey PurchasesGoodsForResale =
        new(Values.PurchasesGoodsForResale);

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey PurchasesDefaultExpense =
        new(Values.PurchasesDefaultExpense);

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey InventoryCogs = new(
        Values.InventoryCogs
    );

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey InventoryStock = new(
        Values.InventoryStock
    );

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey ProductionLaborApplied =
        new(Values.ProductionLaborApplied);

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey ProductionScrap = new(
        Values.ProductionScrap
    );

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey BankFxGain = new(
        Values.BankFxGain
    );

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey BankFxLoss = new(
        Values.BankFxLoss
    );

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey SettlementsFees = new(
        Values.SettlementsFees
    );

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey SettlementsCommissionRevenue =
        new(Values.SettlementsCommissionRevenue);

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey SettlementsSellerPayable =
        new(Values.SettlementsSellerPayable);

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey SettlementsSuspense =
        new(Values.SettlementsSuspense);

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey RevenueDeferredIncome =
        new(Values.RevenueDeferredIncome);

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey RevenueContractAsset =
        new(Values.RevenueContractAsset);

    public static readonly PostV1LedgerPostingRulesUpdateRequestRulesItemKey RevenueRefundLiability =
        new(Values.RevenueRefundLiability);

    public PostV1LedgerPostingRulesUpdateRequestRulesItemKey(string value)
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
    public static PostV1LedgerPostingRulesUpdateRequestRulesItemKey FromCustom(string value)
    {
        return new PostV1LedgerPostingRulesUpdateRequestRulesItemKey(value);
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
        PostV1LedgerPostingRulesUpdateRequestRulesItemKey value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1LedgerPostingRulesUpdateRequestRulesItemKey value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1LedgerPostingRulesUpdateRequestRulesItemKey value
    ) => value.Value;

    public static explicit operator PostV1LedgerPostingRulesUpdateRequestRulesItemKey(
        string value
    ) => new(value);

    internal class PostV1LedgerPostingRulesUpdateRequestRulesItemKeySerializer
        : JsonConverter<PostV1LedgerPostingRulesUpdateRequestRulesItemKey>
    {
        public override PostV1LedgerPostingRulesUpdateRequestRulesItemKey Read(
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
            return new PostV1LedgerPostingRulesUpdateRequestRulesItemKey(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerPostingRulesUpdateRequestRulesItemKey value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerPostingRulesUpdateRequestRulesItemKey ReadAsPropertyName(
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
            return new PostV1LedgerPostingRulesUpdateRequestRulesItemKey(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerPostingRulesUpdateRequestRulesItemKey value,
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
    }
}
