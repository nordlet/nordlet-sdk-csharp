namespace NordletApi;

public partial interface IAssetsClient
{
    WithRawResponseTask<PostV1AssetsGroupsCreateResponse> PostV1AssetsGroupsCreateAsync(
        PostV1AssetsGroupsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AssetsGroupsListResponse> PostV1AssetsGroupsListAsync(
        PostV1AssetsGroupsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AssetsAssetsCreateResponse> PostV1AssetsAssetsCreateAsync(
        PostV1AssetsAssetsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AssetsAssetsGetResponse> PostV1AssetsAssetsGetAsync(
        PostV1AssetsAssetsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AssetsAssetsListResponse> PostV1AssetsAssetsListAsync(
        PostV1AssetsAssetsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AssetsAssetsModernizeResponse> PostV1AssetsAssetsModernizeAsync(
        PostV1AssetsAssetsModernizeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AssetsDepreciationPreviewResponse> PostV1AssetsDepreciationPreviewAsync(
        PostV1AssetsDepreciationPreviewRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AssetsDepreciationPostResponse> PostV1AssetsDepreciationPostAsync(
        PostV1AssetsDepreciationPostRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
