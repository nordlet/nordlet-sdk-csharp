namespace NordletApi;

public partial interface ISalesClient
{
    WithRawResponseTask<InvoicesCreateSalesResponse> InvoicesCreateAsync(
        InvoicesCreateSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesGetSalesResponse> InvoicesGetAsync(
        InvoicesGetSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesPdfSalesResponse> InvoicesPdfAsync(
        InvoicesPdfSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesSendSalesResponse> InvoicesSendAsync(
        InvoicesSendSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesPeppolXmlSalesResponse> InvoicesPeppolXmlAsync(
        InvoicesPeppolXmlSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesPeppolSendSalesResponse> InvoicesPeppolSendAsync(
        InvoicesPeppolSendSalesRequest request,
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

    WithRawResponseTask<InvoicesUpdateSalesResponse> InvoicesUpdateAsync(
        InvoicesUpdateSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesDeleteSalesResponse> InvoicesDeleteAsync(
        InvoicesDeleteSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesIssueSalesResponse> InvoicesIssueAsync(
        InvoicesIssueSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesLockSalesResponse> InvoicesLockAsync(
        InvoicesLockSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesUnlockSalesResponse> InvoicesUnlockAsync(
        InvoicesUnlockSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesPaymentLinkSalesResponse> InvoicesPaymentLinkAsync(
        InvoicesPaymentLinkSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesPaymentSettingsGetSalesResponse> InvoicesPaymentSettingsGetAsync(
        InvoicesPaymentSettingsGetSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesPaymentSettingsUpdateSalesResponse> InvoicesPaymentSettingsUpdateAsync(
        InvoicesPaymentSettingsUpdateSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<RecognitionSchedulesListSalesResponse> RecognitionSchedulesListAsync(
        RecognitionSchedulesListSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesApplyAdvanceSalesResponse> InvoicesApplyAdvanceAsync(
        InvoicesApplyAdvanceSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesListSalesResponse> InvoicesListAsync(
        InvoicesListSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ActsCreateSalesResponse> ActsCreateAsync(
        ActsCreateSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ActsUpdateSalesResponse> ActsUpdateAsync(
        ActsUpdateSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ActsIssueSalesResponse> ActsIssueAsync(
        ActsIssueSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ActsCancelSalesResponse> ActsCancelAsync(
        ActsCancelSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ActsGetSalesResponse> ActsGetAsync(
        ActsGetSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ActsListSalesResponse> ActsListAsync(
        ActsListSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ActsPdfSalesResponse> ActsPdfAsync(
        ActsPdfSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<RecognitionComputeSalesResponse> RecognitionComputeAsync(
        RecognitionComputeSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<RecognitionRunSalesResponse> RecognitionRunAsync(
        RecognitionRunSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

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

    WithRawResponseTask<RecognitionRunsListSalesResponse> RecognitionRunsListAsync(
        RecognitionRunsListSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<RecognitionSummarySalesResponse> RecognitionSummaryAsync(
        RecognitionSummarySalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<RefundLiabilityListSalesResponse> RefundLiabilityListAsync(
        RefundLiabilityListSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<RefundLiabilityTrueUpSalesResponse> RefundLiabilityTrueUpAsync(
        RefundLiabilityTrueUpSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
