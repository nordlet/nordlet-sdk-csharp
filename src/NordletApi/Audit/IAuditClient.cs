namespace NordletApi;

public partial interface IAuditClient
{
    /// <summary>
    /// List the audit log of the company: who did what to which entity, with the recorded change in `diff`. Filterable by `action`, `entity`, `entityId`, `actorType` and `actorId`; sortable by `createdAt` and `id`, newest first by default.
    /// </summary>
    WithRawResponseTask<ListAuditResponse> ListAsync(
        ListAuditRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
