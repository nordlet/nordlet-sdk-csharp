namespace NordletApi;

public partial interface IAssetsClient
{
    WithRawResponseTask<SettingsGetAssetsResponse> SettingsGetAsync(
        SettingsGetAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SettingsUpdateAssetsResponse> SettingsUpdateAsync(
        SettingsUpdateAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GroupsCreateAssetsResponse> GroupsCreateAsync(
        GroupsCreateAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GroupsListAssetsResponse> GroupsListAsync(
        GroupsListAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AssetsCreateAssetsResponse> AssetsCreateAsync(
        AssetsCreateAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AssetsUpdateAssetsResponse> AssetsUpdateAsync(
        AssetsUpdateAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Record the input VAT facts of a capital good that the annual VAT return needs for the adjustment of the deduction over the adjustment period (Article 187 of the VAT Directive, § 15a UStG): the input VAT on the acquisition, the date of first use, the share of use for deductible turnover at first use, whether it is land or a building (ten-year period instead of five), and every later year in which the share changed or the good was sold or withdrawn. Allowed also after depreciation has been posted.
    /// </summary>
    WithRawResponseTask<AssetsInputVatAssetsResponse> AssetsInputVatAsync(
        AssetsInputVatAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AssetsGetAssetsResponse> AssetsGetAsync(
        AssetsGetAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AssetsListAssetsResponse> AssetsListAsync(
        AssetsListAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AssetsModernizeAssetsResponse> AssetsModernizeAsync(
        AssetsModernizeAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Dispose of a fixed asset (sold, scrapped or written off). Removes its cost and accumulated depreciation, books the net book value as a disposal loss and the proceeds as a disposal gain (posting rules assets.disposalLoss, assets.disposalGain, assets.disposalProceeds), and stops its depreciation. Depreciation must be posted for every month before the disposal month.
    /// </summary>
    WithRawResponseTask<AssetsDisposeAssetsResponse> AssetsDisposeAsync(
        AssetsDisposeAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DepreciationPreviewAssetsResponse> DepreciationPreviewAsync(
        DepreciationPreviewAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DepreciationPostAssetsResponse> DepreciationPostAsync(
        DepreciationPostAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
