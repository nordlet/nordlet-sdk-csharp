namespace NordletApi;

public partial interface IBankClient
{
    WithRawResponseTask<AccountsCreateBankResponse> AccountsCreateAsync(
        AccountsCreateBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AccountsListBankResponse> AccountsListAsync(
        AccountsListBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AccountsUpdateBankResponse> AccountsUpdateAsync(
        AccountsUpdateBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TransactionsImportBankResponse> TransactionsImportAsync(
        TransactionsImportBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StatementsImportBankResponse> StatementsImportAsync(
        StatementsImportBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TransactionsListBankResponse> TransactionsListAsync(
        TransactionsListBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TransactionsMatchBankResponse> TransactionsMatchAsync(
        TransactionsMatchBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Undo a match. A payment matched to an invoice, or a line posted by an import template, gets a reversing journal transaction dated date (default: today) and the invoice paid amount and payment status are restored; a line linked to a payment-provider settlement is only unlinked. The line returns to status new.
    /// </summary>
    WithRawResponseTask<TransactionsUnmatchBankResponse> TransactionsUnmatchAsync(
        TransactionsUnmatchBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TransactionsRecordBankResponse> TransactionsRecordAsync(
        TransactionsRecordBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PaymentsExportBankResponse> PaymentsExportAsync(
        PaymentsExportBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ImportTemplatesCreateBankResponse> ImportTemplatesCreateAsync(
        ImportTemplatesCreateBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ImportTemplatesUpdateBankResponse> ImportTemplatesUpdateAsync(
        ImportTemplatesUpdateBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ImportTemplatesDeleteBankResponse> ImportTemplatesDeleteAsync(
        ImportTemplatesDeleteBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ImportTemplatesGetBankResponse> ImportTemplatesGetAsync(
        ImportTemplatesGetBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ImportTemplatesListBankResponse> ImportTemplatesListAsync(
        ImportTemplatesListBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MatchRulesCreateBankResponse> MatchRulesCreateAsync(
        MatchRulesCreateBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MatchRulesUpdateBankResponse> MatchRulesUpdateAsync(
        MatchRulesUpdateBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MatchRulesDeleteBankResponse> MatchRulesDeleteAsync(
        MatchRulesDeleteBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MatchRulesListBankResponse> MatchRulesListAsync(
        MatchRulesListBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MandatesCreateBankResponse> MandatesCreateAsync(
        MandatesCreateBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MandatesUpdateBankResponse> MandatesUpdateAsync(
        MandatesUpdateBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MandatesCancelBankResponse> MandatesCancelAsync(
        MandatesCancelBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MandatesGetBankResponse> MandatesGetAsync(
        MandatesGetBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MandatesListBankResponse> MandatesListAsync(
        MandatesListBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DirectDebitsExportBankResponse> DirectDebitsExportAsync(
        DirectDebitsExportBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TransactionsSuggestMatchesBankResponse> TransactionsSuggestMatchesAsync(
        TransactionsSuggestMatchesBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SettlementsImportBankResponse> SettlementsImportAsync(
        SettlementsImportBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SettlementsListBankResponse> SettlementsListAsync(
        SettlementsListBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SettlementsGetBankResponse> SettlementsGetAsync(
        SettlementsGetBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SettlementsMatchBankResponse> SettlementsMatchAsync(
        SettlementsMatchBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// A line with its own rate or amount is split with that value when the batch is posted. A line without one falls back to the commissionPercent given to the posting call, and without that the amount goes to the suspense account. Send both fields as null to clear the line back to the fallback.
    /// </summary>
    WithRawResponseTask<SettlementsCommissionBankResponse> SettlementsCommissionAsync(
        SettlementsCommissionBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Attach the incoming bank-statement line that carries this payout to the settlement batch.
    /// </summary>
    WithRawResponseTask<SettlementsLinkBankResponse> SettlementsLinkAsync(
        SettlementsLinkBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Detach the bank-statement line from the settlement batch and return the line to unmatched.
    /// </summary>
    WithRawResponseTask<SettlementsUnlinkBankResponse> SettlementsUnlinkAsync(
        SettlementsUnlinkBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SettlementsPostBankResponse> SettlementsPostAsync(
        SettlementsPostBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FeedsBanksListBankResponse> FeedsBanksListAsync(
        FeedsBanksListBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FeedsConnectionsStartBankResponse> FeedsConnectionsStartAsync(
        FeedsConnectionsStartBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FeedsConnectionsCompleteBankResponse> FeedsConnectionsCompleteAsync(
        FeedsConnectionsCompleteBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FeedsConnectionsGetBankResponse> FeedsConnectionsGetAsync(
        FeedsConnectionsGetBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FeedsConnectionsListBankResponse> FeedsConnectionsListAsync(
        FeedsConnectionsListBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FeedsConnectionsDeleteBankResponse> FeedsConnectionsDeleteAsync(
        FeedsConnectionsDeleteBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FeedsAccountsLinkBankResponse> FeedsAccountsLinkAsync(
        FeedsAccountsLinkBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FeedsAccountsConfigureBankResponse> FeedsAccountsConfigureAsync(
        FeedsAccountsConfigureBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FeedsSyncBankResponse> FeedsSyncAsync(
        FeedsSyncBankRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
