using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubscriptionsUpdateWebhooksRequestEventsItem.SubscriptionsUpdateWebhooksRequestEventsItemSerializer)
)]
[Serializable]
public readonly record struct SubscriptionsUpdateWebhooksRequestEventsItem : IStringEnum
{
    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem AgreementInvoiceGenerated =
        new(Values.AgreementInvoiceGenerated);

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem BankFeedSynced = new(
        Values.BankFeedSynced
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem FilingFailed = new(
        Values.FilingFailed
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem FilingRejected = new(
        Values.FilingRejected
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem GoodsReceiptPosted = new(
        Values.GoodsReceiptPosted
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem IntercompanyInvoiceMirrored =
        new(Values.IntercompanyInvoiceMirrored);

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem ItemCreated = new(
        Values.ItemCreated
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem ItemDeleted = new(
        Values.ItemDeleted
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem ItemUpdated = new(
        Values.ItemUpdated
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem LeadConverted = new(
        Values.LeadConverted
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem LeadCreated = new(
        Values.LeadCreated
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem PartnerInquiryCreated = new(
        Values.PartnerInquiryCreated
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem PayrollRunApproved = new(
        Values.PayrollRunApproved
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem PosReportCreated = new(
        Values.PosReportCreated
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem PriceListUpdated = new(
        Values.PriceListUpdated
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem PurchaseInvoicePaid = new(
        Values.PurchaseInvoicePaid
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem PurchaseInvoiceRegistered =
        new(Values.PurchaseInvoiceRegistered);

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem PurchaseOrderApproved = new(
        Values.PurchaseOrderApproved
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem PurchaseOrderReceived = new(
        Values.PurchaseOrderReceived
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem RefundLiabilityActual = new(
        Values.RefundLiabilityActual
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem RefundLiabilityTruedUp =
        new(Values.RefundLiabilityTruedUp);

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem ReportCompleted = new(
        Values.ReportCompleted
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem ReportFailed = new(
        Values.ReportFailed
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem RevenueRecognitionModified =
        new(Values.RevenueRecognitionModified);

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem RevenueRecognitionPosted =
        new(Values.RevenueRecognitionPosted);

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem SaleInvoiceEinvoiceSent =
        new(Values.SaleInvoiceEinvoiceSent);

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem SaleInvoiceIssued = new(
        Values.SaleInvoiceIssued
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem SaleInvoicePaid = new(
        Values.SaleInvoicePaid
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem SaleInvoicePeppolSent = new(
        Values.SaleInvoicePeppolSent
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem SaleInvoiceSent = new(
        Values.SaleInvoiceSent
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem SalesOrderCreated = new(
        Values.SalesOrderCreated
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem SalesOrderFulfilled = new(
        Values.SalesOrderFulfilled
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem SettlementImported = new(
        Values.SettlementImported
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem SettlementPosted = new(
        Values.SettlementPosted
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem SettlementUpdated = new(
        Values.SettlementUpdated
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem StockChanged = new(
        Values.StockChanged
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem StockReorderNeeded = new(
        Values.StockReorderNeeded
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem VatReviewOpened = new(
        Values.VatReviewOpened
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem VatReviewResolved = new(
        Values.VatReviewResolved
    );

    public static readonly SubscriptionsUpdateWebhooksRequestEventsItem All = new(Values.All);

    public SubscriptionsUpdateWebhooksRequestEventsItem(string value)
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
    public static SubscriptionsUpdateWebhooksRequestEventsItem FromCustom(string value)
    {
        return new SubscriptionsUpdateWebhooksRequestEventsItem(value);
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
        SubscriptionsUpdateWebhooksRequestEventsItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SubscriptionsUpdateWebhooksRequestEventsItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SubscriptionsUpdateWebhooksRequestEventsItem value) =>
        value.Value;

    public static explicit operator SubscriptionsUpdateWebhooksRequestEventsItem(string value) =>
        new(value);

    internal class SubscriptionsUpdateWebhooksRequestEventsItemSerializer
        : JsonConverter<SubscriptionsUpdateWebhooksRequestEventsItem>
    {
        public override SubscriptionsUpdateWebhooksRequestEventsItem Read(
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
            return new SubscriptionsUpdateWebhooksRequestEventsItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubscriptionsUpdateWebhooksRequestEventsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubscriptionsUpdateWebhooksRequestEventsItem ReadAsPropertyName(
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
            return new SubscriptionsUpdateWebhooksRequestEventsItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubscriptionsUpdateWebhooksRequestEventsItem value,
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
        public const string AgreementInvoiceGenerated = "agreement.invoice_generated";

        public const string BankFeedSynced = "bank_feed.synced";

        public const string FilingFailed = "filing.failed";

        public const string FilingRejected = "filing.rejected";

        public const string GoodsReceiptPosted = "goods_receipt.posted";

        public const string IntercompanyInvoiceMirrored = "intercompany.invoice_mirrored";

        public const string ItemCreated = "item.created";

        public const string ItemDeleted = "item.deleted";

        public const string ItemUpdated = "item.updated";

        public const string LeadConverted = "lead.converted";

        public const string LeadCreated = "lead.created";

        public const string PartnerInquiryCreated = "partner_inquiry.created";

        public const string PayrollRunApproved = "payroll_run.approved";

        public const string PosReportCreated = "pos_report.created";

        public const string PriceListUpdated = "price_list.updated";

        public const string PurchaseInvoicePaid = "purchase_invoice.paid";

        public const string PurchaseInvoiceRegistered = "purchase_invoice.registered";

        public const string PurchaseOrderApproved = "purchase_order.approved";

        public const string PurchaseOrderReceived = "purchase_order.received";

        public const string RefundLiabilityActual = "refund_liability.actual";

        public const string RefundLiabilityTruedUp = "refund_liability.trued_up";

        public const string ReportCompleted = "report.completed";

        public const string ReportFailed = "report.failed";

        public const string RevenueRecognitionModified = "revenue_recognition.modified";

        public const string RevenueRecognitionPosted = "revenue_recognition.posted";

        public const string SaleInvoiceEinvoiceSent = "sale_invoice.einvoice_sent";

        public const string SaleInvoiceIssued = "sale_invoice.issued";

        public const string SaleInvoicePaid = "sale_invoice.paid";

        public const string SaleInvoicePeppolSent = "sale_invoice.peppol_sent";

        public const string SaleInvoiceSent = "sale_invoice.sent";

        public const string SalesOrderCreated = "sales_order.created";

        public const string SalesOrderFulfilled = "sales_order.fulfilled";

        public const string SettlementImported = "settlement.imported";

        public const string SettlementPosted = "settlement.posted";

        public const string SettlementUpdated = "settlement.updated";

        public const string StockChanged = "stock.changed";

        public const string StockReorderNeeded = "stock.reorder_needed";

        public const string VatReviewOpened = "vat_review.opened";

        public const string VatReviewResolved = "vat_review.resolved";

        public const string All = "*";
    }
}
