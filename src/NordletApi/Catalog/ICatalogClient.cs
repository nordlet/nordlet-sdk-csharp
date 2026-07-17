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
