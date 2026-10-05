namespace NordletApi;

public partial interface IReferenceClient
{
    WithRawResponseTask<ExchangeRatesSyncReferenceResponse> ExchangeRatesSyncAsync(
        ExchangeRatesSyncReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ExchangeRatesListReferenceResponse> ExchangeRatesListAsync(
        ExchangeRatesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ExchangeRatesSetReferenceResponse> ExchangeRatesSetAsync(
        ExchangeRatesSetReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ExchangeRatesOverridesListReferenceResponse> ExchangeRatesOverridesListAsync(
        ExchangeRatesOverridesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ExchangeRatesOverridesDeleteReferenceResponse> ExchangeRatesOverridesDeleteAsync(
        ExchangeRatesOverridesDeleteReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CountriesListReferenceResponse> CountriesListAsync(
        CountriesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<LtCountiesListReferenceResponse> LtCountiesListAsync(
        LtCountiesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<LtMunicipalitiesListReferenceResponse> LtMunicipalitiesListAsync(
        LtMunicipalitiesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<LtCitiesListReferenceResponse> LtCitiesListAsync(
        LtCitiesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<BanksListReferenceResponse> BanksListAsync(
        BanksListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<BanksUpsertReferenceResponse> BanksUpsertAsync(
        BanksUpsertReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<LtRegionsListReferenceResponse> LtRegionsListAsync(
        LtRegionsListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CurrenciesListReferenceResponse> CurrenciesListAsync(
        CurrenciesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<VatClassifiersListReferenceResponse> VatClassifiersListAsync(
        VatClassifiersListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<VatClassifiersUpsertReferenceResponse> VatClassifiersUpsertAsync(
        VatClassifiersUpsertReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Effective EU VAT rate mapping for this company: EC TEDB defaults, replaced per country by any company overrides. Verify the mapping fits the goods and services you sell before relying on it.
    /// </summary>
    WithRawResponseTask<EuVatRatesListReferenceResponse> EuVatRatesListAsync(
        EuVatRatesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replace the VAT rate mapping this company uses for one EU country. Pass an empty rates array to drop the overrides and return to the TEDB defaults. Overrides feed rate suggestions (vat/resolve) and OSS/IOSS return rate classification.
    /// </summary>
    WithRawResponseTask<EuVatRatesSetOverridesReferenceResponse> EuVatRatesSetOverridesAsync(
        EuVatRatesSetOverridesReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<VatResolveReferenceResponse> VatResolveAsync(
        VatResolveReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CnCodesListReferenceResponse> CnCodesListAsync(
        CnCodesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CnCodesUpsertReferenceResponse> CnCodesUpsertAsync(
        CnCodesUpsertReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ComplianceVersionsListReferenceResponse> ComplianceVersionsListAsync(
        ComplianceVersionsListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<IntrastatThresholdsListReferenceResponse> IntrastatThresholdsListAsync(
        IntrastatThresholdsListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<UnitsListReferenceResponse> UnitsListAsync(
        UnitsListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SeriesCreateReferenceResponse> SeriesCreateAsync(
        SeriesCreateReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SeriesListReferenceResponse> SeriesListAsync(
        SeriesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
