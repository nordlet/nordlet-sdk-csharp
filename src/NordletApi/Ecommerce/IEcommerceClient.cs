namespace NordletApi;

public partial interface IEcommerceClient
{
    WithRawResponseTask<OrdersCreateEcommerceResponse> OrdersCreateAsync(
        OrdersCreateEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersGetEcommerceResponse> OrdersGetAsync(
        OrdersGetEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersListEcommerceResponse> OrdersListAsync(
        OrdersListEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersReserveEcommerceResponse> OrdersReserveAsync(
        OrdersReserveEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersFulfillEcommerceResponse> OrdersFulfillAsync(
        OrdersFulfillEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersCancelEcommerceResponse> OrdersCancelAsync(
        OrdersCancelEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ProductsListEcommerceResponse> ProductsListAsync(
        ProductsListEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StockListEcommerceResponse> StockListAsync(
        StockListEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
