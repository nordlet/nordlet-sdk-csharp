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

    WithRawResponseTask<GetPlatformSellersResponse> GetAsync(
        GetPlatformSellersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CreatePlatformSellersResponse> CreateAsync(
        CreatePlatformSellersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<UpdatePlatformSellersResponse> UpdateAsync(
        UpdatePlatformSellersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DeletePlatformSellersResponse> DeleteAsync(
        DeletePlatformSellersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
