namespace NordletApi;

public partial interface ICaptureClient
{
    /// <summary>
    /// Return the company's document capture settings: whether intake by e-mail is enabled, whether e-mailed documents are read on arrival, the company's intake e-mail address and whether a reading provider is configured. The intake token behind the address is created on the first call.
    /// </summary>
    WithRawResponseTask<SettingsGetCaptureResponse> SettingsGetAsync(
        SettingsGetCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Switch `intakeEnabled` (documents sent to the intake address are accepted) and `captureAutoExtract` (they are read on arrival) on or off; at least one field is required.
    /// </summary>
    WithRawResponseTask<SettingsUpdateCaptureResponse> SettingsUpdateAsync(
        SettingsUpdateCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replace the company's intake token, so the previous intake e-mail address stops working and the settings come back with the new one.
    /// </summary>
    WithRawResponseTask<SettingsRegenerateIntakeCaptureResponse> SettingsRegenerateIntakeAsync(
        SettingsRegenerateIntakeCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Endpoint for the inbound e-mail provider (Postmark field names or the generic `to`, `from`, `subject` and `attachments` form). It needs the `x-inbound-secret` header and finds the company by the `intake+&lt;token&gt;@` recipient address (404 when unknown, 403 when intake is disabled). Every PDF, image, Word or PowerPoint attachment up to 10 MB becomes a `pending` capture (`accepted`), anything else is `skipped`; when the company has automatic reading on, is not on trial and a reading provider is configured, each capture is read at once.
    /// </summary>
    WithRawResponseTask<InboundEmailCaptureResponse> InboundEmailAsync(
        InboundEmailCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Upload a supplier document (PDF, image, Word or PowerPoint, up to 10 MB; 422 for any other type) as a capture and read it at once. The result holds the extracted supplier, dates, totals and lines, the partner matched by VAT code, then partner code, then name, the raw text, and `status` `extracted` or `failed` with `error`. Needs a configured reading provider, is refused with 402 for a company on trial until its first top-up, and counts every page read as `ocr_page` usage. The draft is reviewed and saved with `capture/documents/confirm`.
    /// </summary>
    WithRawResponseTask<DocumentsUploadCaptureResponse> DocumentsUploadAsync(
        DocumentsUploadCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Read a stored capture again and replace its draft (supplier, totals, lines, matched partner). A capture received over Peppol is parsed from its document again without a reading provider; any other needs the provider and, for a company on trial, the first top-up (402). Refused with 409 once the capture is linked to a purchase invoice.
    /// </summary>
    WithRawResponseTask<DocumentsExtractCaptureResponse> DocumentsExtractAsync(
        DocumentsExtractCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return one capture with its extraction and raw text.
    /// </summary>
    WithRawResponseTask<DocumentsGetCaptureResponse> DocumentsGetAsync(
        DocumentsGetCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List captures without raw text. Filterable by `status`, `matchedPartnerId` and `purchaseInvoiceId`; sortable by `createdAt` and `updatedAt`.
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
