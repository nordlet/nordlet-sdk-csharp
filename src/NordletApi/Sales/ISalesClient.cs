namespace NordletApi;

public partial interface ISalesClient
{
    WithRawResponseTask<PostV1SalesInvoicesCreateResponse> PostV1SalesInvoicesCreateAsync(
        PostV1SalesInvoicesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesInvoicesGetResponse> PostV1SalesInvoicesGetAsync(
        PostV1SalesInvoicesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesInvoicesPdfResponse> PostV1SalesInvoicesPdfAsync(
        PostV1SalesInvoicesPdfRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesInvoicesSendResponse> PostV1SalesInvoicesSendAsync(
        PostV1SalesInvoicesSendRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesInvoicesPeppolXmlResponse> PostV1SalesInvoicesPeppolXmlAsync(
        PostV1SalesInvoicesPeppolXmlRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesInvoicesPeppolSendResponse> PostV1SalesInvoicesPeppolSendAsync(
        PostV1SalesInvoicesPeppolSendRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Render an issued invoice as the national e-invoicing payload for the company country: FatturaPA (IT), KSeF FA(3) (PL) or UBL CIUS-RO (RO). Review the warnings - data the invoice does not carry is flagged, never invented.
    /// </summary>
    WithRawResponseTask<PostV1SalesInvoicesEinvoiceXmlResponse> PostV1SalesInvoicesEinvoiceXmlAsync(
        PostV1SalesInvoicesEinvoiceXmlRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the national e-invoicing payload and deliver it over the transport configured for the country gateway in compliance settings. With transport=direct the request talks to the tax authority itself - SdICoop over 2-way TLS for Italy, a KSeF session for Poland, ANAF SPV OAuth for Romania - and returns the national number as soon as the channel assigns one. With transport=bridge the payload goes to the configured bridge endpoint (an accredited intermediary or connector) instead.
    /// </summary>
    WithRawResponseTask<PostV1SalesInvoicesEinvoiceSendResponse> PostV1SalesInvoicesEinvoiceSendAsync(
        PostV1SalesInvoicesEinvoiceSendRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Ask the national e-invoicing channel what happened to an invoice that was already sent, and store the answer. Italy, Poland and Romania return the outcome only on request - none of them calls back - so this is the way the national number and any rejection reason reach the invoice.
    /// </summary>
    WithRawResponseTask<PostV1SalesInvoicesEinvoiceStatusResponse> PostV1SalesInvoicesEinvoiceStatusAsync(
        PostV1SalesInvoicesEinvoiceStatusRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesInvoicesUpdateResponse> PostV1SalesInvoicesUpdateAsync(
        PostV1SalesInvoicesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesInvoicesDeleteResponse> PostV1SalesInvoicesDeleteAsync(
        PostV1SalesInvoicesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesInvoicesIssueResponse> PostV1SalesInvoicesIssueAsync(
        PostV1SalesInvoicesIssueRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesInvoicesLockResponse> PostV1SalesInvoicesLockAsync(
        PostV1SalesInvoicesLockRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesInvoicesUnlockResponse> PostV1SalesInvoicesUnlockAsync(
        PostV1SalesInvoicesUnlockRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesInvoicesPaymentLinkResponse> PostV1SalesInvoicesPaymentLinkAsync(
        PostV1SalesInvoicesPaymentLinkRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesInvoicesPaymentSettingsGetResponse> PostV1SalesInvoicesPaymentSettingsGetAsync(
        PostV1SalesInvoicesPaymentSettingsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesInvoicesPaymentSettingsUpdateResponse> PostV1SalesInvoicesPaymentSettingsUpdateAsync(
        PostV1SalesInvoicesPaymentSettingsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesRecognitionSchedulesListResponse> PostV1SalesRecognitionSchedulesListAsync(
        PostV1SalesRecognitionSchedulesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesInvoicesApplyAdvanceResponse> PostV1SalesInvoicesApplyAdvanceAsync(
        PostV1SalesInvoicesApplyAdvanceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesInvoicesListResponse> PostV1SalesInvoicesListAsync(
        PostV1SalesInvoicesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesActsCreateResponse> PostV1SalesActsCreateAsync(
        PostV1SalesActsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesActsUpdateResponse> PostV1SalesActsUpdateAsync(
        PostV1SalesActsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesActsIssueResponse> PostV1SalesActsIssueAsync(
        PostV1SalesActsIssueRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesActsCancelResponse> PostV1SalesActsCancelAsync(
        PostV1SalesActsCancelRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesActsGetResponse> PostV1SalesActsGetAsync(
        PostV1SalesActsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesActsListResponse> PostV1SalesActsListAsync(
        PostV1SalesActsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesActsPdfResponse> PostV1SalesActsPdfAsync(
        PostV1SalesActsPdfRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1OperationTypesCreateResponse> PostV1OperationTypesCreateAsync(
        PostV1OperationTypesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1OperationTypesUpdateResponse> PostV1OperationTypesUpdateAsync(
        PostV1OperationTypesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1OperationTypesGetResponse> PostV1OperationTypesGetAsync(
        PostV1OperationTypesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1OperationTypesDeleteResponse> PostV1OperationTypesDeleteAsync(
        PostV1OperationTypesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1OperationTypesListResponse> PostV1OperationTypesListAsync(
        PostV1OperationTypesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DocumentSeriesCreateResponse> PostV1DocumentSeriesCreateAsync(
        PostV1DocumentSeriesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DocumentSeriesUpdateResponse> PostV1DocumentSeriesUpdateAsync(
        PostV1DocumentSeriesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DocumentSeriesGetResponse> PostV1DocumentSeriesGetAsync(
        PostV1DocumentSeriesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DocumentSeriesDeleteResponse> PostV1DocumentSeriesDeleteAsync(
        PostV1DocumentSeriesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DocumentSeriesListResponse> PostV1DocumentSeriesListAsync(
        PostV1DocumentSeriesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesRecognitionComputeResponse> PostV1SalesRecognitionComputeAsync(
        PostV1SalesRecognitionComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesRecognitionRunResponse> PostV1SalesRecognitionRunAsync(
        PostV1SalesRecognitionRunRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesRecognitionProgressResponse> PostV1SalesRecognitionProgressAsync(
        PostV1SalesRecognitionProgressRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Apply an IFRS 15 contract modification to a deferred invoice line. Prospective: cancel the pending schedule and respread the unrecognized remainder over the new terms. Cumulative catch-up (ratable only): recompute revenue as if the new terms applied from the start and post the difference immediately.
    /// </summary>
    WithRawResponseTask<PostV1SalesRecognitionModifyResponse> PostV1SalesRecognitionModifyAsync(
        PostV1SalesRecognitionModifyRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesRecognitionRunsListResponse> PostV1SalesRecognitionRunsListAsync(
        PostV1SalesRecognitionRunsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesRecognitionSummaryResponse> PostV1SalesRecognitionSummaryAsync(
        PostV1SalesRecognitionSummaryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesRefundLiabilityListResponse> PostV1SalesRefundLiabilityListAsync(
        PostV1SalesRefundLiabilityListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1SalesRefundLiabilityTrueUpResponse> PostV1SalesRefundLiabilityTrueUpAsync(
        PostV1SalesRefundLiabilityTrueUpRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
