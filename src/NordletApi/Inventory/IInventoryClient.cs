namespace NordletApi;

public partial interface IInventoryClient
{
    WithRawResponseTask<PostV1InventorySettingsGetResponse> PostV1InventorySettingsGetAsync(
        PostV1InventorySettingsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventorySettingsUpdateResponse> PostV1InventorySettingsUpdateAsync(
        PostV1InventorySettingsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryWarehousesCreateResponse> PostV1InventoryWarehousesCreateAsync(
        PostV1InventoryWarehousesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryWarehousesListResponse> PostV1InventoryWarehousesListAsync(
        PostV1InventoryWarehousesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryStockReceiveResponse> PostV1InventoryStockReceiveAsync(
        PostV1InventoryStockReceiveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryStockWriteOffResponse> PostV1InventoryStockWriteOffAsync(
        PostV1InventoryStockWriteOffRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryStockTransferResponse> PostV1InventoryStockTransferAsync(
        PostV1InventoryStockTransferRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryStockTakeResponse> PostV1InventoryStockTakeAsync(
        PostV1InventoryStockTakeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryStockLevelsResponse> PostV1InventoryStockLevelsAsync(
        PostV1InventoryStockLevelsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryStockMovementsListResponse> PostV1InventoryStockMovementsListAsync(
        PostV1InventoryStockMovementsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryLotsListResponse> PostV1InventoryLotsListAsync(
        PostV1InventoryLotsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryLotsGetResponse> PostV1InventoryLotsGetAsync(
        PostV1InventoryLotsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryLotsUpdateResponse> PostV1InventoryLotsUpdateAsync(
        PostV1InventoryLotsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryLandedCostsCreateResponse> PostV1InventoryLandedCostsCreateAsync(
        PostV1InventoryLandedCostsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryLandedCostsGetResponse> PostV1InventoryLandedCostsGetAsync(
        PostV1InventoryLandedCostsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryLandedCostsListResponse> PostV1InventoryLandedCostsListAsync(
        PostV1InventoryLandedCostsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryReorderRulesCreateResponse> PostV1InventoryReorderRulesCreateAsync(
        PostV1InventoryReorderRulesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryReorderRulesUpdateResponse> PostV1InventoryReorderRulesUpdateAsync(
        PostV1InventoryReorderRulesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryReorderRulesDeleteResponse> PostV1InventoryReorderRulesDeleteAsync(
        PostV1InventoryReorderRulesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryReorderRulesListResponse> PostV1InventoryReorderRulesListAsync(
        PostV1InventoryReorderRulesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1InventoryReorderRulesCheckResponse> PostV1InventoryReorderRulesCheckAsync(
        PostV1InventoryReorderRulesCheckRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
