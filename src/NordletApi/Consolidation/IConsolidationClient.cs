namespace NordletApi;

public partial interface IConsolidationClient
{
    WithRawResponseTask<PostV1ConsolidationGroupsCreateResponse> PostV1ConsolidationGroupsCreateAsync(
        PostV1ConsolidationGroupsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ConsolidationGroupsListResponse> PostV1ConsolidationGroupsListAsync(
        PostV1ConsolidationGroupsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ConsolidationGroupsGetResponse> PostV1ConsolidationGroupsGetAsync(
        PostV1ConsolidationGroupsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ConsolidationGroupsUpdateResponse> PostV1ConsolidationGroupsUpdateAsync(
        PostV1ConsolidationGroupsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ConsolidationGroupsDeleteResponse> PostV1ConsolidationGroupsDeleteAsync(
        PostV1ConsolidationGroupsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ConsolidationMembersAddResponse> PostV1ConsolidationMembersAddAsync(
        PostV1ConsolidationMembersAddRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ConsolidationMembersRemoveResponse> PostV1ConsolidationMembersRemoveAsync(
        PostV1ConsolidationMembersRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Partners in member companies that look like other members of the same group (matched on company code or VAT code), with any existing intercompany link. Confirming a candidate via intercompany/links/set enables invoice mirroring.
    /// </summary>
    WithRawResponseTask<PostV1ConsolidationIntercompanyCandidatesResponse> PostV1ConsolidationIntercompanyCandidatesAsync(
        PostV1ConsolidationIntercompanyCandidatesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Confirm that a partner record in one member company represents another member company of the group. Once links exist in both directions, issuing an intercompany sale invoice automatically creates the matching draft purchase invoice in the counterparty.
    /// </summary>
    WithRawResponseTask<PostV1ConsolidationIntercompanyLinksSetResponse> PostV1ConsolidationIntercompanyLinksSetAsync(
        PostV1ConsolidationIntercompanyLinksSetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ConsolidationIntercompanyLinksListResponse> PostV1ConsolidationIntercompanyLinksListAsync(
        PostV1ConsolidationIntercompanyLinksListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ConsolidationIntercompanyLinksRemoveResponse> PostV1ConsolidationIntercompanyLinksRemoveAsync(
        PostV1ConsolidationIntercompanyLinksRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Intercompany reconciliation for a period: every issued intercompany sale invoice with its mirrored or manually recorded counterpart, unmatched documents on both sides, and per-currency totals with differences. Confirmed pairs are the basis for consolidation eliminations.
    /// </summary>
    WithRawResponseTask<PostV1ConsolidationIntercompanyReportResponse> PostV1ConsolidationIntercompanyReportAsync(
        PostV1ConsolidationIntercompanyReportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ConsolidationReportResponse> PostV1ConsolidationReportAsync(
        PostV1ConsolidationReportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
