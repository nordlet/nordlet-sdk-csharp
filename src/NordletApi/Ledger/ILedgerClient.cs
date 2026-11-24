namespace NordletApi;

public partial interface ILedgerClient
{
    /// <summary>
    /// Lists the company's chart of accounts. Filterable by `code`, `name`, `type` and `isPostable`; sortable by `code`, `name`, `type` and `isPostable`. A `name` filter with `contains` matches the stored name and the name shown in the language of the request (`displayName`).
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
    /// Replaces the seeded chart with the chart template of the company country (the national chart for a company registered in Belgium, the Czech Republic, Denmark, Estonia, France, Luxembourg, the Netherlands, Portugal, Romania, Slovakia, Slovenia, Spain, the United Kingdom or the United States, the chart of the balance sheet and profit and loss items of Directive 2013/34/EU for a company registered in Austria, Bulgaria, Croatia, Cyprus, Finland, Germany, Greece, Hungary, Iceland, Ireland, Italy, Latvia, Liechtenstein, Malta, Norway, Poland or Sweden, the Lithuanian standard chart otherwise) and switches the posting defaults with it. Answers 409 when the company already uses that chart, has journal entries, holds accounts created by hand, or has settings that name an account the new chart does not have.
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
    /// Locks the month so that postings dated in it are refused with 409 (`ledger/journal/transactions/create`, `cash/orders/create` and `cash/expense-reports/create` among them). Before locking a month that is not locked yet, posts the pending ratable revenue recognition tranches scheduled up to the month end and emits `revenue_recognition.posted` when there were any; when the month is the company's fiscal year end and no year-end close is posted for that year, posts the year-end close that moves the income and expense balances of the fiscal year to the retained earnings account (posting rule `closing.retainedEarnings`). The lock is not refused for open items: `warnings` lists them as `reports/period-checklist` does, for the month, or for the fiscal year when the month is the fiscal year end.
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
    /// Lists journal transactions with the partner name. Filterable by `date`, `status`, `documentType`, `partnerId` and `documentId`; sortable by `date`, `createdAt`, `description`, `partnerName` (the name of the partner), `documentType` and `status`.
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
    /// Lists the company's owners. Filterable by `name` and `code`; sortable by `name`, `createdAt`, `code`, `sharesQuantity`, `sharesAmount`, `sharesType`, `sharesAcquisitionDate`, `partnerLiability` and `withholdingTaxPercent`.
    /// </summary>
    WithRawResponseTask<OwnersListLedgerResponse> OwnersListAsync(
        OwnersListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a journal transaction with its entries, ordered by account code. `reversedByTransactionId` is the transaction posted by `ledger/journal/transactions/reverse` for a manual transaction, else null.
    /// </summary>
    WithRawResponseTask<JournalTransactionsGetLedgerResponse> JournalTransactionsGetAsync(
        JournalTransactionsGetLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Posts a manual journal transaction (`documentType` `manual`, status `posted`) in the company's base currency. Every `accountCode` must be a postable account of the chart, cost centers must exist and be active, projects must exist, an entry `partnerId` must be a partner of the company (422), and the debits must equal the credits. An entry with a `partnerId` on the receivable or payable account (posting rules `sales.receivable`, `purchases.payables`) is counted by `reports/partner-balances` and `reports/debt-aging`. Answers 422 for an unknown or non-postable account, an unknown cost center or project, debits that differ from the credits, an amount that is not whole cents (a third or fourth decimal other than zero; `10.5000` is accepted), for a `currency` other than the base currency and for an inactive cost center, and 409 when the accounting period of `date` is locked.
    /// </summary>
    WithRawResponseTask<JournalTransactionsCreateLedgerResponse> JournalTransactionsCreateAsync(
        JournalTransactionsCreateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Save a journal template: the accounts of a recurring manual transaction, each with its side (`debit` or `credit`), for example the lines of a payslip from an outside payroll provider. `ledger/journal/templates/post` then posts it with the amounts of the month. The accounts, cost centers, projects and partners are checked as in `ledger/journal/transactions/create` (422); the template needs at least one debit and one credit line (422), and a repeated `name` is refused with 409.
    /// </summary>
    WithRawResponseTask<JournalTemplatesCreateLedgerResponse> JournalTemplatesCreateAsync(
        JournalTemplatesCreateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the journal templates with their lines. Filterable by `name`; sortable by `name` and `createdAt`.
    /// </summary>
    WithRawResponseTask<JournalTemplatesListLedgerResponse> JournalTemplatesListAsync(
        JournalTemplatesListLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a journal template. The transactions already posted from it stay. Answers 404 for an unknown template.
    /// </summary>
    WithRawResponseTask<JournalTemplatesDeleteLedgerResponse> JournalTemplatesDeleteAsync(
        JournalTemplatesDeleteLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Posts a manual journal transaction from a journal template: `amounts` gives one amount per template line, in the template's order, on the line's side; a line with amount 0 is left out. The transaction is posted as by `ledger/journal/transactions/create` (`documentType` `manual`, base currency) with `description`, else the template name. Answers 404 for an unknown template and 422 when the number of amounts differs from the number of lines, when fewer than two lines have an amount or when the debits differ from the credits, besides the answers of `ledger/journal/transactions/create`.
    /// </summary>
    WithRawResponseTask<JournalTemplatesPostLedgerResponse> JournalTemplatesPostAsync(
        JournalTemplatesPostLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Posts a journal transaction (`documentType` `manual_reversal`, `documentId` the original) dated `date` (default the original date) whose entries mirror the original's (debits and credits swapped). Only a `manual` transaction, a `tax_provision` (posted by `ledger/tax-provision/post`), a `vat_prorata_adjustment` (posted by `declarations/vat-prorata/adjustment/post`) or an `it_tfr_accrual` or `it_tfr_revaluation` (posted by `declarations/it/tfr/accrual/post` and `declarations/it/tfr/revaluation/post`) is reversed here; a transaction posted by a document is reversed through that document. Answers 409 when the transaction is neither, when it is already reversed and when the accounting period of `date` is locked, and 400 when `date` is before the original date.
    /// </summary>
    WithRawResponseTask<JournalTransactionsReverseLedgerResponse> JournalTransactionsReverseAsync(
        JournalTransactionsReverseLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Revalues the open sale and purchase documents in a currency other than the base currency (open amount at `date`, payments up to `date` deducted) and the balances of the foreign-currency bank accounts at the stored exchange rate of `date` against the rate of each document or the booked base balance, and posts one journal transaction dated `date` (`documentType` `fx_revaluation`): the difference on each receivable or payable account with the partner on the entry, and the unrealised gain or loss on the `bank.fxUnrealisedGain` and `bank.fxUnrealisedLoss` posting rule accounts. A second transaction (`documentType` `fx_revaluation_reversal`) reverses it on the next calendar day. Nothing is posted and `runId` is null when nothing differs. The payment match keeps booking the realised difference against the rate of the document. Runs only on request, once per `date`: 409 when `date` is already revalued (reverse that run first) and when `date` or the next day is in a locked accounting period; 422 when a stored rate is missing.
    /// </summary>
    WithRawResponseTask<FxRevaluationRunLedgerResponse> FxRevaluationRunAsync(
        FxRevaluationRunLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancels the run `id` of `ledger/fx-revaluation/run`: posts a mirror of the revaluation transaction on the run date (`documentType` `fx_revaluation_undo`) and a mirror of its next-day reversal on the reversal date (`documentType` `fx_revaluation_undo_reversal`), so the net effect is zero, and frees the date for a new run. Answers 404 for an unknown run, 409 when the run is already reversed or when the run date or the next day is in a locked accounting period.
    /// </summary>
    WithRawResponseTask<FxRevaluationReverseLedgerResponse> FxRevaluationReverseAsync(
        FxRevaluationReverseLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Posts a journal transaction (`documentType` `accrual`) dated `date` from `lines` (each line either a debit or a credit, whole cents, balanced; an optional `partnerId` is counted by the partner reports on the receivable and payable accounts) and a mirror transaction (`documentType` `accrual_reversal`, `documentId` the accrual) dated the first day of the next month. 422 for an unknown or non-postable account, an unknown partner, an unbalanced or one-sided line; 409 when the accounting period of `date` or of the reversal date is locked.
    /// </summary>
    WithRawResponseTask<AccrualsCreateLedgerResponse> AccrualsCreateAsync(
        AccrualsCreateLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Posts a journal transaction (`documentType` `tax_provision`, `documentId` the fiscal year) dated the last day of the fiscal year `fiscalYear`: debit the `tax.corporateExpense` posting rule account, credit `tax.corporatePayable`. `amount` defaults to the tax payable of the year's corporate tax return for Lithuanian (PLN204) and Romanian (D101) companies; for other countries it is required (422). 422 when the amount is zero or not whole cents; 409 when the accounting period is locked and when the year already has a provision that is not reversed (reverse it with `ledger/journal/transactions/reverse`).
    /// </summary>
    WithRawResponseTask<TaxProvisionPostLedgerResponse> TaxProvisionPostAsync(
        TaxProvisionPostLedgerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The rows or codes of each return or registry deposit of the company country that are filled from account balances. Accounts fall into a row by the layout defaults for the standard chart of accounts unless mapped with ledger/statement-rows/set.
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
