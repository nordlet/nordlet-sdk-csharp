namespace NordletApi;

public partial interface ICalendarClient
{
    WithRawResponseTask<ListCalendarResponse> ListAsync(
        ListCalendarRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GetCalendarResponse> GetAsync(
        GetCalendarRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// With amend: true the return is filed again as a correction of the one already submitted or accepted for the period; only returns whose format has a correction mark accept it.
    /// </summary>
    WithRawResponseTask<SubmitCalendarResponse> SubmitAsync(
        SubmitCalendarRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Builds the file of a deadline whose format Nordlet produces but whose administration takes it only through the company's own account or program. Nothing is sent and no filing is recorded.
    /// </summary>
    WithRawResponseTask<DownloadCalendarResponse> DownloadAsync(
        DownloadCalendarRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CreateCalendarResponse> CreateAsync(
        CreateCalendarRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<UpdateCalendarResponse> UpdateAsync(
        UpdateCalendarRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DeleteCalendarResponse> DeleteAsync(
        DeleteCalendarRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
