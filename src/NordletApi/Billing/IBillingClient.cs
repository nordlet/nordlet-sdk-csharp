namespace NordletApi;

public partial interface IBillingClient
{
    WithRawResponseTask<PostV1BillingAccountGetResponse> PostV1BillingAccountGetAsync(
        PostV1BillingAccountGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BillingAccountSetPlanResponse> PostV1BillingAccountSetPlanAsync(
        PostV1BillingAccountSetPlanRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BillingTopupCreateResponse> PostV1BillingTopupCreateAsync(
        PostV1BillingTopupCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BillingPortalCreateResponse> PostV1BillingPortalCreateAsync(
        PostV1BillingPortalCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BillingTransactionsListResponse> PostV1BillingTransactionsListAsync(
        PostV1BillingTransactionsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BillingUsageListResponse> PostV1BillingUsageListAsync(
        PostV1BillingUsageListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
