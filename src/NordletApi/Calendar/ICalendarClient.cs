namespace NordletApi;

public partial interface ICalendarClient
{
    WithRawResponseTask<PostV1CalendarListResponse> PostV1CalendarListAsync(
        PostV1CalendarListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CalendarGetResponse> PostV1CalendarGetAsync(
        PostV1CalendarGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CalendarCreateResponse> PostV1CalendarCreateAsync(
        PostV1CalendarCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CalendarUpdateResponse> PostV1CalendarUpdateAsync(
        PostV1CalendarUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1CalendarDeleteResponse> PostV1CalendarDeleteAsync(
        PostV1CalendarDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
