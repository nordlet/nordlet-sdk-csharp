namespace NordletApi;

public partial interface IProductionClient
{
    /// <summary>
    /// Create a work center with its `costPerHour`. `costAccountCode` must be a postable account of the chart (422 otherwise); when a production order completes, the labor cost of the operations run on this center is credited to it instead of the `production.laborApplied` posting rule account. A duplicate `code` is refused with 409.
    /// </summary>
    WithRawResponseTask<WorkCentersCreateProductionResponse> WorkCentersCreateAsync(
        WorkCentersCreateProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change a work center; only the fields sent are changed. `costAccountCode` must be a postable account of the chart (422 otherwise); a `code` already used by another work center is refused with 409.
    /// </summary>
    WithRawResponseTask<WorkCentersUpdateProductionResponse> WorkCentersUpdateAsync(
        WorkCentersUpdateProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List work centers. `nextMaintenanceDate` is the latest completed maintenance date (the creation date when there is none) plus `maintenanceIntervalDays`, null without an interval. Filterable by `code`, `name` and `isActive`; sortable by `code`, `name` and `createdAt`.
    /// </summary>
    WithRawResponseTask<WorkCentersListProductionResponse> WorkCentersListAsync(
        WorkCentersListProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a routing with its operations: `sequence`, work center, `setupMinutes`, `runMinutesPerUnit` and an optional `qualityCheckName` that becomes a pending quality check on every production order using the routing. Operation sequences must be unique (422); a duplicate `code` is refused with 409.
    /// </summary>
    WithRawResponseTask<RoutingsCreateProductionResponse> RoutingsCreateAsync(
        RoutingsCreateProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return one routing with its operations in sequence order.
    /// </summary>
    WithRawResponseTask<RoutingsGetProductionResponse> RoutingsGetAsync(
        RoutingsGetProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List routings without their operations. Filterable by `code`, `name` and `isActive`; sortable by `code`, `name` and `createdAt`.
    /// </summary>
    WithRawResponseTask<RoutingsListProductionResponse> RoutingsListAsync(
        RoutingsListProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Record a `preventive` or `corrective` maintenance planned for a work center on `plannedDate`; it starts as `planned`. `purchaseInvoiceId` links the purchase invoice that books its cost (422 when it is not a purchase invoice of the company or is a credit note). Maintenance posts nothing to the ledger itself.
    /// </summary>
    WithRawResponseTask<MaintenanceCreateProductionResponse> MaintenanceCreateAsync(
        MaintenanceCreateProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Mark a `planned` maintenance as completed on `completedDate`, with optional `downtimeHours` and `cost` (409 when it is already completed or cancelled). The work center's `nextMaintenanceDate` is then counted from the latest completed maintenance date. `purchaseInvoiceId` links the purchase invoice that books the cost, as on `production/maintenance/create`; the cost is not posted to the ledger, with or without the link.
    /// </summary>
    WithRawResponseTask<MaintenanceCompleteProductionResponse> MaintenanceCompleteAsync(
        MaintenanceCompleteProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancel a `planned` maintenance (409 when it is already completed or cancelled).
    /// </summary>
    WithRawResponseTask<MaintenanceCancelProductionResponse> MaintenanceCancelAsync(
        MaintenanceCancelProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List maintenance records. Filterable by `workCenterId`, `status` and `type`; sortable by `plannedDate` and `createdAt`.
    /// </summary>
    WithRawResponseTask<MaintenanceListProductionResponse> MaintenanceListAsync(
        MaintenanceListProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a bill of materials for a finished item. `outputQuantity` is the finished quantity made per unit of order quantity; each line's `quantity` is the component consumed per unit of order quantity, increased by its `scrapPercent` at completion; `routingId` is the default routing of assembly orders. A BOM that consumes its own finished item is refused with 422, a duplicate `code` with 409.
    /// </summary>
    WithRawResponseTask<BomsCreateProductionResponse> BomsCreateAsync(
        BomsCreateProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return one bill of materials with its component lines.
    /// </summary>
    WithRawResponseTask<BomsGetProductionResponse> BomsGetAsync(
        BomsGetProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List bills of materials without their lines. Filterable by `code`, `name`, `finishedItemId` and `isActive`; sortable by `code` and `name`.
    /// </summary>
    WithRawResponseTask<BomsListProductionResponse> BomsListAsync(
        BomsListProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a draft production order for `quantity` units of a BOM in a warehouse; stock moves only at `production/orders/complete`. An `assembly` order takes its routing from `routingId`, else from the BOM, and copies the routing's operations onto the order (`plannedMinutes` = setup minutes + run minutes per unit × finished quantity, priced at the work center's current `costPerHour`) with a pending quality check for every operation that names one. A `routingId` on a `disassembly` order, an inactive routing or a routing without operations is refused with 422.
    /// </summary>
    WithRawResponseTask<OrdersCreateProductionResponse> OrdersCreateAsync(
        OrdersCreateProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Record the `actualMinutes` spent on one operation of a draft production order; at completion the actual minutes, else the planned ones, price the operation's labor cost. Refused with 409 once the order is completed.
    /// </summary>
    WithRawResponseTask<OrdersRecordOperationProductionResponse> OrdersRecordOperationAsync(
        OrdersRecordOperationProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a pending quality check to a draft production order (409 once the order is completed). The order cannot complete while a check is pending or failed.
    /// </summary>
    WithRawResponseTask<QualityChecksAddProductionResponse> QualityChecksAddAsync(
        QualityChecksAddProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Record the result of a quality check as `passed` or `failed`, with the time and the actor (409 once the order is completed). `production/orders/complete` answers 409 while a check is `pending` or `failed`; a failed check can be recorded again as `passed`.
    /// </summary>
    WithRawResponseTask<QualityChecksRecordProductionResponse> QualityChecksRecordAsync(
        QualityChecksRecordProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List quality checks. Filterable by `orderId`, `result` and `name`; sortable by `createdAt` and `name`.
    /// </summary>
    WithRawResponseTask<QualityChecksListProductionResponse> QualityChecksListAsync(
        QualityChecksListProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Complete a draft production order on the order's date. An `assembly` consumes the components from the warehouse, the first-expiring lot first (lots without an expiry date after those with one, then the oldest layers first), leaving out expired lots (line quantity × order quantity, increased by `scrapPercent`), prices each operation at its actual or planned minutes × `costPerHour`, receives the finished item at material cost + labor cost less the share of `scrappedQuantity`, and, when there is labor, scrap or a component stock account other than the finished one, posts a journal entry debiting the finished stock account (and the `production.scrap` rule account for the scrapped share) and crediting the component stock accounts and the work centers' cost accounts (or the `production.laborApplied` rule account); a `disassembly` consumes the finished item and receives the components at its cost shared by quantity. `componentsAccountCode` and `finishedAccountCode` default to the chart's production accounts; consumed layers without a stock account are credited to the given code, else to the `inventory.stock` rule account. Refused with 409 when the order is already completed, a quality check is still pending or has failed, or the accounting period is locked, and with 422 when the BOM has no lines, `scrappedQuantity` is given on a disassembly or exceeds the finished quantity, the assembly cost is zero, stock is insufficient, a received item needs lot or serial tracking, or a posting account is missing. Emits `stock.changed`.
    /// </summary>
    WithRawResponseTask<OrdersCompleteProductionResponse> OrdersCompleteAsync(
        OrdersCompleteProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return one production order with its operations and quality checks.
    /// </summary>
    WithRawResponseTask<OrdersGetProductionResponse> OrdersGetAsync(
        OrdersGetProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List production orders without operations and quality checks. Filterable by `bomId`, `warehouseId`, `status` and `type`; sortable by `date` and `createdAt`.
    /// </summary>
    WithRawResponseTask<OrdersListProductionResponse> OrdersListAsync(
        OrdersListProductionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
