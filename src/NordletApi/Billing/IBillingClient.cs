namespace NordletApi;

public partial interface IBillingClient
{
    WithRawResponseTask<AccountGetBillingResponse> AccountGetAsync(
        AccountGetBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AccountSetPlanBillingResponse> AccountSetPlanAsync(
        AccountSetPlanBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TopupCreateBillingResponse> TopupCreateAsync(
        TopupCreateBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PortalCreateBillingResponse> PortalCreateAsync(
        PortalCreateBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TransactionsListBillingResponse> TransactionsListAsync(
        TransactionsListBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<UsageListBillingResponse> UsageListAsync(
        UsageListBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
