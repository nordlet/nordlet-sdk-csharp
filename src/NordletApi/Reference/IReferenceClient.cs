namespace NordletApi;

public partial interface IReferenceClient
{
    WithRawResponseTask<PostV1ReferenceExchangeRatesSyncResponse> PostV1ReferenceExchangeRatesSyncAsync(
        PostV1ReferenceExchangeRatesSyncRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceExchangeRatesListResponse> PostV1ReferenceExchangeRatesListAsync(
        PostV1ReferenceExchangeRatesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceExchangeRatesSetResponse> PostV1ReferenceExchangeRatesSetAsync(
        PostV1ReferenceExchangeRatesSetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceExchangeRatesOverridesListResponse> PostV1ReferenceExchangeRatesOverridesListAsync(
        PostV1ReferenceExchangeRatesOverridesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceExchangeRatesOverridesDeleteResponse> PostV1ReferenceExchangeRatesOverridesDeleteAsync(
        PostV1ReferenceExchangeRatesOverridesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceCountriesListResponse> PostV1ReferenceCountriesListAsync(
        PostV1ReferenceCountriesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceBanksListResponse> PostV1ReferenceBanksListAsync(
        PostV1ReferenceBanksListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceBanksUpsertResponse> PostV1ReferenceBanksUpsertAsync(
        PostV1ReferenceBanksUpsertRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceLtRegionsListResponse> PostV1ReferenceLtRegionsListAsync(
        PostV1ReferenceLtRegionsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceCurrenciesListResponse> PostV1ReferenceCurrenciesListAsync(
        PostV1ReferenceCurrenciesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceVatClassifiersListResponse> PostV1ReferenceVatClassifiersListAsync(
        PostV1ReferenceVatClassifiersListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceVatClassifiersUpsertResponse> PostV1ReferenceVatClassifiersUpsertAsync(
        PostV1ReferenceVatClassifiersUpsertRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Effective EU VAT rate mapping for this company: EC TEDB defaults, replaced per country by any company overrides. Verify the mapping fits the goods and services you sell before relying on it.
    /// </summary>
    WithRawResponseTask<PostV1ReferenceEuVatRatesListResponse> PostV1ReferenceEuVatRatesListAsync(
        PostV1ReferenceEuVatRatesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// History of EU VAT rate imports from the EC TEDB VatRetrievalService: when rates were pulled, what changed, and whether the run succeeded. The initial seed run carries the built-in snapshot.
    /// </summary>
    WithRawResponseTask<PostV1ReferenceEuVatRatesImportsListResponse> PostV1ReferenceEuVatRatesImportsListAsync(
        PostV1ReferenceEuVatRatesImportsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Trigger an immediate pull of EU VAT rates from the EC TEDB VatRetrievalService. Rates are shared reference data: new rates open with today as their effective date, rates that disappeared are closed with a validity end date. Returns the finished import run.
    /// </summary>
    WithRawResponseTask<PostV1ReferenceEuVatRatesSyncResponse> PostV1ReferenceEuVatRatesSyncAsync(
        PostV1ReferenceEuVatRatesSyncRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replace the VAT rate mapping this company uses for one EU country. Pass an empty rates array to drop the overrides and return to the TEDB defaults. Overrides feed rate suggestions (vat/resolve) and OSS/IOSS return rate classification.
    /// </summary>
    WithRawResponseTask<PostV1ReferenceEuVatRatesSetOverridesResponse> PostV1ReferenceEuVatRatesSetOverridesAsync(
        PostV1ReferenceEuVatRatesSetOverridesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceVatResolveResponse> PostV1ReferenceVatResolveAsync(
        PostV1ReferenceVatResolveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceCnCodesListResponse> PostV1ReferenceCnCodesListAsync(
        PostV1ReferenceCnCodesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceCnCodesUpsertResponse> PostV1ReferenceCnCodesUpsertAsync(
        PostV1ReferenceCnCodesUpsertRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceComplianceVersionsListResponse> PostV1ReferenceComplianceVersionsListAsync(
        PostV1ReferenceComplianceVersionsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceIntrastatThresholdsListResponse> PostV1ReferenceIntrastatThresholdsListAsync(
        PostV1ReferenceIntrastatThresholdsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceUnitsListResponse> PostV1ReferenceUnitsListAsync(
        PostV1ReferenceUnitsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceSeriesCreateResponse> PostV1ReferenceSeriesCreateAsync(
        PostV1ReferenceSeriesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1ReferenceSeriesListResponse> PostV1ReferenceSeriesListAsync(
        PostV1ReferenceSeriesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
