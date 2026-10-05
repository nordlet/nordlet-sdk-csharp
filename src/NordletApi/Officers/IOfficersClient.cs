namespace NordletApi;

public partial interface IOfficersClient
{
    /// <summary>
    /// Directors, board members, the company secretary, representatives and liquidators, with their personal identifier, appointment and resignation dates and whether they sign the annual accounts. Annual returns and registry deposits are built from this register.
    /// </summary>
    WithRawResponseTask<ListOfficersResponse> ListAsync(
        ListOfficersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CreateOfficersResponse> CreateAsync(
        CreateOfficersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<UpdateOfficersResponse> UpdateAsync(
        UpdateOfficersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DeleteOfficersResponse> DeleteAsync(
        DeleteOfficersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
