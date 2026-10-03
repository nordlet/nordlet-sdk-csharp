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

    WithRawResponseTask<PostV1CalendarSubmitResponse> GenerateTheFilingForADeadlineAndSendItToTheAdministrationAsync(
        PostV1CalendarSubmitRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Builds the file of a deadline whose format Nordlet produces but whose administration takes it only through the company's own account or program. Nothing is sent and no filing is recorded.
    /// </summary>
    WithRawResponseTask<PostV1CalendarDownloadResponse> GenerateTheFileOfADeadlineForTheCompanyToSendItselfAsync(
        PostV1CalendarDownloadRequest request,
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
