namespace NordletApi;

public partial interface IConsolidationClient
{
    /// <summary>
    /// Create a consolidation group owned by the calling company; `presentationCurrency` defaults to the company's base currency. Members are added with `consolidation/members/add`.
    /// </summary>
    WithRawResponseTask<GroupsCreateConsolidationResponse> GroupsCreateAsync(
        GroupsCreateConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the calling company's consolidation groups with their member counts.
    /// </summary>
    WithRawResponseTask<GroupsListConsolidationResponse> GroupsListAsync(
        GroupsListConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return one consolidation group with its members, each with its ownership percentage and consolidation method.
    /// </summary>
    WithRawResponseTask<GroupsGetConsolidationResponse> GroupsGetAsync(
        GroupsGetConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Rename a consolidation group or change its presentation currency.
    /// </summary>
    WithRawResponseTask<GroupsUpdateConsolidationResponse> GroupsUpdateAsync(
        GroupsUpdateConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a consolidation group.
    /// </summary>
    WithRawResponseTask<GroupsDeleteConsolidationResponse> GroupsDeleteAsync(
        GroupsDeleteConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a company to a consolidation group with its ownership percentage and method (`full`, `proportional` or `equity`), or change those of an existing member. Another company can be added only by a signed-in user who is owner, admin or accountant of it; an API key is refused with 403.
    /// </summary>
    WithRawResponseTask<MembersAddConsolidationResponse> MembersAddAsync(
        MembersAddConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove a company from a consolidation group.
    /// </summary>
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

    /// <summary>
    /// List the intercompany links of a group: which partner record of which member company stands for which other member company.
    /// </summary>
    WithRawResponseTask<IntercompanyLinksListConsolidationResponse> IntercompanyLinksListAsync(
        IntercompanyLinksListConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove an intercompany link from a group.
    /// </summary>
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

    /// <summary>
    /// Consolidated financial statements of a group for a period in its presentation currency, with the consolidated trial balance and cash flow, each member's contribution and the intercompany candidates. Each member's balances are translated at the group owner's exchange rates of `toDate` and taken in full, in proportion to the ownership (`proportional`) or as an equity-method investment (`equity`); a fully consolidated member held below 100 % yields the non-controlling interest, and `eliminations` are amounts added to account codes before the statements are assembled (`balanced` tells whether they net to zero). Refused with 422 when the group has no members.
    /// </summary>
    WithRawResponseTask<ReportConsolidationResponse> ReportAsync(
        ReportConsolidationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
