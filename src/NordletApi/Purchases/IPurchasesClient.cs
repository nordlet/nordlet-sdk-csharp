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
}
