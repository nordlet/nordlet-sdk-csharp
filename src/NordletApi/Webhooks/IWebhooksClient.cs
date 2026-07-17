namespace NordletApi;

public partial interface IWebhooksClient
{
    WithRawResponseTask<PostV1WebhooksSubscriptionsCreateResponse> PostV1WebhooksSubscriptionsCreateAsync(
        PostV1WebhooksSubscriptionsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1WebhooksSubscriptionsListResponse> PostV1WebhooksSubscriptionsListAsync(
        PostV1WebhooksSubscriptionsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1WebhooksSubscriptionsUpdateResponse> PostV1WebhooksSubscriptionsUpdateAsync(
        PostV1WebhooksSubscriptionsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1WebhooksSubscriptionsDeleteResponse> PostV1WebhooksSubscriptionsDeleteAsync(
        PostV1WebhooksSubscriptionsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1WebhooksDeliveriesListResponse> PostV1WebhooksDeliveriesListAsync(
        PostV1WebhooksDeliveriesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1WebhooksDeliveriesRedeliverResponse> PostV1WebhooksDeliveriesRedeliverAsync(
        PostV1WebhooksDeliveriesRedeliverRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
