namespace NordletApi;

public partial interface IFilesClient
{
    WithRawResponseTask<PostV1FilesUploadResponse> PostV1FilesUploadAsync(
        PostV1FilesUploadRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1FilesGetResponse> PostV1FilesGetAsync(
        PostV1FilesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1FilesListResponse> PostV1FilesListAsync(
        PostV1FilesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1FilesDeleteResponse> PostV1FilesDeleteAsync(
        PostV1FilesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
