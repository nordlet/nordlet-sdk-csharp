namespace NordletApi;

public partial interface IPayrollClient
{
    WithRawResponseTask<DepartmentsCreatePayrollResponse> DepartmentsCreateAsync(
        DepartmentsCreatePayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DepartmentsListPayrollResponse> DepartmentsListAsync(
        DepartmentsListPayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SchedulesCreatePayrollResponse> SchedulesCreateAsync(
        SchedulesCreatePayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SchedulesListPayrollResponse> SchedulesListAsync(
        SchedulesListPayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CalcPayrollResponse> CalcAsync(
        CalcPayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<RunsCreatePayrollResponse> RunsCreateAsync(
        RunsCreatePayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<RunsGetPayrollResponse> RunsGetAsync(
        RunsGetPayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<RunsListPayrollResponse> RunsListAsync(
        RunsListPayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The days and hours worked, the days on the register and the average hourly earnings that some countries report per employment. The Czech monthly employer report asks for all four. They can be set while the run is a draft.
    /// </summary>
    WithRawResponseTask<LinesAttendancePayrollResponse> LinesAttendanceAsync(
        LinesAttendancePayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<RunsApprovePayrollResponse> RunsApproveAsync(
        RunsApprovePayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<RunsReversePayrollResponse> RunsReverseAsync(
        RunsReversePayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<RunsCancelPayrollResponse> RunsCancelAsync(
        RunsCancelPayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PaymentsExportPayrollResponse> PaymentsExportAsync(
        PaymentsExportPayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
