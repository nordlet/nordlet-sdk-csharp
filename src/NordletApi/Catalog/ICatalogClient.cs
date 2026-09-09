namespace NordletApi;

public partial interface ICatalogClient
{
    WithRawResponseTask<PostV1CatalogItemsCreateResponse> PostV1CatalogItemsCreateAsync(
        PostV1CatalogItemsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogItemsGetResponse> PostV1CatalogItemsGetAsync(
        PostV1CatalogItemsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogItemsUpdateResponse> PostV1CatalogItemsUpdateAsync(
        PostV1CatalogItemsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogItemsDeleteResponse> PostV1CatalogItemsDeleteAsync(
        PostV1CatalogItemsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogItemsListResponse> PostV1CatalogItemsListAsync(
        PostV1CatalogItemsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogItemsFilesListResponse> PostV1CatalogItemsFilesListAsync(
        PostV1CatalogItemsFilesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogItemsKindsCreateResponse> PostV1CatalogItemsKindsCreateAsync(
        PostV1CatalogItemsKindsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogItemsKindsUpdateResponse> PostV1CatalogItemsKindsUpdateAsync(
        PostV1CatalogItemsKindsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogItemsKindsDeleteResponse> PostV1CatalogItemsKindsDeleteAsync(
        PostV1CatalogItemsKindsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogItemsKindsListResponse> PostV1CatalogItemsKindsListAsync(
        PostV1CatalogItemsKindsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogUnitsCreateResponse> PostV1CatalogUnitsCreateAsync(
        PostV1CatalogUnitsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogUnitsUpdateResponse> PostV1CatalogUnitsUpdateAsync(
        PostV1CatalogUnitsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogUnitsDeleteResponse> PostV1CatalogUnitsDeleteAsync(
        PostV1CatalogUnitsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogUnitsListResponse> PostV1CatalogUnitsListAsync(
        PostV1CatalogUnitsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogUnitsOptionsResponse> PostV1CatalogUnitsOptionsAsync(
        PostV1CatalogUnitsOptionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogItemGroupsCreateResponse> PostV1CatalogItemGroupsCreateAsync(
        PostV1CatalogItemGroupsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogItemGroupsUpdateResponse> PostV1CatalogItemGroupsUpdateAsync(
        PostV1CatalogItemGroupsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogItemGroupsDeleteResponse> PostV1CatalogItemGroupsDeleteAsync(
        PostV1CatalogItemGroupsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogItemGroupsListResponse> PostV1CatalogItemGroupsListAsync(
        PostV1CatalogItemGroupsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogItemsSuppliersUpsertResponse> PostV1CatalogItemsSuppliersUpsertAsync(
        PostV1CatalogItemsSuppliersUpsertRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogItemsSuppliersListResponse> PostV1CatalogItemsSuppliersListAsync(
        PostV1CatalogItemsSuppliersListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogItemsSuppliersDeleteResponse> PostV1CatalogItemsSuppliersDeleteAsync(
        PostV1CatalogItemsSuppliersDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogPriceListsCreateResponse> PostV1CatalogPriceListsCreateAsync(
        PostV1CatalogPriceListsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogPriceListsUpdateResponse> PostV1CatalogPriceListsUpdateAsync(
        PostV1CatalogPriceListsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogPriceListsListResponse> PostV1CatalogPriceListsListAsync(
        PostV1CatalogPriceListsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogPriceListsItemsSetResponse> PostV1CatalogPriceListsItemsSetAsync(
        PostV1CatalogPriceListsItemsSetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogPriceListsItemsListResponse> PostV1CatalogPriceListsItemsListAsync(
        PostV1CatalogPriceListsItemsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CatalogPriceListsItemsDeleteResponse> PostV1CatalogPriceListsItemsDeleteAsync(
        PostV1CatalogPriceListsItemsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
