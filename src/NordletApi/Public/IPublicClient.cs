namespace NordletApi;

public partial interface IPublicClient
{
    /// <summary>
    /// Store a request for an integration: the integration asked for and the sender's name, company, e-mail and details. When `website` is filled in, the call answers `received` without storing anything.
    /// </summary>
    WithRawResponseTask<IntegrationRequestsPublicResponse> IntegrationRequestsAsync(
        IntegrationRequestsPublicRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Redirect (302) to the company's payment page for the issued invoice that carries this payment token, rendered from the template set with `sales/invoices/payment-settings/update` with the invoice number, the amount still unpaid, the currency, the token, the invoice id and the customer name (see `sales/invoices/payment-link`). Answers 404 when the token matches no issued invoice or the company has no template, and 409 when the invoice is already paid.
    /// </summary>
    WithRawResponseTask PayAsync(
        PayPublicRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
