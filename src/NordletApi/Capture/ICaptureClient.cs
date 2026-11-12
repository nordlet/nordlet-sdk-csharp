namespace NordletApi;

public partial interface ICaptureClient
{
    /// <summary>
    /// Parse a capture received over Peppol from its stored document again and replace its draft (supplier, totals, lines, matched partner). Refused with 422 for a capture that was not received over Peppol and with 409 once the capture is linked to a purchase invoice.
    /// </summary>
    WithRawResponseTask<DocumentsExtractCaptureResponse> DocumentsExtractAsync(
        DocumentsExtractCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return one document received over Peppol (a capture) with its draft: supplier, dates, totals and lines.
    /// </summary>
    WithRawResponseTask<DocumentsGetCaptureResponse> DocumentsGetAsync(
        DocumentsGetCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the documents received over Peppol (captures) with their drafts. Filterable by `status`, `matchedPartnerId` and `purchaseInvoiceId`; sortable by `createdAt` and `updatedAt`.
    /// </summary>
    WithRawResponseTask<DocumentsListCaptureResponse> DocumentsListAsync(
        DocumentsListCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a capture and its stored file (409 once it is linked to a purchase invoice).
    /// </summary>
    WithRawResponseTask<DocumentsDeleteCaptureResponse> DocumentsDeleteAsync(
        DocumentsDeleteCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates the purchase invoice (or credit note, see `type`) from `lines`. Lines with the opposite sign go in `oppositeLines` and are saved as a second document of the opposite type for the same supplier: a purchase credit note against the new invoice, or a purchase invoice next to the new credit note. It is numbered `oppositeDocumentNumber`, by default the document number followed by "-CR" (credit note) or "-INV" (invoice).
    /// </summary>
    WithRawResponseTask<DocumentsConfirmCaptureResponse> DocumentsConfirmAsync(
        DocumentsConfirmCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
