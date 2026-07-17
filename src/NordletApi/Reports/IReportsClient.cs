namespace NordletApi;

public partial interface IReportsClient
{
    WithRawResponseTask<PostV1ReportsTrialBalanceResponse> PostV1ReportsTrialBalanceAsync(
        PostV1ReportsTrialBalanceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsSizeCategoryResponse> PostV1ReportsSizeCategoryAsync(
        PostV1ReportsSizeCategoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsFinancialStatementsResponse> PostV1ReportsFinancialStatementsAsync(
        PostV1ReportsFinancialStatementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsGeneralJournalResponse> PostV1ReportsGeneralJournalAsync(
        PostV1ReportsGeneralJournalRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsGlDetailResponse> PostV1ReportsGlDetailAsync(
        PostV1ReportsGlDetailRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsPartnerBalancesResponse> PostV1ReportsPartnerBalancesAsync(
        PostV1ReportsPartnerBalancesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsDebtAgingResponse> PostV1ReportsDebtAgingAsync(
        PostV1ReportsDebtAgingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsMonthlySummaryResponse> PostV1ReportsMonthlySummaryAsync(
        PostV1ReportsMonthlySummaryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsStockBalanceResponse> PostV1ReportsStockBalanceAsync(
        PostV1ReportsStockBalanceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsStockMovementResponse> PostV1ReportsStockMovementAsync(
        PostV1ReportsStockMovementRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsVatSummaryResponse> PostV1ReportsVatSummaryAsync(
        PostV1ReportsVatSummaryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsCashFlowResponse> PostV1ReportsCashFlowAsync(
        PostV1ReportsCashFlowRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsStockAgingResponse> PostV1ReportsStockAgingAsync(
        PostV1ReportsStockAgingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsStockShortageResponse> PostV1ReportsStockShortageAsync(
        PostV1ReportsStockShortageRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsEuPurchasesResponse> PostV1ReportsEuPurchasesAsync(
        PostV1ReportsEuPurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsVatDetailResponse> PostV1ReportsVatDetailAsync(
        PostV1ReportsVatDetailRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsPosSalesResponse> PostV1ReportsPosSalesAsync(
        PostV1ReportsPosSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsOnlineSalesResponse> PostV1ReportsOnlineSalesAsync(
        PostV1ReportsOnlineSalesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsOssResponse> PostV1ReportsOssAsync(
        PostV1ReportsOssRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsAdvanceReconciliationResponse> PostV1ReportsAdvanceReconciliationAsync(
        PostV1ReportsAdvanceReconciliationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsWriteOffActsResponse> PostV1ReportsWriteOffActsAsync(
        PostV1ReportsWriteOffActsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsCostCentersResponse> PostV1ReportsCostCentersAsync(
        PostV1ReportsCostCentersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsCostCenterActivityResponse> PostV1ReportsCostCenterActivityAsync(
        PostV1ReportsCostCenterActivityRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsCostCenterItemsResponse> PostV1ReportsCostCenterItemsAsync(
        PostV1ReportsCostCenterItemsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsJobsCreateResponse> PostV1ReportsJobsCreateAsync(
        PostV1ReportsJobsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsJobsGetResponse> PostV1ReportsJobsGetAsync(
        PostV1ReportsJobsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReportsJobsListResponse> PostV1ReportsJobsListAsync(
        PostV1ReportsJobsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
