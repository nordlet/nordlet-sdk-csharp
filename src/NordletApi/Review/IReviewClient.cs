namespace NordletApi;

public partial interface IReviewClient
{
    /// <summary>
    /// Read-only. Lists, each with its `kind`, the `id` of the record, a `message` and the `fix` (the call or field that resolves it): `draft_warning` (a draft purchase or sale document with a warning of `purchases/invoices/create` or `sales/invoices/create`, one item per warning, with its `code`), `bank_transaction_unbooked` (a bank line with the status `new`), `partner_vat_invalid` (a partner whose VAT number failed its VIES check) and `filing_settings_missing` (a filing due in the window of `account/companies/context` whose settings are missing, with the `declarations/configs/update` call; the id is the calendar key). Each kind lists at most 200 records, the newest first. An empty list means nothing needs a look.
    /// </summary>
    WithRawResponseTask<QueueListReviewResponse> QueueListAsync(
        QueueListReviewRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
