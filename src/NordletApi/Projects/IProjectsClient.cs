namespace NordletApi;

public partial interface IProjectsClient
{
    /// <summary>
    /// Create a project; `partnerId` is the customer that `projects/time-entries/bill` invoices by default. A duplicate `code` is refused with 409.
    /// </summary>
    WithRawResponseTask<CreateProjectsResponse> CreateAsync(
        CreateProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change a project's name, customer, `status` (`active`, `completed`, `archived`) or notes; only the fields sent are changed. An archived project accepts no new time entries.
    /// </summary>
    WithRawResponseTask<UpdateProjectsResponse> UpdateAsync(
        UpdateProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return one project.
    /// </summary>
    WithRawResponseTask<GetProjectsResponse> GetAsync(
        GetProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List projects. Filterable by `code`, `name`, `status` and `partnerId`; sortable by `code`, `name` and `createdAt`.
    /// </summary>
    WithRawResponseTask<ListProjectsResponse> ListAsync(
        ListProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Record hours worked on a project on a date, optionally for an employee and with the `hourlyRate` used when billing. `hours` must be positive (422); an archived project is refused with 409.
    /// </summary>
    WithRawResponseTask<TimeEntriesCreateProjectsResponse> TimeEntriesCreateAsync(
        TimeEntriesCreateProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change a time entry; only the fields sent are changed. `hours` must be positive (422); an entry already billed to an invoice cannot be changed (409).
    /// </summary>
    WithRawResponseTask<TimeEntriesUpdateProjectsResponse> TimeEntriesUpdateAsync(
        TimeEntriesUpdateProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a time entry (409 once it is billed).
    /// </summary>
    WithRawResponseTask<TimeEntriesDeleteProjectsResponse> TimeEntriesDeleteAsync(
        TimeEntriesDeleteProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List time entries. Filterable by `projectId`, `employeeId`, `billable`, `billedInvoiceId` and `date`; sortable by `date`, `createdAt` and `hours`.
    /// </summary>
    WithRawResponseTask<TimeEntriesListProjectsResponse> TimeEntriesListAsync(
        TimeEntriesListProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a draft sale invoice from the project's unbilled billable time entries, optionally limited to `dateFrom` and `dateTo`, and mark them billed; needs the `sales:write` scope, and the invoice is issued with `sales/invoices/issue`. The customer is `partnerId`, else the project's partner (422 without either); each entry is priced at its own `hourlyRate`, else the call's `hourlyRate` (422 when an entry has neither); `groupBy` `rate` makes one line per rate with the summed hours, `entry` one line per entry; `itemId`, `vatRatePercent` and `vatClassifierCode` go onto every line. No matching entries is 422.
    /// </summary>
    WithRawResponseTask<TimeEntriesBillProjectsResponse> TimeEntriesBillAsync(
        TimeEntriesBillProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Profitability per project: `revenue` and `costs` from posted journal entries tagged with the project (income accounts credit less debit, expense accounts debit less credit), `profit` as their difference, and the hours from time entries (total, billable, billed, unbilled, and the unbilled amount at the entries' hourly rates). `projectId` limits the report to one project; `dateFrom` and `dateTo` limit the journal dates and the entry dates. Nothing is changed.
    /// </summary>
    WithRawResponseTask<ReportProjectsResponse> ReportAsync(
        ReportProjectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
