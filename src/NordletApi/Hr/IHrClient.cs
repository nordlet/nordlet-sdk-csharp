namespace NordletApi;

public partial interface IHrClient
{
    WithRawResponseTask<PostV1HrPositionsCreateResponse> PostV1HrPositionsCreateAsync(
        PostV1HrPositionsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrPositionsUpdateResponse> PostV1HrPositionsUpdateAsync(
        PostV1HrPositionsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrPositionsListResponse> PostV1HrPositionsListAsync(
        PostV1HrPositionsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrEmployeesCreateResponse> PostV1HrEmployeesCreateAsync(
        PostV1HrEmployeesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrEmployeesUpdateResponse> PostV1HrEmployeesUpdateAsync(
        PostV1HrEmployeesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrEmployeesGetResponse> PostV1HrEmployeesGetAsync(
        PostV1HrEmployeesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrEmployeesListResponse> PostV1HrEmployeesListAsync(
        PostV1HrEmployeesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrEmployeesDeleteResponse> PostV1HrEmployeesDeleteAsync(
        PostV1HrEmployeesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replaces the name with a placeholder and removes personal code, birth date, contact details, address, bank account, social-insurance number, notes and sick-leave reasons. Payroll and contract rows stay linked to the record for the statutory retention period.
    /// </summary>
    WithRawResponseTask<PostV1HrEmployeesAnonymizeResponse> BlankAnEmployeesPersonalDataAndHideTheRecordAsync(
        PostV1HrEmployeesAnonymizeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrContractsCreateResponse> PostV1HrContractsCreateAsync(
        PostV1HrContractsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrContractsEndResponse> PostV1HrContractsEndAsync(
        PostV1HrContractsEndRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrContractsListResponse> PostV1HrContractsListAsync(
        PostV1HrContractsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrLeaveBalancesSetResponse> PostV1HrLeaveBalancesSetAsync(
        PostV1HrLeaveBalancesSetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrLeaveBalancesListResponse> PostV1HrLeaveBalancesListAsync(
        PostV1HrLeaveBalancesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrIncapacityCertificatesCreateResponse> PostV1HrIncapacityCertificatesCreateAsync(
        PostV1HrIncapacityCertificatesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrIncapacityCertificatesListResponse> PostV1HrIncapacityCertificatesListAsync(
        PostV1HrIncapacityCertificatesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrEmployeesRecordsCreateResponse> PostV1HrEmployeesRecordsCreateAsync(
        PostV1HrEmployeesRecordsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrEmployeesRecordsUpdateResponse> PostV1HrEmployeesRecordsUpdateAsync(
        PostV1HrEmployeesRecordsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrEmployeesRecordsDeleteResponse> PostV1HrEmployeesRecordsDeleteAsync(
        PostV1HrEmployeesRecordsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrEmployeesRecordsListResponse> PostV1HrEmployeesRecordsListAsync(
        PostV1HrEmployeesRecordsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrEmployeesAttachmentsListResponse> PostV1HrEmployeesAttachmentsListAsync(
        PostV1HrEmployeesAttachmentsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrTimesheetsGenerateResponse> PostV1HrTimesheetsGenerateAsync(
        PostV1HrTimesheetsGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrTimesheetsUpsertResponse> PostV1HrTimesheetsUpsertAsync(
        PostV1HrTimesheetsUpsertRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrTimesheetsGetResponse> PostV1HrTimesheetsGetAsync(
        PostV1HrTimesheetsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrTimesheetsListResponse> PostV1HrTimesheetsListAsync(
        PostV1HrTimesheetsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1HrTimesheetsDeleteResponse> PostV1HrTimesheetsDeleteAsync(
        PostV1HrTimesheetsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
