namespace NordletApi;

public partial interface IBillingClient
{
    /// <summary>
    /// Return the signed-in user's billing account of the site named by the `x-nordlet-site` header (`app` when absent): plan, account type, status, balance, trial and payment state, the month-to-date usage of that site in the companies the user pays for with an estimate of today's charge, the plan catalogue, and the top-up, automatic top-up and overdraft settings. Each site has its own account and plan.
    /// </summary>
    WithRawResponseTask<AccountGetBillingResponse> AccountGetAsync(
        AccountGetBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change the plan of the user's flat-rate billing account of the request's site; answers 422 when the plan is not one of that site's plans and 409 when the account type is not `flat_rate`. With a Stripe subscription and payments configured, the subscription is moved to the new plan.
    /// </summary>
    WithRawResponseTask<AccountSetPlanBillingResponse> AccountSetPlanAsync(
        AccountSetPlanBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Switch the user's billing account of the request's site between `flat_rate` and `per_request`; answers 422 for an account type the site does not offer (the `invoice` site has `flat_rate` only). With a Stripe subscription and payments configured, the subscription is moved to the plan's price for `flat_rate`; for `per_request` the plan is taken off the subscription, and a subscription that carried only the plan is cancelled, leaving the account without one. When Stripe refuses the change, the previous account type is restored.
    /// </summary>
    WithRawResponseTask<AccountSetAccountTypeBillingResponse> AccountSetAccountTypeAsync(
        AccountSetAccountTypeBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Switch automatic top-ups on or off and set their amount; answers 409 on a site without top-ups. Switching them on needs a Stripe customer, which the first card top-up creates (400 otherwise); when switched on, a top-up is charged at once if the balance is at or below zero, no payment has failed and no top-up was requested in the last 24 hours.
    /// </summary>
    WithRawResponseTask<AccountSetAutoTopUpBillingResponse> AccountSetAutoTopUpAsync(
        AccountSetAutoTopUpBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Set the overdraft cap of the user's billing account: how far usage charges may take the balance below zero before the account is suspended. A suspended account whose balance is within the new cap is activated again. Answers 409 on a site without top-ups.
    /// </summary>
    WithRawResponseTask<AccountSetOverdraftCapBillingResponse> AccountSetOverdraftCapAsync(
        AccountSetOverdraftCapBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Open a Stripe Checkout session for a one-time credit top-up of `amountCents` and return its URL; a Stripe customer is created for the user when there is none. `returnTo` chooses whether Checkout returns to the credits page or to the onboarding plan page, in `locale`. Answers 409 on a site without top-ups and 503 when online payments are not configured.
    /// </summary>
    WithRawResponseTask<TopupCreateBillingResponse> TopupCreateAsync(
        TopupCreateBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Confirm a paid top-up Checkout session by `sessionId` and credit the account at once instead of waiting for the Stripe webhook; a session is credited only once. Answers 404 when the session is not the user's own or is not paid, and 409 on a site without top-ups.
    /// </summary>
    WithRawResponseTask<TopupConfirmBillingResponse> TopupConfirmAsync(
        TopupConfirmBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Open a Stripe Checkout session for a flat-rate subscription on `plan` (by default the first plan of the request's site) for the billing account of the request's site, with the trial period of `trialDays` days, and return its URL; a Stripe customer is created for that account when it has none. The `invoicing` plan of the `invoice` site takes its trial days from the server setting `INVOICE_PLAN_TRIAL_DAYS` and returns to the invoice app. Answers 422 when the plan is not one of the site's plans, 409 when the site's flat-rate subscription is already active and 503 when online payments are not configured, the plan has no price, or the Invoicing trial is not set.
    /// </summary>
    WithRawResponseTask<FlatRateCreateBillingResponse> FlatRateCreateAsync(
        FlatRateCreateBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Confirm a completed flat-rate Checkout session by `sessionId`: the billing account of the site of the session's plan becomes `flat_rate` on that plan with status `active` and the subscription attached, unless the Stripe webhook already did this. Answers 404 when the session is not the user's own or not completed.
    /// </summary>
    WithRawResponseTask<FlatRateConfirmBillingResponse> FlatRateConfirmAsync(
        FlatRateConfirmBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancel the Stripe subscription of the user's billing account of the request's site at the end of the period already paid: the plan stays active until `subscriptionCancelAt`, and Stripe then ends the subscription, which its `customer.subscription.deleted` webhook records. Answers 503 when online payments are not configured and 409 when the account has no subscription.
    /// </summary>
    WithRawResponseTask<SubscriptionCancelBillingResponse> SubscriptionCancelAsync(
        SubscriptionCancelBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Open a Stripe customer portal session for the billing account of the request's site that returns to that site's credits page (the plan page on the `invoice` site) in `locale`, and return its URL. Answers 503 when online payments are not configured and 400 when the account has no Stripe customer yet.
    /// </summary>
    WithRawResponseTask<PortalCreateBillingResponse> PortalCreateAsync(
        PortalCreateBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the newest credit transactions of the user's billing account of the request's site, up to `limit`: trial grants, top-ups, usage charges, activations and adjustments, each with the balance after it.
    /// </summary>
    WithRawResponseTask<TransactionsListBillingResponse> TransactionsListAsync(
        TransactionsListBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the daily usage records of the request's site in the companies the user pays for, from `from` to `to`: one row per company, date and metric (API requests, OCR pages, file storage bytes, database bytes, sale invoices). Requests, OCR pages and invoices count on the site the request came from; storage counts on the `app` site.
    /// </summary>
    WithRawResponseTask<UsageListBillingResponse> UsageListAsync(
        UsageListBillingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
