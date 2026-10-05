namespace NordletApi;

public partial interface IConsolidationClient
{
    WithRawResponseTask<GroupsCreateConsolidationResponse> GroupsCreateAsync(
        GroupsCreateConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GroupsListConsolidationResponse> GroupsListAsync(
        GroupsListConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GroupsGetConsolidationResponse> GroupsGetAsync(
        GroupsGetConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GroupsUpdateConsolidationResponse> GroupsUpdateAsync(
        GroupsUpdateConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GroupsDeleteConsolidationResponse> GroupsDeleteAsync(
        GroupsDeleteConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MembersAddConsolidationResponse> MembersAddAsync(
        MembersAddConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MembersRemoveConsolidationResponse> MembersRemoveAsync(
        MembersRemoveConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Partners in member companies that look like other members of the same group (matched on company code or VAT code), with any existing intercompany link. Confirming a candidate via intercompany/links/set enables invoice mirroring.
    /// </summary>
    WithRawResponseTask<IntercompanyCandidatesConsolidationResponse> IntercompanyCandidatesAsync(
        IntercompanyCandidatesConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Confirm that a partner record in one member company represents another member company of the group. Once links exist in both directions, issuing an intercompany sale invoice automatically creates the matching draft purchase invoice in the counterparty.
    /// </summary>
    WithRawResponseTask<IntercompanyLinksSetConsolidationResponse> IntercompanyLinksSetAsync(
        IntercompanyLinksSetConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<IntercompanyLinksListConsolidationResponse> IntercompanyLinksListAsync(
        IntercompanyLinksListConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<IntercompanyLinksRemoveConsolidationResponse> IntercompanyLinksRemoveAsync(
        IntercompanyLinksRemoveConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Intercompany reconciliation for a period: every issued intercompany sale invoice with its mirrored or manually recorded counterpart, unmatched documents on both sides, and per-currency totals with differences. Confirmed pairs are the basis for consolidation eliminations.
    /// </summary>
    WithRawResponseTask<IntercompanyReportConsolidationResponse> IntercompanyReportAsync(
        IntercompanyReportConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReportConsolidationResponse> ReportAsync(
        ReportConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
