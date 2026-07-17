namespace NordletApi;

public partial interface IPayrollClient
{
    WithRawResponseTask<PostV1PayrollDepartmentsCreateResponse> PostV1PayrollDepartmentsCreateAsync(
        PostV1PayrollDepartmentsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PayrollDepartmentsListResponse> PostV1PayrollDepartmentsListAsync(
        PostV1PayrollDepartmentsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PayrollSchedulesCreateResponse> PostV1PayrollSchedulesCreateAsync(
        PostV1PayrollSchedulesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PayrollSchedulesListResponse> PostV1PayrollSchedulesListAsync(
        PostV1PayrollSchedulesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PayrollCalcResponse> PostV1PayrollCalcAsync(
        PostV1PayrollCalcRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PayrollRunsCreateResponse> PostV1PayrollRunsCreateAsync(
        PostV1PayrollRunsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PayrollRunsGetResponse> PostV1PayrollRunsGetAsync(
        PostV1PayrollRunsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PayrollRunsListResponse> PostV1PayrollRunsListAsync(
        PostV1PayrollRunsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PayrollRunsApproveResponse> PostV1PayrollRunsApproveAsync(
        PostV1PayrollRunsApproveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PayrollRunsCancelResponse> PostV1PayrollRunsCancelAsync(
        PostV1PayrollRunsCancelRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PayrollPaymentsExportResponse> PostV1PayrollPaymentsExportAsync(
        PostV1PayrollPaymentsExportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
