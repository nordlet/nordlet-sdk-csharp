namespace NordletApi;

public partial interface IInventoryClient
{
    /// <summary>
    /// Return the company's negative stock policy.
    /// </summary>
    WithRawResponseTask<SettingsGetInventoryResponse> SettingsGetAsync(
        SettingsGetInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Set the negative stock policy. With `reject` a consumption larger than the stock on hand of the item in the warehouse is refused with 422. With `allow` the missing quantity is written as a shortage priced at the unit cost of the last receipt in that warehouse (the item's purchase price when there is none); the next receipt of the item there settles the shortage and posts any cost difference between `inventory.cogs` and `inventory.stock`. A consumption from a named lot is refused with 422 under both policies.
    /// </summary>
    WithRawResponseTask<SettingsUpdateInventoryResponse> SettingsUpdateAsync(
        SettingsUpdateInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a warehouse. 409 when the code already exists.
    /// </summary>
    WithRawResponseTask<WarehousesCreateInventoryResponse> WarehousesCreateAsync(
        WarehousesCreateInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the warehouses. Filterable and sortable: code, name.
    /// </summary>
    WithRawResponseTask<WarehousesListInventoryResponse> WarehousesListAsync(
        WarehousesListInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change the name or the country code of a warehouse.
    /// </summary>
    WithRawResponseTask<WarehousesUpdateInventoryResponse> WarehousesUpdateAsync(
        WarehousesUpdateInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Record a manual receipt of an item into a warehouse at `unitCost` (document type `manual_receipt`); the quantity must be positive (422). A lot- or serial-tracked item needs `lotNumber` (422); an unknown lot is created, and `expiryDate` is stored on a lot that has none. A serial-tracked item is received one unit at a time (422), and 409 when that serial number is already in stock. Open shortages of the item in the warehouse (negative stock policy `allow`) are settled from the receipt. Emits `stock.changed`. Receipts against a purchase order go through `purchases/receipts/create`.
    /// </summary>
    WithRawResponseTask<StockReceiveInventoryResponse> StockReceiveAsync(
        StockReceiveInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Consume a quantity of an item from a warehouse, oldest layers first (from one lot when `lotNumber` is given), and post a journal entry: debit the expense account (`expenseAccountCode`, default the chart's inventory expense account), credit the stock account each consumed layer was received on (the chart's inventory account for layers without one), or `inventoryAccountCode` for the whole cost when given. 409 when the accounting period of `date` is locked; 422 when the stock is insufficient under the `reject` policy or in the named lot. Emits `stock.changed` and, when the consumption takes the available quantity from above a reorder rule's minimum to at or below it, `stock.reorder_needed`.
    /// </summary>
    WithRawResponseTask<StockWriteOffInventoryResponse> StockWriteOffAsync(
        StockWriteOffInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Move a quantity of an item from one warehouse to another: the source layers are consumed oldest first (from one lot when `lotNumber` is given) and received in the target with the same quantities, costs, lots and stock accounts (document type `warehouse_transfer`). 422 when both warehouses are the same or the source stock is insufficient under the `reject` policy. `inMovementId` is the first receipt when the consumption spans several lots or stock accounts. Emits `stock.changed` for both warehouses and `stock.reorder_needed` as `inventory/stock/write-off` does.
    /// </summary>
    WithRawResponseTask<StockTransferInventoryResponse> StockTransferAsync(
        StockTransferInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Post a stock count for a warehouse. Each line names an item by `itemId` or `barcode` with its `countedQty`; the difference to the quantity on hand in the warehouse (all lots together) is written off oldest layers first or received as a surplus at `unitCost` (the item's purchase price when omitted; 422 when neither is set), with document type `stock_take`, and a surplus of a lot- or serial-tracked item needs `lotNumber` (422). The shortage cost less the surplus cost is posted in one journal entry between the expense account (`expenseAccountCode`, default the chart's inventory expense account) and the stock accounts (`inventoryAccountCode` for everything when given, else the accounts of the consumed layers and the chart's inventory account for the surpluses); nothing is posted and `journalTransactionId` is null when the net is zero. 409 when the accounting period of `date` is locked. Emits `stock.changed` per adjusted item.
    /// </summary>
    WithRawResponseTask<StockTakeInventoryResponse> StockTakeAsync(
        StockTakeInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return the quantity and value on hand per item and warehouse, summed from the stock movements, optionally for one `warehouseId` and/or `itemId`. Rows with a zero quantity are left out.
    /// </summary>
    WithRawResponseTask<StockLevelsInventoryResponse> StockLevelsAsync(
        StockLevelsInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the stock movements. Filterable: itemId, warehouseId, lotId, direction, documentType, date, quantity, totalCost. Sortable: date, createdAt, quantity, totalCost; default newest first.
    /// </summary>
    WithRawResponseTask<StockMovementsListInventoryResponse> StockMovementsListAsync(
        StockMovementsListInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the lots with their quantity on hand (the remaining quantity of the lot's incoming movements). Filterable: itemId, lotNumber, expiryDate. Sortable: lotNumber, expiryDate, createdAt; default newest first.
    /// </summary>
    WithRawResponseTask<LotsListInventoryResponse> LotsListAsync(
        LotsListInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return a lot with its quantity on hand and its movements in date order.
    /// </summary>
    WithRawResponseTask<LotsGetInventoryResponse> LotsGetAsync(
        LotsGetInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change the expiry date or the notes of a lot; null clears the value.
    /// </summary>
    WithRawResponseTask<LotsUpdateInventoryResponse> LotsUpdateAsync(
        LotsUpdateInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Allocate an extra cost `amount` (positive, whole cents; 422 otherwise) over incoming stock movements, named by `movementIds` or taken from the lines of a goods receipt (`goodsReceiptId`; 422 when the receipt has no stock movements), in proportion to their cost (`by_value`) or quantity (`by_quantity`), largest remainder to the cent. The part of each share that belongs to the quantity still on hand raises the movement's remaining cost and recomputes its unit cost; the part that belongs to quantity already consumed is posted in a journal entry dated `date` debiting `inventory.cogs` and crediting the movement's stock account (`inventory.stock` when it has none), 409 when that period is locked. 422 when a movement is not incoming or the weights sum to zero. `sourceInvoiceId` records the purchase invoice the cost came from. Goods receipts come from `purchases/receipts/create`.
    /// </summary>
    WithRawResponseTask<LandedCostsCreateInventoryResponse> LandedCostsCreateAsync(
        LandedCostsCreateInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return a landed cost with its allocation lines and the journal transaction it posted, if any.
    /// </summary>
    WithRawResponseTask<LandedCostsGetInventoryResponse> LandedCostsGetAsync(
        LandedCostsGetInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the landed costs without their lines. Filterable: date, method, goodsReceiptId, sourceInvoiceId. Sortable: date, createdAt, amount; default newest first.
    /// </summary>
    WithRawResponseTask<LandedCostsListInventoryResponse> LandedCostsListAsync(
        LandedCostsListInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a reorder rule for an item, for one warehouse or, without `warehouseId`, for the item over all warehouses; one rule per item and warehouse (409). While the rule is active, an outgoing movement or a reservation that takes the available quantity (on hand less reserved) from above `minQty` to at or below it emits `stock.reorder_needed` with the `reorderQty`. `inventory/reorder-rules/check` lists the rules currently at or below their minimum.
    /// </summary>
    WithRawResponseTask<ReorderRulesCreateInventoryResponse> ReorderRulesCreateAsync(
        ReorderRulesCreateInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change the minimum quantity, the reorder quantity (null clears it), the active flag or the notes of a reorder rule.
    /// </summary>
    WithRawResponseTask<ReorderRulesUpdateInventoryResponse> ReorderRulesUpdateAsync(
        ReorderRulesUpdateInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a reorder rule.
    /// </summary>
    WithRawResponseTask<ReorderRulesDeleteInventoryResponse> ReorderRulesDeleteAsync(
        ReorderRulesDeleteInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the reorder rules. Filterable: itemId, warehouseId, isActive. Sortable: createdAt, minQty; default newest first.
    /// </summary>
    WithRawResponseTask<ReorderRulesListInventoryResponse> ReorderRulesListAsync(
        ReorderRulesListInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return the active reorder rules whose available quantity (on hand less reserved, in the rule's warehouse or over all warehouses) is at or below `minQty`, with the quantities. Emits no event.
    /// </summary>
    WithRawResponseTask<ReorderRulesCheckInventoryResponse> ReorderRulesCheckAsync(
        ReorderRulesCheckInventoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
