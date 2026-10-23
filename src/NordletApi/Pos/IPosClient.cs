namespace NordletApi;

public partial interface IPosClient
{
    /// <summary>
    /// Register a cash register (POS device). The serial number must be unique in the company; a repeat is refused with 409.
    /// </summary>
    WithRawResponseTask<DevicesCreatePosResponse> DevicesCreateAsync(
        DevicesCreatePosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change a POS device's details or set `isActive`; an inactive device accepts no new shifts or reports. A serial number already used by another device is refused with 409.
    /// </summary>
    WithRawResponseTask<DevicesUpdatePosResponse> DevicesUpdateAsync(
        DevicesUpdatePosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List POS devices. Filterable by `name` and `serialNumber`; sortable by `name`, `serialNumber` and `createdAt`.
    /// </summary>
    WithRawResponseTask<DevicesListPosResponse> DevicesListAsync(
        DevicesListPosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Record a daily cash register report (Z-report) and post it to the ledger in one journal entry: the cash and card takings are debited to `cashAccountCode` and `cardAccountCode`, the net of the `vatLines` is credited to `revenueAccountCode` and their VAT to `vatAccountCode`. `itemLines` write the sold products off `warehouseId` FIFO (a set is expanded to its product components) and add the cost of goods sold, debited to `cogsAccountCode` against the stock accounts. Account codes default to the company's chart. Refused with 422 when cash plus card differs from the gross total, the item lines have no warehouse or the device is inactive, with 409 when the accounting period is locked or the `reportNumber` already exists. Emits `pos_report.created` and, per item line, `stock.changed`.
    /// </summary>
    WithRawResponseTask<ReportsCreatePosResponse> ReportsCreateAsync(
        ReportsCreatePosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Read one POS report with its VAT lines.
    /// </summary>
    WithRawResponseTask<ReportsGetPosResponse> ReportsGetAsync(
        ReportsGetPosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List POS reports without their VAT lines. Filterable by `date`, `reportNumber` and `deviceId`; sortable by `date`, `reportNumber` and `createdAt`.
    /// </summary>
    WithRawResponseTask<ReportsListPosResponse> ReportsListAsync(
        ReportsListPosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Open a shift on a POS device with the cash float `openingCash`. A device has at most one open shift (409 for a second); an inactive device is refused with 422. Give `warehouseId` when the shift will sell stock items; they are written off that warehouse when the shift is closed.
    /// </summary>
    WithRawResponseTask<ShiftsOpenPosResponse> ShiftsOpenAsync(
        ShiftsOpenPosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Read one POS shift.
    /// </summary>
    WithRawResponseTask<ShiftsGetPosResponse> ShiftsGetAsync(
        ShiftsGetPosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List POS shifts. Filterable by `deviceId` and `status`; sortable by `openedAt`.
    /// </summary>
    WithRawResponseTask<ShiftsListPosResponse> ShiftsListAsync(
        ShiftsListPosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Record a receipt in an open shift, numbered per shift from 1. Each line's net, VAT and gross come from its VAT-inclusive unit price; a line without `description` takes its item's name. Refused with 422 when cash plus card differs from the receipt total or a stock item is sold in a shift opened without a warehouse, with 409 when the shift is closed.
    /// </summary>
    WithRawResponseTask<ReceiptsCreatePosResponse> ReceiptsCreateAsync(
        ReceiptsCreatePosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List receipts without their lines. Filterable by `shiftId`; sortable by `number` and `createdAt`.
    /// </summary>
    WithRawResponseTask<ReceiptsListPosResponse> ReceiptsListAsync(
        ReceiptsListPosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Read one receipt with its lines.
    /// </summary>
    WithRawResponseTask<ReceiptsGetPosResponse> ReceiptsGetAsync(
        ReceiptsGetPosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Close an open shift: its receipts are summed by VAT rate and by product into one POS report, created as by `pos/reports/create` with number `reportNumber` (default `Z-&lt;device serial&gt;-&lt;n&gt;`, n being the device's closed shifts plus one) on `date` (default: the company's today), which posts the takings and the stock write-off to the ledger and emits `pos_report.created`. The response adds `expectedCash` (opening cash plus the cash receipts) and `cashDifference` (`countedCash` less expected). A shift without receipts is refused with 422, a closed one with 409.
    /// </summary>
    WithRawResponseTask<ShiftsClosePosResponse> ShiftsCloseAsync(
        ShiftsClosePosRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
