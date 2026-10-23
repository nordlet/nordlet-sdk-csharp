namespace NordletApi;

public partial interface ITransportClient
{
    /// <summary>
    /// Create a draft waybill to the consignee. The cargo lines are `lines` or, when none are given and `saleInvoiceId` is set, the product lines of that sale invoice (422 when it has none); a line without `description`, `unit` or `productCode` takes them from its item. `documentDate` defaults to the company's today and `series` to `VAZ`.
    /// </summary>
    WithRawResponseTask<WaybillsCreateTransportResponse> WaybillsCreateAsync(
        WaybillsCreateTransportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change a draft waybill; omitted fields keep their value, the optional ones can be cleared with null, and `lines`, when given, replace all existing lines. A waybill that is already issued or cancelled is refused with 409.
    /// </summary>
    WithRawResponseTask<WaybillsUpdateTransportResponse> WaybillsUpdateAsync(
        WaybillsUpdateTransportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Issue a draft waybill: it takes the next number of its `series` for the year of `documentDate` and becomes `issued`. Without a vehicle plate or without lines the call is refused with 422, a waybill that is not a draft with 409. Only issued waybills can go into the Lithuanian i.VAZ file (`declarations/lt/ivaz/generate`) and the Romanian e-Transport declaration (`declarations/ro/etransport/build`).
    /// </summary>
    WithRawResponseTask<WaybillsIssueTransportResponse> WaybillsIssueAsync(
        WaybillsIssueTransportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancel a draft or issued waybill. An already cancelled one is refused with 409.
    /// </summary>
    WithRawResponseTask<WaybillsCancelTransportResponse> WaybillsCancelAsync(
        WaybillsCancelTransportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Read one waybill with its lines.
    /// </summary>
    WithRawResponseTask<WaybillsGetTransportResponse> WaybillsGetAsync(
        WaybillsGetTransportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List waybills with the consignee's name. Filterable by `status`, `consigneePartnerId`, `documentDate`, `fullNumber` and `dispatchAt`; sortable by `createdAt`, `dispatchAt` and `fullNumber`.
    /// </summary>
    WithRawResponseTask<WaybillsListTransportResponse> WaybillsListAsync(
        WaybillsListTransportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
