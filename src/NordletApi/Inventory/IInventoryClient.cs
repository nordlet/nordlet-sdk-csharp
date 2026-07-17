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
}
