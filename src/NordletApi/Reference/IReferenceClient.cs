namespace NordletApi;

public partial interface IReferenceClient
{
    /// <summary>
    /// Fetches the euro exchange rates the Bank of Lithuania web service publishes for `date` (default: the company's current date) and stores them in the rate table shared by all companies, replacing the rates already stored for that date. Answers 404 when no rates are published for the date.
    /// </summary>
    WithRawResponseTask<ExchangeRatesSyncReferenceResponse> ExchangeRatesSyncAsync(
        ExchangeRatesSyncReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the stored euro exchange rates, which are shared by all companies. Filterable by `currencyCode` and `date`; sortable by `date` and `currencyCode`.
    /// </summary>
    WithRawResponseTask<ExchangeRatesListReferenceResponse> ExchangeRatesListAsync(
        ExchangeRatesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Stores a company exchange rate for `currency` on `date`, in units of the currency per one unit of the company's base currency, replacing the company rate stored for that currency and date. Rate lookups use the company rate when it is dated on or after the latest shared rate on or before the lookup date. Answers 422 when `rate` is not positive.
    /// </summary>
    WithRawResponseTask<ExchangeRatesSetReferenceResponse> ExchangeRatesSetAsync(
        ExchangeRatesSetReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the company's own exchange rates set with `reference/exchange-rates/set`. Filterable by `currencyCode` and `date`; sortable by `date` and `currencyCode`.
    /// </summary>
    WithRawResponseTask<ExchangeRatesOverridesListReferenceResponse> ExchangeRatesOverridesListAsync(
        ExchangeRatesOverridesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Removes the company's own exchange rate for `currency` on `date`.
    /// </summary>
    WithRawResponseTask<ExchangeRatesOverridesDeleteReferenceResponse> ExchangeRatesOverridesDeleteAsync(
        ExchangeRatesOverridesDeleteReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists every country code Nordlet knows with its EU and EEA membership and its name in each supported locale.
    /// </summary>
    WithRawResponseTask<CountriesListReferenceResponse> CountriesListAsync(
        CountriesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the ten Lithuanian counties (apskritys) with their code and ISO code.
    /// </summary>
    WithRawResponseTask<LtCountiesListReferenceResponse> LtCountiesListAsync(
        LtCountiesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the Lithuanian municipalities (savivaldybės) with the county each belongs to; `countyCode` limits the list to one county.
    /// </summary>
    WithRawResponseTask<LtMunicipalitiesListReferenceResponse> LtMunicipalitiesListAsync(
        LtMunicipalitiesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists Lithuanian cities with their municipality; `municipalityCode` limits the list to one municipality and `q` to names that start with the given text (case-insensitive).
    /// </summary>
    WithRawResponseTask<LtCitiesListReferenceResponse> LtCitiesListAsync(
        LtCitiesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the banks of the bank directory shared by all companies. Filterable by `countryCode`, `name`, `bic` and `bankCode`; sortable by `name`, `bic` and `countryCode`.
    /// </summary>
    WithRawResponseTask<BanksListReferenceResponse> BanksListAsync(
        BanksListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds a bank to the shared bank directory or, when a bank with the same `countryCode` and `bic` exists, replaces its name, bank code and active flag. Platform administrators only.
    /// </summary>
    WithRawResponseTask<BanksUpsertReferenceResponse> BanksUpsertAsync(
        BanksUpsertReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the ten Lithuanian regions (apskritys) with their code and ISO code; the same list as `reference/lt/counties/list`.
    /// </summary>
    WithRawResponseTask<LtRegionsListReferenceResponse> LtRegionsListAsync(
        LtRegionsListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the currencies known to Nordlet with their minor units. Filterable and sortable by `code` and `name`.
    /// </summary>
    WithRawResponseTask<CurrenciesListReferenceResponse> CurrenciesListAsync(
        CurrenciesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the company's VAT classifiers (code, country, name and rate). A document line that names a classifier in `vatClassifierCode` takes its rate from it when neither the line nor the item has a rate. Filterable by `code`, `countryCode` and `ratePercent`; sortable by `code` and `ratePercent`.
    /// </summary>
    WithRawResponseTask<VatClassifiersListReferenceResponse> VatClassifiersListAsync(
        VatClassifiersListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds VAT classifiers to the company or replaces the country, name and rate of the ones whose `code` already exists.
    /// </summary>
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

    /// <summary>
    /// Works out the VAT treatment of a supply by this company: the scheme (domestic, intra-EU B2B, reverse charge, OSS, IOSS, marketplace deemed supplier, export, out of scope or SME exempt), the country whose VAT applies, its rates with the company's overrides applied, and the legal basis. The customer comes from `partnerId` (country from the partner's address or VAT number, business status from the VAT number) or from `customerCountryCode` and `customerIsBusiness`; `date` defaults to the company's current date; when `belowDistanceSalesThreshold` is not given, the distance-sales threshold is tracked from the company's ledger. Answers 422 when the partner has neither an address country nor a VAT code.
    /// </summary>
    WithRawResponseTask<VatResolveReferenceResponse> VatResolveAsync(
        VatResolveReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the Combined Nomenclature codes of the directory shared by all companies. Filterable by `code`, `name` and `nameLt`; sortable by `code`.
    /// </summary>
    WithRawResponseTask<CnCodesListReferenceResponse> CnCodesListAsync(
        CnCodesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds Combined Nomenclature codes to the shared directory or replaces the names and supplementary unit of the codes that exist. Platform administrators only.
    /// </summary>
    WithRawResponseTask<CnCodesUpsertReferenceResponse> CnCodesUpsertAsync(
        CnCodesUpsertReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the versions of the filing systems, schemas and forms Nordlet's output was checked against, with the date of the check and the source; `country` limits the list to one country.
    /// </summary>
    WithRawResponseTask<ComplianceVersionsListReferenceResponse> ComplianceVersionsListAsync(
        ComplianceVersionsListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the Intrastat thresholds stored per year: the reporting and the statistical-value threshold for arrivals and for dispatches.
    /// </summary>
    WithRawResponseTask<IntrastatThresholdsListReferenceResponse> IntrastatThresholdsListAsync(
        IntrastatThresholdsListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the measurement units of the directory shared by all companies, with Lithuanian and English names. Filterable by `code`, `nameLt` and `nameEn`; sortable by `code`.
    /// </summary>
    WithRawResponseTask<UnitsListReferenceResponse> UnitsListAsync(
        UnitsListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a numbering series for a document type, prefix and year; the first number the series hands out is at least `startAt`. Answers 409 when a series with the same document type, prefix and year exists.
    /// </summary>
    WithRawResponseTask<SeriesCreateReferenceResponse> SeriesCreateAsync(
        SeriesCreateReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the company's numbering series with the next number of each. Filterable and sortable by `documentType`, `prefix` and `year`.
    /// </summary>
    WithRawResponseTask<SeriesListReferenceResponse> SeriesListAsync(
        SeriesListReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
