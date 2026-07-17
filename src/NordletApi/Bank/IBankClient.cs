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

    WithRawResponseTask<PostV1BankPaymentsExportResponse> PostV1BankPaymentsExportAsync(
        PostV1BankPaymentsExportRequest request,
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

    WithRawResponseTask<PostV1BankSettlementsPostResponse> PostV1BankSettlementsPostAsync(
        PostV1BankSettlementsPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
