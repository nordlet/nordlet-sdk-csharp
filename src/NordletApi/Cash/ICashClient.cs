namespace NordletApi;

public partial interface ICashClient
{
    /// <summary>
    /// Creates a numbered cash receipt (series `KPO`) or cash disbursement (`KIO`) and posts it in the base currency between the cash account (`cashAccountCode`, default the cash account of the company's chart) and `counterAccountCode`; a receipt debits the cash account, a disbursement credits it. Linked to an invoice - `saleInvoiceId` for a receipt against an issued invoice or advance invoice or a disbursement against an issued credit note, `purchaseInvoiceId` for a disbursement against a registered purchase invoice - the counter account is the receivable or payable account of the posting rules, the invoice's paid amount and payment status (`partial` or `paid`) are updated, and `sale_invoice.paid` or `purchase_invoice.paid` is emitted when the invoice becomes fully paid. Answers 422 when both invoice ids are given, a receipt names a purchase invoice, `counterAccountCode` differs from the invoice's account, or the invoice is in another currency or belongs to another partner; 409 when `amount` exceeds the invoice's remaining amount or the accounting period of `date` is locked.
    /// </summary>
    WithRawResponseTask<OrdersCreateCashResponse> OrdersCreateAsync(
        OrdersCreateCashRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns one cash order.
    /// </summary>
    WithRawResponseTask<OrdersGetCashResponse> OrdersGetAsync(
        OrdersGetCashRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists cash orders. Filterable by `type`, `date`, `partnerId`, `employeeId`, `fullNumber` and `amount`; sortable by `date`, `fullNumber`, `createdAt` and `amount`.
    /// </summary>
    WithRawResponseTask<OrdersListCashResponse> OrdersListAsync(
        OrdersListCashRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the balance of a cash account (default: the cash account of the company's chart) from the posted journal entries, up to and including `asOf` when given.
    /// </summary>
    WithRawResponseTask<BalanceCashResponse> BalanceAsync(
        BalanceCashRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a numbered expense report (series `AA`) for the employee and posts it: each line's net amount is debited to its `accountCode` and the VAT total to the input VAT account of the posting rules (`purchases.vatReceivable`), or the gross amount to the line account when the company is not a VAT payer, and the total is credited to the cash advances account (`cash.advances`), which settles the employee's advance balance shown by `cash/advance-holders/balances`. Answers 422 when the total is zero or a line account is missing from the chart or not postable, and 409 when the accounting period of `date` is locked.
    /// </summary>
    WithRawResponseTask<ExpenseReportsCreateCashResponse> ExpenseReportsCreateAsync(
        ExpenseReportsCreateCashRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns one expense report with its lines.
    /// </summary>
    WithRawResponseTask<ExpenseReportsGetCashResponse> ExpenseReportsGetAsync(
        ExpenseReportsGetCashRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists expense reports without their lines. Filterable by `employeeId` and `date`; sortable by `date` and `number`.
    /// </summary>
    WithRawResponseTask<ExpenseReportsListCashResponse> ExpenseReportsListAsync(
        ExpenseReportsListCashRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns, per employee, the cash advances issued to them (disbursements posted to the `cash.advances` account with the employee set), the amounts returned (receipts on the same account), the total settled by expense reports and the open balance (issued less returned less settled).
    /// </summary>
    WithRawResponseTask<AdvanceHoldersBalancesCashResponse> AdvanceHoldersBalancesAsync(
        AdvanceHoldersBalancesCashRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
