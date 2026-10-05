namespace NordletApi;

public partial interface ILeadsClient
{
    WithRawResponseTask<CreateLeadsResponse> CreateAsync(
        CreateLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GetLeadsResponse> GetAsync(
        GetLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<UpdateLeadsResponse> UpdateAsync(
        UpdateLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DeleteLeadsResponse> DeleteAsync(
        DeleteLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ListLeadsResponse> ListAsync(
        ListLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<NotesCreateLeadsResponse> NotesCreateAsync(
        NotesCreateLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<NotesDeleteLeadsResponse> NotesDeleteAsync(
        NotesDeleteLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<NotesListLeadsResponse> NotesListAsync(
        NotesListLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FilesListLeadsResponse> FilesListAsync(
        FilesListLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SourcesCreateLeadsResponse> SourcesCreateAsync(
        SourcesCreateLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SourcesUpdateLeadsResponse> SourcesUpdateAsync(
        SourcesUpdateLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SourcesDeleteLeadsResponse> SourcesDeleteAsync(
        SourcesDeleteLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SourcesListLeadsResponse> SourcesListAsync(
        SourcesListLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SourcesOptionsLeadsResponse> SourcesOptionsAsync(
        SourcesOptionsLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a customer partner from the lead, move the lead files to the partner, copy the lead notes into the partner notes and mark the lead as converted.
    /// </summary>
    WithRawResponseTask<ConvertLeadsResponse> ConvertAsync(
        ConvertLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
