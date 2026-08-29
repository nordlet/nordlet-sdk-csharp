namespace NordletApi;

public partial interface IProjectsClient
{
    WithRawResponseTask<PostV1ProjectsCreateResponse> PostV1ProjectsCreateAsync(
        PostV1ProjectsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProjectsUpdateResponse> PostV1ProjectsUpdateAsync(
        PostV1ProjectsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProjectsGetResponse> PostV1ProjectsGetAsync(
        PostV1ProjectsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProjectsListResponse> PostV1ProjectsListAsync(
        PostV1ProjectsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProjectsTimeEntriesCreateResponse> PostV1ProjectsTimeEntriesCreateAsync(
        PostV1ProjectsTimeEntriesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProjectsTimeEntriesUpdateResponse> PostV1ProjectsTimeEntriesUpdateAsync(
        PostV1ProjectsTimeEntriesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProjectsTimeEntriesDeleteResponse> PostV1ProjectsTimeEntriesDeleteAsync(
        PostV1ProjectsTimeEntriesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProjectsTimeEntriesListResponse> PostV1ProjectsTimeEntriesListAsync(
        PostV1ProjectsTimeEntriesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProjectsTimeEntriesBillResponse> PostV1ProjectsTimeEntriesBillAsync(
        PostV1ProjectsTimeEntriesBillRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ProjectsReportResponse> PostV1ProjectsReportAsync(
        PostV1ProjectsReportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
