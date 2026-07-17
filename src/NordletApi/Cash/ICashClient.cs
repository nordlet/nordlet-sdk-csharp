namespace NordletApi;

public partial interface ICashClient
{
    WithRawResponseTask<PostV1CashOrdersCreateResponse> PostV1CashOrdersCreateAsync(
        PostV1CashOrdersCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CashOrdersGetResponse> PostV1CashOrdersGetAsync(
        PostV1CashOrdersGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CashOrdersListResponse> PostV1CashOrdersListAsync(
        PostV1CashOrdersListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CashBalanceResponse> PostV1CashBalanceAsync(
        PostV1CashBalanceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CashAdvanceHoldersBalancesResponse> PostV1CashAdvanceHoldersBalancesAsync(
        PostV1CashAdvanceHoldersBalancesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
