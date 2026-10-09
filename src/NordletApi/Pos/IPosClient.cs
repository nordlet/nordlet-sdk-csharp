namespace NordletApi;

public partial interface IPosClient
{
    WithRawResponseTask<DevicesCreatePosResponse> DevicesCreateAsync(
        DevicesCreatePosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DevicesUpdatePosResponse> DevicesUpdateAsync(
        DevicesUpdatePosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DevicesListPosResponse> DevicesListAsync(
        DevicesListPosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReportsCreatePosResponse> ReportsCreateAsync(
        ReportsCreatePosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReportsGetPosResponse> ReportsGetAsync(
        ReportsGetPosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReportsListPosResponse> ReportsListAsync(
        ReportsListPosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ShiftsOpenPosResponse> ShiftsOpenAsync(
        ShiftsOpenPosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ShiftsGetPosResponse> ShiftsGetAsync(
        ShiftsGetPosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ShiftsListPosResponse> ShiftsListAsync(
        ShiftsListPosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReceiptsCreatePosResponse> ReceiptsCreateAsync(
        ReceiptsCreatePosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReceiptsListPosResponse> ReceiptsListAsync(
        ReceiptsListPosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReceiptsGetPosResponse> ReceiptsGetAsync(
        ReceiptsGetPosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ShiftsClosePosResponse> ShiftsCloseAsync(
        ShiftsClosePosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
