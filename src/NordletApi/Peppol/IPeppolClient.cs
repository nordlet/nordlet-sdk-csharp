namespace NordletApi;

public partial interface IPeppolClient
{
    /// <summary>
    /// Look a receiver up on the Peppol network (SML and SMP) and say which Peppol BIS Billing 3.0 documents it accepts. Give `partnerId` to look up a partner by its Peppol ID, VAT code or registration code, or `participantId` as "&lt;scheme&gt;:&lt;identifier&gt;". Works without an access point.
    /// </summary>
    WithRawResponseTask<ParticipantsLookupPeppolResponse> ParticipantsLookupAsync(
        ParticipantsLookupPeppolRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Apply one event: a delivery status event updates the Peppol status of the sale invoice with that message id and, when the status changes, emits `sale_invoice.peppol_delivered`, `sale_invoice.peppol_rejected` or `sale_invoice.peppol_failed`; a received-document event fetches the document from the access point, stores it as a document capture with the matched supplier, emits `document_capture.peppol_received` and marks it read at the access point (a document already stored is skipped). `handled` is false when the event matched no invoice or document. Answers 404 when no company uses that provider account, 401 when the signature does not match.
    /// </summary>
    WithRawResponseTask<WebhooksPeppolResponse> WebhooksAsync(
        WebhooksPeppolRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
