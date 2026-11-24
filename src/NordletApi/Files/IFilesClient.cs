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
    /// Create a link that takes one file of up to 10 MB as the raw request body, so the file does not have to be sent base64-encoded: `POST` the bytes to `url` with any `Content-Type`; no API key is needed, the link is the permission. The link works once and until `expiresAt` (`expiresInMinutes`, 60 by default, at most 1440). The file is stored under `entity`, `entityId`, `fileName` and `mimeType` (else the media type of the upload request) with the id `fileId` and the `storageKey` given here, which other calls take as `documentRef` once the file is uploaded; `files/get` with `fileId` answers 404 until then. The upload answers 404 for an unknown or expired link and 409 for a link already used.
    /// </summary>
    WithRawResponseTask<UploadLinksCreateFilesResponse> UploadLinksCreateAsync(
        UploadLinksCreateFilesRequest request,
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
    /// List the company's files. Filterable by `entity`, `entityId` and `fileName`; sortable by `createdAt`, `fileName`, `sizeBytes`, `entity`, `entityId` and `mimeType`.
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
