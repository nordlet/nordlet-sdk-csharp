namespace NordletApi;

public partial interface IFilesClient
{
    WithRawResponseTask<UploadFilesResponse> UploadAsync(
        UploadFilesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GetFilesResponse> GetAsync(
        GetFilesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ListFilesResponse> ListAsync(
        ListFilesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DeleteFilesResponse> DeleteAsync(
        DeleteFilesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
