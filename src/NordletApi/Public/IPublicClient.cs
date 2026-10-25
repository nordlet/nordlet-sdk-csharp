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
    /// Redirect (302) to the company's payment page for the issued invoice that carries this payment token, rendered from the template set with `sales/invoices/payment-settings/update` with the invoice number, the amount still unpaid, the currency, the token, the invoice id and the customer name (see `sales/invoices/payment-link`). Answers 404 when the token matches no issued invoice, the invoice has `payLinkEnabled` false or the company has no template, and 409 when the invoice is already paid.
    /// </summary>
    WithRawResponseTask PayAsync(
        PayPublicRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return the issued sale document that carries this customer token (`token` of `sales/invoices/view`), in the shape of `sales/invoices/view` without the token. Answers 404 when the token matches no issued document.
    /// </summary>
    WithRawResponseTask<InvoicesGetPublicResponse> InvoicesGetAsync(
        InvoicesGetPublicRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Open a Stripe Checkout page on the company's connected Stripe account for the amount still unpaid on the issued invoice that carries this customer token, and return its `url`. Stripe sends the customer back to the public invoice page. Answers 404 when the token matches no issued invoice, the invoice has `payLinkEnabled` false or the company has no Stripe account that can take charges, 409 when the invoice is already paid and 422 when Stripe cannot take the amount in the invoice currency.
    /// </summary>
    WithRawResponseTask<InvoicesCheckoutPublicResponse> InvoicesCheckoutAsync(
        InvoicesCheckoutPublicRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return the PDF of the issued sale document that carries this customer token, base64-encoded, as `sales/invoices/pdf` renders it in the document's own language, English when it has none. Answers 404 when the token matches no issued document.
    /// </summary>
    WithRawResponseTask<InvoicesPdfPublicResponse> InvoicesPdfAsync(
        InvoicesPdfPublicRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
