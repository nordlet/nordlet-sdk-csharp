namespace NordletApi;

public partial interface IFleetClient
{
    WithRawResponseTask<VehiclesCreateFleetResponse> VehiclesCreateAsync(
        VehiclesCreateFleetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<VehiclesUpdateFleetResponse> VehiclesUpdateAsync(
        VehiclesUpdateFleetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<VehiclesGetFleetResponse> VehiclesGetAsync(
        VehiclesGetFleetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<VehiclesListFleetResponse> VehiclesListAsync(
        VehiclesListFleetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AssignmentsCreateFleetResponse> AssignmentsCreateAsync(
        AssignmentsCreateFleetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AssignmentsEndFleetResponse> AssignmentsEndAsync(
        AssignmentsEndFleetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AssignmentsListFleetResponse> AssignmentsListAsync(
        AssignmentsListFleetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<NaturaPreviewFleetResponse> NaturaPreviewAsync(
        NaturaPreviewFleetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
