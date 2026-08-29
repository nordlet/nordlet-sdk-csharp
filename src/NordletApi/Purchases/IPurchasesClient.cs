namespace NordletApi;

public partial interface IPurchasesClient
{
    WithRawResponseTask<PostV1PurchasesInvoicesCreateResponse> PostV1PurchasesInvoicesCreateAsync(
        PostV1PurchasesInvoicesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesInvoicesGetResponse> PostV1PurchasesInvoicesGetAsync(
        PostV1PurchasesInvoicesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesInvoicesUpdateResponse> PostV1PurchasesInvoicesUpdateAsync(
        PostV1PurchasesInvoicesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesInvoicesDeleteResponse> PostV1PurchasesInvoicesDeleteAsync(
        PostV1PurchasesInvoicesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesInvoicesRegisterResponse> PostV1PurchasesInvoicesRegisterAsync(
        PostV1PurchasesInvoicesRegisterRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesInvoicesListResponse> PostV1PurchasesInvoicesListAsync(
        PostV1PurchasesInvoicesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesOrdersCreateResponse> PostV1PurchasesOrdersCreateAsync(
        PostV1PurchasesOrdersCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesOrdersUpdateResponse> PostV1PurchasesOrdersUpdateAsync(
        PostV1PurchasesOrdersUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesOrdersGetResponse> PostV1PurchasesOrdersGetAsync(
        PostV1PurchasesOrdersGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesOrdersListResponse> PostV1PurchasesOrdersListAsync(
        PostV1PurchasesOrdersListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesOrdersSubmitResponse> PostV1PurchasesOrdersSubmitAsync(
        PostV1PurchasesOrdersSubmitRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesOrdersApproveResponse> PostV1PurchasesOrdersApproveAsync(
        PostV1PurchasesOrdersApproveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesOrdersRejectResponse> PostV1PurchasesOrdersRejectAsync(
        PostV1PurchasesOrdersRejectRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesOrdersCancelResponse> PostV1PurchasesOrdersCancelAsync(
        PostV1PurchasesOrdersCancelRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesOrdersCloseResponse> PostV1PurchasesOrdersCloseAsync(
        PostV1PurchasesOrdersCloseRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesOrdersDeleteResponse> PostV1PurchasesOrdersDeleteAsync(
        PostV1PurchasesOrdersDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesReceiptsCreateResponse> PostV1PurchasesReceiptsCreateAsync(
        PostV1PurchasesReceiptsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesReceiptsGetResponse> PostV1PurchasesReceiptsGetAsync(
        PostV1PurchasesReceiptsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesReceiptsListResponse> PostV1PurchasesReceiptsListAsync(
        PostV1PurchasesReceiptsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PurchasesInvoicesMatchResponse> PostV1PurchasesInvoicesMatchAsync(
        PostV1PurchasesInvoicesMatchRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
