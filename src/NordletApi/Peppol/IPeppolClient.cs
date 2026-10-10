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

    WithRawResponseTask<WebhooksPeppolResponse> WebhooksAsync(
        WebhooksPeppolRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
