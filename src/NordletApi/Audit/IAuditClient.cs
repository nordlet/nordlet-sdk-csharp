namespace NordletApi;

public partial interface IAuditClient
{
    WithRawResponseTask<ListAuditResponse> ListAsync(
        ListAuditRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
