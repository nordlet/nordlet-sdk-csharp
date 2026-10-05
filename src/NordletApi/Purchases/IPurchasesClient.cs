namespace NordletApi;

public partial interface IPurchasesClient
{
    WithRawResponseTask<InvoicesCreatePurchasesResponse> InvoicesCreateAsync(
        InvoicesCreatePurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesGetPurchasesResponse> InvoicesGetAsync(
        InvoicesGetPurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesUpdatePurchasesResponse> InvoicesUpdateAsync(
        InvoicesUpdatePurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesDeletePurchasesResponse> InvoicesDeleteAsync(
        InvoicesDeletePurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesRegisterPurchasesResponse> InvoicesRegisterAsync(
        InvoicesRegisterPurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesListPurchasesResponse> InvoicesListAsync(
        InvoicesListPurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersCreatePurchasesResponse> OrdersCreateAsync(
        OrdersCreatePurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersUpdatePurchasesResponse> OrdersUpdateAsync(
        OrdersUpdatePurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersGetPurchasesResponse> OrdersGetAsync(
        OrdersGetPurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersListPurchasesResponse> OrdersListAsync(
        OrdersListPurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersSubmitPurchasesResponse> OrdersSubmitAsync(
        OrdersSubmitPurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersApprovePurchasesResponse> OrdersApproveAsync(
        OrdersApprovePurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersRejectPurchasesResponse> OrdersRejectAsync(
        OrdersRejectPurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersCancelPurchasesResponse> OrdersCancelAsync(
        OrdersCancelPurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersClosePurchasesResponse> OrdersCloseAsync(
        OrdersClosePurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersDeletePurchasesResponse> OrdersDeleteAsync(
        OrdersDeletePurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReceiptsCreatePurchasesResponse> ReceiptsCreateAsync(
        ReceiptsCreatePurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReceiptsGetPurchasesResponse> ReceiptsGetAsync(
        ReceiptsGetPurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReceiptsListPurchasesResponse> ReceiptsListAsync(
        ReceiptsListPurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvoicesMatchPurchasesResponse> InvoicesMatchAsync(
        InvoicesMatchPurchasesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
