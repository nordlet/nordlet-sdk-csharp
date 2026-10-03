namespace NordletApi;

public partial interface ILedgerClient
{
    WithRawResponseTask<PostV1LedgerAccountsListResponse> PostV1LedgerAccountsListAsync(
        PostV1LedgerAccountsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerAccountsCreateResponse> PostV1LedgerAccountsCreateAsync(
        PostV1LedgerAccountsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerAccountsUpdateResponse> PostV1LedgerAccountsUpdateAsync(
        PostV1LedgerAccountsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerAccountsApplyTemplateResponse> PostV1LedgerAccountsApplyTemplateAsync(
        PostV1LedgerAccountsApplyTemplateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replaces the seeded chart with the chart template of the company country (the Romanian general chart for a company registered in Romania, the Lithuanian standard chart otherwise) and switches the posting defaults with it. Answers 409 when the company already uses that chart, has journal entries, holds accounts created by hand, or has settings that name an account the new chart does not have.
    /// </summary>
    WithRawResponseTask<PostV1LedgerAccountsSwitchChartResponse> MoveACompanyThatHasPostedNothingYetToTheChartOfAccountsOfItsCountryAsync(
        PostV1LedgerAccountsSwitchChartRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerPeriodsListResponse> PostV1LedgerPeriodsListAsync(
        PostV1LedgerPeriodsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerPeriodsLockResponse> PostV1LedgerPeriodsLockAsync(
        PostV1LedgerPeriodsLockRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerPeriodsUnlockResponse> PostV1LedgerPeriodsUnlockAsync(
        PostV1LedgerPeriodsUnlockRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerJournalTransactionsListResponse> PostV1LedgerJournalTransactionsListAsync(
        PostV1LedgerJournalTransactionsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerCostCentersCreateResponse> PostV1LedgerCostCentersCreateAsync(
        PostV1LedgerCostCentersCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerCostCentersUpdateResponse> PostV1LedgerCostCentersUpdateAsync(
        PostV1LedgerCostCentersUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerCostCentersListResponse> PostV1LedgerCostCentersListAsync(
        PostV1LedgerCostCentersListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerCostCenterGroupsCreateResponse> PostV1LedgerCostCenterGroupsCreateAsync(
        PostV1LedgerCostCenterGroupsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerCostCenterGroupsUpdateResponse> PostV1LedgerCostCenterGroupsUpdateAsync(
        PostV1LedgerCostCenterGroupsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerCostCenterGroupsDeleteResponse> PostV1LedgerCostCenterGroupsDeleteAsync(
        PostV1LedgerCostCenterGroupsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerCostCenterGroupsListResponse> PostV1LedgerCostCenterGroupsListAsync(
        PostV1LedgerCostCenterGroupsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerPostingRulesListResponse> PostV1LedgerPostingRulesListAsync(
        PostV1LedgerPostingRulesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerPostingRulesUpdateResponse> PostV1LedgerPostingRulesUpdateAsync(
        PostV1LedgerPostingRulesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerOwnersCreateResponse> PostV1LedgerOwnersCreateAsync(
        PostV1LedgerOwnersCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerOwnersUpdateResponse> PostV1LedgerOwnersUpdateAsync(
        PostV1LedgerOwnersUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerOwnersDeleteResponse> PostV1LedgerOwnersDeleteAsync(
        PostV1LedgerOwnersDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerOwnersListResponse> PostV1LedgerOwnersListAsync(
        PostV1LedgerOwnersListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerJournalTransactionsGetResponse> PostV1LedgerJournalTransactionsGetAsync(
        PostV1LedgerJournalTransactionsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerJournalTransactionsCreateResponse> PostV1LedgerJournalTransactionsCreateAsync(
        PostV1LedgerJournalTransactionsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The rows or codes of each return or registry deposit of the company country that are filled from account balances. Accounts fall into a row by the layout defaults for the standard chart of accounts unless mapped under Settings → Statement rows.
    /// </summary>
    WithRawResponseTask<PostV1LedgerStatementRowsSchemesResponse> NationalStatementLayoutsAvailableToTheCompanyAsync(
        PostV1LedgerStatementRowsSchemesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LedgerStatementRowsListResponse> AccountsPlacedOnTheRowsOfAStatementLayoutWithTheRowTotalsOfAPeriodAsync(
        PostV1LedgerStatementRowsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// A mapping on a code prefix covers every account whose code starts with it; the longest matching prefix wins. An empty rowCode removes the mapping so the layout default applies again.
    /// </summary>
    WithRawResponseTask<PostV1LedgerStatementRowsSetResponse> MapAnAccountOrAnAccountCodePrefixToARowOfAStatementLayoutAsync(
        PostV1LedgerStatementRowsSetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Directors, board members, the company secretary, representatives and liquidators, with their personal identifier, appointment and resignation dates and whether they sign the annual accounts. Annual returns and registry deposits are built from this register.
    /// </summary>
    WithRawResponseTask<PostV1OfficersListResponse> OfficersOfTheCompanyAsync(
        PostV1OfficersListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1OfficersCreateResponse> RecordAnOfficerOfTheCompanyAsync(
        PostV1OfficersCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1OfficersUpdateResponse> ChangeARecordedOfficerAsync(
        PostV1OfficersUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1OfficersDeleteResponse> RemoveARecordedOfficerAsync(
        PostV1OfficersDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
