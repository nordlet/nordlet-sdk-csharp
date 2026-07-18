namespace NordletApi;

public partial interface IDeclarationsClient
{
    WithRawResponseTask<PostV1DeclarationsLtIntrastatComputeResponse> PostV1DeclarationsLtIntrastatComputeAsync(
        PostV1DeclarationsLtIntrastatComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtIvazGenerateResponse> PostV1DeclarationsLtIvazGenerateAsync(
        PostV1DeclarationsLtIvazGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtIntrastatObligationResponse> PostV1DeclarationsLtIntrastatObligationAsync(
        PostV1DeclarationsLtIntrastatObligationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtIsafGenerateResponse> PostV1DeclarationsLtIsafGenerateAsync(
        PostV1DeclarationsLtIsafGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtFr0600ComputeResponse> PostV1DeclarationsLtFr0600ComputeAsync(
        PostV1DeclarationsLtFr0600ComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtGpm313ComputeResponse> PostV1DeclarationsLtGpm313ComputeAsync(
        PostV1DeclarationsLtGpm313ComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtSamComputeResponse> PostV1DeclarationsLtSamComputeAsync(
        PostV1DeclarationsLtSamComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtSdGenerateResponse> PostV1DeclarationsLtSdGenerateAsync(
        PostV1DeclarationsLtSdGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtSaftGenerateResponse> PostV1DeclarationsLtSaftGenerateAsync(
        PostV1DeclarationsLtSaftGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuOssComputeResponse> PostV1DeclarationsEuOssComputeAsync(
        PostV1DeclarationsEuOssComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuIossComputeResponse> PostV1DeclarationsEuIossComputeAsync(
        PostV1DeclarationsEuIossComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuDistanceSalesThresholdGetResponse> PostV1DeclarationsEuDistanceSalesThresholdGetAsync(
        PostV1DeclarationsEuDistanceSalesThresholdGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuUnionTurnoverGetResponse> PostV1DeclarationsEuUnionTurnoverGetAsync(
        PostV1DeclarationsEuUnionTurnoverGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuSmeCrossBorderReportComputeResponse> PostV1DeclarationsEuSmeCrossBorderReportComputeAsync(
        PostV1DeclarationsEuSmeCrossBorderReportComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuSmeThresholdsListResponse> PostV1DeclarationsEuSmeThresholdsListAsync(
        PostV1DeclarationsEuSmeThresholdsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuSmeThresholdGetResponse> PostV1DeclarationsEuSmeThresholdGetAsync(
        PostV1DeclarationsEuSmeThresholdGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuVatReturnPacksListResponse> PostV1DeclarationsEuVatReturnPacksListAsync(
        PostV1DeclarationsEuVatReturnPacksListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuVatReturnComputeResponse> PostV1DeclarationsEuVatReturnComputeAsync(
        PostV1DeclarationsEuVatReturnComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsConfigsListResponse> PostV1DeclarationsConfigsListAsync(
        PostV1DeclarationsConfigsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsConfigsUpdateResponse> PostV1DeclarationsConfigsUpdateAsync(
        PostV1DeclarationsConfigsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsSubmissionsCreateResponse> PostV1DeclarationsSubmissionsCreateAsync(
        PostV1DeclarationsSubmissionsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsSubmissionsMarkResponse> PostV1DeclarationsSubmissionsMarkAsync(
        PostV1DeclarationsSubmissionsMarkRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsSubmissionsListResponse> PostV1DeclarationsSubmissionsListAsync(
        PostV1DeclarationsSubmissionsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
