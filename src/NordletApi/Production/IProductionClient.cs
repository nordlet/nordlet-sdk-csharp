namespace NordletApi;

public partial interface IProductionClient
{
    WithRawResponseTask<PostV1ProductionBomsCreateResponse> PostV1ProductionBomsCreateAsync(
        PostV1ProductionBomsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionBomsGetResponse> PostV1ProductionBomsGetAsync(
        PostV1ProductionBomsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionBomsListResponse> PostV1ProductionBomsListAsync(
        PostV1ProductionBomsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionOrdersCreateResponse> PostV1ProductionOrdersCreateAsync(
        PostV1ProductionOrdersCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionOrdersCompleteResponse> PostV1ProductionOrdersCompleteAsync(
        PostV1ProductionOrdersCompleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionOrdersGetResponse> PostV1ProductionOrdersGetAsync(
        PostV1ProductionOrdersGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionOrdersListResponse> PostV1ProductionOrdersListAsync(
        PostV1ProductionOrdersListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
