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

    /// <summary>
    /// Add an officer to the company's register (`officers/list`); `signsAccounts` defaults to true. Refused with 422 when `resignedOn` is before `appointedOn`.
    /// </summary>
    WithRawResponseTask<CreateOfficersResponse> CreateAsync(
        CreateOfficersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replace the recorded data of an officer; every field is written as sent, so a field left out is cleared and `signsAccounts` falls back to true. Refused with 422 when `resignedOn` is before `appointedOn`.
    /// </summary>
    WithRawResponseTask<UpdateOfficersResponse> UpdateAsync(
        UpdateOfficersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove an officer from the company's register.
    /// </summary>
    WithRawResponseTask<DeleteOfficersResponse> DeleteAsync(
        DeleteOfficersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
