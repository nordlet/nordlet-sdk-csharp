using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubscriptionsCreateWebhooksRequestEventsItem.SubscriptionsCreateWebhooksRequestEventsItemSerializer)
)]
[Serializable]
public readonly record struct SubscriptionsCreateWebhooksRequestEventsItem : IStringEnum
{
    public static readonly SubscriptionsCreateWebhooksRequestEventsItem AgreementInvoiceGenerated =
        new(Values.AgreementInvoiceGenerated);

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem BankFeedSynced = new(
        Values.BankFeedSynced
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem DocumentCapturePeppolReceived =
        new(Values.DocumentCapturePeppolReceived);

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem FilingFailed = new(
        Values.FilingFailed
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem FilingRejected = new(
        Values.FilingRejected
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem GoodsReceiptPosted = new(
        Values.GoodsReceiptPosted
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem IntercompanyInvoiceMirrored =
        new(Values.IntercompanyInvoiceMirrored);

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem ItemCreated = new(
        Values.ItemCreated
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem ItemDeleted = new(
        Values.ItemDeleted
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem ItemUpdated = new(
        Values.ItemUpdated
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem LeadConverted = new(
        Values.LeadConverted
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem LeadCreated = new(
        Values.LeadCreated
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem PartnerInquiryCreated = new(
        Values.PartnerInquiryCreated
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem PayrollRunApproved = new(
        Values.PayrollRunApproved
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem PayrollRunReversed = new(
        Values.PayrollRunReversed
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem PosReportCreated = new(
        Values.PosReportCreated
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem PriceListUpdated = new(
        Values.PriceListUpdated
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem PurchaseInvoicePaid = new(
        Values.PurchaseInvoicePaid
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem PurchaseInvoiceRegistered =
        new(Values.PurchaseInvoiceRegistered);

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem PurchaseOrderApproved = new(
        Values.PurchaseOrderApproved
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem PurchaseOrderReceived = new(
        Values.PurchaseOrderReceived
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem RefundLiabilityActual = new(
        Values.RefundLiabilityActual
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem RefundLiabilityTruedUp =
        new(Values.RefundLiabilityTruedUp);

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem ReportCompleted = new(
        Values.ReportCompleted
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem ReportFailed = new(
        Values.ReportFailed
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem RevenueRecognitionModified =
        new(Values.RevenueRecognitionModified);

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem RevenueRecognitionPosted =
        new(Values.RevenueRecognitionPosted);

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem SaleInvoiceEinvoiceSent =
        new(Values.SaleInvoiceEinvoiceSent);

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem SaleInvoiceIssued = new(
        Values.SaleInvoiceIssued
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem SaleInvoicePaid = new(
        Values.SaleInvoicePaid
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem SaleInvoicePeppolDelivered =
        new(Values.SaleInvoicePeppolDelivered);

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem SaleInvoicePeppolFailed =
        new(Values.SaleInvoicePeppolFailed);

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem SaleInvoicePeppolRejected =
        new(Values.SaleInvoicePeppolRejected);

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem SaleInvoicePeppolSent = new(
        Values.SaleInvoicePeppolSent
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem SaleInvoiceSent = new(
        Values.SaleInvoiceSent
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem SalesOrderCreated = new(
        Values.SalesOrderCreated
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem SalesOrderFulfilled = new(
        Values.SalesOrderFulfilled
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem SettlementImported = new(
        Values.SettlementImported
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem SettlementPosted = new(
        Values.SettlementPosted
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem SettlementUpdated = new(
        Values.SettlementUpdated
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem StockChanged = new(
        Values.StockChanged
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem StockReorderNeeded = new(
        Values.StockReorderNeeded
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem VatReviewOpened = new(
        Values.VatReviewOpened
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem VatReviewResolved = new(
        Values.VatReviewResolved
    );

    public static readonly SubscriptionsCreateWebhooksRequestEventsItem All = new(Values.All);

    public SubscriptionsCreateWebhooksRequestEventsItem(string value)
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
    public static SubscriptionsCreateWebhooksRequestEventsItem FromCustom(string value)
    {
        return new SubscriptionsCreateWebhooksRequestEventsItem(value);
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
        SubscriptionsCreateWebhooksRequestEventsItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SubscriptionsCreateWebhooksRequestEventsItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SubscriptionsCreateWebhooksRequestEventsItem value) =>
        value.Value;

    public static explicit operator SubscriptionsCreateWebhooksRequestEventsItem(string value) =>
        new(value);

    internal class SubscriptionsCreateWebhooksRequestEventsItemSerializer
        : JsonConverter<SubscriptionsCreateWebhooksRequestEventsItem>
    {
        public override SubscriptionsCreateWebhooksRequestEventsItem Read(
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
            return new SubscriptionsCreateWebhooksRequestEventsItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubscriptionsCreateWebhooksRequestEventsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubscriptionsCreateWebhooksRequestEventsItem ReadAsPropertyName(
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
            return new SubscriptionsCreateWebhooksRequestEventsItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubscriptionsCreateWebhooksRequestEventsItem value,
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

        public const string DocumentCapturePeppolReceived = "document_capture.peppol_received";

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

        public const string PayrollRunReversed = "payroll_run.reversed";

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

        public const string SaleInvoicePeppolDelivered = "sale_invoice.peppol_delivered";

        public const string SaleInvoicePeppolFailed = "sale_invoice.peppol_failed";

        public const string SaleInvoicePeppolRejected = "sale_invoice.peppol_rejected";

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
