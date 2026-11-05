namespace NordletApi;

public partial interface IWebhooksClient
{
    /// <summary>
    /// Register a webhook endpoint for the given event types (`*` for every event). The URL must be an https address that resolves to a public network (422 otherwise). The signing secret is generated unless `secret` is given (at least 32 characters), and this call is the only one that returns it. Answers 503 when the platform encryption key is not configured.
    /// </summary>
    WithRawResponseTask<SubscriptionsCreateWebhooksResponse> SubscriptionsCreateAsync(
        SubscriptionsCreateWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the company's webhook subscriptions with their last delivery state. Filterable by `url` and `isActive`; sortable by `createdAt` and `url`.
    /// </summary>
    WithRawResponseTask<SubscriptionsListWebhooksResponse> SubscriptionsListAsync(
        SubscriptionsListWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replace the signing secret of a subscription and return the new one; this call is the only one that returns it. The secret is generated unless `secret` is given (at least 32 characters). For 24 hours `x-nordlet-signature-v2` carries two `v1=` values, one with the new secret and one with the previous one, so a receiver can switch secrets without refusing deliveries; `x-nordlet-signature` uses the new secret only. Answers 404 for an unknown subscription and 503 when the platform encryption key is not configured.
    /// </summary>
    WithRawResponseTask<SubscriptionsRotateSecretWebhooksResponse> SubscriptionsRotateSecretAsync(
        SubscriptionsRotateSecretWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change the URL, event types or `isActive` flag of a subscription; at least one field is required (400) and a new URL must be an https address that resolves to a public network (422). Setting `isActive` to true also clears `pausedAt` and `consecutiveFailures`, which is how a subscription paused after 5 failed deliveries in a row is switched back on.
    /// </summary>
    WithRawResponseTask<SubscriptionsUpdateWebhooksResponse> SubscriptionsUpdateAsync(
        SubscriptionsUpdateWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a webhook subscription.
    /// </summary>
    WithRawResponseTask<SubscriptionsDeleteWebhooksResponse> SubscriptionsDeleteAsync(
        SubscriptionsDeleteWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the company's webhook deliveries, newest first. Filterable by `status`, `eventType` and `subscriptionId`; sortable by `createdAt`.
    /// </summary>
    WithRawResponseTask<DeliveriesListWebhooksResponse> DeliveriesListAsync(
        DeliveriesListWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Send a delivery again now: its status goes back to `pending` with the attempt count and last error cleared. Answers 409 when the subscription is inactive.
    /// </summary>
    WithRawResponseTask<DeliveriesRedeliverWebhooksResponse> DeliveriesRedeliverAsync(
        DeliveriesRedeliverWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
