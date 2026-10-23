namespace NordletApi;

public partial interface IPlatformSellersClient
{
    /// <summary>
    /// Individuals and entities that sell goods, rent out property or transport, or perform personal services through the platform the company operates. The yearly DAC7 report is built from them.
    /// </summary>
    WithRawResponseTask<ListPlatformSellersResponse> ListAsync(
        ListPlatformSellersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Read one platform seller with its activities, ordered by year.
    /// </summary>
    WithRawResponseTask<GetPlatformSellersResponse> GetAsync(
        GetPlatformSellersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Record a seller on the company's platform for the DAC7 report: an `individual` (first and last name required) or an `entity` (`entityName` required), with its `activities` per year and quarter. An `immovable_property` activity needs `propertyAddress`; property address, type and rented days on any other kind of activity are refused. These checks answer 422; a `partnerId` that does not exist answers 404. The report is built from the sellers with `declarations/eu/dac7/preview` and `declarations/eu/dac7/xml`.
    /// </summary>
    WithRawResponseTask<CreatePlatformSellersResponse> CreateAsync(
        CreatePlatformSellersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replace a platform seller's details and all of its activities with the ones given, under the same checks as `platform-sellers/create`.
    /// </summary>
    WithRawResponseTask<UpdatePlatformSellersResponse> UpdateAsync(
        UpdatePlatformSellersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Mark a platform seller as deleted. It leaves the lists and the DAC7 report.
    /// </summary>
    WithRawResponseTask<DeletePlatformSellersResponse> DeleteAsync(
        DeletePlatformSellersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
