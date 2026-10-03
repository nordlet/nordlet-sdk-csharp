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

    WithRawResponseTask<PostV1AssetsAssetsUpdateResponse> PostV1AssetsAssetsUpdateAsync(
        PostV1AssetsAssetsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Record the input VAT facts of a capital good that the annual VAT return needs for the adjustment of the deduction over the adjustment period (Article 187 of the VAT Directive, § 15a UStG): the input VAT on the acquisition, the date of first use, the share of use for deductible turnover at first use, whether it is land or a building (ten-year period instead of five), and every later year in which the share changed or the good was sold or withdrawn. Allowed also after depreciation has been posted.
    /// </summary>
    WithRawResponseTask<PostV1AssetsAssetsInputVatResponse> PostV1AssetsAssetsInputVatAsync(
        PostV1AssetsAssetsInputVatRequest request,
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
