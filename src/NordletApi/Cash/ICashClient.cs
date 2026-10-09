namespace NordletApi;

public partial interface ICashClient
{
    WithRawResponseTask<OrdersCreateCashResponse> OrdersCreateAsync(
        OrdersCreateCashRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersGetCashResponse> OrdersGetAsync(
        OrdersGetCashRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrdersListCashResponse> OrdersListAsync(
        OrdersListCashRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<BalanceCashResponse> BalanceAsync(
        BalanceCashRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ExpenseReportsCreateCashResponse> ExpenseReportsCreateAsync(
        ExpenseReportsCreateCashRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ExpenseReportsGetCashResponse> ExpenseReportsGetAsync(
        ExpenseReportsGetCashRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ExpenseReportsListCashResponse> ExpenseReportsListAsync(
        ExpenseReportsListCashRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AdvanceHoldersBalancesCashResponse> AdvanceHoldersBalancesAsync(
        AdvanceHoldersBalancesCashRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
