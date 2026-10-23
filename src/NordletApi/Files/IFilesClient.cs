namespace NordletApi;

public partial interface IFilesClient
{
    /// <summary>
    /// Store a base64-encoded file of up to 10 MB (413 above that) under an `entity` and optional `entityId`, and return its record with the SHA-256 of the content and its `storageKey`, which other calls take as `documentRef`.
    /// </summary>
    WithRawResponseTask<UploadFilesResponse> UploadAsync(
        UploadFilesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return a file record with its content, base64-encoded.
    /// </summary>
    WithRawResponseTask<GetFilesResponse> GetAsync(
        GetFilesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the company's files. Filterable by `entity`, `entityId` and `fileName`; sortable by `createdAt`, `fileName` and `sizeBytes`.
    /// </summary>
    WithRawResponseTask<ListFilesResponse> ListAsync(
        ListFilesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a file record and its stored content.
    /// </summary>
    WithRawResponseTask<DeleteFilesResponse> DeleteAsync(
        DeleteFilesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
