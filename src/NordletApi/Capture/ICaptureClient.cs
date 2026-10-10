namespace NordletApi;

public partial interface ICaptureClient
{
    WithRawResponseTask<SettingsGetCaptureResponse> SettingsGetAsync(
        SettingsGetCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SettingsUpdateCaptureResponse> SettingsUpdateAsync(
        SettingsUpdateCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SettingsRegenerateIntakeCaptureResponse> SettingsRegenerateIntakeAsync(
        SettingsRegenerateIntakeCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InboundEmailCaptureResponse> InboundEmailAsync(
        InboundEmailCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocumentsUploadCaptureResponse> DocumentsUploadAsync(
        DocumentsUploadCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocumentsExtractCaptureResponse> DocumentsExtractAsync(
        DocumentsExtractCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocumentsGetCaptureResponse> DocumentsGetAsync(
        DocumentsGetCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocumentsListCaptureResponse> DocumentsListAsync(
        DocumentsListCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

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
