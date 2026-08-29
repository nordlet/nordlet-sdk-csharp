namespace NordletApi;

public partial interface ICaptureClient
{
    WithRawResponseTask<PostV1CaptureDocumentsUploadResponse> ReadAVendorBillOrReceiptAndReturnAnEditablePurchaseInvoiceDraftAsync(
        PostV1CaptureDocumentsUploadRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CaptureDocumentsExtractResponse> ReReadAStoredCaptureReplacingThePreviousDraftAsync(
        PostV1CaptureDocumentsExtractRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CaptureDocumentsGetResponse> PostV1CaptureDocumentsGetAsync(
        PostV1CaptureDocumentsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CaptureDocumentsListResponse> PostV1CaptureDocumentsListAsync(
        PostV1CaptureDocumentsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CaptureDocumentsDeleteResponse> PostV1CaptureDocumentsDeleteAsync(
        PostV1CaptureDocumentsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CaptureDocumentsConfirmResponse> SaveTheReviewedDraftAsAPurchaseInvoiceAndAttachTheOriginalDocumentAsync(
        PostV1CaptureDocumentsConfirmRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
