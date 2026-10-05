namespace NordletApi;

public partial interface IDocumentSeriesClient
{
    WithRawResponseTask<CreateDocumentSeriesResponse> CreateAsync(
        CreateDocumentSeriesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<UpdateDocumentSeriesResponse> UpdateAsync(
        UpdateDocumentSeriesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GetDocumentSeriesResponse> GetAsync(
        GetDocumentSeriesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DeleteDocumentSeriesResponse> DeleteAsync(
        DeleteDocumentSeriesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ListDocumentSeriesResponse> ListAsync(
        ListDocumentSeriesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
