namespace NordletApi;

public partial interface IInventoryClient
{
    WithRawResponseTask<SettingsGetInventoryResponse> SettingsGetAsync(
        SettingsGetInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SettingsUpdateInventoryResponse> SettingsUpdateAsync(
        SettingsUpdateInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<WarehousesCreateInventoryResponse> WarehousesCreateAsync(
        WarehousesCreateInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<WarehousesListInventoryResponse> WarehousesListAsync(
        WarehousesListInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<WarehousesUpdateInventoryResponse> WarehousesUpdateAsync(
        WarehousesUpdateInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StockReceiveInventoryResponse> StockReceiveAsync(
        StockReceiveInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StockWriteOffInventoryResponse> StockWriteOffAsync(
        StockWriteOffInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StockTransferInventoryResponse> StockTransferAsync(
        StockTransferInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StockTakeInventoryResponse> StockTakeAsync(
        StockTakeInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StockLevelsInventoryResponse> StockLevelsAsync(
        StockLevelsInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StockMovementsListInventoryResponse> StockMovementsListAsync(
        StockMovementsListInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<LotsListInventoryResponse> LotsListAsync(
        LotsListInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<LotsGetInventoryResponse> LotsGetAsync(
        LotsGetInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<LotsUpdateInventoryResponse> LotsUpdateAsync(
        LotsUpdateInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<LandedCostsCreateInventoryResponse> LandedCostsCreateAsync(
        LandedCostsCreateInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<LandedCostsGetInventoryResponse> LandedCostsGetAsync(
        LandedCostsGetInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<LandedCostsListInventoryResponse> LandedCostsListAsync(
        LandedCostsListInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReorderRulesCreateInventoryResponse> ReorderRulesCreateAsync(
        ReorderRulesCreateInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReorderRulesUpdateInventoryResponse> ReorderRulesUpdateAsync(
        ReorderRulesUpdateInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReorderRulesDeleteInventoryResponse> ReorderRulesDeleteAsync(
        ReorderRulesDeleteInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReorderRulesListInventoryResponse> ReorderRulesListAsync(
        ReorderRulesListInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReorderRulesCheckInventoryResponse> ReorderRulesCheckAsync(
        ReorderRulesCheckInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
