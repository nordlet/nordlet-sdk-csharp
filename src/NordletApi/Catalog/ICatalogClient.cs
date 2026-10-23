namespace NordletApi;

public partial interface ICatalogClient
{
    /// <summary>
    /// Create a catalog item: a product, a service or a set of other items. `unit` must be `vnt`, a global measurement unit or one of the company's own units (`catalog/units/options`), the sale, purchase and expense account codes must be postable accounts of the chart, and `priceFrom`/`priceTo` and `validFrom`/`validTo` must be in order; otherwise 422. A `set` needs at least one component and none of them may be a set; `components` on any other type is refused with 422. 409 when an active item already carries the `code`. `documentRef` is the storage key of a file uploaded with `files/upload`, which is attached to the item. Emits `item.created`.
    /// </summary>
    WithRawResponseTask<ItemsCreateCatalogResponse> ItemsCreateAsync(
        ItemsCreateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return one item; a set comes with its components.
    /// </summary>
    WithRawResponseTask<ItemsGetCatalogResponse> ItemsGetAsync(
        ItemsGetCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change the fields of an item; the fields that are nullable in the request can be set to null to clear them. The checks of `catalog/items/create` apply. `components` replaces the whole component list and is accepted only when the item is or becomes a set (422); turning an item into a set needs components and is refused with 409 while the item is itself a component of another set. Turning a set into another type removes its components. 409 when an active item already carries the new `code`. Emits `item.updated`.
    /// </summary>
    WithRawResponseTask<ItemsUpdateCatalogResponse> ItemsUpdateAsync(
        ItemsUpdateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Soft-delete an item. Refused with 409 while the item is a component of an active set. Emits `item.deleted`.
    /// </summary>
    WithRawResponseTask<ItemsDeleteCatalogResponse> ItemsDeleteAsync(
        ItemsDeleteCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the active items. Filterable: name, code, barcode, type, vatClassifierCode, groupId, kindId, externalId, manufacturer, department. Sortable: name, code, createdAt, updatedAt, salePriceExclVat; default name ascending. Rows carry no components; `catalog/items/get` returns them.
    /// </summary>
    WithRawResponseTask<ItemsListCatalogResponse> ItemsListAsync(
        ItemsListCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the files attached to an item, newest first.
    /// </summary>
    WithRawResponseTask<ItemsFilesListCatalogResponse> ItemsFilesListAsync(
        ItemsFilesListCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create an item kind: a code, a name, the SAF-T item type, whether quantities are accounted for, and a sort order. 409 when the code already exists.
    /// </summary>
    WithRawResponseTask<ItemsKindsCreateCatalogResponse> ItemsKindsCreateAsync(
        ItemsKindsCreateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change an item kind. 409 when the new code already exists.
    /// </summary>
    WithRawResponseTask<ItemsKindsUpdateCatalogResponse> ItemsKindsUpdateAsync(
        ItemsKindsUpdateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete an item kind. Refused with 409 while an active item uses it; soft-deleted items that still carry it are detached.
    /// </summary>
    WithRawResponseTask<ItemsKindsDeleteCatalogResponse> ItemsKindsDeleteAsync(
        ItemsKindsDeleteCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the company's item kinds in sort order, then by code.
    /// </summary>
    WithRawResponseTask<ItemsKindsListCatalogResponse> ItemsKindsListAsync(
        ItemsKindsListCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a unit of measure of the company's own, in addition to the global measurement units (`reference/units/list`). 409 when the code already exists.
    /// </summary>
    WithRawResponseTask<UnitsCreateCatalogResponse> UnitsCreateAsync(
        UnitsCreateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change the code, name or active flag of a company unit. 409 when the new code already exists.
    /// </summary>
    WithRawResponseTask<UnitsUpdateCatalogResponse> UnitsUpdateAsync(
        UnitsUpdateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a company unit of measure.
    /// </summary>
    WithRawResponseTask<UnitsDeleteCatalogResponse> UnitsDeleteAsync(
        UnitsDeleteCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the company's own units of measure, ordered by code.
    /// </summary>
    WithRawResponseTask<UnitsListCatalogResponse> UnitsListAsync(
        UnitsListCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return the unit codes an item can use: the company's active own units first, then the global measurement units, named in the requested `locale` (Lithuanian for `lt`, English otherwise). A company unit hides a global unit with the same code.
    /// </summary>
    WithRawResponseTask<UnitsOptionsCatalogResponse> UnitsOptionsAsync(
        UnitsOptionsCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create an item group, optionally under `parentId`. 409 when the code already exists.
    /// </summary>
    WithRawResponseTask<ItemGroupsCreateCatalogResponse> ItemGroupsCreateAsync(
        ItemGroupsCreateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change the code, name or parent of an item group; `parentId` null moves it to the top level. 422 when the new parent is the group itself or one of its descendants. 409 when the new code already exists.
    /// </summary>
    WithRawResponseTask<ItemGroupsUpdateCatalogResponse> ItemGroupsUpdateAsync(
        ItemGroupsUpdateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete an item group. Refused with 409 while it has child groups or active items assigned.
    /// </summary>
    WithRawResponseTask<ItemGroupsDeleteCatalogResponse> ItemGroupsDeleteAsync(
        ItemGroupsDeleteCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the company's item groups, ordered by code.
    /// </summary>
    WithRawResponseTask<ItemGroupsListCatalogResponse> ItemGroupsListAsync(
        ItemGroupsListCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create or replace the supplier record of an item for a partner (one per item and partner): supplier code, purchase price excluding VAT, currency (EUR when omitted) and notes. Fields omitted from the request are cleared on an existing record.
    /// </summary>
    WithRawResponseTask<ItemsSuppliersUpsertCatalogResponse> ItemsSuppliersUpsertAsync(
        ItemsSuppliersUpsertCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the supplier records, optionally for one `itemId` and/or `partnerId`, ordered by partner name.
    /// </summary>
    WithRawResponseTask<ItemsSuppliersListCatalogResponse> ItemsSuppliersListAsync(
        ItemsSuppliersListCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete the supplier record of an item.
    /// </summary>
    WithRawResponseTask<ItemsSuppliersDeleteCatalogResponse> ItemsSuppliersDeleteAsync(
        ItemsSuppliersDeleteCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a price list (currency EUR and active when omitted). 409 when the code already exists.
    /// </summary>
    WithRawResponseTask<PriceListsCreateCatalogResponse> PriceListsCreateAsync(
        PriceListsCreateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change a price list. 409 when the new code already exists.
    /// </summary>
    WithRawResponseTask<PriceListsUpdateCatalogResponse> PriceListsUpdateAsync(
        PriceListsUpdateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the company's price lists, ordered by code.
    /// </summary>
    WithRawResponseTask<PriceListsListCatalogResponse> PriceListsListAsync(
        PriceListsListCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Set the unit price excluding VAT of up to 500 items on a price list; a price already on the list is replaced and the other items on the list are kept. 422 when an item appears twice in the request. Emits `price_list.updated` with the item ids.
    /// </summary>
    WithRawResponseTask<PriceListsItemsSetCatalogResponse> PriceListsItemsSetAsync(
        PriceListsItemsSetCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the prices of a price list with the item name and code, ordered by item name.
    /// </summary>
    WithRawResponseTask<PriceListsItemsListCatalogResponse> PriceListsItemsListAsync(
        PriceListsItemsListCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove one item from a price list.
    /// </summary>
    WithRawResponseTask<PriceListsItemsDeleteCatalogResponse> PriceListsItemsDeleteAsync(
        PriceListsItemsDeleteCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
