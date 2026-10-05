namespace NordletApi;

public partial interface IWebhooksClient
{
    WithRawResponseTask<SubscriptionsCreateWebhooksResponse> SubscriptionsCreateAsync(
        SubscriptionsCreateWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SubscriptionsListWebhooksResponse> SubscriptionsListAsync(
        SubscriptionsListWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SubscriptionsUpdateWebhooksResponse> SubscriptionsUpdateAsync(
        SubscriptionsUpdateWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SubscriptionsDeleteWebhooksResponse> SubscriptionsDeleteAsync(
        SubscriptionsDeleteWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DeliveriesListWebhooksResponse> DeliveriesListAsync(
        DeliveriesListWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DeliveriesRedeliverWebhooksResponse> DeliveriesRedeliverAsync(
        DeliveriesRedeliverWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
