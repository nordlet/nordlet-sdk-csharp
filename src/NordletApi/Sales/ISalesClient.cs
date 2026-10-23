namespace NordletApi;

public partial interface ISalesClient
{
    /// <summary>
    /// Create a draft sale document - an invoice, credit note, proforma or advance invoice (`type`) - with its lines; the totals are computed from the lines and `discountPercent`, and the number is assigned by `sales/invoices/issue`. Answers 422 when a credit note credits a proforma, another credit note or a document that is not issued, when the credited document has another partner or currency, when an OSS or IOSS document has no EU `vatCountryCode`, when the lines carry VAT but the company is not a VAT payer or the VAT scheme charges none, or when the operation type or document series is for another document type.
    /// </summary>
    WithRawResponseTask<InvoicesCreateSalesResponse> InvoicesCreateAsync(
        InvoicesCreateSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return one sale document with its lines, its VAT evidence and, on an advance invoice, the gross amount already applied to final invoices.
    /// </summary>
    WithRawResponseTask<InvoicesGetSalesResponse> InvoicesGetAsync(
        InvoicesGetSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Render a sale document, draft or issued, as a PDF returned base64-encoded. The document's own `locale` wins over the requested one. When the company has a payment link template and the document is issued and not paid, the PDF carries the payment link.
    /// </summary>
    WithRawResponseTask<InvoicesPdfSalesResponse> InvoicesPdfAsync(
        InvoicesPdfSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// E-mail an issued sale document as a PDF attachment to `to`, else to the partner's e-mail address, and emit `sale_invoice.sent`. The PDF is the one of `sales/invoices/pdf`. Answers 422 when e-mail sending is not configured, when the document is not issued, or when neither `to` nor the partner's e-mail is set.
    /// </summary>
    WithRawResponseTask<InvoicesSendSalesResponse> InvoicesSendAsync(
        InvoicesSendSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Render an issued invoice or credit note as a Peppol BIS Billing 3.0 UBL file, returned base64-encoded with the sender and receiver participant identifiers, without sending it; `sales/invoices/peppol-send` sends the same file. Answers 422 for a draft, a proforma or an advance invoice.
    /// </summary>
    WithRawResponseTask<InvoicesPeppolXmlSalesResponse> InvoicesPeppolXmlAsync(
        InvoicesPeppolXmlSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Send an issued invoice or credit note to the customer over Peppol through the company's own access point (Account → Compliance → EU; Nordlet supports Recommand, Storecove and e-invoice.be). Without one the call is refused with 422 and the document can only be downloaded with `sales/invoices/peppol-xml`. `status` is `pending` until the receiving access point confirms, then `delivered`; `failed` and `rejected` come with `detail`, and the invoice can then be sent again. Later changes arrive through the access point's webhook and are announced as `sale_invoice.peppol_delivered`, `sale_invoice.peppol_rejected` and `sale_invoice.peppol_failed`.
    /// </summary>
    WithRawResponseTask<InvoicesPeppolSendSalesResponse> InvoicesPeppolSendAsync(
        InvoicesPeppolSendSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Ask the company's Peppol access point what happened to an invoice sent with `sales/invoices/peppol-send`, and store the answer: `pending`, `delivered` (the receiving access point confirmed it), `rejected` (the receiver refused it, see `detail`) or `failed` (it could not be delivered, see `detail`). The access point's webhook updates the same fields without this call. Storecove has no call for the status of a sent document, so for a Storecove access point this answers 422 and the status comes only from its webhook.
    /// </summary>
    WithRawResponseTask<InvoicesPeppolStatusSalesResponse> InvoicesPeppolStatusAsync(
        InvoicesPeppolStatusSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Render an issued invoice as the national e-invoicing payload for the company country: FatturaPA (IT), KSeF FA(3) (PL) or UBL CIUS-RO (RO). Review the warnings - data the invoice does not carry is flagged, never invented.
    /// </summary>
    WithRawResponseTask<InvoicesEinvoiceXmlSalesResponse> InvoicesEinvoiceXmlAsync(
        InvoicesEinvoiceXmlSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the national e-invoicing payload and deliver it over the transport configured for the country gateway in compliance settings. With transport=direct the request talks to the tax authority itself - SdICoop over 2-way TLS for Italy, a KSeF session for Poland, ANAF SPV OAuth for Romania - and returns the national number as soon as the channel assigns one. With transport=bridge the payload goes to the configured bridge endpoint (an accredited intermediary or connector) instead.
    /// </summary>
    WithRawResponseTask<InvoicesEinvoiceSendSalesResponse> InvoicesEinvoiceSendAsync(
        InvoicesEinvoiceSendSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Ask the national e-invoicing channel what happened to an invoice that was already sent, and store the answer. Italy, Poland and Romania return the outcome only on request - none of them calls back - so this is the way the national number and any rejection reason reach the invoice.
    /// </summary>
    WithRawResponseTask<InvoicesEinvoiceStatusSalesResponse> InvoicesEinvoiceStatusAsync(
        InvoicesEinvoiceStatusSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change a draft sale document. Fields left out keep their value, `lines` replaces every line, and a changed `discountPercent` recomputes the existing lines. Answers 409 when the document is issued or locked, and 422 under the checks of `sales/invoices/create` (the credited document's partner and currency, the OSS and IOSS country, VAT on the lines, the operation type and document series).
    /// </summary>
    WithRawResponseTask<InvoicesUpdateSalesResponse> InvoicesUpdateAsync(
        InvoicesUpdateSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a draft sale document and release the time entries billed on it. Answers 409 when the document is issued (credit it instead) or locked.
    /// </summary>
    WithRawResponseTask<InvoicesDeleteSalesResponse> InvoicesDeleteAsync(
        InvoicesDeleteSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Issue a draft sale document: assigns the next number (from its document series, else from `series` or the type's default prefix and the year), the issue date (`issueDate`, else the draft's, else today) and a missing due date from the partner's payment term, and for an invoice, credit note or advance invoice posts the journal entry and stores the VAT evidence. `warehouseId` (or the series' warehouse) takes the sold goods of an invoice out of stock with a cost of goods sold entry; `returnToStock` puts them back for a credit note that credits an invoice. A credit note is set against the unpaid balance of the credited document. Emits `sale_invoice.issued`, `sale_invoice.paid` when a credit note settles the credited invoice in full, and `intercompany.invoice_mirrored` when the partner is linked to another company of the group (a draft purchase invoice is created there). Answers 409 when the document is already issued or locked or the accounting period is locked, 422 when the lines carry VAT under a scheme that charges none, when credit notes would exceed the credited total, or when `returnToStock` is used on anything but a credit note of an invoice.
    /// </summary>
    WithRawResponseTask<InvoicesIssueSalesResponse> InvoicesIssueAsync(
        InvoicesIssueSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lock a sale document. A locked document is refused with 409 by `sales/invoices/update`, `sales/invoices/delete`, `sales/invoices/issue` and `sales/invoices/apply-advance` until `sales/invoices/unlock`.
    /// </summary>
    WithRawResponseTask<InvoicesLockSalesResponse> InvoicesLockAsync(
        InvoicesLockSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Unlock a sale document locked with `sales/invoices/lock`.
    /// </summary>
    WithRawResponseTask<InvoicesUnlockSalesResponse> InvoicesUnlockAsync(
        InvoicesUnlockSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return the customer payment link of a sale document, rendered from the company's payment link template (`sales/invoices/payment-settings/update`); `url` is null when the company has no template or the document is not issued. The document's payment token is created on first use. Answers 409 when the document is already paid.
    /// </summary>
    WithRawResponseTask<InvoicesPaymentLinkSalesResponse> InvoicesPaymentLinkAsync(
        InvoicesPaymentLinkSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return the company's payment link template, the https URL that `sales/invoices/payment-link`, the invoice PDF and the invoice e-mail fill in for an issued, unpaid document.
    /// </summary>
    WithRawResponseTask<InvoicesPaymentSettingsGetSalesResponse> InvoicesPaymentSettingsGetAsync(
        InvoicesPaymentSettingsGetSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Set or clear (null) the company's payment link template: an https URL in which `{{number}}`, `{{amount}}` (the unpaid balance), `{{currency}}`, `{{token}}`, `{{invoiceId}}` and `{{partnerName}}` are replaced, URL-encoded, when a link is rendered.
    /// </summary>
    WithRawResponseTask<InvoicesPaymentSettingsUpdateSalesResponse> InvoicesPaymentSettingsUpdateAsync(
        InvoicesPaymentSettingsUpdateSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the revenue recognition schedules: the tranches of deferred income of issued invoices whose lines are recognised ratably, by milestone or by percent complete, each with its status and the journal transaction that recognised it. Filterable by invoiceId, invoiceLineId, status, method and scheduleDate; sortable by scheduleDate and createdAt.
    /// </summary>
    WithRawResponseTask<RecognitionSchedulesListSalesResponse> RecognitionSchedulesListAsync(
        RecognitionSchedulesListSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Apply a fully paid advance invoice to an issued invoice of the same partner: posts the settlement journal entry dated `date` (default today), with the applied amount's share of the advance VAT, and records the amount as a payment of the invoice. `amount` defaults to the smaller of the unapplied advance and the invoice's unpaid balance. Emits `sale_invoice.paid` when the invoice becomes fully paid. Answers 409 when the advance is not fully paid, is already applied or credited, when the invoice has nothing left to pay, or when `amount` exceeds the unapplied advance or the unpaid balance; 422 when the advance is not in the company's base currency or the two documents differ in currency.
    /// </summary>
    WithRawResponseTask<InvoicesApplyAdvanceSalesResponse> InvoicesApplyAdvanceAsync(
        InvoicesApplyAdvanceSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the sale documents of the company with the partner name. Filterable by partnerId, type, status, paymentStatus, fullNumber, issueDate, currency, agreementId, creditedInvoiceId, operationTypeId, documentSeriesId, lockedAt, grossTotal, netTotal, vatTotal, dueDate, orderNumber, seriesLabel, locale and recurringInvoiceId; sortable by createdAt, issueDate, fullNumber, grossTotal, netTotal, vatTotal, status and paymentStatus.
    /// </summary>
    WithRawResponseTask<InvoicesListSalesResponse> InvoicesListAsync(
        InvoicesListSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a draft delivery act of goods or services (`type`) for a partner, dated `documentDate` (default today). Lines come from `lines`, else from the sale invoice in `saleInvoiceId`, else the act has none; the number is assigned by `sales/acts/issue`. Answers 422 when the sale invoice belongs to another partner or, when its lines are copied, has none.
    /// </summary>
    WithRawResponseTask<ActsCreateSalesResponse> ActsCreateAsync(
        ActsCreateSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change a draft delivery act; fields left out keep their value and `lines` replaces every line. Answers 409 when the act is issued or cancelled, 422 when the linked sale invoice belongs to another partner.
    /// </summary>
    WithRawResponseTask<ActsUpdateSalesResponse> ActsUpdateAsync(
        ActsUpdateSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Issue a draft delivery act: assigns the next number of its series for the year of the document date. When the act is linked to a sale invoice with pending milestone recognition schedules, they are all recognised on the act's document date, which posts the recognition journal entry and emits `revenue_recognition.posted`. Answers 409 when the act is not a draft, 422 when it has no lines.
    /// </summary>
    WithRawResponseTask<ActsIssueSalesResponse> ActsIssueAsync(
        ActsIssueSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancel a draft or issued delivery act. Answers 409 when it is already cancelled.
    /// </summary>
    WithRawResponseTask<ActsCancelSalesResponse> ActsCancelAsync(
        ActsCancelSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return one delivery act with its lines.
    /// </summary>
    WithRawResponseTask<ActsGetSalesResponse> ActsGetAsync(
        ActsGetSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List delivery acts. Filterable by status, type, partnerId and documentDate; sortable by createdAt, documentDate and fullNumber.
    /// </summary>
    WithRawResponseTask<ActsListSalesResponse> ActsListAsync(
        ActsListSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Render a delivery act as a PDF in `locale`, returned base64-encoded, with the number of the linked sale invoice when there is one.
    /// </summary>
    WithRawResponseTask<ActsPdfSalesResponse> ActsPdfAsync(
        ActsPdfSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a named template for invoices or credit notes (`documentType`): the header defaults and the lines that `sales/recurring-invoices/generate` turns into invoices. Answers 422 when a referenced partner, agreement, operation type, document series, catalog item or project does not exist or the series is for another document type; 409 when a template with that name exists.
    /// </summary>
    WithRawResponseTask<InvoiceTemplatesCreateSalesResponse> InvoiceTemplatesCreateAsync(
        InvoiceTemplatesCreateSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change a template; fields left out keep their value and `lines` replaces every line. The 422 reference checks of `sales/invoice-templates/create` apply; 409 when the new name is taken.
    /// </summary>
    WithRawResponseTask<InvoiceTemplatesUpdateSalesResponse> InvoiceTemplatesUpdateAsync(
        InvoiceTemplatesUpdateSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return one invoice template.
    /// </summary>
    WithRawResponseTask<InvoiceTemplatesGetSalesResponse> InvoiceTemplatesGetAsync(
        InvoiceTemplatesGetSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete an invoice template.
    /// </summary>
    WithRawResponseTask<InvoiceTemplatesDeleteSalesResponse> InvoiceTemplatesDeleteAsync(
        InvoiceTemplatesDeleteSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List invoice templates. Filterable by name, documentType and partnerId; sortable by name, documentType and createdAt.
    /// </summary>
    WithRawResponseTask<InvoiceTemplatesListSalesResponse> InvoiceTemplatesListAsync(
        InvoiceTemplatesListSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a schedule that generates invoices from an invoice template every `interval` periods of `frequency` from `startDate` (the first run) until `endDate`, for `partnerId` or else the template's partner. `autoIssue` issues each generated invoice and `autoSend` e-mails it to `sendTo`, else to the partner. Invoices are generated by `sales/recurring-invoices/run`, `sales/recurring-invoices/generate` and the scheduled job `recurring-invoices`. Answers 422 when the template is a credit note template, when neither the schedule nor the template names a partner, when `endDate` is before `startDate`, or when `autoSend` is set without `autoIssue`.
    /// </summary>
    WithRawResponseTask<RecurringInvoicesCreateSalesResponse> RecurringInvoicesCreateAsync(
        RecurringInvoicesCreateSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change a schedule; fields left out keep their value. A change of `startDate`, `frequency` or `interval` moves `nextRunDate` to the first occurrence of the new grid on or after the current next run (or the new start date, if later); an explicit `nextRunDate` wins. `status` switches between `active` and `paused`; a next run past `endDate` makes the schedule `finished`. The 422 checks of `sales/recurring-invoices/create` apply.
    /// </summary>
    WithRawResponseTask<RecurringInvoicesUpdateSalesResponse> RecurringInvoicesUpdateAsync(
        RecurringInvoicesUpdateSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return one recurring invoice schedule with the names of its template and partner.
    /// </summary>
    WithRawResponseTask<RecurringInvoicesGetSalesResponse> RecurringInvoicesGetAsync(
        RecurringInvoicesGetSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a recurring invoice schedule. The invoices it generated stay.
    /// </summary>
    WithRawResponseTask<RecurringInvoicesDeleteSalesResponse> RecurringInvoicesDeleteAsync(
        RecurringInvoicesDeleteSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate the next invoice of a schedule now, dated its `nextRunDate`: creates a draft from the template (due date from the template's payment term, VAT scheme from the template or else resolved for the partner and supply type), issues it when `autoIssue` is set and e-mails it when `autoSend` is set, then moves the schedule to its next occurrence (or to `finished` after the last one) and emits `recurring_invoice.generated`. A failure to issue or send comes back in `error` and is stored as `lastError`; the draft stays. Answers 409 when the schedule is finished, 422 when the template is a credit note template or has no lines.
    /// </summary>
    WithRawResponseTask<RecurringInvoicesGenerateSalesResponse> RecurringInvoicesGenerateAsync(
        RecurringInvoicesGenerateSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate every invoice due up to `asOfDate` (default today) from the active schedules of the company, catching up to 60 missed occurrences per schedule, as `sales/recurring-invoices/generate` does for one; each generated invoice emits `recurring_invoice.generated`. The answer lists what was generated and the schedules that failed; a failure is also stored as the schedule's `lastError`.
    /// </summary>
    WithRawResponseTask<RecurringInvoicesRunSalesResponse> RecurringInvoicesRunAsync(
        RecurringInvoicesRunSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List recurring invoice schedules with the names of their template and partner. Filterable by status, partnerId, templateId, frequency, nextRunDate and autoIssue; sortable by nextRunDate, startDate, status, frequency and createdAt.
    /// </summary>
    WithRawResponseTask<RecurringInvoicesListSalesResponse> RecurringInvoicesListAsync(
        RecurringInvoicesListSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Preview the pending ratable revenue schedules due on or before `asOfDate` (default the company's current date) with their total; nothing is posted. `sales/recognition/run` posts them.
    /// </summary>
    WithRawResponseTask<RecognitionComputeSalesResponse> RecognitionComputeAsync(
        RecognitionComputeSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Recognise deferred revenue: posts one journal entry dated `postingDate` (default `asOfDate`, default the company's current date) that debits the deferred income account and credits each line's revenue account, for the pending ratable schedules due on or before `asOfDate` or for exactly the `scheduleIds` given, marks them recognised, records a run with trigger `manual` and emits `revenue_recognition.posted`. Answers 422 when nothing is due or a given schedule is missing or no longer pending, and 409 when the posting period is locked. Due ratable schedules are also posted by the scheduler once their date has passed (trigger `schedule_due`).
    /// </summary>
    WithRawResponseTask<RecognitionRunSalesResponse> RecognitionRunAsync(
        RecognitionRunSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Report the percentage of completion of a `percent_complete` invoice line and recognise the revenue up to it: a schedule for the difference between the revenue due at that percentage and the amount already recognised is created and posted at once, dated `date` (default the company's current date), as a run with trigger `progress` that emits `revenue_recognition.posted`. Refused with 422 when the line is not `percent_complete`, the invoice is not an issued standard invoice, the percentage is 0 or above 100, or nothing new is to be recognised; 409 when the period is locked.
    /// </summary>
    WithRawResponseTask<RecognitionProgressSalesResponse> RecognitionProgressAsync(
        RecognitionProgressSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Apply an IFRS 15 contract modification to a deferred invoice line. Prospective: cancel the pending schedule and respread the unrecognized remainder over the new terms. Cumulative catch-up (ratable only): recompute revenue as if the new terms applied from the start and post the difference immediately.
    /// </summary>
    WithRawResponseTask<RecognitionModifySalesResponse> RecognitionModifyAsync(
        RecognitionModifySalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the revenue recognition runs, newest first; filterable by `runDate` and `trigger`, sortable by `runDate` and `createdAt`.
    /// </summary>
    WithRawResponseTask<RecognitionRunsListSalesResponse> RecognitionRunsListAsync(
        RecognitionRunsListSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deferred revenue per line of the issued standard invoices whose recognition method is not `point_in_time`: the deferred total, the amount recognised so far, the remainder, the number of pending schedules and the next schedule date, with totals; `invoiceId` limits it to one invoice. For a `percent_complete` line the deferred total is the line's base amount, for the other methods the sum of its schedules.
    /// </summary>
    WithRawResponseTask<RecognitionSummarySalesResponse> RecognitionSummaryAsync(
        RecognitionSummarySalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the refund liabilities of issued invoices (created at issue from the lines' `refundEstimatePercent` or by `sales/refund-liability/true-up`): the estimate, the part consumed by credit notes, the settlement refunds and the remaining amount (estimate less consumed), with the invoice number. Filterable by invoiceId; sortable by createdAt and updatedAt.
    /// </summary>
    WithRawResponseTask<RefundLiabilityListSalesResponse> RefundLiabilityListAsync(
        RefundLiabilityListSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Re-estimate the refund liability of an issued standard invoice to `estimatedTotal` and post the difference on `date` (default today) between the refund liability account and the invoice's revenue accounts, in proportion to the lines' allocated or net amounts; creates the liability when the invoice has none. Emits `refund_liability.trued_up`. Answers 422 when the invoice is not an issued standard invoice, when the estimate is below the amount already consumed or unchanged, or when the invoice has no revenue to allocate against; 409 when the accounting period is locked.
    /// </summary>
    WithRawResponseTask<RefundLiabilityTrueUpSalesResponse> RefundLiabilityTrueUpAsync(
        RefundLiabilityTrueUpSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
