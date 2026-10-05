namespace NordletApi;

public partial interface IProductionClient
{
    WithRawResponseTask<WorkCentersCreateProductionResponse> WorkCentersCreateAsync(
        WorkCentersCreateProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<WorkCentersUpdateProductionResponse> WorkCentersUpdateAsync(
        WorkCentersUpdateProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<WorkCentersListProductionResponse> WorkCentersListAsync(
        WorkCentersListProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<RoutingsCreateProductionResponse> RoutingsCreateAsync(
        RoutingsCreateProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<RoutingsGetProductionResponse> RoutingsGetAsync(
        RoutingsGetProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<RoutingsListProductionResponse> RoutingsListAsync(
        RoutingsListProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MaintenanceCreateProductionResponse> MaintenanceCreateAsync(
        MaintenanceCreateProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MaintenanceCompleteProductionResponse> MaintenanceCompleteAsync(
        MaintenanceCompleteProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MaintenanceCancelProductionResponse> MaintenanceCancelAsync(
        MaintenanceCancelProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MaintenanceListProductionResponse> MaintenanceListAsync(
        MaintenanceListProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<BomsCreateProductionResponse> BomsCreateAsync(
        BomsCreateProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<BomsGetProductionResponse> BomsGetAsync(
        BomsGetProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<BomsListProductionResponse> BomsListAsync(
        BomsListProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersCreateProductionResponse> OrdersCreateAsync(
        OrdersCreateProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersRecordOperationProductionResponse> OrdersRecordOperationAsync(
        OrdersRecordOperationProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<QualityChecksAddProductionResponse> QualityChecksAddAsync(
        QualityChecksAddProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<QualityChecksRecordProductionResponse> QualityChecksRecordAsync(
        QualityChecksRecordProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<QualityChecksListProductionResponse> QualityChecksListAsync(
        QualityChecksListProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersCompleteProductionResponse> OrdersCompleteAsync(
        OrdersCompleteProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersGetProductionResponse> OrdersGetAsync(
        OrdersGetProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersListProductionResponse> OrdersListAsync(
        OrdersListProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
