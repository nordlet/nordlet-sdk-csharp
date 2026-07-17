namespace NordletApi;

public partial interface ITransportClient
{
    WithRawResponseTask<PostV1TransportWaybillsCreateResponse> PostV1TransportWaybillsCreateAsync(
        PostV1TransportWaybillsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1TransportWaybillsUpdateResponse> PostV1TransportWaybillsUpdateAsync(
        PostV1TransportWaybillsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1TransportWaybillsIssueResponse> PostV1TransportWaybillsIssueAsync(
        PostV1TransportWaybillsIssueRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1TransportWaybillsCancelResponse> PostV1TransportWaybillsCancelAsync(
        PostV1TransportWaybillsCancelRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1TransportWaybillsGetResponse> PostV1TransportWaybillsGetAsync(
        PostV1TransportWaybillsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1TransportWaybillsListResponse> PostV1TransportWaybillsListAsync(
        PostV1TransportWaybillsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
