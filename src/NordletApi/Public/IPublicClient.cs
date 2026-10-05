namespace NordletApi;

public partial interface IPublicClient
{
    WithRawResponseTask<IntegrationRequestsPublicResponse> IntegrationRequestsAsync(
        IntegrationRequestsPublicRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask PayAsync(
        PayPublicRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
