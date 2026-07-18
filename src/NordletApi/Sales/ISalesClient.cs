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
