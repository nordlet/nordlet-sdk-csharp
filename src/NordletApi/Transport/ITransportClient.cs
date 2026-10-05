namespace NordletApi;

public partial interface ITransportClient
{
    WithRawResponseTask<WaybillsCreateTransportResponse> WaybillsCreateAsync(
        WaybillsCreateTransportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<WaybillsUpdateTransportResponse> WaybillsUpdateAsync(
        WaybillsUpdateTransportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<WaybillsIssueTransportResponse> WaybillsIssueAsync(
        WaybillsIssueTransportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<WaybillsCancelTransportResponse> WaybillsCancelAsync(
        WaybillsCancelTransportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<WaybillsGetTransportResponse> WaybillsGetAsync(
        WaybillsGetTransportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<WaybillsListTransportResponse> WaybillsListAsync(
        WaybillsListTransportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
