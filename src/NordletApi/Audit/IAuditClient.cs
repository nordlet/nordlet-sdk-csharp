namespace NordletApi;

public partial interface IAuditClient
{
    WithRawResponseTask<PostV1AuditListResponse> PostV1AuditListAsync(
        PostV1AuditListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
