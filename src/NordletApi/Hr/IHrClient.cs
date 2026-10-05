namespace NordletApi;

public partial interface IHrClient
{
    WithRawResponseTask<PositionsCreateHrResponse> PositionsCreateAsync(
        PositionsCreateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PositionsUpdateHrResponse> PositionsUpdateAsync(
        PositionsUpdateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PositionsListHrResponse> PositionsListAsync(
        PositionsListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EmployeesCreateHrResponse> EmployeesCreateAsync(
        EmployeesCreateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EmployeesUpdateHrResponse> EmployeesUpdateAsync(
        EmployeesUpdateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

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

    WithRawResponseTask<EmployeesListHrResponse> EmployeesListAsync(
        EmployeesListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

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

    WithRawResponseTask<ContractsCreateHrResponse> ContractsCreateAsync(
        ContractsCreateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ContractsEndHrResponse> ContractsEndAsync(
        ContractsEndHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ContractsListHrResponse> ContractsListAsync(
        ContractsListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<LeaveBalancesSetHrResponse> LeaveBalancesSetAsync(
        LeaveBalancesSetHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<LeaveBalancesListHrResponse> LeaveBalancesListAsync(
        LeaveBalancesListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<IncapacityCertificatesCreateHrResponse> IncapacityCertificatesCreateAsync(
        IncapacityCertificatesCreateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<IncapacityCertificatesListHrResponse> IncapacityCertificatesListAsync(
        IncapacityCertificatesListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EmployeesRecordsCreateHrResponse> EmployeesRecordsCreateAsync(
        EmployeesRecordsCreateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EmployeesRecordsUpdateHrResponse> EmployeesRecordsUpdateAsync(
        EmployeesRecordsUpdateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EmployeesRecordsDeleteHrResponse> EmployeesRecordsDeleteAsync(
        EmployeesRecordsDeleteHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EmployeesRecordsListHrResponse> EmployeesRecordsListAsync(
        EmployeesRecordsListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EmployeesAttachmentsListHrResponse> EmployeesAttachmentsListAsync(
        EmployeesAttachmentsListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TimesheetsGenerateHrResponse> TimesheetsGenerateAsync(
        TimesheetsGenerateHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TimesheetsUpsertHrResponse> TimesheetsUpsertAsync(
        TimesheetsUpsertHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TimesheetsGetHrResponse> TimesheetsGetAsync(
        TimesheetsGetHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TimesheetsListHrResponse> TimesheetsListAsync(
        TimesheetsListHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TimesheetsDeleteHrResponse> TimesheetsDeleteAsync(
        TimesheetsDeleteHrRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
