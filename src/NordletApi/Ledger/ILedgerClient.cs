namespace NordletApi;

public partial interface ILedgerClient
{
    /// <summary>
    /// Lists the company's chart of accounts. Filterable by `code`, `name`, `type` and `isPostable`; sortable by `code` and `name`.
    /// </summary>
    WithRawResponseTask<AccountsListLedgerResponse> AccountsListAsync(
        AccountsListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds an account to the company's chart of accounts. `parentId` must name an account of the same company. Answers 409 when an account with the same `code` already exists.
    /// </summary>
    WithRawResponseTask<AccountsCreateLedgerResponse> AccountsCreateAsync(
        AccountsCreateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the name, parent or postability of an account; the code and type cannot be changed. An account cannot be its own parent.
    /// </summary>
    WithRawResponseTask<AccountsUpdateLedgerResponse> AccountsUpdateAsync(
        AccountsUpdateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds the accounts of the company's chart template that the chart does not have yet (an account whose code already exists is not replaced) and sets the parent links the template defines. Returns the number of accounts in the chart afterwards.
    /// </summary>
    WithRawResponseTask<AccountsApplyTemplateLedgerResponse> AccountsApplyTemplateAsync(
        AccountsApplyTemplateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replaces the seeded chart with the chart template of the company country (the Romanian general chart for a company registered in Romania, the Estonian e-arveldaja chart for a company registered in Estonia, the Lithuanian standard chart otherwise) and switches the posting defaults with it. Answers 409 when the company already uses that chart, has journal entries, holds accounts created by hand, or has settings that name an account the new chart does not have.
    /// </summary>
    WithRawResponseTask<AccountsSwitchChartLedgerResponse> AccountsSwitchChartAsync(
        AccountsSwitchChartLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the company's accounting periods with their `open` or `locked` status. Filterable by `year`, `month` and `status`; sortable by `year` and `month`.
    /// </summary>
    WithRawResponseTask<PeriodsListLedgerResponse> PeriodsListAsync(
        PeriodsListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Locks the month so that postings dated in it are refused with 409 (`ledger/journal/transactions/create`, `cash/orders/create` and `cash/expense-reports/create` among them). Before locking a month that is not locked yet, posts the pending ratable revenue recognition tranches scheduled up to the month end and emits `revenue_recognition.posted` when there were any; when the month is the company's fiscal year end and no year-end close is posted for that year, posts the year-end close that moves the income and expense balances of the fiscal year to the retained earnings account (posting rule `closing.retainedEarnings`).
    /// </summary>
    WithRawResponseTask<PeriodsLockLedgerResponse> PeriodsLockAsync(
        PeriodsLockLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Opens the month for posting again. When the month is the company's fiscal year end and a year-end close is posted for it, posts a reversal of that close dated the same day.
    /// </summary>
    WithRawResponseTask<PeriodsUnlockLedgerResponse> PeriodsUnlockAsync(
        PeriodsUnlockLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists journal transactions with the partner name. Filterable by `date`, `status`, `documentType`, `partnerId` and `documentId`; sortable by `date` and `createdAt`.
    /// </summary>
    WithRawResponseTask<JournalTransactionsListLedgerResponse> JournalTransactionsListAsync(
        JournalTransactionsListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a cost center, optionally inside a cost center group. Answers 409 when the `code` is already used.
    /// </summary>
    WithRawResponseTask<CostCentersCreateLedgerResponse> CostCentersCreateAsync(
        CostCentersCreateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the name, group or active flag of a cost center. An inactive cost center is refused on new manual journal entries (`ledger/journal/transactions/create` answers 422).
    /// </summary>
    WithRawResponseTask<CostCentersUpdateLedgerResponse> CostCentersUpdateAsync(
        CostCentersUpdateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists cost centers with their group name. Filterable by `code`, `name`, `isActive` and `groupId`; sortable by `code`, `name` and `createdAt`.
    /// </summary>
    WithRawResponseTask<CostCentersListLedgerResponse> CostCentersListAsync(
        CostCentersListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a cost center group. Answers 409 when the `code` is already used.
    /// </summary>
    WithRawResponseTask<CostCenterGroupsCreateLedgerResponse> CostCenterGroupsCreateAsync(
        CostCenterGroupsCreateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the code or name of a cost center group. Answers 409 when the new code is already used.
    /// </summary>
    WithRawResponseTask<CostCenterGroupsUpdateLedgerResponse> CostCenterGroupsUpdateAsync(
        CostCenterGroupsUpdateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a cost center group. Answers 409 while cost centers are still assigned to it.
    /// </summary>
    WithRawResponseTask<CostCenterGroupsDeleteLedgerResponse> CostCenterGroupsDeleteAsync(
        CostCenterGroupsDeleteLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists cost center groups. Filterable and sortable by `code` and `name`.
    /// </summary>
    WithRawResponseTask<CostCenterGroupsListLedgerResponse> CostCenterGroupsListAsync(
        CostCenterGroupsListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists every posting rule with its default account code on the company's chart template, the account code in effect and whether the company has overridden it.
    /// </summary>
    WithRawResponseTask<PostingRulesListLedgerResponse> PostingRulesListAsync(
        PostingRulesListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Overrides the account code of one or more posting rules; an `accountCode` of null removes the override and the chart default applies again. Every code given must be a postable account of the company's chart, else 422.
    /// </summary>
    WithRawResponseTask<PostingRulesUpdateLedgerResponse> PostingRulesUpdateAsync(
        PostingRulesUpdateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds an owner of the company. `equityAccountCode` defaults to the share capital account of the company's chart; a code that is not in the chart of accounts answers 422.
    /// </summary>
    WithRawResponseTask<OwnersCreateLedgerResponse> OwnersCreateAsync(
        OwnersCreateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the fields of an owner. An `equityAccountCode` that is not in the chart of accounts answers 422.
    /// </summary>
    WithRawResponseTask<OwnersUpdateLedgerResponse> OwnersUpdateAsync(
        OwnersUpdateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes an owner.
    /// </summary>
    WithRawResponseTask<OwnersDeleteLedgerResponse> OwnersDeleteAsync(
        OwnersDeleteLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the company's owners. Filterable by `name` and `code`; sortable by `name` and `createdAt`.
    /// </summary>
    WithRawResponseTask<OwnersListLedgerResponse> OwnersListAsync(
        OwnersListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a journal transaction with its entries, ordered by account code.
    /// </summary>
    WithRawResponseTask<JournalTransactionsGetLedgerResponse> JournalTransactionsGetAsync(
        JournalTransactionsGetLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Posts a manual journal transaction (`documentType` `manual`, status `posted`) in the company's base currency. Every `accountCode` must be a postable account of the chart, cost centers must exist and be active, projects must exist, and the debits must equal the credits. Answers 422 for an amount with more than two decimals, for a `currency` other than the base currency and for an inactive cost center, and 409 when the accounting period of `date` is locked.
    /// </summary>
    WithRawResponseTask<JournalTransactionsCreateLedgerResponse> JournalTransactionsCreateAsync(
        JournalTransactionsCreateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The rows or codes of each return or registry deposit of the company country that are filled from account balances. Accounts fall into a row by the layout defaults for the standard chart of accounts unless mapped under Account → Statement rows.
    /// </summary>
    WithRawResponseTask<StatementRowsSchemesLedgerResponse> StatementRowsSchemesAsync(
        StatementRowsSchemesLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Every postable account of the company with the row of `scheme` it falls into, by a mapping (`ledger/statement-rows/set`) or by the layout default, and the amount it carries there: the balance up to `toDate` on a balance-sheet row, the movement from `fromDate` to `toDate` on an income-statement row. `toDate` defaults to today and `fromDate` to 1 January of that year. `rows` holds the row totals and `unmapped` the accounts with a balance but no row.
    /// </summary>
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
