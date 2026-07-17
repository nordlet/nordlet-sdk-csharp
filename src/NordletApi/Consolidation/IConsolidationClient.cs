namespace NordletApi;

public partial interface IConsolidationClient
{
    WithRawResponseTask<PostV1ConsolidationGroupsCreateResponse> PostV1ConsolidationGroupsCreateAsync(
        PostV1ConsolidationGroupsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ConsolidationGroupsListResponse> PostV1ConsolidationGroupsListAsync(
        PostV1ConsolidationGroupsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ConsolidationGroupsGetResponse> PostV1ConsolidationGroupsGetAsync(
        PostV1ConsolidationGroupsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ConsolidationGroupsUpdateResponse> PostV1ConsolidationGroupsUpdateAsync(
        PostV1ConsolidationGroupsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ConsolidationGroupsDeleteResponse> PostV1ConsolidationGroupsDeleteAsync(
        PostV1ConsolidationGroupsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ConsolidationMembersAddResponse> PostV1ConsolidationMembersAddAsync(
        PostV1ConsolidationMembersAddRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ConsolidationMembersRemoveResponse> PostV1ConsolidationMembersRemoveAsync(
        PostV1ConsolidationMembersRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ConsolidationReportResponse> PostV1ConsolidationReportAsync(
        PostV1ConsolidationReportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
