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

    WithRawResponseTask<DocumentsConfirmCaptureResponse> DocumentsConfirmAsync(
        DocumentsConfirmCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
