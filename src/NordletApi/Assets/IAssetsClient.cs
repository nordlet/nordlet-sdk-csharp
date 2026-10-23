namespace NordletApi;

public partial interface IAssetsClient
{
    /// <summary>
    /// Return the company's fixed asset setting `autoDepreciation`.
    /// </summary>
    WithRawResponseTask<SettingsGetAssetsResponse> SettingsGetAsync(
        SettingsGetAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Turn automatic depreciation on or off. When it is on, the scheduler posts the previous month's depreciation for the company once a day, as `assets/depreciation/post` does.
    /// </summary>
    WithRawResponseTask<SettingsUpdateAssetsResponse> SettingsUpdateAsync(
        SettingsUpdateAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create an asset group: the asset, accumulated depreciation and depreciation expense accounts its assets are posted to, and an optional default useful life in months. `expenseAccountCode` defaults to the chart's depreciation expense account; each account must exist and be postable (422). A duplicate code is refused with 409.
    /// </summary>
    WithRawResponseTask<GroupsCreateAssetsResponse> GroupsCreateAsync(
        GroupsCreateAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the asset groups; filterable and sortable by `code` and `name`.
    /// </summary>
    WithRawResponseTask<GroupsListAssetsResponse> GroupsListAsync(
        GroupsListAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Register a fixed asset in a group with its acquisition date and cost, salvage value, useful life in months (defaults to the group's default; 422 when neither is set) and depreciation start date (defaults to the acquisition date). The salvage value must be below the acquisition cost (422); a duplicate code is refused with 409. Depreciation is posted with `assets/depreciation/post`.
    /// </summary>
    WithRawResponseTask<AssetsCreateAssetsResponse> AssetsCreateAsync(
        AssetsCreateAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change an asset that has no posted depreciation yet: group, code, name, dates, cost, salvage value, useful life, notes or documents. Refused with 409 once depreciation is posted or the asset is disposed, and with 422 when the salvage value would reach the acquisition cost; a duplicate code is 409.
    /// </summary>
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

    /// <summary>
    /// Return one fixed asset with its totals (cost including modernisations, accumulated depreciation, net book value, total life in months), its input VAT facts and its disposal.
    /// </summary>
    WithRawResponseTask<AssetsGetAssetsResponse> AssetsGetAsync(
        AssetsGetAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the fixed assets; filterable by `code`, `name`, `groupId`, `status`, `acquisitionDate`, `acquisitionCost` and `accumulatedDepreciation`, sortable by `code`, `name`, `acquisitionDate` and `acquisitionCost`.
    /// </summary>
    WithRawResponseTask<AssetsListAssetsResponse> AssetsListAsync(
        AssetsListAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Record a modernisation of a fixed asset: `amount` is added to its cost and `addedLifeMonths` to its useful life from the month of `date` on, and the remaining depreciable value is spread over the months left. Refused with 422 when the asset is disposed or when no depreciation month would be left (give `addedLifeMonths` of at least 1); a fully depreciated asset becomes active again.
    /// </summary>
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

    /// <summary>
    /// Preview what `assets/depreciation/post` would post for a month: per active asset the amount and the months it covers, earlier unposted months included, and whether the month is already posted. Nothing is written.
    /// </summary>
    WithRawResponseTask<DepreciationPreviewAssetsResponse> DepreciationPreviewAsync(
        DepreciationPreviewAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Post the depreciation of a month: one journal entry dated the last day of the month that debits each group's expense account and credits its accumulated depreciation account, for every active asset whose depreciation has started, covering that month and any earlier month not yet posted. Each month's amount is the remaining depreciable value (cost plus modernisations less salvage value less accumulated depreciation) divided by the months left; an asset whose life or value is used up becomes `fully_depreciated`. Answers 409 when the period is locked, and `journalTransactionId` null when nothing is due.
    /// </summary>
    WithRawResponseTask<DepreciationPostAssetsResponse> DepreciationPostAsync(
        DepreciationPostAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
