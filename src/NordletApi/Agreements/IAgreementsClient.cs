namespace NordletApi;

public partial interface IAgreementsClient
{
    WithRawResponseTask<SettingsGetAgreementsResponse> SettingsGetAsync(
        SettingsGetAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SettingsUpdateAgreementsResponse> SettingsUpdateAsync(
        SettingsUpdateAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TypesCreateAgreementsResponse> TypesCreateAsync(
        TypesCreateAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TypesListAgreementsResponse> TypesListAsync(
        TypesListAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AgreementsCreateAgreementsResponse> AgreementsCreateAsync(
        AgreementsCreateAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AgreementsGetAgreementsResponse> AgreementsGetAsync(
        AgreementsGetAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AgreementsUpdateAgreementsResponse> AgreementsUpdateAsync(
        AgreementsUpdateAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AgreementsDeleteAgreementsResponse> AgreementsDeleteAsync(
        AgreementsDeleteAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AgreementsListAgreementsResponse> AgreementsListAsync(
        AgreementsListAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AgreementsGenerateInvoiceAgreementsResponse> AgreementsGenerateInvoiceAsync(
        AgreementsGenerateInvoiceAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AgreementsBillingRunAgreementsResponse> AgreementsBillingRunAsync(
        AgreementsBillingRunAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InsurancePoliciesCreateAgreementsResponse> InsurancePoliciesCreateAsync(
        InsurancePoliciesCreateAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InsurancePoliciesListAgreementsResponse> InsurancePoliciesListAsync(
        InsurancePoliciesListAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InsurancePoliciesDeleteAgreementsResponse> InsurancePoliciesDeleteAsync(
        InsurancePoliciesDeleteAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
