namespace NordletApi;

public partial interface IProjectsClient
{
    WithRawResponseTask<CreateProjectsResponse> CreateAsync(
        CreateProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<UpdateProjectsResponse> UpdateAsync(
        UpdateProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GetProjectsResponse> GetAsync(
        GetProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ListProjectsResponse> ListAsync(
        ListProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TimeEntriesCreateProjectsResponse> TimeEntriesCreateAsync(
        TimeEntriesCreateProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TimeEntriesUpdateProjectsResponse> TimeEntriesUpdateAsync(
        TimeEntriesUpdateProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TimeEntriesDeleteProjectsResponse> TimeEntriesDeleteAsync(
        TimeEntriesDeleteProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TimeEntriesListProjectsResponse> TimeEntriesListAsync(
        TimeEntriesListProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TimeEntriesBillProjectsResponse> TimeEntriesBillAsync(
        TimeEntriesBillProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReportProjectsResponse> ReportAsync(
        ReportProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
