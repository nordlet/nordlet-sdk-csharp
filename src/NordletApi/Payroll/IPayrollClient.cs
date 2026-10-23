namespace NordletApi;

public partial interface IPayrollClient
{
    /// <summary>
    /// Creates a department with a code and a name; answers 409 when the code already exists.
    /// </summary>
    WithRawResponseTask<DepartmentsCreatePayrollResponse> DepartmentsCreateAsync(
        DepartmentsCreatePayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the company's departments ordered by code.
    /// </summary>
    WithRawResponseTask<DepartmentsListPayrollResponse> DepartmentsListAsync(
        DepartmentsListPayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a work schedule with a code, a name and `hoursPerWeek` (default 40); answers 409 when the code already exists.
    /// </summary>
    WithRawResponseTask<SchedulesCreatePayrollResponse> SchedulesCreateAsync(
        SchedulesCreatePayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the company's work schedules ordered by code.
    /// </summary>
    WithRawResponseTask<SchedulesListPayrollResponse> SchedulesListAsync(
        SchedulesListPayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Reads the payment types of the company country's payroll engine, each with the labels of the taxes, contributions and reporting lines it is subject to (`applies`), and the default type an untyped payment falls under. These codes are what `payroll/calc` and the additions of `payroll/runs/create` accept as `paymentType`. Answers 422 when Nordlet has no payroll engine for the company's country.
    /// </summary>
    WithRawResponseTask<PaymentTypesListPayrollResponse> PaymentTypesListAsync(
        PaymentTypesListPayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Runs the company country's payroll engine once on a taxable base at a date, with the employee settings given in the body instead of an employee record, and returns the allowance, income tax, contributions, components and net; nothing is saved. `payments` passes typed payments to the engine; each `paymentType` must be a code from `payroll/payment-types/list` (422 otherwise). Answers 422 when Nordlet has no payroll engine for the company's country.
    /// </summary>
    WithRawResponseTask<CalcPayrollResponse> CalcAsync(
        CalcPayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a draft payroll run for a month, computing each line with the company country's payroll engine, the employee's approved runs of the year so far and of the two previous years, the month's timesheet and `payDate` (default the last day of the month). Without `lines`, every active employee whose contract covers the month gets a line: the gross is the contract's monthly salary reduced to the paid working days of the contract and the timesheet, unless `grossOverrides` sets it; the per diems of approved business trips ending in the month are added untaxed and the trips linked to the run; for a Lithuanian company the car benefit in kind (`includeNatura`) and the compensation for unused leave of a contract ending in the month are added. With `lines`, only the given employees are computed with their gross, additions and deductions; a taxable addition may carry a `paymentType` from `payroll/payment-types/list` and `hours`. Answers 422 when the country has no engine, an employee is given twice, has two contracts in the month, has no contract and no gross, or is paid by the hour or day without a gross; 409 when a run for the month already exists or the accounting period is locked.
    /// </summary>
    WithRawResponseTask<RunsCreatePayrollResponse> RunsCreateAsync(
        RunsCreatePayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Reads a payroll run with its lines.
    /// </summary>
    WithRawResponseTask<RunsGetPayrollResponse> RunsGetAsync(
        RunsGetPayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists payroll runs without their lines; filterable by `status`, `year` and `month`, sortable by `createdAt`, `year` and `month`.
    /// </summary>
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

    /// <summary>
    /// Posts the run's journal entry dated the last day of the month and sets the status to `approved`: the wage expense (net pay, income tax, employee contributions and deductions) and the employer contributions are debited; the net payable, the income tax, the social contributions (on one account, or split between the employee and employer accounts when their codes differ) and the deductions are credited. The accounts default to the payroll accounts of the company's chart template; each can be given per call. Answers 409 when the run is not a draft or the accounting period is locked, 422 when the run has no lines or nothing to post, and emits `payroll_run.approved`. For an Irish company with the automation of the `ie-payroll-withholding` deadline switched on, the month's payroll submission is sent at once and a failure is added to the run's `warnings`. Undo with `payroll/runs/reverse`, pay with `payroll/payments/export`.
    /// </summary>
    WithRawResponseTask<RunsApprovePayrollResponse> RunsApproveAsync(
        RunsApprovePayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Posts a journal entry dated the last day of the month that mirrors the run's entry (debits and credits swapped), sets the status to `reversed` with the reason, and releases the business trips the run paid so the next run picks them up again. Answers 409 when the run is not approved, when part of it is matched to bank payments (`paidAmount`, unmatch them first) or when the accounting period is locked. Emits `payroll_run.reversed`.
    /// </summary>
    WithRawResponseTask<RunsReversePayrollResponse> RunsReverseAsync(
        RunsReversePayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a draft run with its lines and releases the business trips linked to it; answers 409 when the run is not a draft. An approved run is undone with `payroll/runs/reverse`.
    /// </summary>
    WithRawResponseTask<RunsCancelPayrollResponse> RunsCancelAsync(
        RunsCancelPayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Builds a SEPA credit transfer file (pain.001.001.03) for an approved run: one transfer from the chosen bank account to each employee's IBAN for the line's net when it is positive, with a remittance text in `locale` (default the locale of the calling user) and the run period, executed on `executionDate` (default the company's current date). Answers 409 when the run is not approved, and 422 when the bank account has no IBAN or is not in the company's base currency, an employee has no IBAN (`hr/employees/update`) or no line has a positive net. The file is returned in `xml`; nothing is sent to the bank.
    /// </summary>
    WithRawResponseTask<PaymentsExportPayrollResponse> PaymentsExportAsync(
        PaymentsExportPayrollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
