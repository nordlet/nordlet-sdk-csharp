namespace NordletApi;

public partial interface IReferenceClient
{
    /// <summary>
    /// Fetches the official exchange rates for `date` (default: the company's current date) quoted against the company's base currency and stores them in the rate table shared by all companies, replacing the rates already stored for the same base, currency and date. A company that keeps its books in GBP gets the HMRC monthly rates of the month of `date` (units per 1 GBP, dated the first day of the month), one in USD the Federal Reserve H.10 rates of the two weeks up to `date` (units per 1 USD), one in PLN the National Bank of Poland table A average rates of the two weeks up to `date` (stored as units per 1 PLN, the inverse of the published rate), and every other company the euro rates the Bank of Lithuania publishes for `date` (units per 1 EUR). `baseCurrency` in the answer names the base the rates are quoted against. Answers 404 when no rates are published for the date.
    /// </summary>
    WithRawResponseTask<ExchangeRatesSyncReferenceResponse> ExchangeRatesSyncAsync(
        ExchangeRatesSyncReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the stored official exchange rates, which are shared by all companies. `rate` is the units of `currencyCode` per one unit of `baseCurrency`: EUR rates come from the Bank of Lithuania, GBP rates from HMRC, USD rates from the Federal Reserve, PLN rates from the National Bank of Poland (table A). Filterable by `baseCurrency`, `currencyCode` and `date`; sortable by `date`, `baseCurrency` and `currencyCode`.
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
    /// Lists the company's VAT types (code, country, name and rate). A document line names one in `vatClassifierCode` and takes its rate, VAT scheme and return boxes from it; a company that has VAT types refuses a line without one (422). `side` says whether the type is for sale lines, purchase lines or both, `scheme` is its VAT scheme and `nameEn` its English name; both are null for a type the company added itself. A type without a rate takes the line's `vatRatePercent` on the sides where `rateFromLine` is true, and 0% elsewhere. Filterable by `code`, `countryCode`, `ratePercent`, `side` and `scheme`; `side` and `scheme` take `eq`, `ne` and `in`, and `side` `sale` or `purchase` also matches the types for both sides. Sortable by `code` and `ratePercent`.
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
    /// Replace the VAT rate mapping this company uses for one EU country, or for a country outside the EEA whose rates come from its VAT types (GB). Pass an empty rates array to drop the overrides and return to the TEDB defaults. Overrides feed rate suggestions (vat/resolve) and OSS/IOSS return rate classification.
    /// </summary>
    WithRawResponseTask<EuVatRatesSetOverridesReferenceResponse> EuVatRatesSetOverridesAsync(
        EuVatRatesSetOverridesReferenceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Works out the VAT treatment of a supply by this company: the scheme (domestic, intra-EU B2B, reverse charge, OSS, IOSS, marketplace deemed supplier, export, out of scope or SME exempt), the country whose VAT applies, its rates with the company's overrides applied, and the legal basis. The customer comes from `partnerId` (country from the partner's address or VAT number, business status from the VAT number) or from `customerCountryCode` and `customerIsBusiness`; `date` defaults to the company's current date; when `belowDistanceSalesThreshold` is not given, the distance-sales threshold is tracked from the company's ledger. Answers 422 when the partner has neither an address country nor a VAT code. `vatTypeCodes` lists the codes of the VAT types of the company's country that fit the treatment and are valid on `date` (for `vatClassifierCode` on a line), empty when none is known; when they all belong to one of the schemes `intra_eu_b2b` and `reverse_charge`, `scheme` is that scheme. With `side` `purchase` the partner (or `customerCountryCode` and `customerIsBusiness`) is the supplier, the treatment is that of the supplier's supply to this company, `vatTypeCodes` are purchase types, and the marketplace, platform-service and special-goods fields are not used. For services (or digital services) bought from a supplier outside the EU, `vatTypeCodes` are the reverse-charge purchase types of the company's country for services from non-EU suppliers (empty where the country's list has none), and `scheme` is `reverse_charge` with `reverseCharge` true.
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
