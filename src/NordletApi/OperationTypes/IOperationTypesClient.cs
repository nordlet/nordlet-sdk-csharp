namespace NordletApi;

public partial interface IOperationTypesClient
{
    WithRawResponseTask<CreateOperationTypesResponse> CreateAsync(
        CreateOperationTypesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<UpdateOperationTypesResponse> UpdateAsync(
        UpdateOperationTypesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GetOperationTypesResponse> GetAsync(
        GetOperationTypesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DeleteOperationTypesResponse> DeleteAsync(
        DeleteOperationTypesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ListOperationTypesResponse> ListAsync(
        ListOperationTypesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
