namespace NordletApi;

public partial interface IPosClient
{
    WithRawResponseTask<PostV1PosDevicesCreateResponse> PostV1PosDevicesCreateAsync(
        PostV1PosDevicesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PosDevicesUpdateResponse> PostV1PosDevicesUpdateAsync(
        PostV1PosDevicesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PosDevicesListResponse> PostV1PosDevicesListAsync(
        PostV1PosDevicesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PosReportsCreateResponse> PostV1PosReportsCreateAsync(
        PostV1PosReportsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PosReportsGetResponse> PostV1PosReportsGetAsync(
        PostV1PosReportsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PosReportsListResponse> PostV1PosReportsListAsync(
        PostV1PosReportsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
