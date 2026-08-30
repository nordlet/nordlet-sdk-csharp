namespace NordletApi;

public partial interface IMigrationClient
{
    /// <summary>
    /// Runs every check the import runs (accounts, partners, balances, open invoices, assets, stock) and returns the same summary and warnings, then rolls everything back. Nothing is stored.
    /// </summary>
    WithRawResponseTask<PostV1MigrationBooksValidateResponse> CheckAHistoricalBooksPackageWithoutWritingAnythingAsync(
        PostV1MigrationBooksValidateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Brings a company over from another system in one call: chart of accounts, partners, items, opening balances (or the full journal history), open customer and supplier invoices, fixed assets with their accumulated depreciation, and stock on hand. The whole package is written in one database transaction — if any row fails, nothing is stored.
    /// </summary>
    WithRawResponseTask<PostV1MigrationBooksImportResponse> ImportHistoricalBooksFromAPreviousAccountingSystemAsync(
        PostV1MigrationBooksImportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
