namespace NordletApi;

public partial interface IBankClient
{
    WithRawResponseTask<PostV1BankAccountsCreateResponse> PostV1BankAccountsCreateAsync(
        PostV1BankAccountsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankAccountsListResponse> PostV1BankAccountsListAsync(
        PostV1BankAccountsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankAccountsUpdateResponse> PostV1BankAccountsUpdateAsync(
        PostV1BankAccountsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankTransactionsImportResponse> PostV1BankTransactionsImportAsync(
        PostV1BankTransactionsImportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankStatementsImportResponse> PostV1BankStatementsImportAsync(
        PostV1BankStatementsImportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankTransactionsListResponse> PostV1BankTransactionsListAsync(
        PostV1BankTransactionsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankTransactionsMatchResponse> PostV1BankTransactionsMatchAsync(
        PostV1BankTransactionsMatchRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankTransactionsRecordResponse> PostV1BankTransactionsRecordAsync(
        PostV1BankTransactionsRecordRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankPaymentsExportResponse> PostV1BankPaymentsExportAsync(
        PostV1BankPaymentsExportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankImportTemplatesCreateResponse> CreateABankImportTemplateFieldsDefaultToTheTypesStandardFieldListAsync(
        PostV1BankImportTemplatesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankImportTemplatesUpdateResponse> PostV1BankImportTemplatesUpdateAsync(
        PostV1BankImportTemplatesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankImportTemplatesDeleteResponse> PostV1BankImportTemplatesDeleteAsync(
        PostV1BankImportTemplatesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankImportTemplatesGetResponse> PostV1BankImportTemplatesGetAsync(
        PostV1BankImportTemplatesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankImportTemplatesListResponse> PostV1BankImportTemplatesListAsync(
        PostV1BankImportTemplatesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankMatchRulesCreateResponse> PostV1BankMatchRulesCreateAsync(
        PostV1BankMatchRulesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankMatchRulesUpdateResponse> PostV1BankMatchRulesUpdateAsync(
        PostV1BankMatchRulesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankMatchRulesDeleteResponse> PostV1BankMatchRulesDeleteAsync(
        PostV1BankMatchRulesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankMatchRulesListResponse> PostV1BankMatchRulesListAsync(
        PostV1BankMatchRulesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankMandatesCreateResponse> PostV1BankMandatesCreateAsync(
        PostV1BankMandatesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankMandatesUpdateResponse> PostV1BankMandatesUpdateAsync(
        PostV1BankMandatesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankMandatesCancelResponse> PostV1BankMandatesCancelAsync(
        PostV1BankMandatesCancelRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankMandatesGetResponse> PostV1BankMandatesGetAsync(
        PostV1BankMandatesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankMandatesListResponse> PostV1BankMandatesListAsync(
        PostV1BankMandatesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankDirectDebitsExportResponse> PostV1BankDirectDebitsExportAsync(
        PostV1BankDirectDebitsExportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankTransactionsSuggestMatchesResponse> PostV1BankTransactionsSuggestMatchesAsync(
        PostV1BankTransactionsSuggestMatchesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankSettlementsImportResponse> PostV1BankSettlementsImportAsync(
        PostV1BankSettlementsImportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankSettlementsListResponse> PostV1BankSettlementsListAsync(
        PostV1BankSettlementsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankSettlementsGetResponse> PostV1BankSettlementsGetAsync(
        PostV1BankSettlementsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankSettlementsMatchResponse> PostV1BankSettlementsMatchAsync(
        PostV1BankSettlementsMatchRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Attach the incoming bank-statement line that carries this payout to the settlement batch.
    /// </summary>
    WithRawResponseTask<PostV1BankSettlementsLinkResponse> PostV1BankSettlementsLinkAsync(
        PostV1BankSettlementsLinkRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Detach the bank-statement line from the settlement batch and return the line to unmatched.
    /// </summary>
    WithRawResponseTask<PostV1BankSettlementsUnlinkResponse> PostV1BankSettlementsUnlinkAsync(
        PostV1BankSettlementsUnlinkRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankSettlementsPostResponse> PostV1BankSettlementsPostAsync(
        PostV1BankSettlementsPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankFeedsBanksListResponse> ListThePsd2BanksAspsPsAvailableToConnectAsync(
        PostV1BankFeedsBanksListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankFeedsConnectionsStartResponse> BeginBankAuthorizationRedirectTheUserToTheReturnedUrlAsync(
        PostV1BankFeedsConnectionsStartRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankFeedsConnectionsCompleteResponse> ExchangeTheRedirectCodeForASessionAndStoreTheBankAccountsItExposesAsync(
        PostV1BankFeedsConnectionsCompleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankFeedsConnectionsGetResponse> PostV1BankFeedsConnectionsGetAsync(
        PostV1BankFeedsConnectionsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankFeedsConnectionsListResponse> PostV1BankFeedsConnectionsListAsync(
        PostV1BankFeedsConnectionsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankFeedsConnectionsDeleteResponse> RevokeTheConsentAtTheBankAndDropTheStoredConnectionAsync(
        PostV1BankFeedsConnectionsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankFeedsAccountsLinkResponse> PointABankFeedAccountAtALedgerBankAccountSoItsTransactionsCanBeSyncedAsync(
        PostV1BankFeedsAccountsLinkRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankFeedsAccountsConfigureResponse> ChooseTheImportTemplateAppliedOnSyncAndHowOftenTheAccountIsSyncedAutomaticallyAsync(
        PostV1BankFeedsAccountsConfigureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1BankFeedsSyncResponse> PullNewTransactionsFromTheBankIntoTheLedgerEmitsBankFeedSyncedAsync(
        PostV1BankFeedsSyncRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
