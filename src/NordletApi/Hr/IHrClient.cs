namespace NordletApi;

public partial interface IHrClient
{
    /// <summary>
    /// Creates a job position with an optional code and name translations, for use in `hr/contracts/create`.
    /// </summary>
    WithRawResponseTask<PositionsCreateHrResponse> PositionsCreateAsync(
        PositionsCreateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the code, name or translations of a position; a null `translations` removes them.
    /// </summary>
    WithRawResponseTask<PositionsUpdateHrResponse> PositionsUpdateAsync(
        PositionsUpdateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the company's positions; filterable and sortable by `name` and `code`.
    /// </summary>
    WithRawResponseTask<PositionsListHrResponse> PositionsListAsync(
        PositionsListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates an employee record. `payrollOptions` holds the country-specific settings the payroll engine reads for the person (see `hr/employees/fields`); `applyAllowance` defaults to true and `pensionAccumulation` to false.
    /// </summary>
    WithRawResponseTask<EmployeesCreateHrResponse> EmployeesCreateAsync(
        EmployeesCreateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the given fields of an employee; a null clears the fields that allow it (code, personal code, birth date, contact details, address, IBAN, social insurance number and start, hire date, notes). `status` and `terminationDate` are set here too.
    /// </summary>
    WithRawResponseTask<EmployeesUpdateHrResponse> EmployeesUpdateAsync(
        EmployeesUpdateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Reads one employee.
    /// </summary>
    WithRawResponseTask<EmployeesGetHrResponse> EmployeesGetAsync(
        EmployeesGetHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Attributes a filing of the company country needs about a person that the shared employee record does not carry, such as the sex and place of birth an Italian income certificate asks for. Their values are kept in the payrollOptions of the employee.
    /// </summary>
    WithRawResponseTask<EmployeesFieldsHrResponse> EmployeesFieldsAsync(
        EmployeesFieldsHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the employees that are not deleted; filterable by `firstName`, `lastName`, `code`, `status` and `email`, sortable by `lastName`, `code` and `createdAt`.
    /// </summary>
    WithRawResponseTask<EmployeesListHrResponse> EmployeesListAsync(
        EmployeesListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Marks the employee deleted; the record stays and no longer appears in lists or payroll runs. `hr/employees/anonymize` also blanks the personal data.
    /// </summary>
    WithRawResponseTask<EmployeesDeleteHrResponse> EmployeesDeleteAsync(
        EmployeesDeleteHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replaces the name with a placeholder and removes personal code, birth date, contact details, address, bank account, social-insurance number, notes and sick-leave reasons. Payroll and contract rows stay linked to the record for the statutory retention period.
    /// </summary>
    WithRawResponseTask<EmployeesAnonymizeHrResponse> EmployeesAnonymizeAsync(
        EmployeesAnonymizeHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates an employment contract for an employee. A `permanent` contract takes no `endDate` and a `fixed_term` one requires it; the number comes from `contractNo` or, with `agreementId`, from the employee's agreement; `workHours` defaults by `salaryType`. Answers 422 when the end date is before the start, and 409 when the employee already has a contract overlapping the period (end it with `hr/contracts/end` first) or the contract number already exists.
    /// </summary>
    WithRawResponseTask<ContractsCreateHrResponse> ContractsCreateAsync(
        ContractsCreateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Ends a contract on `endDate` with an optional reason. Answers 422 when the end date is before the contract start.
    /// </summary>
    WithRawResponseTask<ContractsEndHrResponse> ContractsEndAsync(
        ContractsEndHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists employment contracts; filterable by `employeeId`, `agreementId`, `status` and `contractNo`, sortable by `startDate` and `contractNo`.
    /// </summary>
    WithRawResponseTask<ContractsListHrResponse> ContractsListAsync(
        ContractsListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates or replaces the leave entitlement of an employee for a year; `usedDays` is kept unless given (0 on a new row) and `remainingDays` is the entitled days less the used ones.
    /// </summary>
    WithRawResponseTask<LeaveBalancesSetHrResponse> LeaveBalancesSetAsync(
        LeaveBalancesSetHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists leave balances, narrowed to an employee and/or a year when given, oldest year first.
    /// </summary>
    WithRawResponseTask<LeaveBalancesListHrResponse> LeaveBalancesListAsync(
        LeaveBalancesListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Records a sick-leave certificate of an employee. Answers 422 when `toDate` is before `fromDate`. `payroll/runs/create` warns when a certificate covers working days of a month that has no timesheet.
    /// </summary>
    WithRawResponseTask<IncapacityCertificatesCreateHrResponse> IncapacityCertificatesCreateAsync(
        IncapacityCertificatesCreateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists incapacity certificates; filterable by `employeeId` and `number`, sortable by `fromDate` and `number`.
    /// </summary>
    WithRawResponseTask<IncapacityCertificatesListHrResponse> IncapacityCertificatesListAsync(
        IncapacityCertificatesListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds the company's daily per diem rate for a destination country from `validFrom`; `hr/business-trips/create` takes the latest rate valid on the trip's start date. Answers 409 when a rate for that country already starts on that date.
    /// </summary>
    WithRawResponseTask<PerDiemRatesCreateHrResponse> PerDiemRatesCreateAsync(
        PerDiemRatesCreateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists per diem rates; filterable by `countryCode`, sortable by `countryCode` and `validFrom`.
    /// </summary>
    WithRawResponseTask<PerDiemRatesListHrResponse> PerDiemRatesListAsync(
        PerDiemRatesListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a per diem rate.
    /// </summary>
    WithRawResponseTask<PerDiemRatesDeleteHrResponse> PerDiemRatesDeleteAsync(
        PerDiemRatesDeleteHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Stores the trip as a draft with `days` counted as calendar days, both ends included, and `perDiemAmount` as the days times the company's rate for the destination valid on the start date (`hr/per-diem-rates/create`). Answers 422 when the trip ends before it starts or no rate covers the destination on that date, and 409 when the employee already has a trip overlapping the dates.
    /// </summary>
    WithRawResponseTask<BusinessTripsCreateHrResponse> BusinessTripsCreateAsync(
        BusinessTripsCreateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Reads one business trip.
    /// </summary>
    WithRawResponseTask<BusinessTripsGetHrResponse> BusinessTripsGetAsync(
        BusinessTripsGetHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists business trips; filterable by `employeeId`, `status` and `payrollRunId`, sortable by `startDate`.
    /// </summary>
    WithRawResponseTask<BusinessTripsListHrResponse> BusinessTripsListAsync(
        BusinessTripsListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sets the trip's status to `approved`. `payroll/runs/create` without explicit lines adds the per diem of every approved trip ending in the run month as an untaxed addition and sets the trip's `payrollRunId`; reversing or cancelling the run releases the trip again. Answers 409 when the trip is not a draft.
    /// </summary>
    WithRawResponseTask<BusinessTripsApproveHrResponse> BusinessTripsApproveAsync(
        BusinessTripsApproveHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a draft trip; answers 409 when the trip is not a draft.
    /// </summary>
    WithRawResponseTask<BusinessTripsDeleteHrResponse> BusinessTripsDeleteAsync(
        BusinessTripsDeleteHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds an education, qualification, certificate or training record to an employee, optionally linked to one of the company's uploaded files (`fileId`).
    /// </summary>
    WithRawResponseTask<EmployeesRecordsCreateHrResponse> EmployeesRecordsCreateAsync(
        EmployeesRecordsCreateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the given fields of an employee record; `issuedAt`, `validUntil` and `fileId` can be cleared with null.
    /// </summary>
    WithRawResponseTask<EmployeesRecordsUpdateHrResponse> EmployeesRecordsUpdateAsync(
        EmployeesRecordsUpdateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes an employee record.
    /// </summary>
    WithRawResponseTask<EmployeesRecordsDeleteHrResponse> EmployeesRecordsDeleteAsync(
        EmployeesRecordsDeleteHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists employee records; filterable by `employeeId`, `type` and `title`, sortable by `createdAt` and `issuedAt`.
    /// </summary>
    WithRawResponseTask<EmployeesRecordsListHrResponse> EmployeesRecordsListAsync(
        EmployeesRecordsListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the files uploaded against an employee, newest first.
    /// </summary>
    WithRawResponseTask<EmployeesAttachmentsListHrResponse> EmployeesAttachmentsListAsync(
        EmployeesAttachmentsListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Builds the timesheet of the month for every employee with a contract in it, or for one employee with `employeeId`, replacing any existing timesheet: the Monday to Friday days within the contract get the contract's daily hours (its weekly hours over five), and for a Lithuanian company the public holidays are `holiday` days with 0 hours. Answers 422 when no contract covers the month.
    /// </summary>
    WithRawResponseTask<TimesheetsGenerateHrResponse> TimesheetsGenerateAsync(
        TimesheetsGenerateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates or replaces the timesheet of an employee for a month from the given days; `workedDays` and `workedHours` count the `work` and `business_trip` days with hours. Answers 422 for a day outside the month, a day given twice or more than 24 hours in a day. `payroll/runs/create` reads the timesheet for the paid days, the days worked and the business-trip days of the month.
    /// </summary>
    WithRawResponseTask<TimesheetsUpsertHrResponse> TimesheetsUpsertAsync(
        TimesheetsUpsertHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Reads the timesheet of an employee for a month.
    /// </summary>
    WithRawResponseTask<TimesheetsGetHrResponse> TimesheetsGetAsync(
        TimesheetsGetHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the timesheets of a month, ordered by employee name.
    /// </summary>
    WithRawResponseTask<TimesheetsListHrResponse> TimesheetsListAsync(
        TimesheetsListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a timesheet.
    /// </summary>
    WithRawResponseTask<TimesheetsDeleteHrResponse> TimesheetsDeleteAsync(
        TimesheetsDeleteHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
