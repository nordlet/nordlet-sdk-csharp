namespace NordletApi;

public partial interface IFleetClient
{
    WithRawResponseTask<PostV1FleetVehiclesCreateResponse> PostV1FleetVehiclesCreateAsync(
        PostV1FleetVehiclesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1FleetVehiclesUpdateResponse> PostV1FleetVehiclesUpdateAsync(
        PostV1FleetVehiclesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1FleetVehiclesGetResponse> PostV1FleetVehiclesGetAsync(
        PostV1FleetVehiclesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1FleetVehiclesListResponse> PostV1FleetVehiclesListAsync(
        PostV1FleetVehiclesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1FleetAssignmentsCreateResponse> PostV1FleetAssignmentsCreateAsync(
        PostV1FleetAssignmentsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1FleetAssignmentsEndResponse> PostV1FleetAssignmentsEndAsync(
        PostV1FleetAssignmentsEndRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1FleetAssignmentsListResponse> PostV1FleetAssignmentsListAsync(
        PostV1FleetAssignmentsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1FleetNaturaPreviewResponse> PostV1FleetNaturaPreviewAsync(
        PostV1FleetNaturaPreviewRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
