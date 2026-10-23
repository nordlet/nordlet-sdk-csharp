namespace NordletApi;

public partial interface ICalendarClient
{
    /// <summary>
    /// Lists, in due-date order, the filing deadlines Nordlet derives for the company from its country and profile together with the company's own events, between `from` and `to` (default 45 days back to 120 days ahead of the company's current date). Each deadline carries its submissions, whether it can be filed with `calendar/submit`, amended, or built with `calendar/download`, and whether its automation is on; `includeDone: false` leaves out the rows that are completed, submitted or accepted.
    /// </summary>
    WithRawResponseTask<ListCalendarResponse> ListAsync(
        ListCalendarRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Reads one calendar row by `key`: the id of a company event, or `ruleKey:period` for a filing deadline with its submissions.
    /// </summary>
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

    /// <summary>
    /// Creates a company event (kind `custom`) with a title, a due date, notes and a done flag.
    /// </summary>
    WithRawResponseTask<CreateCalendarResponse> CreateAsync(
        CreateCalendarRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes a calendar row by `key`. A company event takes a new title, due date, notes or done flag; a filing deadline (`ruleKey:period`) takes only notes and done, keeps its own title and date, and gets a stored row the first time it is annotated.
    /// </summary>
    WithRawResponseTask<UpdateCalendarResponse> UpdateAsync(
        UpdateCalendarRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a company event by its id, or the stored notes and done mark of a filing deadline by `ruleKey:period`; the deadline itself still comes from the rules.
    /// </summary>
    WithRawResponseTask<DeleteCalendarResponse> DeleteAsync(
        DeleteCalendarRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
