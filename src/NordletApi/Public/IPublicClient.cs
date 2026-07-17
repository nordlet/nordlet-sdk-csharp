namespace NordletApi;

public partial interface IPublicClient
{
    WithRawResponseTask<PostV1PublicIntegrationRequestsResponse> PostV1PublicIntegrationRequestsAsync(
        PostV1PublicIntegrationRequestsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
