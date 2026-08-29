namespace NordletApi;

public partial interface IProductionClient
{
    WithRawResponseTask<PostV1ProductionWorkCentersCreateResponse> PostV1ProductionWorkCentersCreateAsync(
        PostV1ProductionWorkCentersCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionWorkCentersUpdateResponse> PostV1ProductionWorkCentersUpdateAsync(
        PostV1ProductionWorkCentersUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionWorkCentersListResponse> PostV1ProductionWorkCentersListAsync(
        PostV1ProductionWorkCentersListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionRoutingsCreateResponse> PostV1ProductionRoutingsCreateAsync(
        PostV1ProductionRoutingsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionRoutingsGetResponse> PostV1ProductionRoutingsGetAsync(
        PostV1ProductionRoutingsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionRoutingsListResponse> PostV1ProductionRoutingsListAsync(
        PostV1ProductionRoutingsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionMaintenanceCreateResponse> PostV1ProductionMaintenanceCreateAsync(
        PostV1ProductionMaintenanceCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionMaintenanceCompleteResponse> PostV1ProductionMaintenanceCompleteAsync(
        PostV1ProductionMaintenanceCompleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionMaintenanceCancelResponse> PostV1ProductionMaintenanceCancelAsync(
        PostV1ProductionMaintenanceCancelRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionMaintenanceListResponse> PostV1ProductionMaintenanceListAsync(
        PostV1ProductionMaintenanceListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

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

    WithRawResponseTask<PostV1ProductionOrdersRecordOperationResponse> PostV1ProductionOrdersRecordOperationAsync(
        PostV1ProductionOrdersRecordOperationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionQualityChecksAddResponse> PostV1ProductionQualityChecksAddAsync(
        PostV1ProductionQualityChecksAddRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionQualityChecksRecordResponse> PostV1ProductionQualityChecksRecordAsync(
        PostV1ProductionQualityChecksRecordRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProductionQualityChecksListResponse> PostV1ProductionQualityChecksListAsync(
        PostV1ProductionQualityChecksListRequest request,
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
