namespace NordletApi;

public partial interface IEcommerceClient
{
    WithRawResponseTask<PostV1EcommerceOrdersCreateResponse> PostV1EcommerceOrdersCreateAsync(
        PostV1EcommerceOrdersCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1EcommerceOrdersGetResponse> PostV1EcommerceOrdersGetAsync(
        PostV1EcommerceOrdersGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1EcommerceOrdersListResponse> PostV1EcommerceOrdersListAsync(
        PostV1EcommerceOrdersListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1EcommerceOrdersReserveResponse> PostV1EcommerceOrdersReserveAsync(
        PostV1EcommerceOrdersReserveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1EcommerceOrdersFulfillResponse> PostV1EcommerceOrdersFulfillAsync(
        PostV1EcommerceOrdersFulfillRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1EcommerceOrdersCancelResponse> PostV1EcommerceOrdersCancelAsync(
        PostV1EcommerceOrdersCancelRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1EcommerceProductsListResponse> PostV1EcommerceProductsListAsync(
        PostV1EcommerceProductsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1EcommerceStockListResponse> PostV1EcommerceStockListAsync(
        PostV1EcommerceStockListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
