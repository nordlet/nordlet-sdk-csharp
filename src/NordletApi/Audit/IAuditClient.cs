namespace NordletApi;

public partial interface IAuditClient
{
    /// <summary>
    /// List the audit log of the company: who did what to which entity, with the recorded change in `diff`. Filterable by `action`, `entity`, `entityId`, `actorType` and `actorId`; sortable by `createdAt`, `id`, `actor` (the actor type, then the start of the actor id), `action`, `entity` (the entity, then the start of the entity id) and `diff` (the recorded change as text), newest first by default.
    /// </summary>
    WithRawResponseTask<ListAuditResponse> ListAsync(
        ListAuditRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
