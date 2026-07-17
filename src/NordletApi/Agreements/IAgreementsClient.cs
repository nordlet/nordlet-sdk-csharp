namespace NordletApi;

public partial interface IAgreementsClient
{
    WithRawResponseTask<PostV1AgreementsTypesCreateResponse> PostV1AgreementsTypesCreateAsync(
        PostV1AgreementsTypesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AgreementsTypesListResponse> PostV1AgreementsTypesListAsync(
        PostV1AgreementsTypesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AgreementsAgreementsCreateResponse> PostV1AgreementsAgreementsCreateAsync(
        PostV1AgreementsAgreementsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AgreementsAgreementsGetResponse> PostV1AgreementsAgreementsGetAsync(
        PostV1AgreementsAgreementsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AgreementsAgreementsUpdateResponse> PostV1AgreementsAgreementsUpdateAsync(
        PostV1AgreementsAgreementsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AgreementsAgreementsDeleteResponse> PostV1AgreementsAgreementsDeleteAsync(
        PostV1AgreementsAgreementsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AgreementsAgreementsListResponse> PostV1AgreementsAgreementsListAsync(
        PostV1AgreementsAgreementsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AgreementsInsurancePoliciesCreateResponse> PostV1AgreementsInsurancePoliciesCreateAsync(
        PostV1AgreementsInsurancePoliciesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AgreementsInsurancePoliciesListResponse> PostV1AgreementsInsurancePoliciesListAsync(
        PostV1AgreementsInsurancePoliciesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AgreementsInsurancePoliciesDeleteResponse> PostV1AgreementsInsurancePoliciesDeleteAsync(
        PostV1AgreementsInsurancePoliciesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
