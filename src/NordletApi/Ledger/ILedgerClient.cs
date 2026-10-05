namespace NordletApi;

public partial interface ILedgerClient
{
    WithRawResponseTask<AccountsListLedgerResponse> AccountsListAsync(
        AccountsListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AccountsCreateLedgerResponse> AccountsCreateAsync(
        AccountsCreateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AccountsUpdateLedgerResponse> AccountsUpdateAsync(
        AccountsUpdateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AccountsApplyTemplateLedgerResponse> AccountsApplyTemplateAsync(
        AccountsApplyTemplateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replaces the seeded chart with the chart template of the company country (the Romanian general chart for a company registered in Romania, the Lithuanian standard chart otherwise) and switches the posting defaults with it. Answers 409 when the company already uses that chart, has journal entries, holds accounts created by hand, or has settings that name an account the new chart does not have.
    /// </summary>
    WithRawResponseTask<AccountsSwitchChartLedgerResponse> AccountsSwitchChartAsync(
        AccountsSwitchChartLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PeriodsListLedgerResponse> PeriodsListAsync(
        PeriodsListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PeriodsLockLedgerResponse> PeriodsLockAsync(
        PeriodsLockLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PeriodsUnlockLedgerResponse> PeriodsUnlockAsync(
        PeriodsUnlockLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<JournalTransactionsListLedgerResponse> JournalTransactionsListAsync(
        JournalTransactionsListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CostCentersCreateLedgerResponse> CostCentersCreateAsync(
        CostCentersCreateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CostCentersUpdateLedgerResponse> CostCentersUpdateAsync(
        CostCentersUpdateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CostCentersListLedgerResponse> CostCentersListAsync(
        CostCentersListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CostCenterGroupsCreateLedgerResponse> CostCenterGroupsCreateAsync(
        CostCenterGroupsCreateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CostCenterGroupsUpdateLedgerResponse> CostCenterGroupsUpdateAsync(
        CostCenterGroupsUpdateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CostCenterGroupsDeleteLedgerResponse> CostCenterGroupsDeleteAsync(
        CostCenterGroupsDeleteLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CostCenterGroupsListLedgerResponse> CostCenterGroupsListAsync(
        CostCenterGroupsListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostingRulesListLedgerResponse> PostingRulesListAsync(
        PostingRulesListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostingRulesUpdateLedgerResponse> PostingRulesUpdateAsync(
        PostingRulesUpdateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OwnersCreateLedgerResponse> OwnersCreateAsync(
        OwnersCreateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OwnersUpdateLedgerResponse> OwnersUpdateAsync(
        OwnersUpdateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OwnersDeleteLedgerResponse> OwnersDeleteAsync(
        OwnersDeleteLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OwnersListLedgerResponse> OwnersListAsync(
        OwnersListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<JournalTransactionsGetLedgerResponse> JournalTransactionsGetAsync(
        JournalTransactionsGetLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<JournalTransactionsCreateLedgerResponse> JournalTransactionsCreateAsync(
        JournalTransactionsCreateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The rows or codes of each return or registry deposit of the company country that are filled from account balances. Accounts fall into a row by the layout defaults for the standard chart of accounts unless mapped under Settings → Statement rows.
    /// </summary>
    WithRawResponseTask<StatementRowsSchemesLedgerResponse> StatementRowsSchemesAsync(
        StatementRowsSchemesLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StatementRowsListLedgerResponse> StatementRowsListAsync(
        StatementRowsListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// A mapping on a code prefix covers every account whose code starts with it; the longest matching prefix wins. An empty rowCode removes the mapping so the layout default applies again.
    /// </summary>
    WithRawResponseTask<StatementRowsSetLedgerResponse> StatementRowsSetAsync(
        StatementRowsSetLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
