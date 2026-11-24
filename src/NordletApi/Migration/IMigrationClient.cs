namespace NordletApi;

public partial interface IMigrationClient
{
    /// <summary>
    /// Runs every check the import runs (accounts, partners, balances, open invoices, assets, stock) and returns the same summary and warnings, then rolls everything back. Nothing is stored. When the package has problems in several rows of `journal`, `openReceivables`, `openPayables`, `fixedAssets` or `stock`, the 422 lists every one of them, each under its row (`journal[2]`) in `fieldErrors`; a problem in `accounts`, `partners`, `items`, `assetGroups`, `openingBalances` or the package as a whole is reported alone, because the rows after it depend on it.
    /// </summary>
    WithRawResponseTask<BooksValidateMigrationResponse> BooksValidateAsync(
        BooksValidateMigrationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Brings a company over from another system in one call: chart of accounts, partners, items, opening balances (or the full journal history), open customer and supplier invoices, fixed assets with their accumulated depreciation, and stock on hand. The numbering of the open customer invoices continues: each series and year starts after its highest number, and a company without `invoicePrefix` takes the series of the latest open invoice, so `sales/invoices/issue` numbers the next invoice in it. The whole package is written in one database transaction - if any row fails, nothing is stored.
    /// </summary>
    WithRawResponseTask<BooksImportMigrationResponse> BooksImportAsync(
        BooksImportMigrationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
