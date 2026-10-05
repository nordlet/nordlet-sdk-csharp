namespace NordletApi;

public partial interface ICatalogClient
{
    WithRawResponseTask<ItemsCreateCatalogResponse> ItemsCreateAsync(
        ItemsCreateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ItemsGetCatalogResponse> ItemsGetAsync(
        ItemsGetCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ItemsUpdateCatalogResponse> ItemsUpdateAsync(
        ItemsUpdateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ItemsDeleteCatalogResponse> ItemsDeleteAsync(
        ItemsDeleteCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ItemsListCatalogResponse> ItemsListAsync(
        ItemsListCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ItemsFilesListCatalogResponse> ItemsFilesListAsync(
        ItemsFilesListCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ItemsKindsCreateCatalogResponse> ItemsKindsCreateAsync(
        ItemsKindsCreateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ItemsKindsUpdateCatalogResponse> ItemsKindsUpdateAsync(
        ItemsKindsUpdateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ItemsKindsDeleteCatalogResponse> ItemsKindsDeleteAsync(
        ItemsKindsDeleteCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ItemsKindsListCatalogResponse> ItemsKindsListAsync(
        ItemsKindsListCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<UnitsCreateCatalogResponse> UnitsCreateAsync(
        UnitsCreateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<UnitsUpdateCatalogResponse> UnitsUpdateAsync(
        UnitsUpdateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<UnitsDeleteCatalogResponse> UnitsDeleteAsync(
        UnitsDeleteCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<UnitsListCatalogResponse> UnitsListAsync(
        UnitsListCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<UnitsOptionsCatalogResponse> UnitsOptionsAsync(
        UnitsOptionsCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ItemGroupsCreateCatalogResponse> ItemGroupsCreateAsync(
        ItemGroupsCreateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ItemGroupsUpdateCatalogResponse> ItemGroupsUpdateAsync(
        ItemGroupsUpdateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ItemGroupsDeleteCatalogResponse> ItemGroupsDeleteAsync(
        ItemGroupsDeleteCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ItemGroupsListCatalogResponse> ItemGroupsListAsync(
        ItemGroupsListCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ItemsSuppliersUpsertCatalogResponse> ItemsSuppliersUpsertAsync(
        ItemsSuppliersUpsertCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ItemsSuppliersListCatalogResponse> ItemsSuppliersListAsync(
        ItemsSuppliersListCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ItemsSuppliersDeleteCatalogResponse> ItemsSuppliersDeleteAsync(
        ItemsSuppliersDeleteCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PriceListsCreateCatalogResponse> PriceListsCreateAsync(
        PriceListsCreateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PriceListsUpdateCatalogResponse> PriceListsUpdateAsync(
        PriceListsUpdateCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PriceListsListCatalogResponse> PriceListsListAsync(
        PriceListsListCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PriceListsItemsSetCatalogResponse> PriceListsItemsSetAsync(
        PriceListsItemsSetCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PriceListsItemsListCatalogResponse> PriceListsItemsListAsync(
        PriceListsItemsListCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PriceListsItemsDeleteCatalogResponse> PriceListsItemsDeleteAsync(
        PriceListsItemsDeleteCatalogRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
