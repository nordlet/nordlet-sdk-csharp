# Reference
## reference
<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">ExchangeRatesSyncAsync</a>(ExchangeRatesSyncReferenceRequest { ... }) -> WithRawResponseTask&lt;ExchangeRatesSyncReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Fetches the euro exchange rates the Bank of Lithuania web service publishes for `date` (default: the company's current date) and stores them in the rate table shared by all companies, replacing the rates already stored for that date. Answers 404 when no rates are published for the date.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.ExchangeRatesSyncAsync(new ExchangeRatesSyncReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ExchangeRatesSyncReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">ExchangeRatesListAsync</a>(ExchangeRatesListReferenceRequest { ... }) -> WithRawResponseTask&lt;ExchangeRatesListReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the stored euro exchange rates, which are shared by all companies. Filterable by `currencyCode` and `date`; sortable by `date` and `currencyCode`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.ExchangeRatesListAsync(new ExchangeRatesListReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ExchangeRatesListReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">ExchangeRatesSetAsync</a>(ExchangeRatesSetReferenceRequest { ... }) -> WithRawResponseTask&lt;ExchangeRatesSetReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Stores a company exchange rate for `currency` on `date`, in units of the currency per one unit of the company's base currency, replacing the company rate stored for that currency and date. Rate lookups use the company rate when it is dated on or after the latest shared rate on or before the lookup date. Answers 422 when `rate` is not positive.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.ExchangeRatesSetAsync(
    new ExchangeRatesSetReferenceRequest
    {
        Currency = "currency",
        Date = new DateOnly(2026, 7, 1),
        Rate = "121.00000000",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ExchangeRatesSetReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">ExchangeRatesOverridesListAsync</a>(ExchangeRatesOverridesListReferenceRequest { ... }) -> WithRawResponseTask&lt;ExchangeRatesOverridesListReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the company's own exchange rates set with `reference/exchange-rates/set`. Filterable by `currencyCode` and `date`; sortable by `date` and `currencyCode`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.ExchangeRatesOverridesListAsync(
    new ExchangeRatesOverridesListReferenceRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ExchangeRatesOverridesListReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">ExchangeRatesOverridesDeleteAsync</a>(ExchangeRatesOverridesDeleteReferenceRequest { ... }) -> WithRawResponseTask&lt;ExchangeRatesOverridesDeleteReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Removes the company's own exchange rate for `currency` on `date`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.ExchangeRatesOverridesDeleteAsync(
    new ExchangeRatesOverridesDeleteReferenceRequest
    {
        Currency = "currency",
        Date = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ExchangeRatesOverridesDeleteReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">CountriesListAsync</a>(CountriesListReferenceRequest { ... }) -> WithRawResponseTask&lt;CountriesListReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists every country code Nordlet knows with its EU and EEA membership and its name in each supported locale.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.CountriesListAsync(new CountriesListReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CountriesListReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">LtCountiesListAsync</a>(LtCountiesListReferenceRequest { ... }) -> WithRawResponseTask&lt;LtCountiesListReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the ten Lithuanian counties (apskritys) with their code and ISO code.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.LtCountiesListAsync(new LtCountiesListReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtCountiesListReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">LtMunicipalitiesListAsync</a>(LtMunicipalitiesListReferenceRequest { ... }) -> WithRawResponseTask&lt;LtMunicipalitiesListReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the Lithuanian municipalities (savivaldybės) with the county each belongs to; `countyCode` limits the list to one county.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.LtMunicipalitiesListAsync(new LtMunicipalitiesListReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtMunicipalitiesListReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">LtCitiesListAsync</a>(LtCitiesListReferenceRequest { ... }) -> WithRawResponseTask&lt;LtCitiesListReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists Lithuanian cities with their municipality; `municipalityCode` limits the list to one municipality and `q` to names that start with the given text (case-insensitive).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.LtCitiesListAsync(new LtCitiesListReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtCitiesListReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">BanksListAsync</a>(BanksListReferenceRequest { ... }) -> WithRawResponseTask&lt;BanksListReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the banks of the bank directory shared by all companies. Filterable by `countryCode`, `name`, `bic` and `bankCode`; sortable by `name`, `bic` and `countryCode`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.BanksListAsync(new BanksListReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BanksListReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">BanksUpsertAsync</a>(BanksUpsertReferenceRequest { ... }) -> WithRawResponseTask&lt;BanksUpsertReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds a bank to the shared bank directory or, when a bank with the same `countryCode` and `bic` exists, replaces its name, bank code and active flag. Platform administrators only.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.BanksUpsertAsync(
    new BanksUpsertReferenceRequest
    {
        CountryCode = "countryCode",
        Name = "name",
        Bic = "bic",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BanksUpsertReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">LtRegionsListAsync</a>(LtRegionsListReferenceRequest { ... }) -> WithRawResponseTask&lt;LtRegionsListReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the ten Lithuanian regions (apskritys) with their code and ISO code; the same list as `reference/lt/counties/list`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.LtRegionsListAsync(new LtRegionsListReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtRegionsListReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">CurrenciesListAsync</a>(CurrenciesListReferenceRequest { ... }) -> WithRawResponseTask&lt;CurrenciesListReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the currencies known to Nordlet with their minor units. Filterable and sortable by `code` and `name`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.CurrenciesListAsync(new CurrenciesListReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CurrenciesListReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">VatClassifiersListAsync</a>(VatClassifiersListReferenceRequest { ... }) -> WithRawResponseTask&lt;VatClassifiersListReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the company's VAT classifiers (code, country, name and rate). A document line that names a classifier in `vatClassifierCode` takes its rate from it when neither the line nor the item has a rate. Filterable by `code`, `countryCode` and `ratePercent`; sortable by `code` and `ratePercent`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.VatClassifiersListAsync(new VatClassifiersListReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VatClassifiersListReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">VatClassifiersUpsertAsync</a>(VatClassifiersUpsertReferenceRequest { ... }) -> WithRawResponseTask&lt;VatClassifiersUpsertReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds VAT classifiers to the company or replaces the country, name and rate of the ones whose `code` already exists.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.VatClassifiersUpsertAsync(
    new VatClassifiersUpsertReferenceRequest
    {
        Rows = new List<VatClassifiersUpsertReferenceRequestRowsItem>()
        {
            new VatClassifiersUpsertReferenceRequestRowsItem { Code = "code", Name = "name" },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VatClassifiersUpsertReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">EuVatRatesListAsync</a>(EuVatRatesListReferenceRequest { ... }) -> WithRawResponseTask&lt;EuVatRatesListReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Effective EU VAT rate mapping for this company: EC TEDB defaults, replaced per country by any company overrides. Verify the mapping fits the goods and services you sell before relying on it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.EuVatRatesListAsync(new EuVatRatesListReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EuVatRatesListReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">EuVatRatesSetOverridesAsync</a>(EuVatRatesSetOverridesReferenceRequest { ... }) -> WithRawResponseTask&lt;EuVatRatesSetOverridesReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Replace the VAT rate mapping this company uses for one EU country. Pass an empty rates array to drop the overrides and return to the TEDB defaults. Overrides feed rate suggestions (vat/resolve) and OSS/IOSS return rate classification.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.EuVatRatesSetOverridesAsync(
    new EuVatRatesSetOverridesReferenceRequest
    {
        CountryCode = "countryCode",
        Rates = new List<EuVatRatesSetOverridesReferenceRequestRatesItem>()
        {
            new EuVatRatesSetOverridesReferenceRequestRatesItem
            {
                Category = EuVatRatesSetOverridesReferenceRequestRatesItemCategory.Standard,
                RatePercent = "121.00",
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EuVatRatesSetOverridesReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">VatResolveAsync</a>(VatResolveReferenceRequest { ... }) -> WithRawResponseTask&lt;VatResolveReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Works out the VAT treatment of a supply by this company: the scheme (domestic, intra-EU B2B, reverse charge, OSS, IOSS, marketplace deemed supplier, export, out of scope or SME exempt), the country whose VAT applies, its rates with the company's overrides applied, and the legal basis. The customer comes from `partnerId` (country from the partner's address or VAT number, business status from the VAT number) or from `customerCountryCode` and `customerIsBusiness`; `date` defaults to the company's current date; when `belowDistanceSalesThreshold` is not given, the distance-sales threshold is tracked from the company's ledger. Answers 422 when the partner has neither an address country nor a VAT code.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.VatResolveAsync(new VatResolveReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VatResolveReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">CnCodesListAsync</a>(CnCodesListReferenceRequest { ... }) -> WithRawResponseTask&lt;CnCodesListReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the Combined Nomenclature codes of the directory shared by all companies. Filterable by `code`, `name` and `nameLt`; sortable by `code`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.CnCodesListAsync(new CnCodesListReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CnCodesListReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">CnCodesUpsertAsync</a>(CnCodesUpsertReferenceRequest { ... }) -> WithRawResponseTask&lt;CnCodesUpsertReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds Combined Nomenclature codes to the shared directory or replaces the names and supplementary unit of the codes that exist. Platform administrators only.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.CnCodesUpsertAsync(
    new CnCodesUpsertReferenceRequest
    {
        Rows = new List<CnCodesUpsertReferenceRequestRowsItem>()
        {
            new CnCodesUpsertReferenceRequestRowsItem { Code = "code", Name = "name" },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CnCodesUpsertReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">ComplianceVersionsListAsync</a>(ComplianceVersionsListReferenceRequest { ... }) -> WithRawResponseTask&lt;ComplianceVersionsListReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the versions of the filing systems, schemas and forms Nordlet's output was checked against, with the date of the check and the source; `country` limits the list to one country.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.ComplianceVersionsListAsync(new ComplianceVersionsListReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ComplianceVersionsListReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">IntrastatThresholdsListAsync</a>(IntrastatThresholdsListReferenceRequest { ... }) -> WithRawResponseTask&lt;IntrastatThresholdsListReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the Intrastat thresholds stored per year: the reporting and the statistical-value threshold for arrivals and for dispatches.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.IntrastatThresholdsListAsync(new IntrastatThresholdsListReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IntrastatThresholdsListReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">UnitsListAsync</a>(UnitsListReferenceRequest { ... }) -> WithRawResponseTask&lt;UnitsListReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the measurement units of the directory shared by all companies, with Lithuanian and English names. Filterable by `code`, `nameLt` and `nameEn`; sortable by `code`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.UnitsListAsync(new UnitsListReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UnitsListReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">SeriesCreateAsync</a>(SeriesCreateReferenceRequest { ... }) -> WithRawResponseTask&lt;SeriesCreateReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a numbering series for a document type, prefix and year; the first number the series hands out is at least `startAt`. Answers 409 when a series with the same document type, prefix and year exists.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.SeriesCreateAsync(
    new SeriesCreateReferenceRequest { DocumentType = "documentType", Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SeriesCreateReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">SeriesListAsync</a>(SeriesListReferenceRequest { ... }) -> WithRawResponseTask&lt;SeriesListReferenceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the company's numbering series with the next number of each. Filterable and sortable by `documentType`, `prefix` and `year`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.SeriesListAsync(new SeriesListReferenceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SeriesListReferenceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## partners
<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">AddressesCreateAsync</a>(AddressesCreatePartnersRequest { ... }) -> WithRawResponseTask&lt;AddressesCreatePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds an address of type billing, shipping, registered or other to the partner in `partnerId`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.AddressesCreateAsync(
    new AddressesCreatePartnersRequest { PartnerId = "partnerId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AddressesCreatePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">AddressesUpdateAsync</a>(AddressesUpdatePartnersRequest { ... }) -> WithRawResponseTask&lt;AddressesUpdatePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the given fields of a partner address.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.AddressesUpdateAsync(new AddressesUpdatePartnersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AddressesUpdatePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">AddressesDeleteAsync</a>(AddressesDeletePartnersRequest { ... }) -> WithRawResponseTask&lt;AddressesDeletePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a partner address.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.AddressesDeleteAsync(new AddressesDeletePartnersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AddressesDeletePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">AddressesListAsync</a>(AddressesListPartnersRequest { ... }) -> WithRawResponseTask&lt;AddressesListPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists partner addresses; filterable by `partnerId`, `type` and `city`, sortable by `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.AddressesListAsync(new AddressesListPartnersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AddressesListPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">ContactsCreateAsync</a>(ContactsCreatePartnersRequest { ... }) -> WithRawResponseTask&lt;ContactsCreatePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds a contact person to the partner in `partnerId`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.ContactsCreateAsync(
    new ContactsCreatePartnersRequest { Name = "name", PartnerId = "partnerId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ContactsCreatePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">ContactsUpdateAsync</a>(ContactsUpdatePartnersRequest { ... }) -> WithRawResponseTask&lt;ContactsUpdatePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the given fields of a partner contact.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.ContactsUpdateAsync(new ContactsUpdatePartnersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ContactsUpdatePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">ContactsDeleteAsync</a>(ContactsDeletePartnersRequest { ... }) -> WithRawResponseTask&lt;ContactsDeletePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a partner contact.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.ContactsDeleteAsync(new ContactsDeletePartnersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ContactsDeletePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">ContactsListAsync</a>(ContactsListPartnersRequest { ... }) -> WithRawResponseTask&lt;ContactsListPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists partner contacts; filterable by `partnerId`, `name` and `email`, sortable by `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.ContactsListAsync(new ContactsListPartnersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ContactsListPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">BankAccountsCreateAsync</a>(BankAccountsCreatePartnersRequest { ... }) -> WithRawResponseTask&lt;BankAccountsCreatePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds a bank account to the partner in `partnerId`. The IBAN is stored without spaces in upper case; an IBAN the partner already has is refused with 409. With `isDefault` true the partner's other accounts lose their default mark.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.BankAccountsCreateAsync(
    new BankAccountsCreatePartnersRequest { Iban = "iban", PartnerId = "partnerId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BankAccountsCreatePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">BankAccountsUpdateAsync</a>(BankAccountsUpdatePartnersRequest { ... }) -> WithRawResponseTask&lt;BankAccountsUpdatePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the given fields of a partner bank account. A new IBAN is stored without spaces in upper case and is refused with 409 when the partner already has it; when the account is the default after the change, the partner's other accounts lose their default mark.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.BankAccountsUpdateAsync(new BankAccountsUpdatePartnersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BankAccountsUpdatePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">BankAccountsDeleteAsync</a>(BankAccountsDeletePartnersRequest { ... }) -> WithRawResponseTask&lt;BankAccountsDeletePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a partner bank account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.BankAccountsDeleteAsync(new BankAccountsDeletePartnersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BankAccountsDeletePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">BankAccountsListAsync</a>(BankAccountsListPartnersRequest { ... }) -> WithRawResponseTask&lt;BankAccountsListPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists partner bank accounts; filterable by `partnerId` and `iban`, sortable by `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.BankAccountsListAsync(new BankAccountsListPartnersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BankAccountsListPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">FilesListAsync</a>(FilesListPartnersRequest { ... }) -> WithRawResponseTask&lt;FilesListPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the files attached to a partner, newest first. `partners/create` attaches one with `documentRef`, and `leads/convert` moves the lead's files here.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.FilesListAsync(new FilesListPartnersRequest { PartnerId = "partnerId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FilesListPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">DebtRemindersPreviewAsync</a>(DebtRemindersPreviewPartnersRequest { ... }) -> WithRawResponseTask&lt;DebtRemindersPreviewPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Runs the overdue selection of the daily debt-reminder job for this company as of the company's current date and returns the overdue reminders it would send, without sending or recording anything. A partner is included when it has `autoDebtReminder`, is active, has an e-mail address, got no overdue reminder in the last `repeatDays` days (`partners/debt-reminders/settings/get`) and has issued invoices or advance invoices with `debtRemindersEnabled` past their due date with an unpaid remainder; the interest per invoice is the remainder times the partner's `lateInterestPercent` times the days late over 365, and the totals are per currency. Sent reminders are listed by `partners/debt-reminders/list`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.DebtRemindersPreviewAsync(new DebtRemindersPreviewPartnersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DebtRemindersPreviewPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">DebtRemindersListAsync</a>(DebtRemindersListPartnersRequest { ... }) -> WithRawResponseTask&lt;DebtRemindersListPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the debt reminders the daily job has sent, one row per partner and currency with the ids of the invoices it covered and its `kind` (`before_due` or `overdue`); filterable by `partnerId`, sortable by `sentAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.DebtRemindersListAsync(new DebtRemindersListPartnersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DebtRemindersListPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">DebtRemindersSettingsGetAsync</a>(DebtRemindersSettingsGetPartnersRequest { ... }) -> WithRawResponseTask&lt;DebtRemindersSettingsGetPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the debt-reminder schedule of the company: `daysBefore`, the days before the due date on which the first reminder is sent (null when no reminder is sent before the due date), and `repeatDays`, the days between overdue reminders to a partner.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.DebtRemindersSettingsGetAsync(new DebtRemindersSettingsGetPartnersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DebtRemindersSettingsGetPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">DebtRemindersSettingsUpdateAsync</a>(DebtRemindersSettingsUpdatePartnersRequest { ... }) -> WithRawResponseTask&lt;DebtRemindersSettingsUpdatePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the given fields of the company's debt-reminder schedule. `daysBefore` (1 to 90, or null to send nothing before the due date) makes the daily job send one "payment due soon" reminder per invoice that many days before its due date; `repeatDays` (1 to 90) is the number of days between overdue reminders to a partner. Only partners with `autoDebtReminder` get reminders, and only for invoices with `debtRemindersEnabled`. A body without fields is refused with 400.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.DebtRemindersSettingsUpdateAsync(
    new DebtRemindersSettingsUpdatePartnersRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DebtRemindersSettingsUpdatePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">DebtRemindersUpcomingAsync</a>(DebtRemindersUpcomingPartnersRequest { ... }) -> WithRawResponseTask&lt;DebtRemindersUpcomingPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the next reminder the daily debt-reminder job would send for each unpaid issued invoice or advance invoice with `debtRemindersEnabled` of the partners that get reminders (`autoDebtReminder`, active, with an e-mail address), as of the company's current date and sorted by `date`. A `before_due` reminder is sent once per invoice, `daysBefore` days before its due date or on the first daily run after that while the due date is still ahead; `overdue` reminders start the day after the due date and repeat every `repeatDays` days per partner, counting only overdue reminders. Nothing is sent or recorded.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.DebtRemindersUpcomingAsync(new DebtRemindersUpcomingPartnersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DebtRemindersUpcomingPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">ValidateVatAsync</a>(ValidateVatPartnersRequest { ... }) -> WithRawResponseTask&lt;ValidateVatPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Checks a VAT number against VIES, either a free `vatCode` or the VAT code of the partner in `partnerId` (exactly one of the two); a code without an EU country prefix and 2 to 12 alphanumeric characters is refused with 422, as is a partner without a VAT code, and a VIES outage answers 503. With a partner the outcome is written to it (`vatValid`, `vatValidatedAt`): an invalid number or a VIES name that shares no word with the partner's name opens or refreshes the partner's VAT review (`vat_review.opened`), a VIES failure opens one with reason `service_error`, and a valid matching number resolves the open review as `revalidated` (`vat_review.resolved`). Reviews are listed and closed with `partners/vat-reviews/list` and `partners/vat-reviews/resolve`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.ValidateVatAsync(new ValidateVatPartnersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ValidateVatPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">VatReviewsListAsync</a>(VatReviewsListPartnersRequest { ... }) -> WithRawResponseTask&lt;VatReviewsListPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the VAT reviews opened by VIES checks of partners' VAT codes, with reason `invalid`, `name_mismatch` or `service_error`; filterable by `partnerId`, `status` and `reason`, sortable by `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.VatReviewsListAsync(new VatReviewsListPartnersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VatReviewsListPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">VatReviewsResolveAsync</a>(VatReviewsResolvePartnersRequest { ... }) -> WithRawResponseTask&lt;VatReviewsResolvePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Closes an open VAT review as `confirmed_valid`, `confirmed_invalid` or `dismissed`, with an optional note. The first two also set the partner's `vatValid` and stamp `vatValidatedAt` when the partner still carries the reviewed VAT code; `dismissed` leaves the partner unchanged. A review that is already resolved answers 409; emits `vat_review.resolved`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.VatReviewsResolveAsync(
    new VatReviewsResolvePartnersRequest
    {
        Id = "id",
        Resolution = VatReviewsResolvePartnersRequestResolution.ConfirmedValid,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VatReviewsResolvePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">CreateAsync</a>(CreatePartnersRequest { ... }) -> WithRawResponseTask&lt;CreatePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a partner. `groupId`, `statusId` and `priceListId` must belong to the company; without `legalCountryClass` the class is derived from the address country (`lt`, `eu` or `non_eu`); `documentRef` attaches an uploaded file that is not yet linked to a record; a `code` already used by a live partner of the company is refused with 409. A `vatCode` is checked against VIES at once and the result stored on the partner: an invalid number, a VIES name that shares no word with the partner's name, or a VIES failure opens a VAT review (`vat_review.opened`), while a code that is not an EU VAT number is stored unchecked (see `partners/validate-vat`).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.CreateAsync(new CreatePartnersRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreatePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">FindOrCreateAsync</a>(FindOrCreatePartnersRequest { ... }) -> WithRawResponseTask&lt;FindOrCreatePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the live partner matched by `code`, then `vatCode`, then `email` (at least one is required), or creates one from the body with the same validation and VIES check as `partners/create`; `created` says which happened. A creation that loses a race on the partner code returns the partner the other call created.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.FindOrCreateAsync(new FindOrCreatePartnersRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FindOrCreatePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">GetAsync</a>(GetPartnersRequest { ... }) -> WithRawResponseTask&lt;GetPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns one partner; a deleted partner answers 404.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.GetAsync(new GetPartnersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">UpdateAsync</a>(UpdatePartnersRequest { ... }) -> WithRawResponseTask&lt;UpdatePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the given fields of a partner; the clearable fields accept null. A new address country re-derives `legalCountryClass` unless the class is given, and a `code` already used by another live partner of the company is refused with 409. A changed `vatCode` resets the VIES result and is checked at once as in `partners/create`; a removed code, or one that is not an EU VAT number, resolves the partner's open VAT review as `superseded` (`vat_review.resolved`).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.UpdateAsync(new UpdatePartnersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdatePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">DeleteAsync</a>(DeletePartnersRequest { ... }) -> WithRawResponseTask&lt;DeletePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Marks a partner as deleted; it no longer appears in lists or lookups.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.DeleteAsync(new DeletePartnersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeletePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">MergeAsync</a>(MergePartnersRequest { ... }) -> WithRawResponseTask&lt;MergePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Moves every row that references the duplicate `sourceId` through a foreign key to partners (looked up in the database catalogue, within the company) to `targetId`, then marks the source partner as deleted; `moved` lists the tables, columns and row counts. Merging a partner into itself is 422, and when both partners hold the same unique entry (for example the same IBAN or item supplier row) the merge is refused with 409 until it is removed from one of them. When the kept partner has an open VAT review, the duplicate's open review is resolved as `superseded` (`vat_review.resolved`).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.MergeAsync(
    new MergePartnersRequest { SourceId = "sourceId", TargetId = "targetId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MergePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">AnonymizeAsync</a>(AnonymizePartnersRequest { ... }) -> WithRawResponseTask&lt;AnonymizePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Removes birth date, self-employment certificate number, email, phone, address, notes, contacts, addresses and bank accounts, then hides the partner. The name, code and VAT number stay because issued invoices must keep identifying the counterparty for the statutory retention period.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.AnonymizeAsync(new AnonymizePartnersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AnonymizePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">ListAsync</a>(ListPartnersRequest { ... }) -> WithRawResponseTask&lt;ListPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists live partners; filterable by `name`, `code`, `vatCode`, `email`, `type`, `isCustomer`, `isSupplier`, `isActive`, `legalCountryClass`, `isEmployee`, `groupId`, `statusId` and `nextCallDate`, sortable by `name`, `code`, `createdAt`, `nextCallDate` and `rating`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.ListAsync(new ListPartnersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">GroupsCreateAsync</a>(GroupsCreatePartnersRequest { ... }) -> WithRawResponseTask&lt;GroupsCreatePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a partner group; a `code` already used by a group of the company is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.GroupsCreateAsync(
    new GroupsCreatePartnersRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GroupsCreatePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">GroupsUpdateAsync</a>(GroupsUpdatePartnersRequest { ... }) -> WithRawResponseTask&lt;GroupsUpdatePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the code or name of a partner group; a code already used by another group of the company is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.GroupsUpdateAsync(new GroupsUpdatePartnersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GroupsUpdatePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">GroupsDeleteAsync</a>(GroupsDeletePartnersRequest { ... }) -> WithRawResponseTask&lt;GroupsDeletePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a partner group; a group still assigned to a live partner is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.GroupsDeleteAsync(new GroupsDeletePartnersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GroupsDeletePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">GroupsListAsync</a>(GroupsListPartnersRequest { ... }) -> WithRawResponseTask&lt;GroupsListPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the company's partner groups ordered by code.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.GroupsListAsync(new GroupsListPartnersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GroupsListPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">StatusesCreateAsync</a>(StatusesCreatePartnersRequest { ... }) -> WithRawResponseTask&lt;StatusesCreatePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a partner status with a `sortOrder`; a `code` already used by a status of the company is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.StatusesCreateAsync(
    new StatusesCreatePartnersRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StatusesCreatePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">StatusesUpdateAsync</a>(StatusesUpdatePartnersRequest { ... }) -> WithRawResponseTask&lt;StatusesUpdatePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the code, name or sort order of a partner status; a code already used by another status of the company is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.StatusesUpdateAsync(new StatusesUpdatePartnersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StatusesUpdatePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">StatusesDeleteAsync</a>(StatusesDeletePartnersRequest { ... }) -> WithRawResponseTask&lt;StatusesDeletePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a partner status; a status still assigned to a live partner is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.StatusesDeleteAsync(new StatusesDeletePartnersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StatusesDeletePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">StatusesListAsync</a>(StatusesListPartnersRequest { ... }) -> WithRawResponseTask&lt;StatusesListPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the company's partner statuses ordered by sort order, then code.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.StatusesListAsync(new StatusesListPartnersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StatusesListPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">InquiriesCreateAsync</a>(InquiriesCreatePartnersRequest { ... }) -> WithRawResponseTask&lt;InquiriesCreatePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Records an inquiry in status `new`, from a partner (`partnerId`) or from a contact given by `contactName` or `contactEmail`; without any of the three it is refused with 422. `assignedUserId` must be a member of the company. Emits `partner_inquiry.created`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.InquiriesCreateAsync(
    new InquiriesCreatePartnersRequest { Subject = "subject" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InquiriesCreatePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">InquiriesUpdateAsync</a>(InquiriesUpdatePartnersRequest { ... }) -> WithRawResponseTask&lt;InquiriesUpdatePartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the given fields of an inquiry; `partnerId` and `assignedUserId` accept null. Setting `status` to `closed` stamps `closedAt`, and moving a closed inquiry to another status clears it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.InquiriesUpdateAsync(new InquiriesUpdatePartnersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InquiriesUpdatePartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">InquiriesGetAsync</a>(InquiriesGetPartnersRequest { ... }) -> WithRawResponseTask&lt;InquiriesGetPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns one inquiry with the name of its partner.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.InquiriesGetAsync(new InquiriesGetPartnersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InquiriesGetPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">InquiriesListAsync</a>(InquiriesListPartnersRequest { ... }) -> WithRawResponseTask&lt;InquiriesListPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists inquiries with their partner names; filterable by `status`, `channel`, `partnerId`, `assignedUserId` and `subject`, sortable by `createdAt` and `updatedAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.InquiriesListAsync(new InquiriesListPartnersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InquiriesListPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">CreditCheckAsync</a>(CreditCheckPartnersRequest { ... }) -> WithRawResponseTask&lt;CreditCheckPartnersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Compares a partner's open receivables plus an optional `additionalAmount` with its `creditLimit`. The open receivables are the unpaid remainder of the partner's issued invoices, advance invoices and credit notes (credit notes negative), converted to the company's base currency at each invoice's `fxRate`. Without a credit limit `available` is null and `exceeded` is false.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.CreditCheckAsync(new CreditCheckPartnersRequest { PartnerId = "partnerId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreditCheckPartnersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Leads
<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">CreateAsync</a>(CreateLeadsRequest { ... }) -> WithRawResponseTask&lt;CreateLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a lead in status `new`, `contacted`, `qualified` or `lost`. `assignedUserId` must be a member of the company and `sourceId` and `typeId` must exist in it; `countryCode` and `currency` are stored in upper case; `documents` attach uploaded files not yet linked to a record, and `notes` become the lead's first notes with the caller as author. Emits `lead.created`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.CreateAsync(new CreateLeadsRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">GetAsync</a>(GetLeadsRequest { ... }) -> WithRawResponseTask&lt;GetLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns one lead with its source and type names.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.GetAsync(new GetLeadsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">UpdateAsync</a>(UpdateLeadsRequest { ... }) -> WithRawResponseTask&lt;UpdateLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the given fields of a lead; the clearable fields accept null, `documents` attach more uploaded files, and `countryCode` and `currency` are stored in upper case. A lead that is already converted cannot change `status` (409).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.UpdateAsync(new UpdateLeadsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">DeleteAsync</a>(DeleteLeadsRequest { ... }) -> WithRawResponseTask&lt;DeleteLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a lead with its notes and detaches its files, which stay in the company's files without a record.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.DeleteAsync(new DeleteLeadsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">ListAsync</a>(ListLeadsRequest { ... }) -> WithRawResponseTask&lt;ListLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists leads with their source and type names; filterable by `name`, `contactName`, `email`, `phone`, `status`, `sourceId`, `typeId`, `countryCode`, `assignedUserId`, `partnerId`, `estimatedValue` and `createdAt`, sortable by `name`, `status`, `estimatedValue`, `createdAt` and `updatedAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.ListAsync(new ListLeadsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">NotesCreateAsync</a>(NotesCreateLeadsRequest { ... }) -> WithRawResponseTask&lt;NotesCreateLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds a note to a lead with the caller as author and refreshes the lead's `updatedAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.NotesCreateAsync(
    new NotesCreateLeadsRequest { LeadId = "leadId", Body = "body" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `NotesCreateLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">NotesDeleteAsync</a>(NotesDeleteLeadsRequest { ... }) -> WithRawResponseTask&lt;NotesDeleteLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a lead note.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.NotesDeleteAsync(new NotesDeleteLeadsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `NotesDeleteLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">NotesListAsync</a>(NotesListLeadsRequest { ... }) -> WithRawResponseTask&lt;NotesListLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the notes of a lead, newest first.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.NotesListAsync(new NotesListLeadsRequest { LeadId = "leadId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `NotesListLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">FilesListAsync</a>(FilesListLeadsRequest { ... }) -> WithRawResponseTask&lt;FilesListLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the files attached to a lead, newest first.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.FilesListAsync(new FilesListLeadsRequest { LeadId = "leadId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FilesListLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">SourcesCreateAsync</a>(SourcesCreateLeadsRequest { ... }) -> WithRawResponseTask&lt;SourcesCreateLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a lead source; a `name` already used by a source of the company is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.SourcesCreateAsync(new SourcesCreateLeadsRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SourcesCreateLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">SourcesUpdateAsync</a>(SourcesUpdateLeadsRequest { ... }) -> WithRawResponseTask&lt;SourcesUpdateLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the name or `isActive` flag of a lead source; a name already used by another source of the company is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.SourcesUpdateAsync(new SourcesUpdateLeadsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SourcesUpdateLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">SourcesDeleteAsync</a>(SourcesDeleteLeadsRequest { ... }) -> WithRawResponseTask&lt;SourcesDeleteLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a lead source; one still referenced by a lead is refused with 409 and should be deactivated with `leads/sources/update` instead.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.SourcesDeleteAsync(new SourcesDeleteLeadsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SourcesDeleteLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">SourcesListAsync</a>(SourcesListLeadsRequest { ... }) -> WithRawResponseTask&lt;SourcesListLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists all lead sources of the company, active and inactive, ordered by name.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.SourcesListAsync(new SourcesListLeadsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SourcesListLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">SourcesOptionsAsync</a>(SourcesOptionsLeadsRequest { ... }) -> WithRawResponseTask&lt;SourcesOptionsLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the id and name of the active lead sources, ordered by name.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.SourcesOptionsAsync(new SourcesOptionsLeadsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SourcesOptionsLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">TypesCreateAsync</a>(TypesCreateLeadsRequest { ... }) -> WithRawResponseTask&lt;TypesCreateLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a lead type; a `name` already used by a type of the company is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.TypesCreateAsync(new TypesCreateLeadsRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TypesCreateLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">TypesUpdateAsync</a>(TypesUpdateLeadsRequest { ... }) -> WithRawResponseTask&lt;TypesUpdateLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the name or `isActive` flag of a lead type; a name already used by another type of the company is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.TypesUpdateAsync(new TypesUpdateLeadsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TypesUpdateLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">TypesDeleteAsync</a>(TypesDeleteLeadsRequest { ... }) -> WithRawResponseTask&lt;TypesDeleteLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a lead type; one still referenced by a lead is refused with 409 and should be deactivated with `leads/types/update` instead.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.TypesDeleteAsync(new TypesDeleteLeadsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TypesDeleteLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">TypesListAsync</a>(TypesListLeadsRequest { ... }) -> WithRawResponseTask&lt;TypesListLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists all lead types of the company, active and inactive, ordered by name.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.TypesListAsync(new TypesListLeadsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TypesListLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">TypesOptionsAsync</a>(TypesOptionsLeadsRequest { ... }) -> WithRawResponseTask&lt;TypesOptionsLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the id and name of the active lead types, ordered by name.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.TypesOptionsAsync(new TypesOptionsLeadsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TypesOptionsLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Leads.<a href="/src/NordletApi/Leads/LeadsClient.cs">ConvertAsync</a>(ConvertLeadsRequest { ... }) -> WithRawResponseTask&lt;ConvertLeadsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a customer partner from the lead, move the lead files to the partner, copy the lead notes into the partner notes and mark the lead as converted.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Leads.ConvertAsync(new ConvertLeadsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ConvertLeadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## catalog
<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemsCreateAsync</a>(ItemsCreateCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemsCreateCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a catalog item: a product, a service or a set of other items. `unit` must be `vnt`, a global measurement unit or one of the company's own units (`catalog/units/options`), the sale, purchase and expense account codes must be postable accounts of the chart, and `priceFrom`/`priceTo` and `validFrom`/`validTo` must be in order; otherwise 422. A `set` needs at least one component and none of them may be a set; `components` on any other type is refused with 422. 409 when an active item already carries the `code`. `documentRef` is the storage key of a file uploaded with `files/upload`, which is attached to the item. Emits `item.created`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemsCreateAsync(new ItemsCreateCatalogRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemsCreateCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemsGetAsync</a>(ItemsGetCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemsGetCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one item; a set comes with its components.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemsGetAsync(new ItemsGetCatalogRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemsGetCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemsUpdateAsync</a>(ItemsUpdateCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemsUpdateCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change the fields of an item; the fields that are nullable in the request can be set to null to clear them. The checks of `catalog/items/create` apply. `components` replaces the whole component list and is accepted only when the item is or becomes a set (422); turning an item into a set needs components and is refused with 409 while the item is itself a component of another set. Turning a set into another type removes its components. 409 when an active item already carries the new `code`. Emits `item.updated`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemsUpdateAsync(new ItemsUpdateCatalogRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemsUpdateCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemsDeleteAsync</a>(ItemsDeleteCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemsDeleteCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Soft-delete an item. Refused with 409 while the item is a component of an active set. Emits `item.deleted`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemsDeleteAsync(new ItemsDeleteCatalogRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemsDeleteCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemsListAsync</a>(ItemsListCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemsListCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the active items. Filterable: name, code, barcode, type, vatClassifierCode, groupId, kindId, externalId, manufacturer, department. Sortable: name, code, createdAt, updatedAt, salePriceExclVat; default name ascending. Rows carry no components; `catalog/items/get` returns them.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemsListAsync(new ItemsListCatalogRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemsListCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemsFilesListAsync</a>(ItemsFilesListCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemsFilesListCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the files attached to an item, newest first.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemsFilesListAsync(new ItemsFilesListCatalogRequest { ItemId = "itemId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemsFilesListCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemsKindsCreateAsync</a>(ItemsKindsCreateCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemsKindsCreateCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create an item kind: a code, a name, the SAF-T item type, whether quantities are accounted for, and a sort order. 409 when the code already exists.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemsKindsCreateAsync(
    new ItemsKindsCreateCatalogRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemsKindsCreateCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemsKindsUpdateAsync</a>(ItemsKindsUpdateCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemsKindsUpdateCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change an item kind. 409 when the new code already exists.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemsKindsUpdateAsync(new ItemsKindsUpdateCatalogRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemsKindsUpdateCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemsKindsDeleteAsync</a>(ItemsKindsDeleteCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemsKindsDeleteCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete an item kind. Refused with 409 while an active item uses it; soft-deleted items that still carry it are detached.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemsKindsDeleteAsync(new ItemsKindsDeleteCatalogRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemsKindsDeleteCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemsKindsListAsync</a>(ItemsKindsListCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemsKindsListCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the company's item kinds in sort order, then by code.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemsKindsListAsync(new ItemsKindsListCatalogRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemsKindsListCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">UnitsCreateAsync</a>(UnitsCreateCatalogRequest { ... }) -> WithRawResponseTask&lt;UnitsCreateCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a unit of measure of the company's own, in addition to the global measurement units (`reference/units/list`). 409 when the code already exists.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.UnitsCreateAsync(
    new UnitsCreateCatalogRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UnitsCreateCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">UnitsUpdateAsync</a>(UnitsUpdateCatalogRequest { ... }) -> WithRawResponseTask&lt;UnitsUpdateCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change the code, name or active flag of a company unit. 409 when the new code already exists.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.UnitsUpdateAsync(new UnitsUpdateCatalogRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UnitsUpdateCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">UnitsDeleteAsync</a>(UnitsDeleteCatalogRequest { ... }) -> WithRawResponseTask&lt;UnitsDeleteCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a company unit of measure.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.UnitsDeleteAsync(new UnitsDeleteCatalogRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UnitsDeleteCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">UnitsListAsync</a>(UnitsListCatalogRequest { ... }) -> WithRawResponseTask&lt;UnitsListCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the company's own units of measure, ordered by code.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.UnitsListAsync(new UnitsListCatalogRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UnitsListCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">UnitsOptionsAsync</a>(UnitsOptionsCatalogRequest { ... }) -> WithRawResponseTask&lt;UnitsOptionsCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the unit codes an item can use: the company's active own units first, then the global measurement units, named in the requested `locale` (Lithuanian for `lt`, English otherwise). A company unit hides a global unit with the same code.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.UnitsOptionsAsync(new UnitsOptionsCatalogRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UnitsOptionsCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemGroupsCreateAsync</a>(ItemGroupsCreateCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemGroupsCreateCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create an item group, optionally under `parentId`. 409 when the code already exists.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemGroupsCreateAsync(
    new ItemGroupsCreateCatalogRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemGroupsCreateCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemGroupsUpdateAsync</a>(ItemGroupsUpdateCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemGroupsUpdateCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change the code, name or parent of an item group; `parentId` null moves it to the top level. 422 when the new parent is the group itself or one of its descendants. 409 when the new code already exists.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemGroupsUpdateAsync(new ItemGroupsUpdateCatalogRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemGroupsUpdateCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemGroupsDeleteAsync</a>(ItemGroupsDeleteCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemGroupsDeleteCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete an item group. Refused with 409 while it has child groups or active items assigned.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemGroupsDeleteAsync(new ItemGroupsDeleteCatalogRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemGroupsDeleteCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemGroupsListAsync</a>(ItemGroupsListCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemGroupsListCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the company's item groups, ordered by code.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemGroupsListAsync(new ItemGroupsListCatalogRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemGroupsListCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemsSuppliersUpsertAsync</a>(ItemsSuppliersUpsertCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemsSuppliersUpsertCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create or replace the supplier record of an item for a partner (one per item and partner): supplier code, purchase price excluding VAT, currency (EUR when omitted) and notes. Fields omitted from the request are cleared on an existing record.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemsSuppliersUpsertAsync(
    new ItemsSuppliersUpsertCatalogRequest { ItemId = "itemId", PartnerId = "partnerId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemsSuppliersUpsertCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemsSuppliersListAsync</a>(ItemsSuppliersListCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemsSuppliersListCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the supplier records, optionally for one `itemId` and/or `partnerId`, ordered by partner name.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemsSuppliersListAsync(new ItemsSuppliersListCatalogRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemsSuppliersListCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">ItemsSuppliersDeleteAsync</a>(ItemsSuppliersDeleteCatalogRequest { ... }) -> WithRawResponseTask&lt;ItemsSuppliersDeleteCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete the supplier record of an item.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.ItemsSuppliersDeleteAsync(
    new ItemsSuppliersDeleteCatalogRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItemsSuppliersDeleteCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PriceListsCreateAsync</a>(PriceListsCreateCatalogRequest { ... }) -> WithRawResponseTask&lt;PriceListsCreateCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a price list (currency EUR and active when omitted). 409 when the code already exists.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PriceListsCreateAsync(
    new PriceListsCreateCatalogRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PriceListsCreateCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PriceListsUpdateAsync</a>(PriceListsUpdateCatalogRequest { ... }) -> WithRawResponseTask&lt;PriceListsUpdateCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change a price list. 409 when the new code already exists.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PriceListsUpdateAsync(new PriceListsUpdateCatalogRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PriceListsUpdateCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PriceListsListAsync</a>(PriceListsListCatalogRequest { ... }) -> WithRawResponseTask&lt;PriceListsListCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the company's price lists, ordered by code.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PriceListsListAsync(new PriceListsListCatalogRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PriceListsListCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PriceListsItemsSetAsync</a>(PriceListsItemsSetCatalogRequest { ... }) -> WithRawResponseTask&lt;PriceListsItemsSetCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Set the unit price excluding VAT of up to 500 items on a price list; a price already on the list is replaced and the other items on the list are kept. 422 when an item appears twice in the request. Emits `price_list.updated` with the item ids.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PriceListsItemsSetAsync(
    new PriceListsItemsSetCatalogRequest
    {
        PriceListId = "priceListId",
        Items = new List<PriceListsItemsSetCatalogRequestItemsItem>()
        {
            new PriceListsItemsSetCatalogRequestItemsItem
            {
                ItemId = "itemId",
                UnitPriceExclVat = "121.0000",
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PriceListsItemsSetCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PriceListsItemsListAsync</a>(PriceListsItemsListCatalogRequest { ... }) -> WithRawResponseTask&lt;PriceListsItemsListCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the prices of a price list with the item name and code, ordered by item name.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PriceListsItemsListAsync(
    new PriceListsItemsListCatalogRequest { PriceListId = "priceListId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PriceListsItemsListCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PriceListsItemsDeleteAsync</a>(PriceListsItemsDeleteCatalogRequest { ... }) -> WithRawResponseTask&lt;PriceListsItemsDeleteCatalogResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove one item from a price list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PriceListsItemsDeleteAsync(
    new PriceListsItemsDeleteCatalogRequest { PriceListId = "priceListId", ItemId = "itemId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PriceListsItemsDeleteCatalogRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## sales
<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesCreateAsync</a>(InvoicesCreateSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesCreateSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a draft sale document - an invoice, credit note, proforma or advance invoice (`type`) - with its lines; the totals are computed from the lines and `discountPercent`, and the number is assigned by `sales/invoices/issue`. Answers 422 when a credit note credits a proforma, another credit note or a document that is not issued, when the credited document has another partner or currency, when an OSS or IOSS document has no EU `vatCountryCode`, when the lines carry VAT but the company is not a VAT payer or the VAT scheme charges none, or when the operation type or document series is for another document type.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesCreateAsync(
    new InvoicesCreateSalesRequest
    {
        PartnerId = "partnerId",
        Lines = new List<InvoicesCreateSalesRequestLinesItem>()
        {
            new InvoicesCreateSalesRequestLinesItem(),
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesCreateSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesGetAsync</a>(InvoicesGetSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesGetSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one sale document with its lines, its VAT evidence and, on an advance invoice, the gross amount already applied to final invoices.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesGetAsync(new InvoicesGetSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesGetSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesPdfAsync</a>(InvoicesPdfSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesPdfSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Render a sale document, draft or issued, as a PDF returned base64-encoded. The document's own `locale` wins over the requested one. When the company has a payment link template and the document is issued and not paid, the PDF carries the payment link.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesPdfAsync(new InvoicesPdfSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesPdfSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesViewAsync</a>(InvoicesViewSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesViewSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return a sale document as its customer sees it: the seller as printed on it (the snapshot taken at issue, else the company), the buyer with address and e-mail, the lines, the totals, `paidOn` (the date of the latest payment once the document is paid), `payUrl` (as in `sales/invoices/payment-link`) and `token`, the document's customer token for `public/invoices/get` and `public/invoices/pdf`, created on first use; `token` is null on a draft.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesViewAsync(new InvoicesViewSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesViewSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesSendAsync</a>(InvoicesSendSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesSendSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

E-mail an issued sale document as a PDF attachment to `to`, else to the partner's e-mail address, and emit `sale_invoice.sent`. The PDF is the one of `sales/invoices/pdf`. With `quote: true` the document must be a draft: it is e-mailed as a quote (PDF titled quote, no payment link), stays a draft, and `sale_invoice.quote_sent` is emitted instead. Answers 422 when e-mail sending is not configured, when the document is not issued (or, with `quote`, not a draft), or when neither `to` nor the partner's e-mail is set.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesSendAsync(new InvoicesSendSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesSendSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesPeppolXmlAsync</a>(InvoicesPeppolXmlSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesPeppolXmlSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Render an issued invoice or credit note as a Peppol BIS Billing 3.0 UBL file, returned base64-encoded with the sender and receiver participant identifiers, without sending it; `sales/invoices/peppol-send` sends the same file. Answers 422 for a draft, a proforma or an advance invoice.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesPeppolXmlAsync(new InvoicesPeppolXmlSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesPeppolXmlSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesPeppolSendAsync</a>(InvoicesPeppolSendSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesPeppolSendSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Send an issued invoice or credit note to the customer over Peppol through the company's own access point (Account → Compliance → EU; Nordlet supports Recommand, Storecove and e-invoice.be). Without one the call is refused with 422 and the document can only be downloaded with `sales/invoices/peppol-xml`. `status` is `pending` until the receiving access point confirms, then `delivered`; `failed` and `rejected` come with `detail`, and the invoice can then be sent again. Later changes arrive through the access point's webhook and are announced as `sale_invoice.peppol_delivered`, `sale_invoice.peppol_rejected` and `sale_invoice.peppol_failed`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesPeppolSendAsync(new InvoicesPeppolSendSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesPeppolSendSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesPeppolStatusAsync</a>(InvoicesPeppolStatusSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesPeppolStatusSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Ask the company's Peppol access point what happened to an invoice sent with `sales/invoices/peppol-send`, and store the answer: `pending`, `delivered` (the receiving access point confirmed it), `rejected` (the receiver refused it, see `detail`) or `failed` (it could not be delivered, see `detail`). The access point's webhook updates the same fields without this call. Storecove has no call for the status of a sent document, so for a Storecove access point this answers 422 and the status comes only from its webhook.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesPeppolStatusAsync(new InvoicesPeppolStatusSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesPeppolStatusSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesEinvoiceXmlAsync</a>(InvoicesEinvoiceXmlSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesEinvoiceXmlSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Render an issued invoice as the national e-invoicing payload for the company country: FatturaPA (IT), KSeF FA(3) (PL) or UBL CIUS-RO (RO). Review the warnings - data the invoice does not carry is flagged, never invented.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesEinvoiceXmlAsync(new InvoicesEinvoiceXmlSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesEinvoiceXmlSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesEinvoiceSendAsync</a>(InvoicesEinvoiceSendSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesEinvoiceSendSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build the national e-invoicing payload and deliver it over the transport configured for the country gateway in compliance settings. With transport=direct the request talks to the tax authority itself - SdICoop over 2-way TLS for Italy, a KSeF session for Poland, ANAF SPV OAuth for Romania - and returns the national number as soon as the channel assigns one. With transport=bridge the payload goes to the configured bridge endpoint (an accredited intermediary or connector) instead.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesEinvoiceSendAsync(new InvoicesEinvoiceSendSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesEinvoiceSendSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesEinvoiceStatusAsync</a>(InvoicesEinvoiceStatusSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesEinvoiceStatusSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Ask the national e-invoicing channel what happened to an invoice that was already sent, and store the answer. Italy, Poland and Romania return the outcome only on request - none of them calls back - so this is the way the national number and any rejection reason reach the invoice.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesEinvoiceStatusAsync(
    new InvoicesEinvoiceStatusSalesRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesEinvoiceStatusSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesUpdateAsync</a>(InvoicesUpdateSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesUpdateSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change a draft sale document. Fields left out keep their value, `lines` replaces every line, a changed `discountPercent` recomputes the existing lines, and `salesTaxPercent` (invoices only, null removes it) recomputes the sales tax and the total. Answers 409 when the document is issued or locked, and 422 under the checks of `sales/invoices/create` (the credited document's partner and currency, the OSS and IOSS country, VAT on the lines, the operation type and document series).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesUpdateAsync(new InvoicesUpdateSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesUpdateSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesDeleteAsync</a>(InvoicesDeleteSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesDeleteSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a draft sale document and release the time entries billed on it. Answers 409 when the document is issued (credit it instead) or locked.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesDeleteAsync(new InvoicesDeleteSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesDeleteSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesIssueAsync</a>(InvoicesIssueSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesIssueSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Issue a draft sale document: assigns the next number (from its document series, else from `series` or the type's default prefix and the year), the issue date (`issueDate`, else the draft's, else today) and a missing due date from the partner's payment term, and for an invoice, credit note or advance invoice posts the journal entry and stores the VAT evidence. `warehouseId` (or the series' warehouse) takes the sold goods of an invoice out of stock with a cost of goods sold entry; `returnToStock` puts them back for a credit note that credits an invoice. A credit note is set against the unpaid balance of the credited document. Emits `sale_invoice.issued`, `sale_invoice.paid` when a credit note settles the credited invoice in full, and `intercompany.invoice_mirrored` when the partner is linked to another company of the group (a draft purchase invoice is created there). Answers 409 when the document is already issued or locked or the accounting period is locked, 422 when the lines carry VAT under a scheme that charges none, when credit notes would exceed the credited total, or when `returnToStock` is used on anything but a credit note of an invoice.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesIssueAsync(new InvoicesIssueSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesIssueSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesLockAsync</a>(InvoicesLockSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesLockSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lock a sale document. A locked document is refused with 409 by `sales/invoices/update`, `sales/invoices/delete`, `sales/invoices/issue` and `sales/invoices/apply-advance` until `sales/invoices/unlock`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesLockAsync(new InvoicesLockSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesLockSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesUnlockAsync</a>(InvoicesUnlockSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesUnlockSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Unlock a sale document locked with `sales/invoices/lock`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesUnlockAsync(new InvoicesUnlockSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesUnlockSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesPaymentLinkAsync</a>(InvoicesPaymentLinkSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesPaymentLinkSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the customer payment link of a sale document: the Stripe card payment page (`source` `stripe`) when the company's Stripe account is connected and can take charges (`sales/invoices/card-payments/get`), else the link rendered from the company's payment link template (`sales/invoices/payment-settings/update`, `source` `template`); `url` is null when the company has neither, the document is not issued or its `payLinkEnabled` is false. The document's payment token is created on first use. Answers 409 when the document is already paid.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesPaymentLinkAsync(new InvoicesPaymentLinkSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesPaymentLinkSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesPaymentSettingsGetAsync</a>(InvoicesPaymentSettingsGetSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesPaymentSettingsGetSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the company's payment link template, the https URL that `sales/invoices/payment-link`, the invoice PDF and the invoice e-mail fill in for an issued, unpaid document.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesPaymentSettingsGetAsync(new InvoicesPaymentSettingsGetSalesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesPaymentSettingsGetSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesPaymentSettingsUpdateAsync</a>(InvoicesPaymentSettingsUpdateSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesPaymentSettingsUpdateSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Set or clear (null) the company's payment link template: an https URL in which `{{number}}`, `{{amount}}` (the unpaid balance), `{{currency}}`, `{{token}}`, `{{invoiceId}}` and `{{partnerName}}` are replaced, URL-encoded, when a link is rendered.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesPaymentSettingsUpdateAsync(
    new InvoicesPaymentSettingsUpdateSalesRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesPaymentSettingsUpdateSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RecognitionSchedulesListAsync</a>(RecognitionSchedulesListSalesRequest { ... }) -> WithRawResponseTask&lt;RecognitionSchedulesListSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the revenue recognition schedules: the tranches of deferred income of issued invoices whose lines are recognised ratably, by milestone or by percent complete, each with its status and the journal transaction that recognised it. Filterable by invoiceId, invoiceLineId, status, method and scheduleDate; sortable by scheduleDate and createdAt.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.RecognitionSchedulesListAsync(new RecognitionSchedulesListSalesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RecognitionSchedulesListSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesApplyAdvanceAsync</a>(InvoicesApplyAdvanceSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesApplyAdvanceSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Apply a fully paid advance invoice to an issued invoice of the same partner: posts the settlement journal entry dated `date` (default today), with the applied amount's share of the advance VAT, and records the amount as a payment of the invoice. `amount` defaults to the smaller of the unapplied advance and the invoice's unpaid balance. Emits `sale_invoice.paid` when the invoice becomes fully paid. Answers 409 when the advance is not fully paid, is already applied or credited, when the invoice has nothing left to pay, or when `amount` exceeds the unapplied advance or the unpaid balance; 422 when the advance is not in the company's base currency or the two documents differ in currency.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesApplyAdvanceAsync(
    new InvoicesApplyAdvanceSalesRequest { AdvanceId = "advanceId", InvoiceId = "invoiceId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesApplyAdvanceSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesListAsync</a>(InvoicesListSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesListSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the sale documents of the company with the partner name. Filterable by partnerId, type, status, paymentStatus, fullNumber, issueDate, currency, agreementId, creditedInvoiceId, operationTypeId, documentSeriesId, lockedAt, grossTotal, netTotal, vatTotal, dueDate, orderNumber, seriesLabel, locale and recurringInvoiceId; sortable by createdAt, issueDate, fullNumber, grossTotal, netTotal, vatTotal, status and paymentStatus.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesListAsync(new InvoicesListSalesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesListSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">ActsCreateAsync</a>(ActsCreateSalesRequest { ... }) -> WithRawResponseTask&lt;ActsCreateSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a draft delivery act of goods or services (`type`) for a partner, dated `documentDate` (default today). Lines come from `lines`, else from the sale invoice in `saleInvoiceId`, else the act has none; the number is assigned by `sales/acts/issue`. Answers 422 when the sale invoice belongs to another partner or, when its lines are copied, has none.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.ActsCreateAsync(new ActsCreateSalesRequest { PartnerId = "partnerId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ActsCreateSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">ActsUpdateAsync</a>(ActsUpdateSalesRequest { ... }) -> WithRawResponseTask&lt;ActsUpdateSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change a draft delivery act; fields left out keep their value and `lines` replaces every line. Answers 409 when the act is issued or cancelled, 422 when the linked sale invoice belongs to another partner.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.ActsUpdateAsync(new ActsUpdateSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ActsUpdateSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">ActsIssueAsync</a>(ActsIssueSalesRequest { ... }) -> WithRawResponseTask&lt;ActsIssueSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Issue a draft delivery act: assigns the next number of its series for the year of the document date. When the act is linked to a sale invoice with pending milestone recognition schedules, they are all recognised on the act's document date, which posts the recognition journal entry and emits `revenue_recognition.posted`. Answers 409 when the act is not a draft, 422 when it has no lines.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.ActsIssueAsync(new ActsIssueSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ActsIssueSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">ActsCancelAsync</a>(ActsCancelSalesRequest { ... }) -> WithRawResponseTask&lt;ActsCancelSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Cancel a draft or issued delivery act. Answers 409 when it is already cancelled.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.ActsCancelAsync(new ActsCancelSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ActsCancelSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">ActsGetAsync</a>(ActsGetSalesRequest { ... }) -> WithRawResponseTask&lt;ActsGetSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one delivery act with its lines.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.ActsGetAsync(new ActsGetSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ActsGetSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">ActsListAsync</a>(ActsListSalesRequest { ... }) -> WithRawResponseTask&lt;ActsListSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List delivery acts. Filterable by status, type, partnerId and documentDate; sortable by createdAt, documentDate and fullNumber.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.ActsListAsync(new ActsListSalesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ActsListSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">ActsPdfAsync</a>(ActsPdfSalesRequest { ... }) -> WithRawResponseTask&lt;ActsPdfSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Render a delivery act as a PDF in `locale`, returned base64-encoded, with the number of the linked sale invoice when there is one.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.ActsPdfAsync(new ActsPdfSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ActsPdfSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoiceTemplatesCreateAsync</a>(InvoiceTemplatesCreateSalesRequest { ... }) -> WithRawResponseTask&lt;InvoiceTemplatesCreateSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a named template for invoices or credit notes (`documentType`): the header defaults and the lines that `sales/recurring-invoices/generate` turns into invoices. Answers 422 when a referenced partner, agreement, operation type, document series, catalog item or project does not exist or the series is for another document type; 409 when a template with that name exists.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoiceTemplatesCreateAsync(
    new InvoiceTemplatesCreateSalesRequest { Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoiceTemplatesCreateSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoiceTemplatesUpdateAsync</a>(InvoiceTemplatesUpdateSalesRequest { ... }) -> WithRawResponseTask&lt;InvoiceTemplatesUpdateSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change a template; fields left out keep their value and `lines` replaces every line. The 422 reference checks of `sales/invoice-templates/create` apply; 409 when the new name is taken.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoiceTemplatesUpdateAsync(
    new InvoiceTemplatesUpdateSalesRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoiceTemplatesUpdateSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoiceTemplatesGetAsync</a>(InvoiceTemplatesGetSalesRequest { ... }) -> WithRawResponseTask&lt;InvoiceTemplatesGetSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one invoice template.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoiceTemplatesGetAsync(new InvoiceTemplatesGetSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoiceTemplatesGetSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoiceTemplatesDeleteAsync</a>(InvoiceTemplatesDeleteSalesRequest { ... }) -> WithRawResponseTask&lt;InvoiceTemplatesDeleteSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete an invoice template.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoiceTemplatesDeleteAsync(
    new InvoiceTemplatesDeleteSalesRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoiceTemplatesDeleteSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoiceTemplatesListAsync</a>(InvoiceTemplatesListSalesRequest { ... }) -> WithRawResponseTask&lt;InvoiceTemplatesListSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List invoice templates. Filterable by name, documentType and partnerId; sortable by name, documentType and createdAt.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoiceTemplatesListAsync(new InvoiceTemplatesListSalesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoiceTemplatesListSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RecurringInvoicesCreateAsync</a>(RecurringInvoicesCreateSalesRequest { ... }) -> WithRawResponseTask&lt;RecurringInvoicesCreateSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a schedule that generates invoices from an invoice template every `interval` periods of `frequency` from `startDate` (the first run) until `endDate`, for `partnerId` or else the template's partner. `autoIssue` issues each generated invoice and `autoSend` e-mails it to `sendTo`, else to the partner. Invoices are generated by `sales/recurring-invoices/run`, `sales/recurring-invoices/generate` and the scheduled job `recurring-invoices`. Answers 422 when the template is a credit note template, when neither the schedule nor the template names a partner, when `endDate` is before `startDate`, or when `autoSend` is set without `autoIssue`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.RecurringInvoicesCreateAsync(
    new RecurringInvoicesCreateSalesRequest
    {
        TemplateId = "templateId",
        StartDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RecurringInvoicesCreateSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RecurringInvoicesUpdateAsync</a>(RecurringInvoicesUpdateSalesRequest { ... }) -> WithRawResponseTask&lt;RecurringInvoicesUpdateSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change a schedule; fields left out keep their value. A change of `startDate`, `frequency` or `interval` moves `nextRunDate` to the first occurrence of the new grid on or after the current next run (or the new start date, if later); an explicit `nextRunDate` wins. `status` switches between `active` and `paused`; a next run past `endDate` makes the schedule `finished`. The 422 checks of `sales/recurring-invoices/create` apply.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.RecurringInvoicesUpdateAsync(
    new RecurringInvoicesUpdateSalesRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RecurringInvoicesUpdateSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RecurringInvoicesGetAsync</a>(RecurringInvoicesGetSalesRequest { ... }) -> WithRawResponseTask&lt;RecurringInvoicesGetSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one recurring invoice schedule with the names of its template and partner.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.RecurringInvoicesGetAsync(new RecurringInvoicesGetSalesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RecurringInvoicesGetSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RecurringInvoicesDeleteAsync</a>(RecurringInvoicesDeleteSalesRequest { ... }) -> WithRawResponseTask&lt;RecurringInvoicesDeleteSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a recurring invoice schedule. The invoices it generated stay.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.RecurringInvoicesDeleteAsync(
    new RecurringInvoicesDeleteSalesRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RecurringInvoicesDeleteSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RecurringInvoicesGenerateAsync</a>(RecurringInvoicesGenerateSalesRequest { ... }) -> WithRawResponseTask&lt;RecurringInvoicesGenerateSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Generate the next invoice of a schedule now, dated its `nextRunDate`: creates a draft from the template (due date from the template's payment term, VAT scheme from the template or else resolved for the partner and supply type), issues it when `autoIssue` is set and e-mails it when `autoSend` is set, then moves the schedule to its next occurrence (or to `finished` after the last one) and emits `recurring_invoice.generated`. A failure to issue or send comes back in `error` and is stored as `lastError`; the draft stays. Answers 409 when the schedule is finished, 422 when the template is a credit note template or has no lines.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.RecurringInvoicesGenerateAsync(
    new RecurringInvoicesGenerateSalesRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RecurringInvoicesGenerateSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RecurringInvoicesRunAsync</a>(RecurringInvoicesRunSalesRequest { ... }) -> WithRawResponseTask&lt;RecurringInvoicesRunSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Generate every invoice due up to `asOfDate` (default today) from the active schedules of the company, catching up to 60 missed occurrences per schedule, as `sales/recurring-invoices/generate` does for one; each generated invoice emits `recurring_invoice.generated`. The answer lists what was generated and the schedules that failed; a failure is also stored as the schedule's `lastError`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.RecurringInvoicesRunAsync(new RecurringInvoicesRunSalesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RecurringInvoicesRunSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RecurringInvoicesListAsync</a>(RecurringInvoicesListSalesRequest { ... }) -> WithRawResponseTask&lt;RecurringInvoicesListSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List recurring invoice schedules with the names of their template and partner. Filterable by status, partnerId, templateId, frequency, nextRunDate and autoIssue; sortable by nextRunDate, startDate, status, frequency and createdAt.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.RecurringInvoicesListAsync(new RecurringInvoicesListSalesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RecurringInvoicesListSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RecognitionComputeAsync</a>(RecognitionComputeSalesRequest { ... }) -> WithRawResponseTask&lt;RecognitionComputeSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Preview the pending ratable revenue schedules due on or before `asOfDate` (default the company's current date) with their total; nothing is posted. `sales/recognition/run` posts them.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.RecognitionComputeAsync(new RecognitionComputeSalesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RecognitionComputeSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RecognitionRunAsync</a>(RecognitionRunSalesRequest { ... }) -> WithRawResponseTask&lt;RecognitionRunSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Recognise deferred revenue: posts one journal entry dated `postingDate` (default `asOfDate`, default the company's current date) that debits the deferred income account and credits each line's revenue account, for the pending ratable schedules due on or before `asOfDate` or for exactly the `scheduleIds` given, marks them recognised, records a run with trigger `manual` and emits `revenue_recognition.posted`. Answers 422 when nothing is due or a given schedule is missing or no longer pending, and 409 when the posting period is locked. Due ratable schedules are also posted by the scheduler once their date has passed (trigger `schedule_due`).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.RecognitionRunAsync(new RecognitionRunSalesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RecognitionRunSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RecognitionProgressAsync</a>(RecognitionProgressSalesRequest { ... }) -> WithRawResponseTask&lt;RecognitionProgressSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Report the percentage of completion of a `percent_complete` invoice line and recognise the revenue up to it: a schedule for the difference between the revenue due at that percentage and the amount already recognised is created and posted at once, dated `date` (default the company's current date), as a run with trigger `progress` that emits `revenue_recognition.posted`. Refused with 422 when the line is not `percent_complete`, the invoice is not an issued standard invoice, the percentage is 0 or above 100, or nothing new is to be recognised; 409 when the period is locked.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.RecognitionProgressAsync(
    new RecognitionProgressSalesRequest
    {
        InvoiceLineId = "invoiceLineId",
        PercentComplete = "121.00",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RecognitionProgressSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RecognitionModifyAsync</a>(RecognitionModifySalesRequest { ... }) -> WithRawResponseTask&lt;RecognitionModifySalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Apply an IFRS 15 contract modification to a deferred invoice line. Prospective: cancel the pending schedule and respread the unrecognized remainder over the new terms. Cumulative catch-up (ratable only): recompute revenue as if the new terms applied from the start and post the difference immediately.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.RecognitionModifyAsync(
    new RecognitionModifySalesRequest
    {
        InvoiceLineId = "invoiceLineId",
        Approach = RecognitionModifySalesRequestApproach.Prospective,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RecognitionModifySalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RecognitionRunsListAsync</a>(RecognitionRunsListSalesRequest { ... }) -> WithRawResponseTask&lt;RecognitionRunsListSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the revenue recognition runs, newest first; filterable by `runDate` and `trigger`, sortable by `runDate` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.RecognitionRunsListAsync(new RecognitionRunsListSalesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RecognitionRunsListSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RecognitionSummaryAsync</a>(RecognitionSummarySalesRequest { ... }) -> WithRawResponseTask&lt;RecognitionSummarySalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deferred revenue per line of the issued standard invoices whose recognition method is not `point_in_time`: the deferred total, the amount recognised so far, the remainder, the number of pending schedules and the next schedule date, with totals; `invoiceId` limits it to one invoice. For a `percent_complete` line the deferred total is the line's base amount, for the other methods the sum of its schedules.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.RecognitionSummaryAsync(new RecognitionSummarySalesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RecognitionSummarySalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RefundLiabilityListAsync</a>(RefundLiabilityListSalesRequest { ... }) -> WithRawResponseTask&lt;RefundLiabilityListSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the refund liabilities of issued invoices (created at issue from the lines' `refundEstimatePercent` or by `sales/refund-liability/true-up`): the estimate, the part consumed by credit notes, the settlement refunds and the remaining amount (estimate less consumed), with the invoice number. Filterable by invoiceId; sortable by createdAt and updatedAt.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.RefundLiabilityListAsync(new RefundLiabilityListSalesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RefundLiabilityListSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RefundLiabilityTrueUpAsync</a>(RefundLiabilityTrueUpSalesRequest { ... }) -> WithRawResponseTask&lt;RefundLiabilityTrueUpSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Re-estimate the refund liability of an issued standard invoice to `estimatedTotal` and post the difference on `date` (default today) between the refund liability account and the invoice's revenue accounts, in proportion to the lines' allocated or net amounts; creates the liability when the invoice has none. Emits `refund_liability.trued_up`. Answers 422 when the invoice is not an issued standard invoice, when the estimate is below the amount already consumed or unchanged, or when the invoice has no revenue to allocate against; 409 when the accounting period is locked.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.RefundLiabilityTrueUpAsync(
    new RefundLiabilityTrueUpSalesRequest { InvoiceId = "invoiceId", EstimatedTotal = "121.0000" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RefundLiabilityTrueUpSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PaymentsListAsync</a>(PaymentsListSalesRequest { ... }) -> WithRawResponseTask&lt;PaymentsListSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the money received on sale documents between `from` and `to` (inclusive), oldest first: bank payments matched to the document, card settlements of a payment provider and cash receipt orders. A reversed bank match is a row with a negative amount on the date it was reversed. Credit notes, advances applied to a final invoice and balances carried over by a migration are not money received and are left out. `amount` is in the document currency; `method` is `card` for a settlement or a payment into a Stripe bank account, `cash` for a cash order and `bank_transfer` otherwise.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PaymentsListAsync(
    new PaymentsListSalesRequest { From = new DateOnly(2026, 7, 1), To = new DateOnly(2026, 7, 1) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PaymentsListSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">ExportsMonthAsync</a>(ExportsMonthSalesRequest { ... }) -> WithRawResponseTask&lt;ExportsMonthSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Export one calendar month for the accountant as a single file: every invoice and credit note issued in the month (number, dates, client, currency, net, VAT, total and the amount paid so far) and every payment received in the month as listed by `sales/payments/list`. `format` is `csv` (comma separated, UTF-8, one section per table) or `pdf`. `format` `nordlet` instead returns a JSON package that `migration/books/validate` and `migration/books/import` accept: every posted journal transaction dated in the month with its debit and credit lines, the accounts those lines use (with their parent accounts) and the partners of those transactions; its cutoverDate is the day after the month ends. The file comes back base64-encoded in `data`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.ExportsMonthAsync(
    new ExportsMonthSalesRequest { Month = "month", Format = ExportsMonthSalesRequestFormat.Csv }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ExportsMonthSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesCardPaymentsGetAsync</a>(InvoicesCardPaymentsGetSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesCardPaymentsGetSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return whether the company's Stripe account is connected for card payments and whether Stripe lets it take charges yet. While the account is connected but cannot take charges, Stripe is asked again on each call. When `chargesEnabled` is true, payment links of issued invoices open a Stripe Checkout page on that account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesCardPaymentsGetAsync(new InvoicesCardPaymentsGetSalesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesCardPaymentsGetSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesCardPaymentsConnectAsync</a>(InvoicesCardPaymentsConnectSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesCardPaymentsConnectSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Start or continue connecting the company's own Stripe account for card payments: creates the Stripe account on first use and returns the Stripe-hosted onboarding `url`. Stripe sends the user back to `returnUrl` when onboarding ends and to `refreshUrl` when the link has expired. Answers 503 when Stripe is not configured.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesCardPaymentsConnectAsync(
    new InvoicesCardPaymentsConnectSalesRequest
    {
        ReturnUrl = "returnUrl",
        RefreshUrl = "refreshUrl",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesCardPaymentsConnectSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesCardPaymentsDisconnectAsync</a>(InvoicesCardPaymentsDisconnectSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesCardPaymentsDisconnectSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Disconnect the company's Stripe account: payment links fall back to the payment link template. The Stripe account itself is left as it is.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.InvoicesCardPaymentsDisconnectAsync(
    new InvoicesCardPaymentsDisconnectSalesRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesCardPaymentsDisconnectSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## OperationTypes
<details><summary><code>client.OperationTypes.<a href="/src/NordletApi/OperationTypes/OperationTypesClient.cs">CreateAsync</a>(CreateOperationTypesRequest { ... }) -> WithRawResponseTask&lt;CreateOperationTypesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create an operation type: a `code` with the flags that say what it is for (`isSale`, `isPurchase`, ...), an optional `invoiceType` (`invoice`, `credit_note`, `proforma`, `advance`) and optional account codes. An invoice names it in `operationTypeId`: a sale invoice needs `isSale` and a matching `invoiceType`, a purchase invoice `isPurchase`, and the type's account codes then replace the default posting accounts when the invoice is issued (`sales/invoices/issue`) or registered (`purchases/invoices/register`). `includeInVatRegister: false` keeps the type's invoices out of the Lithuanian i.SAF and FR0600, `includeInSaft: false` out of the SAF-T file. Account codes must exist and be postable and `payerPartnerId` must be an active partner (422 otherwise); a repeated `code` is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.OperationTypes.CreateAsync(
    new CreateOperationTypesRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateOperationTypesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.OperationTypes.<a href="/src/NordletApi/OperationTypes/OperationTypesClient.cs">UpdateAsync</a>(UpdateOperationTypesRequest { ... }) -> WithRawResponseTask&lt;UpdateOperationTypesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change an operation type's fields; omitted ones keep their value. A `code` already used by another type is refused with 409, a body without changes with 400.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.OperationTypes.UpdateAsync(new UpdateOperationTypesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateOperationTypesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.OperationTypes.<a href="/src/NordletApi/OperationTypes/OperationTypesClient.cs">GetAsync</a>(GetOperationTypesRequest { ... }) -> WithRawResponseTask&lt;GetOperationTypesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read one operation type.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.OperationTypes.GetAsync(new GetOperationTypesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetOperationTypesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.OperationTypes.<a href="/src/NordletApi/OperationTypes/OperationTypesClient.cs">DeleteAsync</a>(DeleteOperationTypesRequest { ... }) -> WithRawResponseTask&lt;DeleteOperationTypesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete an operation type that no sale invoice, purchase invoice or document series refers to. Otherwise the call is refused with 409; deactivate the type with `operation-types/update` instead.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.OperationTypes.DeleteAsync(new DeleteOperationTypesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteOperationTypesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.OperationTypes.<a href="/src/NordletApi/OperationTypes/OperationTypesClient.cs">ListAsync</a>(ListOperationTypesRequest { ... }) -> WithRawResponseTask&lt;ListOperationTypesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List operation types. Filterable by `code`, `name`, `isSale`, `isPurchase` and `isActive`; sortable by `code`, `name`, `sortOrder` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.OperationTypes.ListAsync(new ListOperationTypesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListOperationTypesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## DocumentSeries
<details><summary><code>client.DocumentSeries.<a href="/src/NordletApi/DocumentSeries/DocumentSeriesClient.cs">CreateAsync</a>(CreateDocumentSeriesRequest { ... }) -> WithRawResponseTask&lt;CreateDocumentSeriesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a numbering series for sale invoices, credit notes, proformas or advance invoices (`documentType`). Numbers run from `nextNumber`, padded to `numberLength` digits, and are written as `prefix`-number or, with `printSeries` false, as the bare number; a series may be bound to an operation type (a default series of an operation type is picked for its documents that name no series) and to a warehouse, which `sales/invoices/issue` takes the goods from. `isDefault` makes it the default of its document type and clears the previous one. Answers 422 when only one end of the allocated range `allocatedFrom`..`allocatedTo` is given or the range is reversed, 409 when the prefix exists for the document type.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.DocumentSeries.CreateAsync(new CreateDocumentSeriesRequest { Prefix = "prefix" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateDocumentSeriesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.DocumentSeries.<a href="/src/NordletApi/DocumentSeries/DocumentSeriesClient.cs">UpdateAsync</a>(UpdateDocumentSeriesRequest { ... }) -> WithRawResponseTask&lt;UpdateDocumentSeriesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change a document series; fields left out keep their value. `nextNumber` cannot go below its current value (409); `isDefault` clears the previous default of the document type. Answers 422 for an incomplete or reversed allocated range, 409 when the prefix is taken for the document type.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.DocumentSeries.UpdateAsync(new UpdateDocumentSeriesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateDocumentSeriesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.DocumentSeries.<a href="/src/NordletApi/DocumentSeries/DocumentSeriesClient.cs">GetAsync</a>(GetDocumentSeriesRequest { ... }) -> WithRawResponseTask&lt;GetDocumentSeriesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one document series.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.DocumentSeries.GetAsync(new GetDocumentSeriesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetDocumentSeriesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.DocumentSeries.<a href="/src/NordletApi/DocumentSeries/DocumentSeriesClient.cs">DeleteAsync</a>(DeleteDocumentSeriesRequest { ... }) -> WithRawResponseTask&lt;DeleteDocumentSeriesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a document series no sale document uses. Answers 409 when invoices reference it; deactivate it with `isActive` instead.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.DocumentSeries.DeleteAsync(new DeleteDocumentSeriesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteDocumentSeriesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.DocumentSeries.<a href="/src/NordletApi/DocumentSeries/DocumentSeriesClient.cs">ListAsync</a>(ListDocumentSeriesRequest { ... }) -> WithRawResponseTask&lt;ListDocumentSeriesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List document series. Filterable by documentType, prefix, operationTypeId and isActive; sortable by prefix, documentType and createdAt.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.DocumentSeries.ListAsync(new ListDocumentSeriesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListDocumentSeriesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## purchases
<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">InvoicesCreateAsync</a>(InvoicesCreatePurchasesRequest { ... }) -> WithRawResponseTask&lt;InvoicesCreatePurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a draft purchase invoice or credit note (`type`) from a supplier document; it is posted with `purchases/invoices/register`. Lines without a unit price take the item's supplier or purchase price, `currency` defaults to the company's invoice currency, `documentRef` links an uploaded file, and the gross total leaves out self-assessed VAT. `creditedInvoiceId` (credit notes only) must be an invoice of the same partner, `purchaseOrderId` an order of the same partner that is not draft, submitted or cancelled, and `operationTypeId` an active purchase operation type, each 422 otherwise; the same `documentNumber` for the same partner is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.InvoicesCreateAsync(
    new InvoicesCreatePurchasesRequest
    {
        PartnerId = "partnerId",
        DocumentNumber = "documentNumber",
        DocumentDate = new DateOnly(2026, 7, 1),
        Lines = new List<InvoicesCreatePurchasesRequestLinesItem>()
        {
            new InvoicesCreatePurchasesRequestLinesItem(),
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesCreatePurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">InvoicesGetAsync</a>(InvoicesGetPurchasesRequest { ... }) -> WithRawResponseTask&lt;InvoicesGetPurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one purchase invoice or credit note with its lines.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.InvoicesGetAsync(new InvoicesGetPurchasesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesGetPurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">InvoicesUpdateAsync</a>(InvoicesUpdatePurchasesRequest { ... }) -> WithRawResponseTask&lt;InvoicesUpdatePurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change a draft purchase invoice (409 once registered); only the fields sent are changed, and `lines` replace all existing lines with the totals recomputed. `purchaseOrderId` and `operationTypeId` are checked as on `purchases/invoices/create` (422). A `documentNumber` already used for the partner is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.InvoicesUpdateAsync(new InvoicesUpdatePurchasesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesUpdatePurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">InvoicesDeleteAsync</a>(InvoicesDeletePurchasesRequest { ... }) -> WithRawResponseTask&lt;InvoicesDeletePurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Mark a draft purchase invoice as deleted (409 once registered). A document capture linked to it goes back to `extracted` (or `pending` when it has no extraction) and can be confirmed again.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.InvoicesDeleteAsync(new InvoicesDeletePurchasesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesDeletePurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">InvoicesRegisterAsync</a>(InvoicesRegisterPurchasesRequest { ... }) -> WithRawResponseTask&lt;InvoicesRegisterPurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Register a draft purchase invoice or credit note: posts the journal entry dated `registrationDate` (default the document date) and sets the status to `registered`. The entry debits each line's expense account (the line's `accountCode`, else the item's purchase or expense account, else the operation type's expense account, else the `purchases.goodsForResale` or `purchases.defaultExpense` rule account), debits VAT receivable (a company that is not a VAT payer books the VAT into the expense instead), credits payables (the operation type's credit account when set) and credits output VAT for self-assessed VAT; a credit note posts the reverse. Lines with `deferralStartDate` and `deferralEndDate` are debited to the `purchases.prepaidExpenses` account instead and get a monthly release schedule for `purchases/deferrals/post`. With `warehouseId` the product lines of an invoice are received into stock at their base-currency cost (422 on an order-linked invoice, whose goods arrive through `purchases/receipts/create`, and for a line that is also deferred); `returnFromStock` on a credit note that credits an invoice takes the goods back out of stock at their FIFO cost and books the difference to the credited amount on the `inventory.cogs` account (422 on an invoice, without `creditedInvoiceId`, or when no goods of the credited invoice are in stock). A credit note that credits a registered invoice in the same currency is applied to it as a payment up to the open amount. Refused with 409 when already registered or the accounting period is locked, and with 422 when the credit notes would exceed the credited invoice, a posting account is missing or no exchange rate exists for the date. Emits `purchase_invoice.registered`, `purchase_invoice.paid` when the credited invoice becomes fully paid, and `stock.changed` when stock moves.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.InvoicesRegisterAsync(new InvoicesRegisterPurchasesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesRegisterPurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">DeferralsListAsync</a>(DeferralsListPurchasesRequest { ... }) -> WithRawResponseTask&lt;DeferralsListPurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the monthly release rows that `purchases/invoices/register` creates for lines booked as prepaid expenses, each with its amount, expense and prepaid account and `status` (`pending`, `posted`, `cancelled`). Filterable by `invoiceId`, `status` and `scheduleDate`; sortable by `scheduleDate`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.DeferralsListAsync(new DeferralsListPurchasesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeferralsListPurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">DeferralsPostAsync</a>(DeferralsPostPurchasesRequest { ... }) -> WithRawResponseTask&lt;DeferralsPostPurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Post every `pending` prepaid-expense release row dated on or before `asOfDate` (default today in the company's time zone): one journal entry per schedule date debiting the expense account and crediting the prepaid account, and the rows become `posted`. A locked accounting period is refused with 409. The scheduled job `expense-deferrals` runs the same release for every active company.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.DeferralsPostAsync(new DeferralsPostPurchasesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeferralsPostPurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">InvoicesListAsync</a>(InvoicesListPurchasesRequest { ... }) -> WithRawResponseTask&lt;InvoicesListPurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List purchase invoices and credit notes without lines, with the supplier's `partnerName`. Filterable by `partnerId`, `type`, `status`, `paymentStatus`, `documentNumber`, `documentDate`, `currency`, `operationTypeId`, `purchaseOrderId`, `grossTotal`, `netTotal`, `vatTotal` and `dueDate`; sortable by `createdAt`, `documentDate`, `documentNumber`, `grossTotal` and `dueDate`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.InvoicesListAsync(new InvoicesListPurchasesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesListPurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">OrdersCreateAsync</a>(OrdersCreatePurchasesRequest { ... }) -> WithRawResponseTask&lt;OrdersCreatePurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a draft purchase order for a supplier. Lines without a unit price take the item's supplier or purchase price; `orderNumber` comes from the `purchase_order` series with prefix PO when not given; `currency` defaults to the company's invoice currency; `documentRef` links an uploaded file to the order. A number already in use is refused with 409. The order continues with `purchases/orders/submit`, `purchases/orders/approve` and `purchases/receipts/create`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.OrdersCreateAsync(
    new OrdersCreatePurchasesRequest
    {
        PartnerId = "partnerId",
        OrderDate = new DateOnly(2026, 7, 1),
        Lines = new List<OrdersCreatePurchasesRequestLinesItem>()
        {
            new OrdersCreatePurchasesRequestLinesItem(),
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersCreatePurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">OrdersUpdateAsync</a>(OrdersUpdatePurchasesRequest { ... }) -> WithRawResponseTask&lt;OrdersUpdatePurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change a draft purchase order (409 once it is submitted); only the fields sent are changed. `lines` replace all existing lines and the totals are recomputed.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.OrdersUpdateAsync(new OrdersUpdatePurchasesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersUpdatePurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">OrdersGetAsync</a>(OrdersGetPurchasesRequest { ... }) -> WithRawResponseTask&lt;OrdersGetPurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one purchase order with its lines; each line carries `receivedQty` and `remainingQty`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.OrdersGetAsync(new OrdersGetPurchasesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersGetPurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">OrdersListAsync</a>(OrdersListPurchasesRequest { ... }) -> WithRawResponseTask&lt;OrdersListPurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List purchase orders without lines, with the supplier's `partnerName`. Filterable by `partnerId`, `status`, `orderNumber`, `orderDate`, `currency` and `grossTotal`; sortable by `createdAt`, `orderDate`, `orderNumber` and `grossTotal`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.OrdersListAsync(new OrdersListPurchasesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersListPurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">OrdersSubmitAsync</a>(OrdersSubmitPurchasesRequest { ... }) -> WithRawResponseTask&lt;OrdersSubmitPurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Move a `draft` purchase order to `submitted` for approval (409 from any other status). `reason` is kept in the audit log.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.OrdersSubmitAsync(new OrdersSubmitPurchasesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersSubmitPurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">OrdersApproveAsync</a>(OrdersApprovePurchasesRequest { ... }) -> WithRawResponseTask&lt;OrdersApprovePurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Approve a `submitted` purchase order (409 from any other status), recording who approved it and when; needs the `purchases:approve` scope. Goods are then received with `purchases/receipts/create`. Emits `purchase_order.approved`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.OrdersApproveAsync(new OrdersApprovePurchasesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersApprovePurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">OrdersRejectAsync</a>(OrdersRejectPurchasesRequest { ... }) -> WithRawResponseTask&lt;OrdersRejectPurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Send a `submitted` purchase order back to `draft` (409 from any other status); needs the `purchases:approve` scope. `reason` is kept in the audit log.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.OrdersRejectAsync(new OrdersRejectPurchasesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersRejectPurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">OrdersCancelAsync</a>(OrdersCancelPurchasesRequest { ... }) -> WithRawResponseTask&lt;OrdersCancelPurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Cancel a `draft`, `submitted` or `approved` purchase order (409 from any other status, or when the order already has a goods receipt).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.OrdersCancelAsync(new OrdersCancelPurchasesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersCancelPurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">OrdersCloseAsync</a>(OrdersClosePurchasesRequest { ... }) -> WithRawResponseTask&lt;OrdersClosePurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Close an `approved`, `partially_received` or `received` purchase order (409 from any other status); a closed order accepts no further goods receipts.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.OrdersCloseAsync(new OrdersClosePurchasesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersClosePurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">OrdersDeleteAsync</a>(OrdersDeletePurchasesRequest { ... }) -> WithRawResponseTask&lt;OrdersDeletePurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Mark a `draft` purchase order as deleted (409 once it is submitted).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.OrdersDeleteAsync(new OrdersDeletePurchasesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersDeletePurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">ReceiptsCreateAsync</a>(ReceiptsCreatePurchasesRequest { ... }) -> WithRawResponseTask&lt;ReceiptsCreatePurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Record a goods receipt against an `approved` or `partially_received` purchase order (409 otherwise), numbered from the `goods_receipt` series with prefix GR. Lines whose item is a product go into stock in `warehouseId`, else the order's warehouse (422 when neither is set), at their share of the order line's net amount converted at the receipt date's rate; `lotNumber` and `expiryDate` receive them into a lot, and an item that needs lot or serial tracking is refused with 422 without one. A quantity above the line's remaining quantity is refused with 409; the order becomes `received` when every line is fully received, else `partially_received`. Emits `goods_receipt.posted`, `stock.changed` and, when fully received, `purchase_order.received`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.ReceiptsCreateAsync(
    new ReceiptsCreatePurchasesRequest
    {
        OrderId = "orderId",
        ReceiptDate = new DateOnly(2026, 7, 1),
        Lines = new List<ReceiptsCreatePurchasesRequestLinesItem>()
        {
            new ReceiptsCreatePurchasesRequestLinesItem
            {
                OrderLineId = "orderLineId",
                Quantity = "121.0000",
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReceiptsCreatePurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">ReceiptsGetAsync</a>(ReceiptsGetPurchasesRequest { ... }) -> WithRawResponseTask&lt;ReceiptsGetPurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one goods receipt with its lines and their stock movement ids.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.ReceiptsGetAsync(new ReceiptsGetPurchasesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReceiptsGetPurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">ReceiptsListAsync</a>(ReceiptsListPurchasesRequest { ... }) -> WithRawResponseTask&lt;ReceiptsListPurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List goods receipts without lines. Filterable by `orderId`, `warehouseId`, `receiptDate` and `receiptNumber`; sortable by `createdAt` and `receiptDate`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.ReceiptsListAsync(new ReceiptsListPurchasesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReceiptsListPurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">InvoicesMatchAsync</a>(InvoicesMatchPurchasesRequest { ... }) -> WithRawResponseTask&lt;InvoicesMatchPurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Compare a purchase invoice with its linked purchase order and the goods received so far, grouped by item (by description for lines without one). Each row is `matched`, `not_received` (invoiced but nothing received), `over_invoiced` (invoiced more than received), `price_mismatch` (unit price differs by more than `priceTolerancePercent`), `not_on_order` or `not_invoiced`; `status` is `mismatched` when any row other than `not_invoiced` is not matched. Refused with 422 when the invoice has no `purchaseOrderId` or its currency differs from the order's. Nothing is changed.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.InvoicesMatchAsync(
    new InvoicesMatchPurchasesRequest { InvoiceId = "invoiceId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesMatchPurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## capture
<details><summary><code>client.Capture.<a href="/src/NordletApi/Capture/CaptureClient.cs">SettingsGetAsync</a>(SettingsGetCaptureRequest { ... }) -> WithRawResponseTask&lt;SettingsGetCaptureResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the company's document capture settings: whether intake by e-mail is enabled, whether e-mailed documents are read on arrival, the company's intake e-mail address and whether a reading provider is configured. The intake token behind the address is created on the first call.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Capture.SettingsGetAsync(new SettingsGetCaptureRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettingsGetCaptureRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Capture.<a href="/src/NordletApi/Capture/CaptureClient.cs">SettingsUpdateAsync</a>(SettingsUpdateCaptureRequest { ... }) -> WithRawResponseTask&lt;SettingsUpdateCaptureResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Switch `intakeEnabled` (documents sent to the intake address are accepted) and `captureAutoExtract` (they are read on arrival) on or off; at least one field is required.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Capture.SettingsUpdateAsync(new SettingsUpdateCaptureRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettingsUpdateCaptureRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Capture.<a href="/src/NordletApi/Capture/CaptureClient.cs">SettingsRegenerateIntakeAsync</a>(SettingsRegenerateIntakeCaptureRequest { ... }) -> WithRawResponseTask&lt;SettingsRegenerateIntakeCaptureResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Replace the company's intake token, so the previous intake e-mail address stops working and the settings come back with the new one.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Capture.SettingsRegenerateIntakeAsync(new SettingsRegenerateIntakeCaptureRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettingsRegenerateIntakeCaptureRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Capture.<a href="/src/NordletApi/Capture/CaptureClient.cs">InboundEmailAsync</a>(InboundEmailCaptureRequest { ... }) -> WithRawResponseTask&lt;InboundEmailCaptureResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Endpoint for the inbound e-mail provider (Postmark field names or the generic `to`, `from`, `subject` and `attachments` form). It needs the `x-inbound-secret` header and finds the company by the `intake+<token>@` recipient address (404 when unknown, 403 when intake is disabled). Every PDF, image, Word or PowerPoint attachment up to 10 MB becomes a `pending` capture (`accepted`), anything else is `skipped`; when the company has automatic reading on, is not on trial and a reading provider is configured, each capture is read at once.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Capture.InboundEmailAsync(new InboundEmailCaptureRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InboundEmailCaptureRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Capture.<a href="/src/NordletApi/Capture/CaptureClient.cs">DocumentsUploadAsync</a>(DocumentsUploadCaptureRequest { ... }) -> WithRawResponseTask&lt;DocumentsUploadCaptureResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Upload a supplier document (PDF, image, Word or PowerPoint, up to 10 MB; 422 for any other type) as a capture and read it at once. The result holds the extracted supplier, dates, totals and lines, the partner matched by VAT code, then partner code, then name, the raw text, and `status` `extracted` or `failed` with `error`. Needs a configured reading provider, is refused with 402 for a company on trial until its first top-up, and counts every page read as `ocr_page` usage. The draft is reviewed and saved with `capture/documents/confirm`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Capture.DocumentsUploadAsync(
    new DocumentsUploadCaptureRequest
    {
        FileName = "fileName",
        MimeType = "mimeType",
        Content = "content",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocumentsUploadCaptureRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Capture.<a href="/src/NordletApi/Capture/CaptureClient.cs">DocumentsExtractAsync</a>(DocumentsExtractCaptureRequest { ... }) -> WithRawResponseTask&lt;DocumentsExtractCaptureResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read a stored capture again and replace its draft (supplier, totals, lines, matched partner). A capture received over Peppol is parsed from its document again without a reading provider; any other needs the provider and, for a company on trial, the first top-up (402). Refused with 409 once the capture is linked to a purchase invoice.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Capture.DocumentsExtractAsync(new DocumentsExtractCaptureRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocumentsExtractCaptureRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Capture.<a href="/src/NordletApi/Capture/CaptureClient.cs">DocumentsGetAsync</a>(DocumentsGetCaptureRequest { ... }) -> WithRawResponseTask&lt;DocumentsGetCaptureResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one capture with its extraction and raw text.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Capture.DocumentsGetAsync(new DocumentsGetCaptureRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocumentsGetCaptureRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Capture.<a href="/src/NordletApi/Capture/CaptureClient.cs">DocumentsListAsync</a>(DocumentsListCaptureRequest { ... }) -> WithRawResponseTask&lt;DocumentsListCaptureResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List captures without raw text. Filterable by `status`, `matchedPartnerId` and `purchaseInvoiceId`; sortable by `createdAt` and `updatedAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Capture.DocumentsListAsync(new DocumentsListCaptureRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocumentsListCaptureRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Capture.<a href="/src/NordletApi/Capture/CaptureClient.cs">DocumentsDeleteAsync</a>(DocumentsDeleteCaptureRequest { ... }) -> WithRawResponseTask&lt;DocumentsDeleteCaptureResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a capture and its stored file (409 once it is linked to a purchase invoice).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Capture.DocumentsDeleteAsync(new DocumentsDeleteCaptureRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocumentsDeleteCaptureRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Capture.<a href="/src/NordletApi/Capture/CaptureClient.cs">DocumentsConfirmAsync</a>(DocumentsConfirmCaptureRequest { ... }) -> WithRawResponseTask&lt;DocumentsConfirmCaptureResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates the purchase invoice (or credit note, see `type`) from `lines`. Lines with the opposite sign go in `oppositeLines` and are saved as a second document of the opposite type for the same supplier: a purchase credit note against the new invoice, or a purchase invoice next to the new credit note. It is numbered `oppositeDocumentNumber`, by default the document number followed by "-CR" (credit note) or "-INV" (invoice).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Capture.DocumentsConfirmAsync(
    new DocumentsConfirmCaptureRequest
    {
        Id = "id",
        DocumentNumber = "documentNumber",
        DocumentDate = new DateOnly(2026, 7, 1),
        Lines = new List<DocumentsConfirmCaptureRequestLinesItem>()
        {
            new DocumentsConfirmCaptureRequestLinesItem(),
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocumentsConfirmCaptureRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## peppol
<details><summary><code>client.Peppol.<a href="/src/NordletApi/Peppol/PeppolClient.cs">ParticipantsLookupAsync</a>(ParticipantsLookupPeppolRequest { ... }) -> WithRawResponseTask&lt;ParticipantsLookupPeppolResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Look a receiver up on the Peppol network (SML and SMP) and say which Peppol BIS Billing 3.0 documents it accepts. Give `partnerId` to look up a partner by its Peppol ID, VAT code or registration code, or `participantId` as "<scheme>:<identifier>". Works without an access point.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Peppol.ParticipantsLookupAsync(new ParticipantsLookupPeppolRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ParticipantsLookupPeppolRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Peppol.<a href="/src/NordletApi/Peppol/PeppolClient.cs">WebhooksAsync</a>(WebhooksPeppolRequest { ... }) -> WithRawResponseTask&lt;WebhooksPeppolResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Apply one event: a delivery status event updates the Peppol status of the sale invoice with that message id and, when the status changes, emits `sale_invoice.peppol_delivered`, `sale_invoice.peppol_rejected` or `sale_invoice.peppol_failed`; a received-document event fetches the document from the access point, stores it as a document capture with the matched supplier, emits `document_capture.peppol_received` and marks it read at the access point (a document already stored is skipped). `handled` is false when the event matched no invoice or document. Answers 404 when no company uses that provider account, 401 when the signature does not match.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Peppol.WebhooksAsync(
    new WebhooksPeppolRequest
    {
        Provider = WebhooksPeppolRequestProvider.Recommand,
        CompanyId = "companyId",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WebhooksPeppolRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## declarations
<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtIntrastatComputeAsync</a>(LtIntrastatComputeDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtIntrastatComputeDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Builds the Lithuanian Intrastat report of a month for one flow as the IDAIS INTRASTATReportSubmission XML: dispatches from the issued sale invoices and purchase credit notes, arrivals from the registered purchase invoices and sale credit notes, grouped into report items. `transactionNature`, `deliveryTerms`, `transportMode` and `regionCode` are the defaults for lines without their own values; `statisticalValueRequired` adds the statistical value to each item. Answers 422 when the company is not a VAT payer. With `persist`, the file is stored and a submission for `lt-intrastat-arrivals` or `lt-intrastat-dispatches` is created.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtIntrastatComputeAsync(
    new LtIntrastatComputeDeclarationsRequest
    {
        Year = 1000000,
        Month = 1000000,
        Flow = LtIntrastatComputeDeclarationsRequestFlow.Arrivals,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtIntrastatComputeDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtIvazGenerateAsync</a>(LtIvazGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtIvazGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Builds the i.VAZ transport document message (iVAZ1.3.3) for up to 100 issued waybills and returns the XML. Answers 422 when the registration code of the company is not numeric or when a waybill is not issued. With `persist`, the file is stored and a submission for `lt-ivaz` is created.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtIvazGenerateAsync(
    new LtIvazGenerateDeclarationsRequest { WaybillIds = new List<string>() { "waybillIds" } }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtIvazGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtIntrastatObligationAsync</a>(LtIntrastatObligationDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtIntrastatObligationDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Checks the Intrastat reporting obligation of a year per flow: the value of goods traded with other Member States in the previous year, the month from which reporting is due (January when that value already passed the reporting threshold, else the month the cumulative value of the year passes it), whether the statistical value is required, and the monthly values. Answers 422 when no thresholds are stored for the year.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtIntrastatObligationAsync(
    new LtIntrastatObligationDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtIntrastatObligationDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtIsafGenerateAsync</a>(LtIsafGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtIsafGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Builds the Lithuanian i.SAF register XML of a month: `dataType` F covers both registers, S the issued sale invoices only, P the registered purchase invoices only. Returns the XML without storing it; `declarations/submissions/create` stores it as a submission.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtIsafGenerateAsync(
    new LtIsafGenerateDeclarationsRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtIsafGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtFr0600ComputeAsync</a>(LtFr0600ComputeDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtFr0600ComputeDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Computes the fields of the Lithuanian VAT return FR0600 for the period of `months` months starting in `month`, with the breakdown by VAT classifier behind them. `deductionPercent` is the share of input VAT deducted and is written to field 28.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtFr0600ComputeAsync(
    new LtFr0600ComputeDeclarationsRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtFr0600ComputeDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtGpm313ComputeAsync</a>(LtGpm313ComputeDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtGpm313ComputeDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Computes fields 5 to 7 of the monthly GPM313 from the payroll run of the month the pay was earned: the run of the previous month with `payoutTiming` `next-month`, the run of the same month with `same-month`. `paymentDay` decides whether the withheld tax goes to field 6 (paid by the 15th) or field 7 (after it). Fields 8 to 12 are returned as zero.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtGpm313ComputeAsync(
    new LtGpm313ComputeDeclarationsRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtGpm313ComputeDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtSamComputeAsync</a>(LtSamComputeDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtSamComputeDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Computes the monthly SAM figures from the payroll run of the month: per employee the insured income, the employee and employer contributions together and the resulting tariff, plus the insured count and the totals. A missing run or a run still in draft is reported in the warnings.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtSamComputeAsync(
    new LtSamComputeDeclarationsRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtSamComputeDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtSdGenerateAsync</a>(LtSdGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtSdGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the rows of the 1-SD (employment contracts that start in the date range) or of the 2-SD (contracts that ended in the range, with the final insured income and contributions from the payroll line of the termination month). Answers 422 when `fromDate` is after `toDate`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtSdGenerateAsync(
    new LtSdGenerateDeclarationsRequest
    {
        Type = LtSdGenerateDeclarationsRequestType.OneSd,
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtSdGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtSaftGenerateAsync</a>(LtSaftGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtSaftGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Builds the Lithuanian SAF-T (version 2.01) XML for a date range: `dataType` F is the full file, GL, SI, PI, PA, MG and AS limit it to the general ledger, sale invoices, purchase invoices, payments, movements of goods or asset transactions. Answers 422 when `fromDate` is after `toDate`. With `persist`, the file is stored and a submission for `lt-saft` is created.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtSaftGenerateAsync(
    new LtSaftGenerateDeclarationsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtSaftGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtIvazAmendAsync</a>(LtIvazAmendDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtIvazAmendDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Builds an i.VAZ amendment message for up to 100 issued waybills, carrying their current data as TransportDocumentAmendment elements. Answers 422 when the registration code of the company is not numeric or when a waybill is not issued. With `persist`, the file is stored and a submission for `lt-ivaz-amendment` is created.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtIvazAmendAsync(
    new LtIvazAmendDeclarationsRequest { WaybillIds = new List<string>() { "waybillIds" } }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtIvazAmendDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtIvazCancelAsync</a>(LtIvazCancelDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtIvazCancelDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Builds an i.VAZ cancellation message for up to 100 waybills, each with a cancellation reason code and optional additional information. Answers 422 when the registration code of the company is not numeric; a waybill that was never issued is reported in the warnings. With `persist`, the file is stored and a submission for `lt-ivaz-cancellation` is created.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtIvazCancelAsync(
    new LtIvazCancelDeclarationsRequest
    {
        Entries = new List<LtIvazCancelDeclarationsRequestEntriesItem>()
        {
            new LtIvazCancelDeclarationsRequestEntriesItem
            {
                WaybillId = "waybillId",
                Reason = LtIvazCancelDeclarationsRequestEntriesItemReason.One,
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtIvazCancelDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtFr0564ComputeAsync</a>(LtFr0564ComputeDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtFr0564ComputeDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Computes the rows of the Lithuanian FR0564 report of a month from the issued sale invoices and credit notes with the `intra_eu_b2b` or `reverse_charge` scheme: one row per buyer VAT number of another Member State, with goods and services split by the type of the catalogue item. Invoices not in EUR and buyers without a valid EU VAT number are left out and named in the warnings; the triangular column is always zero.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtFr0564ComputeAsync(
    new LtFr0564ComputeDeclarationsRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtFr0564ComputeDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtGpm312ComputeAsync</a>(LtGpm312ComputeDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtGpm312ComputeDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Computes the rows of the annual GPM312 from the payroll runs of the payout months of the year (December of the previous year to November with `payoutTiming` `next-month`, January to December with `same-month`): one row per employee and payment type code, with the amount paid, the tax withheld and the rate applied.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtGpm312ComputeAsync(
    new LtGpm312ComputeDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtGpm312ComputeDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtPln204ComputeAsync</a>(LtPln204ComputeDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtPln204ComputeDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Computes the boxes of the Lithuanian annual corporate income tax return PLN204 for the fiscal year from the financial statements and the tax adjustments recorded with `declarations/tax-adjustments/create`: the PLN204S annex from the `non_deductible` adjustments and the PLN204Z annex from the `non_taxable_income` ones, by their `code`. The small-entity rate is applied when the size criteria allow it. Answers 422 when such an adjustment has no code or a code the annex does not list, or when no rate table covers the period.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtPln204ComputeAsync(
    new LtPln204ComputeDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtPln204ComputeDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">EuOssComputeAsync</a>(EuOssComputeDeclarationsRequest { ... }) -> WithRawResponseTask&lt;EuOssComputeDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Computes the Union OSS return of a quarter from the issued invoices and credit notes with the `oss_union` VAT scheme: one row per Member State of consumption and VAT rate, classified as standard or reduced, and a corrections section for the credit notes that credit invoices of earlier periods. Amounts are in EUR, converted at the official rate of the last day of the period. Answers 422 when the company is not established in the EU.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.EuOssComputeAsync(
    new EuOssComputeDeclarationsRequest { Year = 1000000, Quarter = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EuOssComputeDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">EuIossComputeAsync</a>(EuIossComputeDeclarationsRequest { ... }) -> WithRawResponseTask&lt;EuIossComputeDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Computes the IOSS return of a month from the issued invoices and credit notes with the `ioss` VAT scheme, with the same rows, corrections and EUR conversion as `declarations/eu/oss/compute`. Answers 422 when the company is not established in the EU.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.EuIossComputeAsync(
    new EuIossComputeDeclarationsRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EuIossComputeDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">EuOwnGoodsTransfersComputeAsync</a>(EuOwnGoodsTransfersComputeDeclarationsRequest { ... }) -> WithRawResponseTask&lt;EuOwnGoodsTransfersComputeDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Builds the monthly return of the special scheme for transfers of own goods from the warehouse transfers between warehouses in two different EU Member States: one row per destination and dispatch country with the cost of the goods as the taxable amount in EUR, the transfers behind the rows, and the due date. Answers 422 when the company is not established in the EU.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.EuOwnGoodsTransfersComputeAsync(
    new EuOwnGoodsTransfersComputeDeclarationsRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EuOwnGoodsTransfersComputeDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">EuDigitalReportingListAsync</a>(EuDigitalReportingListDeclarationsRequest { ... }) -> WithRawResponseTask&lt;EuDigitalReportingListDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the transactions of a date range that fall under EU digital reporting: issued sale invoices and credit notes with the `intra_eu_b2b` or `reverse_charge` scheme to EU customers, and registered purchase invoices from suppliers in other Member States whose lines carry a self-assessed VAT classifier. Each transaction names the article it is reported under, the Member State it is reported to, its deadline and the data still missing. Answers 422 when the company is not identified for VAT in the EU.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.EuDigitalReportingListAsync(
    new EuDigitalReportingListDeclarationsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EuDigitalReportingListDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">EuDac7PreviewAsync</a>(EuDac7PreviewDeclarationsRequest { ... }) -> WithRawResponseTask&lt;EuDac7PreviewDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Which platform sellers are reportable for the year (Council Directive (EU) 2021/514, Annex V) and why the others are excluded, the data still missing, and how the company files the report in its Member State.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.EuDac7PreviewAsync(
    new EuDac7PreviewDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EuDac7PreviewDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">EuDac7XmlAsync</a>(EuDac7XmlDeclarationsRequest { ... }) -> WithRawResponseTask&lt;EuDac7XmlDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Builds the DAC7 (DPI) XML report of a year for the Member State of the company and returns it base64-encoded with the file name the administration expects. Answers 422 when no DAC7 filing channel exists for the company country. The sellers and the missing data behind it come from `declarations/eu/dac7/preview`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.EuDac7XmlAsync(new EuDac7XmlDeclarationsRequest { Year = 1000000 });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EuDac7XmlDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">EuDistanceSalesThresholdGetAsync</a>(EuDistanceSalesThresholdGetDeclarationsRequest { ... }) -> WithRawResponseTask&lt;EuDistanceSalesThresholdGetDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Sums the cross-border sales to EU consumers (invoices under the `oss_union` scheme, and domestic-scheme invoices to partners without a VAT number in another Member State) of the current and the preceding calendar year as of `date` (default: the current date of the company) and compares both with the EUR 10 000 distance sales threshold.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.EuDistanceSalesThresholdGetAsync(
    new EuDistanceSalesThresholdGetDeclarationsRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EuDistanceSalesThresholdGetDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">EuUnionTurnoverGetAsync</a>(EuUnionTurnoverGetDeclarationsRequest { ... }) -> WithRawResponseTask&lt;EuUnionTurnoverGetDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Sums the turnover of the company within the Union (issued invoices and credit notes other than export and out-of-scope supplies) for the current and the previous calendar year as of `date` (default: the current date of the company) and compares it with the EUR 100 000 cap of the cross-border SME scheme. The status is `not_applicable` for a registered VAT payer, otherwise `below`, `approaching` or `exceeded`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.EuUnionTurnoverGetAsync(new EuUnionTurnoverGetDeclarationsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EuUnionTurnoverGetDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">EuSmeCrossBorderReportComputeAsync</a>(EuSmeCrossBorderReportComputeDeclarationsRequest { ... }) -> WithRawResponseTask&lt;EuSmeCrossBorderReportComputeDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Builds the quarterly report of the cross-border SME scheme: the value of the issued supplies within the Union per Member State of supply (the VAT country of the invoice, else the country of the partner, else the home country), in the base currency of the company. Supplies that resolve to a non-EU country are left out and named in the warnings.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.EuSmeCrossBorderReportComputeAsync(
    new EuSmeCrossBorderReportComputeDeclarationsRequest { Year = 1000000, Quarter = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EuSmeCrossBorderReportComputeDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">EuSmeThresholdsListAsync</a>(EuSmeThresholdsListDeclarationsRequest { ... }) -> WithRawResponseTask&lt;EuSmeThresholdsListDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the stored table of national SME VAT exemption thresholds per Member State, with sector thresholds and intra-EU acquisition triggers where recorded, and the national and Union-wide caps of the directive. No company data is read.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.EuSmeThresholdsListAsync(new EuSmeThresholdsListDeclarationsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EuSmeThresholdsListDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">EuSmeThresholdGetAsync</a>(EuSmeThresholdGetDeclarationsRequest { ... }) -> WithRawResponseTask&lt;EuSmeThresholdGetDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Compares the gross turnover of the company in the current calendar year as of `date` (default: the current date of the company) with the national SME exemption threshold of its country. The status is `not_applicable` for a registered VAT payer, `unknown` when no threshold is on file or its currency differs from the base currency, otherwise `below`, `approaching` or `exceeded`; when the country has an intra-EU acquisitions trigger, the acquisitions from and services to other Member States are compared with it too.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.EuSmeThresholdGetAsync(new EuSmeThresholdGetDeclarationsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EuSmeThresholdGetDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">EuVatReturnPacksListAsync</a>(EuVatReturnPacksListDeclarationsRequest { ... }) -> WithRawResponseTask&lt;EuVatReturnPacksListDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the national VAT return forms Nordlet can compute, with the country, form key, form name, filing frequency and source.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.EuVatReturnPacksListAsync(new EuVatReturnPacksListDeclarationsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EuVatReturnPacksListDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">EuVatReturnComputeAsync</a>(EuVatReturnComputeDeclarationsRequest { ... }) -> WithRawResponseTask&lt;EuVatReturnComputeDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Computes the national VAT return of `countryCode` for the period of `months` months starting in `month`, as the numbered boxes of the form with labels and amounts. Answers 422 when no return pack is registered for the country; the packs are listed by `declarations/eu/vat-return/packs/list`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.EuVatReturnComputeAsync(
    new EuVatReturnComputeDeclarationsRequest
    {
        CountryCode = "countryCode",
        Year = 1000000,
        Month = 1000000,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EuVatReturnComputeDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PlJpkV7MGenerateAsync</a>(PlJpkV7MGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;PlJpkV7MGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Generate the Polish JPK_V7M(3) file (VAT declaration with evidence) for a month, per the MF schema in force since February 2026. Amounts must already be in PLN; rows are marked BFK until a KSeF integration supplies invoice numbers. Review the warnings before submitting via e-dokumenty.mf.gov.pl.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PlJpkV7MGenerateAsync(
    new PlJpkV7MGenerateDeclarationsRequest
    {
        Year = 1000000,
        Month = 1000000,
        KodUrzedu = "kodUrzedu",
        Email = "email",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PlJpkV7MGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PlVatUeGenerateAsync</a>(PlVatUeGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;PlVatUeGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build the rows of the Polish recapitulative statement VAT-UE for a month: section C intra-Community supplies of goods, section D intra-Community acquisitions, section E services taxed where the customer is established. Amounts are full złoty per counterparty. The VAT-UE(5) file itself goes out from the EU sales list deadline in the calendar.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PlVatUeGenerateAsync(
    new PlVatUeGenerateDeclarationsRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PlVatUeGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PlIntrastatGenerateAsync</a>(PlIntrastatGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;PlIntrastatGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build the rows of the Polish INTRASTAT declaration for a month, arrivals or dispatches, grouped by CN code, partner country, country of origin, partner VAT number, nature of transaction, transport and delivery terms. Values are whole złoty converted at the invoice rate; credit notes with goods lines are returns (code 21). Goods without a CN code are left out and named in the warnings. The IST message itself goes out from the Intrastat deadline in the calendar.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PlIntrastatGenerateAsync(
    new PlIntrastatGenerateDeclarationsRequest
    {
        Year = 1000000,
        Month = 1000000,
        Flow = PlIntrastatGenerateDeclarationsRequestFlow.Arrivals,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PlIntrastatGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PlKsefReceivedListAsync</a>(PlKsefReceivedListDeclarationsRequest { ... }) -> WithRawResponseTask&lt;PlKsefReceivedListDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the invoices KSeF holds for this company as the buyer, for a window of acquisition timestamps. Each row carries the KSeF number and, when the document number matches a registered purchase invoice, the invoice it belongs to.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PlKsefReceivedListAsync(
    new PlKsefReceivedListDeclarationsRequest
    {
        From = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        To = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PlKsefReceivedListDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PlKsefReceivedFetchAsync</a>(PlKsefReceivedFetchDeclarationsRequest { ... }) -> WithRawResponseTask&lt;PlKsefReceivedFetchDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read one invoice out of KSeF by its national number. With a purchase invoice given, the KSeF number is written onto that invoice, which is what makes the purchase row of JPK_V7M carry NrKSeF instead of the BFK marker.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PlKsefReceivedFetchAsync(
    new PlKsefReceivedFetchDeclarationsRequest { KsefNumber = "ksefNumber" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PlKsefReceivedFetchDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PlKsefReceiptAsync</a>(PlKsefReceiptDeclarationsRequest { ... }) -> WithRawResponseTask&lt;PlKsefReceiptDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

The UPO for a KSeF session. KSeF issues one receipt per session rather than per invoice, so the session reference number from the send is what identifies it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PlKsefReceiptAsync(new PlKsefReceiptDeclarationsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PlKsefReceiptDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">TaxAdjustmentsListAsync</a>(TaxAdjustmentsListDeclarationsRequest { ... }) -> WithRawResponseTask&lt;TaxAdjustmentsListDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

The differences between the accounting result and the taxable profit: non-deductible expenses, income added to or left out of the tax base, extra deductible expenses, donations, losses carried forward, reliefs and tax credits. The annual corporate income tax return is built from them.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.TaxAdjustmentsListAsync(
    new TaxAdjustmentsListDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TaxAdjustmentsListDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">TaxAdjustmentsCreateAsync</a>(TaxAdjustmentsCreateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;TaxAdjustmentsCreateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Records a tax adjustment of one kind for a tax year, with an optional form `code`. Answers 422 when the amount is zero.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.TaxAdjustmentsCreateAsync(
    new TaxAdjustmentsCreateDeclarationsRequest
    {
        Year = 1000000,
        Kind = TaxAdjustmentsCreateDeclarationsRequestKind.NonDeductible,
        Amount = "121.00",
        Description = "description",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TaxAdjustmentsCreateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">TaxAdjustmentsUpdateAsync</a>(TaxAdjustmentsUpdateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;TaxAdjustmentsUpdateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the kind, code, amount or description of a recorded tax adjustment; fields left out keep their value and an empty `code` clears it. Answers 422 when the new amount is zero.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.TaxAdjustmentsUpdateAsync(
    new TaxAdjustmentsUpdateDeclarationsRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TaxAdjustmentsUpdateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">TaxAdjustmentsDeleteAsync</a>(TaxAdjustmentsDeleteDeclarationsRequest { ... }) -> WithRawResponseTask&lt;TaxAdjustmentsDeleteDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a recorded tax adjustment.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.TaxAdjustmentsDeleteAsync(
    new TaxAdjustmentsDeleteDeclarationsRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TaxAdjustmentsDeleteDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">TaxPaymentsListAsync</a>(TaxPaymentsListDeclarationsRequest { ... }) -> WithRawResponseTask&lt;TaxPaymentsListDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

What the company has paid the administration towards a tax before the return is filed: payments on account, tax withheld at source by others, a final settlement, and a refund received. Returns report these on their own lines, so the amount they ask for is the balance.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.TaxPaymentsListAsync(
    new TaxPaymentsListDeclarationsRequest
    {
        Tax = TaxPaymentsListDeclarationsRequestTax.CorporateIncomeTax,
        Year = 1000000,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TaxPaymentsListDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">TaxPaymentsCreateAsync</a>(TaxPaymentsCreateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;TaxPaymentsCreateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Records a payment made towards a tax (`tax`) of a year, and of a month when given, as an advance payment, tax withheld by others, a final settlement or a refund received. Answers 422 when the amount is zero.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.TaxPaymentsCreateAsync(
    new TaxPaymentsCreateDeclarationsRequest
    {
        Tax = TaxPaymentsCreateDeclarationsRequestTax.CorporateIncomeTax,
        Year = 1000000,
        Kind = TaxPaymentsCreateDeclarationsRequestKind.Advance,
        Amount = "121.00",
        PaidOn = new DateOnly(2026, 7, 1),
        Description = "description",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TaxPaymentsCreateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">TaxPaymentsUpdateAsync</a>(TaxPaymentsUpdateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;TaxPaymentsUpdateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the kind, amount, payment date, reference or description of a recorded tax payment; fields left out keep their value and an empty `reference` clears it. Answers 422 when the new amount is zero.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.TaxPaymentsUpdateAsync(
    new TaxPaymentsUpdateDeclarationsRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TaxPaymentsUpdateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">TaxPaymentsDeleteAsync</a>(TaxPaymentsDeleteDeclarationsRequest { ... }) -> WithRawResponseTask&lt;TaxPaymentsDeleteDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a recorded tax payment.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.TaxPaymentsDeleteAsync(
    new TaxPaymentsDeleteDeclarationsRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TaxPaymentsDeleteDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">AnnualAccountsGetAsync</a>(AnnualAccountsGetDeclarationsRequest { ... }) -> WithRawResponseTask&lt;AnnualAccountsGetDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Whether the general meeting adopted the annual accounts and on which date, the date the accounts were prepared, and which directors signed them. The annual accounts filed with the trade register are built from these facts.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.AnnualAccountsGetAsync(
    new AnnualAccountsGetDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AnnualAccountsGetDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">AnnualAccountsSetAsync</a>(AnnualAccountsSetDeclarationsRequest { ... }) -> WithRawResponseTask&lt;AnnualAccountsSetDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates or replaces the record of a year: whether and when the accounts were adopted, when they were prepared, whether they were audited (with the qualification flag and the auditor report date) or the auditor was not elected, the report texts and the appropriation of the result. Answers 422 when `adopted` is true without `adoptionDate`, when the adoption date is not after 31 December of the year, or when the date of preparation is after the adoption date.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.AnnualAccountsSetAsync(
    new AnnualAccountsSetDeclarationsRequest
    {
        Year = 1000000,
        Adopted = true,
        DateOfPreparation = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AnnualAccountsSetDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">AnnualAccountsSignaturesCreateAsync</a>(AnnualAccountsSignaturesCreateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;AnnualAccountsSignaturesCreateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds a director to the signatures of the annual accounts of the year: signed, with the date and place of signature, or not signed, with the reason. Answers 422 when no annual accounts record exists for the year (`declarations/annual-accounts/set` first), when a signed entry lacks the date or the place, or when an unsigned entry lacks the reason.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.AnnualAccountsSignaturesCreateAsync(
    new AnnualAccountsSignaturesCreateDeclarationsRequest
    {
        Year = 1000000,
        DirectorName = "directorName",
        DirectorType =
            AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType.ManagingCurrent,
        Signed = true,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AnnualAccountsSignaturesCreateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">AnnualAccountsSignaturesUpdateAsync</a>(AnnualAccountsSignaturesUpdateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;AnnualAccountsSignaturesUpdateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Replaces the name, type and signing facts of a recorded director signature. Answers 422 when a signed entry lacks the date or the place of signature, or when an unsigned entry lacks the reason.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.AnnualAccountsSignaturesUpdateAsync(
    new AnnualAccountsSignaturesUpdateDeclarationsRequest
    {
        Id = "id",
        DirectorName = "directorName",
        DirectorType =
            AnnualAccountsSignaturesUpdateDeclarationsRequestDirectorType.ManagingCurrent,
        Signed = true,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AnnualAccountsSignaturesUpdateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">AnnualAccountsSignaturesDeleteAsync</a>(AnnualAccountsSignaturesDeleteDeclarationsRequest { ... }) -> WithRawResponseTask&lt;AnnualAccountsSignaturesDeleteDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a recorded director signature.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.AnnualAccountsSignaturesDeleteAsync(
    new AnnualAccountsSignaturesDeleteDeclarationsRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AnnualAccountsSignaturesDeleteDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">AnnualAccountsDistributionsCreateAsync</a>(AnnualAccountsDistributionsCreateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;AnnualAccountsDistributionsCreateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds a profit distribution decision (decision date, kind, amount, description) to the annual accounts record of the year. Answers 422 when no annual accounts record exists for the year.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.AnnualAccountsDistributionsCreateAsync(
    new AnnualAccountsDistributionsCreateDeclarationsRequest
    {
        Year = 1000000,
        DecidedOn = new DateOnly(2026, 7, 1),
        Kind = AnnualAccountsDistributionsCreateDeclarationsRequestKind.Dividend,
        Amount = "121.00",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AnnualAccountsDistributionsCreateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">AnnualAccountsDistributionsUpdateAsync</a>(AnnualAccountsDistributionsUpdateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;AnnualAccountsDistributionsUpdateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Replaces the decision date, kind, amount and description of a recorded profit distribution.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.AnnualAccountsDistributionsUpdateAsync(
    new AnnualAccountsDistributionsUpdateDeclarationsRequest
    {
        Id = "id",
        DecidedOn = new DateOnly(2026, 7, 1),
        Kind = AnnualAccountsDistributionsUpdateDeclarationsRequestKind.Dividend,
        Amount = "121.00",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AnnualAccountsDistributionsUpdateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">AnnualAccountsDistributionsDeleteAsync</a>(AnnualAccountsDistributionsDeleteDeclarationsRequest { ... }) -> WithRawResponseTask&lt;AnnualAccountsDistributionsDeleteDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a recorded profit distribution.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.AnnualAccountsDistributionsDeleteAsync(
    new AnnualAccountsDistributionsDeleteDeclarationsRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AnnualAccountsDistributionsDeleteDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">AnnualAccountsAttachmentsAddAsync</a>(AnnualAccountsAttachmentsAddDeclarationsRequest { ... }) -> WithRawResponseTask&lt;AnnualAccountsAttachmentsAddDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Links a file uploaded through files/upload (its storageKey) to the annual accounts of the year as the notes, the management report, the auditor statement, the profit appropriation resolution, the approval certificate, the general data sheet, the full report as a pdf, or another document. Deposits that must carry these documents take them from here.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.AnnualAccountsAttachmentsAddAsync(
    new AnnualAccountsAttachmentsAddDeclarationsRequest
    {
        Year = 1000000,
        Kind = AnnualAccountsAttachmentsAddDeclarationsRequestKind.FullReport,
        Ref = "ref",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AnnualAccountsAttachmentsAddDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">AnnualAccountsAttachmentsDeleteAsync</a>(AnnualAccountsAttachmentsDeleteDeclarationsRequest { ... }) -> WithRawResponseTask&lt;AnnualAccountsAttachmentsDeleteDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Removes the attachment from the annual accounts and deletes its file record and the stored bytes.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.AnnualAccountsAttachmentsDeleteAsync(
    new AnnualAccountsAttachmentsDeleteDeclarationsRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AnnualAccountsAttachmentsDeleteDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">CyTd4GenerateAsync</a>(CyTd4GenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;CyTd4GenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Compute the company income tax return TD4 of a tax year from the ledger and the recorded tax adjustments: the accounting profit, the add-backs, deductions, capital allowances and losses brought forward, the chargeable income, the corporation tax at the rate of the year and the double tax relief, as the fields the company keys into TAXISnet or Tax For All. The Tax Department publishes no upload layout for the TD4; the XML is a working file.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.CyTd4GenerateAsync(
    new CyTd4GenerateDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CyTd4GenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">CyHe32GenerateAsync</a>(CyHe32GenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;CyHe32GenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build the annual return HE32 of a year: the figures the Registrar’s e-filing screens ask for (company number, registered office, made-up-to date, share capital, register of members, directors and secretary, annual general meeting date, the accounts summary), the working file, and the printed form HE32(I) filled in as a PDF for signing and for keying into the Registrar’s system, which takes the return only through its own screens.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.CyHe32GenerateAsync(
    new CyHe32GenerateDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CyHe32GenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">DeReturnsGenerateAsync</a>(DeReturnsGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;DeReturnsGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build one of the German returns that ELSTER accepts only through a licensed ERiC transmission (E-Bilanz, Körperschaftsteuer, Gewerbesteuer with its Zerlegungserklärung, annual VAT return, Lohnsteuer-Anmeldung, Lohnsteuerbescheinigung) for the company to send through its own ELSTER-capable program, or the Anlage EÜR with the Anlage AVEÜR of a cash-basis company as a UTF-8 CSV file of its Zeilen and Kennzahlen (`de-euer`, 422 for a company without the cash-basis flag). The period is the year, or YYYY-MM for the monthly Lohnsteuer-Anmeldung.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.DeReturnsGenerateAsync(
    new DeReturnsGenerateDeclarationsRequest
    {
        RuleKey = DeReturnsGenerateDeclarationsRequestRuleKey.DeEBilanz,
        Period = "period",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeReturnsGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">DeEuerGetAsync</a>(DeEuerGetDeclarationsRequest { ... }) -> WithRawResponseTask&lt;DeEuerGetDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

The Anlage EÜR and the Anlage AVEÜR of a year for a company that determines its profit on a cash basis (§ 4 Abs. 3 EStG), as the Zeilen and Kennzahlen of the official 2025 forms with their amounts: the receipts and payments of the year from the invoice payments (each payment split over the lines of its invoice), the payroll and tax payments and the journal transactions on cash and bank accounts, and the asset register for the Anlage AVEÜR and the AfA. Accounts are placed on the Zeilen through the de-euer statement scheme (Account → Statement rows). Refused with 422 for a company without the cash-basis flag.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.DeEuerGetAsync(new DeEuerGetDeclarationsRequest { Year = 1000000 });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeEuerGetDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">DeReturnFactsGetAsync</a>(DeReturnFactsGetDeclarationsRequest { ... }) -> WithRawResponseTask&lt;DeReturnFactsGetDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

The facts of one year that the German annual returns (Körperschaftsteuer, Gewerbesteuer, Umsatzsteuererklärung) need and the ledger does not hold: changes of shareholders, contracts with shareholders, the tax contribution account, loss carry-back, the donation carry-forward, the business premises with the municipalities for the apportionment of the trade tax, the land values or property tax and the participations for the trade tax additions and reductions, the foreign income per country for the Anlage AESt, the date of leaving the small-business scheme, the Anlage UN answers of a company seated abroad and, for a cash-basis company, the kind of income and the withdrawals and contributions of the owner for the Anlage EÜR. A key that is absent has not been answered.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.DeReturnFactsGetAsync(
    new DeReturnFactsGetDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeReturnFactsGetDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">DeReturnFactsSetAsync</a>(DeReturnFactsSetDeclarationsRequest { ... }) -> WithRawResponseTask&lt;DeReturnFactsSetDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Replace the facts of one year for the German annual returns. The returns built afterwards read them; a key left out stays unanswered.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.DeReturnFactsSetAsync(
    new DeReturnFactsSetDeclarationsRequest
    {
        Year = 1000000,
        Facts = new DeReturnFactsSetDeclarationsRequestFacts(),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeReturnFactsSetDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">DeDeuevGenerateAsync</a>(DeDeuevGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;DeDeuevGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build the DEÜV notifications of a month (Anmeldung for every start, Abmeldung for every leaving, in December the Jahresmeldung for everyone employed on 31 December) as DSME records with the DBME, DBNA, DBGB and DBAN blocks of Anlage 4 in force from 2026, from the approved payroll runs and the employee record, for the company's own transmission channel.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.DeDeuevGenerateAsync(
    new DeDeuevGenerateDeclarationsRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeDeuevGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">DeBeitragsnachweisGenerateAsync</a>(DeBeitragsnachweisGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;DeBeitragsnachweisGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build the monthly contribution statement to the health insurers (Beitragsnachweis) from the payroll run: one fixed-length record BW02 per insurer, in the record layout in force from 2026, ready for the company's own transmission channel.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.DeBeitragsnachweisGenerateAsync(
    new DeBeitragsnachweisGenerateDeclarationsRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeBeitragsnachweisGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">DkSelskabsskatGenerateAsync</a>(DkSelskabsskatGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;DkSelskabsskatGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Compute the oplysningsskema for selskaber (selskabsselvangivelsen) of an income year from the ledger and the recorded tax adjustments: accounting result before tax, tax adjustments, losses carried forward, taxable income, the 22 % corporation tax, reliefs and the balance, as the rubrikker the company keys into TastSelv Selskabsskat (DIAS). Skatteforvaltningen publishes no file format for the return; the XML is a working file.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.DkSelskabsskatGenerateAsync(
    new DkSelskabsskatGenerateDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DkSelskabsskatGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">EeEmploymentRegisterSendAsync</a>(EeEmploymentRegisterSendDeclarationsRequest { ... }) -> WithRawResponseTask&lt;EeEmploymentRegisterSendDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Send one employment register (töötamise register) entry for an employment contract to e-MTA over X-tee: the start of work, or its end with the reason recorded on the contract.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.EeEmploymentRegisterSendAsync(
    new EeEmploymentRegisterSendDeclarationsRequest
    {
        ContractId = "contractId",
        Event = EeEmploymentRegisterSendDeclarationsRequestEvent.Start,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EeEmploymentRegisterSendDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">EsVerifactuDeclaracionResponsableAsync</a>(EsVerifactuDeclaracionResponsableDeclarationsRequest { ... }) -> WithRawResponseTask&lt;EsVerifactuDeclaracionResponsableDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Nordlet's declaración responsable for its VERI*FACTU invoicing system (Orden HAC/1177/2024, art. 15), as a PDF and as plain text.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.EsVerifactuDeclaracionResponsableAsync(
    new EsVerifactuDeclaracionResponsableDeclarationsRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EsVerifactuDeclaracionResponsableDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">IeCt1GenerateAsync</a>(IeCt1GenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;IeCt1GenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build the Form CT1 of an accounting year as the ROS version 26 XML and the accompanying financial statements as inline XBRL on the FRS 102 Irish Extension 2026 taxonomy Revenue accepts, both from the ledger, the recorded tax adjustments, the annual accounts record and the officers, for upload through the company’s own ROS account. Says whether the company is above the iXBRL deferral limits (balance sheet total €4.4 million, turnover €8.8 million, 50 employees).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.IeCt1GenerateAsync(
    new IeCt1GenerateDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IeCt1GenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">IeB1GenerateAsync</a>(IeB1GenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;IeB1GenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build the working paper for the Form B1 annual return of a financial year - company details, registered office, directors and secretary from Account → Officers, the members from Account → Shareholders, the issued share capital and the figures of the financial statements - in the order the CORE screens ask for them. The CRO publishes no file format for the B1, so it is keyed into CORE.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.IeB1GenerateAsync(new IeB1GenerateDeclarationsRequest { Year = 1000000 });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IeB1GenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">ItSdiPurchaseSendAsync</a>(ItSdiPurchaseSendDeclarationsRequest { ... }) -> WithRawResponseTask&lt;ItSdiPurchaseSendDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build the TD16-TD19 integration document for a registered purchase invoice and send it to the Sistema di Interscambio. Since July 2022 a purchase from a supplier established abroad is reported this way instead of the esterometro. The Italian VAT rate to self-assess is a judgement about the supply: pass vatRatePercent unless the purchase lines already carry it, otherwise the request is refused rather than guessed.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.ItSdiPurchaseSendAsync(
    new ItSdiPurchaseSendDeclarationsRequest { PurchaseInvoiceId = "purchaseInvoiceId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItSdiPurchaseSendDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">ItSdiPurchasePreviewAsync</a>(ItSdiPurchasePreviewDeclarationsRequest { ... }) -> WithRawResponseTask&lt;ItSdiPurchasePreviewDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Render the TD16-TD19 integration document for a registered purchase invoice without sending it, so the rate and the document type can be checked first.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.ItSdiPurchasePreviewAsync(
    new ItSdiPurchasePreviewDeclarationsRequest { PurchaseInvoiceId = "purchaseInvoiceId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ItSdiPurchasePreviewDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtSaftSendAsync</a>(LtSaftSendDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtSaftSendDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Upload the SAF-T file to i.SAF-T over the iSAFTUploaderService web service and start its processing. The file, the case reference and the status are kept as a declaration submission (submissionId), whose outcome Nordlet then checks with i.SAF-T. The submission itself is confirmed separately, because after confirmation the file can no longer be corrected. A range and data type already sent is sent again only with amend: true.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtSaftSendAsync(
    new LtSaftSendDeclarationsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtSaftSendDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtSdFfdataAsync</a>(LtSdFfdataDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtSdFfdataDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Render the Sodra 1-SD or 2-SD notice for the contracts starting or ending in the range as an .ffdata document for EDAS.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtSdFfdataAsync(
    new LtSdFfdataDeclarationsRequest
    {
        Type = LtSdFfdataDeclarationsRequestType.OneSd,
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtSdFfdataDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtPln204FfdataAsync</a>(LtPln204FfdataDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtPln204FfdataDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Render the annual corporate income tax return PLN204 as an .ffdata document, including the PLN204S and PLN204Z annexes, from the ledger and the tax adjustments recorded for that year.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LtPln204FfdataAsync(
    new LtPln204FfdataDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LtPln204FfdataDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">MtCompanyTaxGenerateAsync</a>(MtCompanyTaxGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;MtCompanyTaxGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Compute the company income tax return and self-assessment of a year of assessment from the ledger and the recorded tax adjustments: the accounting profit before tax, the add-backs and deductions, the approved donations, capital allowances and losses carried forward, the chargeable income, the 35 % charge, the relief against the tax and the allocation of the distributable profit to the five tax accounts. The Malta Tax and Customs Administration issues the return as a personalised spreadsheet to the registered tax practitioner and publishes no layout, so the XML is a working file and the figures are keyed into that spreadsheet.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.MtCompanyTaxGenerateAsync(
    new MtCompanyTaxGenerateDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MtCompanyTaxGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">MtAnnualReturnGenerateAsync</a>(MtAnnualReturnGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;MtAnnualReturnGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build the annual return of a year: the company number, registered office and made-up-to date, the share capital, the register of members, the directors and the company secretary and the accounts summary, as the figures the Malta Business Registry asks for on its own screens, plus the printed Annual Return Form of the Seventh Schedule filled in as a PDF for signing.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.MtAnnualReturnGenerateAsync(
    new MtAnnualReturnGenerateDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MtAnnualReturnGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PlJpkFaGenerateAsync</a>(PlJpkFaGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;PlJpkFaGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Generate JPK_FA(4), the on-demand structure with every sales invoice issued in a period, its VAT bases per rate and one row per invoice line. Filed only when the tax office asks for it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PlJpkFaGenerateAsync(
    new PlJpkFaGenerateDeclarationsRequest
    {
        DateFrom = new DateOnly(2026, 7, 1),
        DateTo = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PlJpkFaGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PlJpkKrGenerateAsync</a>(PlJpkKrGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;PlJpkKrGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Generate JPK_KR(1), the on-demand structure with the chart of accounts and its opening balances and turnover, the journal and the double entries behind it. Filed only when the tax office asks for it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PlJpkKrGenerateAsync(
    new PlJpkKrGenerateDeclarationsRequest
    {
        DateFrom = new DateOnly(2026, 7, 1),
        DateTo = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PlJpkKrGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PlJpkMagGenerateAsync</a>(PlJpkMagGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;PlJpkMagGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Generate JPK_MAG(2), the on-demand structure with the warehouse documents of one warehouse: goods received from outside (PZ) or internally (PW) and issued to a customer (WZ) or internally (RW). Filed only when the tax office asks for it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PlJpkMagGenerateAsync(
    new PlJpkMagGenerateDeclarationsRequest
    {
        DateFrom = new DateOnly(2026, 7, 1),
        DateTo = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PlJpkMagGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PlPit11GenerateAsync</a>(PlPit11GenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;PlPit11GenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Generate PIT-11(29) for every person on the payroll of one year: the pay, the deductible costs, the advance withheld and the social and health contributions taken off it. One document per person, because that is how the form is filed, addressed to the tax office of the place of residence of that person (employee field plKodUrzedu); a person without that code is refused with 422.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PlPit11GenerateAsync(
    new PlPit11GenerateDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PlPit11GenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PlCit8GenerateAsync</a>(PlCit8GenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;PlCit8GenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Generate CIT-8(34), the annual corporate income tax return, from the ledger of the year and the recorded tax adjustments. The tax office code and the small-taxpayer setting come from the e-Deklaracje compliance settings, the seat address from the JPK gateway settings. Names the annexes the figures would need, which are not produced.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PlCit8GenerateAsync(
    new PlCit8GenerateDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PlCit8GenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PlZusDraComputeAsync</a>(PlZusDraComputeDeclarationsRequest { ... }) -> WithRawResponseTask&lt;PlZusDraComputeDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Compute the monthly ZUS DRA settlement from the payroll run of one month: the pension, disability, sickness, accident and health insurance contributions and the Labour Fund, Solidarity Fund and guaranteed benefits fund charges, each split between the insured person and the payer. The amounts are carried into Płatnik or ePłatnik by hand.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PlZusDraComputeAsync(
    new PlZusDraComputeDeclarationsRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PlZusDraComputeDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PlZusDraKeduAsync</a>(PlZusDraKeduDeclarationsRequest { ... }) -> WithRawResponseTask&lt;PlZusDraKeduDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build the KEDU file for one month: the ZUS DRA settlement and one ZUS RCA report per person on the payroll, in the schema kedu_5_4 that Płatnik and ePłatnik import. The payer REGON, short name and declaration deadline code come from the ZUS compliance settings; the insurance title code and working time of each person from the employee record.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PlZusDraKeduAsync(
    new PlZusDraKeduDeclarationsRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PlZusDraKeduDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PlZusDraPdfAsync</a>(PlZusDraPdfDeclarationsRequest { ... }) -> WithRawResponseTask&lt;PlZusDraPdfDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Fill the published ZUS DRA form for one month and return it as a PDF. The amounts, the payer identity and the deadline code are the same ones the KEDU file carries; blocks the payroll does not hold (paid benefits, bridging pensions, income declaration of a self-paying person) stay empty.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PlZusDraPdfAsync(
    new PlZusDraPdfDeclarationsRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PlZusDraPdfDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">RoEtransportBuildAsync</a>(RoEtransportBuildDeclarationsRequest { ... }) -> WithRawResponseTask&lt;RoEtransportBuildDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build the RO e-Transport declaration for an issued waybill: goods with their tariff codes and masses, the commercial partner, the route and the vehicle. The XML follows the ANAF eTransport v2 schema and is kept as a file on the waybill. Anything listed in blockers has to be filled in before /etransport/send will accept it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.RoEtransportBuildAsync(
    new RoEtransportBuildDeclarationsRequest { WaybillId = "waybillId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RoEtransportBuildDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">RoEtransportSubmitAsync</a>(RoEtransportSubmitDeclarationsRequest { ... }) -> WithRawResponseTask&lt;RoEtransportSubmitDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Hand the RO e-Transport declaration for an issued waybill to ANAF under the SPV OAuth token in compliance settings, and return the upload index the UIT is read back with. Answers 422 while any field the ANAF validator requires is still missing.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.RoEtransportSubmitAsync(
    new RoEtransportSubmitDeclarationsRequest { WaybillId = "waybillId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RoEtransportSubmitDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">RoEtransportStatusAsync</a>(RoEtransportStatusDeclarationsRequest { ... }) -> WithRawResponseTask&lt;RoEtransportStatusDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read the outcome of an e-Transport declaration from ANAF by its upload index, under the SPV OAuth token in compliance settings. Returns the UIT code once the declaration validates.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.RoEtransportStatusAsync(
    new RoEtransportStatusDeclarationsRequest { Reference = "reference" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RoEtransportStatusDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LiLohndeklarationGenerateAsync</a>(LiLohndeklarationGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LiLohndeklarationGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build the annual wage declaration (Lohndeklaration) to the AHV-IV-FAK from the approved payroll runs of the year as the CSV that AHVeasy imports under Lohndeklaration → CSV-Import der Lohndaten: one row per employee with the 18 columns of the AHVeasy template, the AHV-liable wage and the ALV wage.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LiLohndeklarationGenerateAsync(
    new LiLohndeklarationGenerateDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LiLohndeklarationGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LiLohnlistenGenerateAsync</a>(LiLohnlistenGenerateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LiLohnlistenGenerateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build the annual wage list (Lohnliste) of a Liechtenstein employer from the approved payroll runs of the year as the XLSX file the tax administration's eLohnausweis / eLohnlisten application imports: one row per employee with PEID, name, birth date, address, gross wage, wage tax withheld and the settlement period.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.LiLohnlistenGenerateAsync(
    new LiLohnlistenGenerateDeclarationsRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LiLohnlistenGenerateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">ConfigsListAsync</a>(ConfigsListDeclarationsRequest { ... }) -> WithRawResponseTask&lt;ConfigsListDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the filing systems the company can configure: those of the company country (or of `country` when given), the EU-wide systems and the cross-border e-invoicing systems `it_sdi`, `pl_ksef` and `ro_efactura`. Each row carries the stored values, with a secret or certificate field shown as `__secret_set__` and the fields taken from the company profile filled from it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.ConfigsListAsync(new ConfigsListDeclarationsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ConfigsListDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">ConfigsUpdateAsync</a>(ConfigsUpdateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;ConfigsUpdateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Stores the settings of one filing system for the company, merging the given fields into the stored ones. A secret or certificate value is encrypted before it is stored, an empty string clears a field, and `__secret_set__` leaves a stored secret unchanged. Answers 422 for an unknown system.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.ConfigsUpdateAsync(
    new ConfigsUpdateDeclarationsRequest
    {
        System = "system",
        Config = new Dictionary<string, string>() { { "key", "value" } },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ConfigsUpdateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">CertificatesUploadAsync</a>(CertificatesUploadDeclarationsRequest { ... }) -> WithRawResponseTask&lt;CertificatesUploadDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Stores a PEM certificate, a PEM private key or a PKCS#12 bundle (base64 in `content`, opened with `passphrase` when it needs one) in the settings of the filing system and replaces the earlier upload of the same kind; for a PEM certificate the fingerprint, subject, issuer and validity dates are recorded. Answers 422 when the system is unknown or does not authenticate with a certificate. Returns the full certificate list of the company.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.CertificatesUploadAsync(
    new CertificatesUploadDeclarationsRequest
    {
        System = "system",
        FileName = "fileName",
        Content = "content",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CertificatesUploadDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">CertificatesListAsync</a>(CertificatesListDeclarationsRequest { ... }) -> WithRawResponseTask&lt;CertificatesListDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the certificates and private keys stored for the filing systems of the company, ordered by system and field, each with its validity facts and health (`ok`, `expiring`, `expired` or `unknown`).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.CertificatesListAsync(new CertificatesListDeclarationsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CertificatesListDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">CertificatesDeleteAsync</a>(CertificatesDeleteDeclarationsRequest { ... }) -> WithRawResponseTask&lt;CertificatesDeleteDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Removes the certificate or the private key (`fieldKey`) of a filing system from the settings of the company and from the certificate list, and returns the remaining certificates.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.CertificatesDeleteAsync(
    new CertificatesDeleteDeclarationsRequest
    {
        System = "system",
        FieldKey = CertificatesDeleteDeclarationsRequestFieldKey.Certificate,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CertificatesDeleteDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">AutomationListAsync</a>(AutomationListDeclarationsRequest { ... }) -> WithRawResponseTask&lt;AutomationListDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the filing deadlines Nordlet can file by itself for the country of the company: for each, whether automatic filing is switched on, whether the rule applies to the company profile, whether its filing system is configured, the state of its certificate and whether it would go to the test or the production service.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.AutomationListAsync(new AutomationListDeclarationsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AutomationListDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">AutomationUpdateAsync</a>(AutomationUpdateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;AutomationUpdateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Switches automatic filing of one deadline on or off for the company and returns the list of `declarations/automation/list`. Answers 422 when the deadline is not one Nordlet files, or when switching on while the filing system is connected to the test service of the administration (unless the company is a sandbox), is not configured, or has no valid certificate.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.AutomationUpdateAsync(
    new AutomationUpdateDeclarationsRequest { RuleKey = "ruleKey", Enabled = true }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AutomationUpdateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">SubmissionsRetryAsync</a>(SubmissionsRetryDeclarationsRequest { ... }) -> WithRawResponseTask&lt;SubmissionsRetryDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Sends a submission that is still in status `generated` through its filing system once more, with the stored file or, when none was stored yet, a freshly generated one, and returns the updated submission. Answers 409 when the submission is already submitted, accepted or rejected.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.SubmissionsRetryAsync(
    new SubmissionsRetryDeclarationsRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SubmissionsRetryDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">SubmissionsCreateAsync</a>(SubmissionsCreateDeclarationsRequest { ... }) -> WithRawResponseTask&lt;SubmissionsCreateDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Builds the Lithuanian i.SAF register file of a month (`dataType` F both registers, S sale invoices only, P purchase invoices only), stores it and creates a submission in status `generated` for the obligation `lt-isaf`, the only obligation accepted. The XML alone comes from `declarations/lt/isaf/generate`; the submission is moved on with `declarations/submissions/mark`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.SubmissionsCreateAsync(
    new SubmissionsCreateDeclarationsRequest
    {
        Obligation = SubmissionsCreateDeclarationsRequestObligation.LtIsaf,
        Year = 1000000,
        Month = 1000000,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SubmissionsCreateDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">SubmissionsMarkAsync</a>(SubmissionsMarkDeclarationsRequest { ... }) -> WithRawResponseTask&lt;SubmissionsMarkDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Records by hand that a submission was sent, accepted or rejected, with the reference and message of the administration when given. The allowed moves are `generated` to `submitted` and `submitted` to `accepted` or `rejected`; any other move answers 409. A submission without a transport system is marked as sent manually.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.SubmissionsMarkAsync(
    new SubmissionsMarkDeclarationsRequest
    {
        Id = "id",
        Status = SubmissionsMarkDeclarationsRequestStatus.Submitted,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SubmissionsMarkDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">SubmissionsListAsync</a>(SubmissionsListDeclarationsRequest { ... }) -> WithRawResponseTask&lt;SubmissionsListDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the declaration submissions of the company, newest first, filterable by `obligation`, `status`, `periodYear` and `periodMonth` and sortable by `createdAt` or `periodYear`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.SubmissionsListAsync(new SubmissionsListDeclarationsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SubmissionsListDeclarationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ledger
<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">AccountsListAsync</a>(AccountsListLedgerRequest { ... }) -> WithRawResponseTask&lt;AccountsListLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the company's chart of accounts. Filterable by `code`, `name`, `type` and `isPostable`; sortable by `code` and `name`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.AccountsListAsync(new AccountsListLedgerRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AccountsListLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">AccountsCreateAsync</a>(AccountsCreateLedgerRequest { ... }) -> WithRawResponseTask&lt;AccountsCreateLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds an account to the company's chart of accounts. `parentId` must name an account of the same company. Answers 409 when an account with the same `code` already exists.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.AccountsCreateAsync(
    new AccountsCreateLedgerRequest
    {
        Code = "code",
        Name = "name",
        Type = AccountsCreateLedgerRequestType.Asset,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AccountsCreateLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">AccountsUpdateAsync</a>(AccountsUpdateLedgerRequest { ... }) -> WithRawResponseTask&lt;AccountsUpdateLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the name, parent or postability of an account; the code and type cannot be changed. An account cannot be its own parent.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.AccountsUpdateAsync(new AccountsUpdateLedgerRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AccountsUpdateLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">AccountsApplyTemplateAsync</a>(AccountsApplyTemplateLedgerRequest { ... }) -> WithRawResponseTask&lt;AccountsApplyTemplateLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds the accounts of the company's chart template that the chart does not have yet (an account whose code already exists is not replaced) and sets the parent links the template defines. Returns the number of accounts in the chart afterwards.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.AccountsApplyTemplateAsync(new AccountsApplyTemplateLedgerRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AccountsApplyTemplateLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">AccountsSwitchChartAsync</a>(AccountsSwitchChartLedgerRequest { ... }) -> WithRawResponseTask&lt;AccountsSwitchChartLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Replaces the seeded chart with the chart template of the company country (the Romanian general chart for a company registered in Romania, the Estonian e-arveldaja chart for a company registered in Estonia, the Lithuanian standard chart otherwise) and switches the posting defaults with it. Answers 409 when the company already uses that chart, has journal entries, holds accounts created by hand, or has settings that name an account the new chart does not have.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.AccountsSwitchChartAsync(new AccountsSwitchChartLedgerRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AccountsSwitchChartLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PeriodsListAsync</a>(PeriodsListLedgerRequest { ... }) -> WithRawResponseTask&lt;PeriodsListLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the company's accounting periods with their `open` or `locked` status. Filterable by `year`, `month` and `status`; sortable by `year` and `month`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PeriodsListAsync(new PeriodsListLedgerRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PeriodsListLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PeriodsLockAsync</a>(PeriodsLockLedgerRequest { ... }) -> WithRawResponseTask&lt;PeriodsLockLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Locks the month so that postings dated in it are refused with 409 (`ledger/journal/transactions/create`, `cash/orders/create` and `cash/expense-reports/create` among them). Before locking a month that is not locked yet, posts the pending ratable revenue recognition tranches scheduled up to the month end and emits `revenue_recognition.posted` when there were any; when the month is the company's fiscal year end and no year-end close is posted for that year, posts the year-end close that moves the income and expense balances of the fiscal year to the retained earnings account (posting rule `closing.retainedEarnings`).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PeriodsLockAsync(
    new PeriodsLockLedgerRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PeriodsLockLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PeriodsUnlockAsync</a>(PeriodsUnlockLedgerRequest { ... }) -> WithRawResponseTask&lt;PeriodsUnlockLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Opens the month for posting again. When the month is the company's fiscal year end and a year-end close is posted for it, posts a reversal of that close dated the same day.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PeriodsUnlockAsync(
    new PeriodsUnlockLedgerRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PeriodsUnlockLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">JournalTransactionsListAsync</a>(JournalTransactionsListLedgerRequest { ... }) -> WithRawResponseTask&lt;JournalTransactionsListLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists journal transactions with the partner name. Filterable by `date`, `status`, `documentType`, `partnerId` and `documentId`; sortable by `date` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.JournalTransactionsListAsync(new JournalTransactionsListLedgerRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `JournalTransactionsListLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">CostCentersCreateAsync</a>(CostCentersCreateLedgerRequest { ... }) -> WithRawResponseTask&lt;CostCentersCreateLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a cost center, optionally inside a cost center group. Answers 409 when the `code` is already used.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.CostCentersCreateAsync(
    new CostCentersCreateLedgerRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CostCentersCreateLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">CostCentersUpdateAsync</a>(CostCentersUpdateLedgerRequest { ... }) -> WithRawResponseTask&lt;CostCentersUpdateLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the name, group or active flag of a cost center. An inactive cost center is refused on new manual journal entries (`ledger/journal/transactions/create` answers 422).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.CostCentersUpdateAsync(new CostCentersUpdateLedgerRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CostCentersUpdateLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">CostCentersListAsync</a>(CostCentersListLedgerRequest { ... }) -> WithRawResponseTask&lt;CostCentersListLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists cost centers with their group name. Filterable by `code`, `name`, `isActive` and `groupId`; sortable by `code`, `name` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.CostCentersListAsync(new CostCentersListLedgerRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CostCentersListLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">CostCenterGroupsCreateAsync</a>(CostCenterGroupsCreateLedgerRequest { ... }) -> WithRawResponseTask&lt;CostCenterGroupsCreateLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a cost center group. Answers 409 when the `code` is already used.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.CostCenterGroupsCreateAsync(
    new CostCenterGroupsCreateLedgerRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CostCenterGroupsCreateLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">CostCenterGroupsUpdateAsync</a>(CostCenterGroupsUpdateLedgerRequest { ... }) -> WithRawResponseTask&lt;CostCenterGroupsUpdateLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the code or name of a cost center group. Answers 409 when the new code is already used.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.CostCenterGroupsUpdateAsync(
    new CostCenterGroupsUpdateLedgerRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CostCenterGroupsUpdateLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">CostCenterGroupsDeleteAsync</a>(CostCenterGroupsDeleteLedgerRequest { ... }) -> WithRawResponseTask&lt;CostCenterGroupsDeleteLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a cost center group. Answers 409 while cost centers are still assigned to it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.CostCenterGroupsDeleteAsync(
    new CostCenterGroupsDeleteLedgerRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CostCenterGroupsDeleteLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">CostCenterGroupsListAsync</a>(CostCenterGroupsListLedgerRequest { ... }) -> WithRawResponseTask&lt;CostCenterGroupsListLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists cost center groups. Filterable and sortable by `code` and `name`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.CostCenterGroupsListAsync(new CostCenterGroupsListLedgerRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CostCenterGroupsListLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostingRulesListAsync</a>(PostingRulesListLedgerRequest { ... }) -> WithRawResponseTask&lt;PostingRulesListLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists every posting rule with its default account code on the company's chart template, the account code in effect and whether the company has overridden it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostingRulesListAsync(new PostingRulesListLedgerRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostingRulesListLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostingRulesUpdateAsync</a>(PostingRulesUpdateLedgerRequest { ... }) -> WithRawResponseTask&lt;PostingRulesUpdateLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Overrides the account code of one or more posting rules; an `accountCode` of null removes the override and the chart default applies again. Every code given must be a postable account of the company's chart, else 422.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostingRulesUpdateAsync(
    new PostingRulesUpdateLedgerRequest
    {
        Rules = new List<PostingRulesUpdateLedgerRequestRulesItem>()
        {
            new PostingRulesUpdateLedgerRequestRulesItem
            {
                Key = PostingRulesUpdateLedgerRequestRulesItemKey.SalesReceivable,
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostingRulesUpdateLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">OwnersCreateAsync</a>(OwnersCreateLedgerRequest { ... }) -> WithRawResponseTask&lt;OwnersCreateLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds an owner of the company. `equityAccountCode` defaults to the share capital account of the company's chart; a code that is not in the chart of accounts answers 422.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.OwnersCreateAsync(new OwnersCreateLedgerRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OwnersCreateLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">OwnersUpdateAsync</a>(OwnersUpdateLedgerRequest { ... }) -> WithRawResponseTask&lt;OwnersUpdateLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the fields of an owner. An `equityAccountCode` that is not in the chart of accounts answers 422.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.OwnersUpdateAsync(new OwnersUpdateLedgerRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OwnersUpdateLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">OwnersDeleteAsync</a>(OwnersDeleteLedgerRequest { ... }) -> WithRawResponseTask&lt;OwnersDeleteLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes an owner.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.OwnersDeleteAsync(new OwnersDeleteLedgerRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OwnersDeleteLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">OwnersListAsync</a>(OwnersListLedgerRequest { ... }) -> WithRawResponseTask&lt;OwnersListLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the company's owners. Filterable by `name` and `code`; sortable by `name` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.OwnersListAsync(new OwnersListLedgerRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OwnersListLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">JournalTransactionsGetAsync</a>(JournalTransactionsGetLedgerRequest { ... }) -> WithRawResponseTask&lt;JournalTransactionsGetLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a journal transaction with its entries, ordered by account code.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.JournalTransactionsGetAsync(
    new JournalTransactionsGetLedgerRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `JournalTransactionsGetLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">JournalTransactionsCreateAsync</a>(JournalTransactionsCreateLedgerRequest { ... }) -> WithRawResponseTask&lt;JournalTransactionsCreateLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Posts a manual journal transaction (`documentType` `manual`, status `posted`) in the company's base currency. Every `accountCode` must be a postable account of the chart, cost centers must exist and be active, projects must exist, and the debits must equal the credits. Answers 422 for an amount with more than two decimals, for a `currency` other than the base currency and for an inactive cost center, and 409 when the accounting period of `date` is locked.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.JournalTransactionsCreateAsync(
    new JournalTransactionsCreateLedgerRequest
    {
        Date = new DateOnly(2026, 7, 1),
        Entries = new List<JournalTransactionsCreateLedgerRequestEntriesItem>()
        {
            new JournalTransactionsCreateLedgerRequestEntriesItem { AccountCode = "accountCode" },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `JournalTransactionsCreateLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">StatementRowsSchemesAsync</a>(StatementRowsSchemesLedgerRequest { ... }) -> WithRawResponseTask&lt;StatementRowsSchemesLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

The rows or codes of each return or registry deposit of the company country that are filled from account balances. Accounts fall into a row by the layout defaults for the standard chart of accounts unless mapped under Account → Statement rows.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.StatementRowsSchemesAsync(new StatementRowsSchemesLedgerRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StatementRowsSchemesLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">StatementRowsListAsync</a>(StatementRowsListLedgerRequest { ... }) -> WithRawResponseTask&lt;StatementRowsListLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Every postable account of the company with the row of `scheme` it falls into, by a mapping (`ledger/statement-rows/set`) or by the layout default, and the amount it carries there: the balance up to `toDate` on a balance-sheet row, the movement from `fromDate` to `toDate` on an income-statement row. `toDate` defaults to today and `fromDate` to 1 January of that year. `rows` holds the row totals and `unmapped` the accounts with a balance but no row.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.StatementRowsListAsync(
    new StatementRowsListLedgerRequest { Scheme = "scheme" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StatementRowsListLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">StatementRowsSetAsync</a>(StatementRowsSetLedgerRequest { ... }) -> WithRawResponseTask&lt;StatementRowsSetLedgerResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

A mapping on a code prefix covers every account whose code starts with it; the longest matching prefix wins. An empty rowCode removes the mapping so the layout default applies again.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.StatementRowsSetAsync(
    new StatementRowsSetLedgerRequest { Scheme = "scheme", AccountCode = "accountCode" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StatementRowsSetLedgerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Officers
<details><summary><code>client.Officers.<a href="/src/NordletApi/Officers/OfficersClient.cs">ListAsync</a>(ListOfficersRequest { ... }) -> WithRawResponseTask&lt;ListOfficersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Directors, board members, the company secretary, representatives and liquidators, with their personal identifier, appointment and resignation dates and whether they sign the annual accounts. Annual returns and registry deposits are built from this register.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Officers.ListAsync(new ListOfficersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListOfficersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Officers.<a href="/src/NordletApi/Officers/OfficersClient.cs">CreateAsync</a>(CreateOfficersRequest { ... }) -> WithRawResponseTask&lt;CreateOfficersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add an officer to the company's register (`officers/list`); `signsAccounts` defaults to true. Refused with 422 when `resignedOn` is before `appointedOn`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Officers.CreateAsync(
    new CreateOfficersRequest { Name = "name", Role = CreateOfficersRequestRole.Director }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateOfficersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Officers.<a href="/src/NordletApi/Officers/OfficersClient.cs">UpdateAsync</a>(UpdateOfficersRequest { ... }) -> WithRawResponseTask&lt;UpdateOfficersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Replace the recorded data of an officer; every field is written as sent, so a field left out is cleared and `signsAccounts` falls back to true. Refused with 422 when `resignedOn` is before `appointedOn`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Officers.UpdateAsync(
    new UpdateOfficersRequest
    {
        Id = "id",
        Name = "name",
        Role = UpdateOfficersRequestRole.Director,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateOfficersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Officers.<a href="/src/NordletApi/Officers/OfficersClient.cs">DeleteAsync</a>(DeleteOfficersRequest { ... }) -> WithRawResponseTask&lt;DeleteOfficersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove an officer from the company's register.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Officers.DeleteAsync(new DeleteOfficersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteOfficersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PlatformSellers
<details><summary><code>client.PlatformSellers.<a href="/src/NordletApi/PlatformSellers/PlatformSellersClient.cs">ListAsync</a>(ListPlatformSellersRequest { ... }) -> WithRawResponseTask&lt;ListPlatformSellersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Individuals and entities that sell goods, rent out property or transport, or perform personal services through the platform the company operates. The yearly DAC7 report is built from them.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PlatformSellers.ListAsync(new ListPlatformSellersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListPlatformSellersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PlatformSellers.<a href="/src/NordletApi/PlatformSellers/PlatformSellersClient.cs">GetAsync</a>(GetPlatformSellersRequest { ... }) -> WithRawResponseTask&lt;GetPlatformSellersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read one platform seller with its activities, ordered by year.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PlatformSellers.GetAsync(new GetPlatformSellersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetPlatformSellersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PlatformSellers.<a href="/src/NordletApi/PlatformSellers/PlatformSellersClient.cs">CreateAsync</a>(CreatePlatformSellersRequest { ... }) -> WithRawResponseTask&lt;CreatePlatformSellersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Record a seller on the company's platform for the DAC7 report: an `individual` (first and last name required) or an `entity` (`entityName` required), with its `activities` per year and quarter. An `immovable_property` activity needs `propertyAddress`; property address, type and rented days on any other kind of activity are refused. These checks answer 422; a `partnerId` that does not exist answers 404. The report is built from the sellers with `declarations/eu/dac7/preview` and `declarations/eu/dac7/xml`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PlatformSellers.CreateAsync(
    new CreatePlatformSellersRequest
    {
        Kind = CreatePlatformSellersRequestKind.Individual,
        Address = new CreatePlatformSellersRequestAddress { CountryCode = "countryCode" },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreatePlatformSellersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PlatformSellers.<a href="/src/NordletApi/PlatformSellers/PlatformSellersClient.cs">UpdateAsync</a>(UpdatePlatformSellersRequest { ... }) -> WithRawResponseTask&lt;UpdatePlatformSellersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Replace a platform seller's details and all of its activities with the ones given, under the same checks as `platform-sellers/create`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PlatformSellers.UpdateAsync(
    new UpdatePlatformSellersRequest
    {
        Id = "id",
        Kind = UpdatePlatformSellersRequestKind.Individual,
        Address = new UpdatePlatformSellersRequestAddress { CountryCode = "countryCode" },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdatePlatformSellersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PlatformSellers.<a href="/src/NordletApi/PlatformSellers/PlatformSellersClient.cs">DeleteAsync</a>(DeletePlatformSellersRequest { ... }) -> WithRawResponseTask&lt;DeletePlatformSellersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Mark a platform seller as deleted. It leaves the lists and the DAC7 report.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PlatformSellers.DeleteAsync(new DeletePlatformSellersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeletePlatformSellersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## migration
<details><summary><code>client.Migration.<a href="/src/NordletApi/Migration/MigrationClient.cs">BooksValidateAsync</a>(BooksValidateMigrationRequest { ... }) -> WithRawResponseTask&lt;BooksValidateMigrationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Runs every check the import runs (accounts, partners, balances, open invoices, assets, stock) and returns the same summary and warnings, then rolls everything back. Nothing is stored.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Migration.BooksValidateAsync(
    new BooksValidateMigrationRequest { CutoverDate = new DateOnly(2026, 7, 1) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BooksValidateMigrationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Migration.<a href="/src/NordletApi/Migration/MigrationClient.cs">BooksImportAsync</a>(BooksImportMigrationRequest { ... }) -> WithRawResponseTask&lt;BooksImportMigrationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Brings a company over from another system in one call: chart of accounts, partners, items, opening balances (or the full journal history), open customer and supplier invoices, fixed assets with their accumulated depreciation, and stock on hand. The whole package is written in one database transaction - if any row fails, nothing is stored.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Migration.BooksImportAsync(
    new BooksImportMigrationRequest { CutoverDate = new DateOnly(2026, 7, 1) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BooksImportMigrationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## assets
<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">SettingsGetAsync</a>(SettingsGetAssetsRequest { ... }) -> WithRawResponseTask&lt;SettingsGetAssetsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the company's fixed asset setting `autoDepreciation`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.SettingsGetAsync(new SettingsGetAssetsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettingsGetAssetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">SettingsUpdateAsync</a>(SettingsUpdateAssetsRequest { ... }) -> WithRawResponseTask&lt;SettingsUpdateAssetsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Turn automatic depreciation on or off. When it is on, the scheduler posts the previous month's depreciation for the company once a day, as `assets/depreciation/post` does.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.SettingsUpdateAsync(
    new SettingsUpdateAssetsRequest { AutoDepreciation = true }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettingsUpdateAssetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">GroupsCreateAsync</a>(GroupsCreateAssetsRequest { ... }) -> WithRawResponseTask&lt;GroupsCreateAssetsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create an asset group: the asset, accumulated depreciation and depreciation expense accounts its assets are posted to, and an optional default useful life in months. `expenseAccountCode` defaults to the chart's depreciation expense account; each account must exist and be postable (422). A duplicate code is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.GroupsCreateAsync(
    new GroupsCreateAssetsRequest
    {
        Code = "code",
        Name = "name",
        AssetAccountCode = "assetAccountCode",
        DepreciationAccountCode = "depreciationAccountCode",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GroupsCreateAssetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">GroupsListAsync</a>(GroupsListAssetsRequest { ... }) -> WithRawResponseTask&lt;GroupsListAssetsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the asset groups; filterable and sortable by `code` and `name`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.GroupsListAsync(new GroupsListAssetsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GroupsListAssetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">AssetsCreateAsync</a>(AssetsCreateAssetsRequest { ... }) -> WithRawResponseTask&lt;AssetsCreateAssetsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Register a fixed asset in a group with its acquisition date and cost, salvage value, useful life in months (defaults to the group's default; 422 when neither is set) and depreciation start date (defaults to the acquisition date). The salvage value must be below the acquisition cost (422); a duplicate code is refused with 409. Depreciation is posted with `assets/depreciation/post`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.AssetsCreateAsync(
    new AssetsCreateAssetsRequest
    {
        GroupId = "groupId",
        Code = "code",
        Name = "name",
        AcquisitionDate = new DateOnly(2026, 7, 1),
        AcquisitionCost = "121.0000",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AssetsCreateAssetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">AssetsUpdateAsync</a>(AssetsUpdateAssetsRequest { ... }) -> WithRawResponseTask&lt;AssetsUpdateAssetsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change an asset that has no posted depreciation yet: group, code, name, dates, cost, salvage value, useful life, notes or documents. Refused with 409 once depreciation is posted or the asset is disposed, and with 422 when the salvage value would reach the acquisition cost; a duplicate code is 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.AssetsUpdateAsync(new AssetsUpdateAssetsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AssetsUpdateAssetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">AssetsInputVatAsync</a>(AssetsInputVatAssetsRequest { ... }) -> WithRawResponseTask&lt;AssetsInputVatAssetsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Record the input VAT facts of a capital good that the annual VAT return needs for the adjustment of the deduction over the adjustment period (Article 187 of the VAT Directive, § 15a UStG): the input VAT on the acquisition, the date of first use, the share of use for deductible turnover at first use, whether it is land or a building (ten-year period instead of five), and every later year in which the share changed or the good was sold or withdrawn. Allowed also after depreciation has been posted.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.AssetsInputVatAsync(
    new AssetsInputVatAssetsRequest
    {
        Id = "id",
        InputVatRealEstate = true,
        InputVatUseChanges = new List<AssetsInputVatAssetsRequestInputVatUseChangesItem>()
        {
            new AssetsInputVatAssetsRequestInputVatUseChangesItem
            {
                Year = 1000000,
                Percent = "121.00",
                Reason = AssetsInputVatAssetsRequestInputVatUseChangesItemReason.UseChange,
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AssetsInputVatAssetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">AssetsGetAsync</a>(AssetsGetAssetsRequest { ... }) -> WithRawResponseTask&lt;AssetsGetAssetsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one fixed asset with its totals (cost including modernisations, accumulated depreciation, net book value, total life in months), its input VAT facts and its disposal.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.AssetsGetAsync(new AssetsGetAssetsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AssetsGetAssetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">AssetsListAsync</a>(AssetsListAssetsRequest { ... }) -> WithRawResponseTask&lt;AssetsListAssetsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the fixed assets; filterable by `code`, `name`, `groupId`, `status`, `acquisitionDate`, `acquisitionCost` and `accumulatedDepreciation`, sortable by `code`, `name`, `acquisitionDate` and `acquisitionCost`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.AssetsListAsync(new AssetsListAssetsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AssetsListAssetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">AssetsModernizeAsync</a>(AssetsModernizeAssetsRequest { ... }) -> WithRawResponseTask&lt;AssetsModernizeAssetsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Record a modernisation of a fixed asset: `amount` is added to its cost and `addedLifeMonths` to its useful life from the month of `date` on, and the remaining depreciable value is spread over the months left. Refused with 422 when the asset is disposed or when no depreciation month would be left (give `addedLifeMonths` of at least 1); a fully depreciated asset becomes active again.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.AssetsModernizeAsync(
    new AssetsModernizeAssetsRequest
    {
        Id = "id",
        Date = new DateOnly(2026, 7, 1),
        Amount = "121.0000",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AssetsModernizeAssetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">AssetsDisposeAsync</a>(AssetsDisposeAssetsRequest { ... }) -> WithRawResponseTask&lt;AssetsDisposeAssetsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Dispose of a fixed asset (sold, scrapped or written off). Removes its cost and accumulated depreciation, books the net book value as a disposal loss and the proceeds as a disposal gain (posting rules assets.disposalLoss, assets.disposalGain, assets.disposalProceeds), and stops its depreciation. Depreciation must be posted for every month before the disposal month.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.AssetsDisposeAsync(
    new AssetsDisposeAssetsRequest
    {
        Id = "id",
        Date = new DateOnly(2026, 7, 1),
        Reason = AssetsDisposeAssetsRequestReason.Sold,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AssetsDisposeAssetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">DepreciationPreviewAsync</a>(DepreciationPreviewAssetsRequest { ... }) -> WithRawResponseTask&lt;DepreciationPreviewAssetsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Preview what `assets/depreciation/post` would post for a month: per active asset the amount and the months it covers, earlier unposted months included, and whether the month is already posted. Nothing is written.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.DepreciationPreviewAsync(
    new DepreciationPreviewAssetsRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DepreciationPreviewAssetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">DepreciationPostAsync</a>(DepreciationPostAssetsRequest { ... }) -> WithRawResponseTask&lt;DepreciationPostAssetsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Post the depreciation of a month: one journal entry dated the last day of the month that debits each group's expense account and credits its accumulated depreciation account, for every active asset whose depreciation has started, covering that month and any earlier month not yet posted. Each month's amount is the remaining depreciable value (cost plus modernisations less salvage value less accumulated depreciation) divided by the months left; an asset whose life or value is used up becomes `fully_depreciated`. Answers 409 when the period is locked, and `journalTransactionId` null when nothing is due.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.DepreciationPostAsync(
    new DepreciationPostAssetsRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DepreciationPostAssetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## hr
<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PositionsCreateAsync</a>(PositionsCreateHrRequest { ... }) -> WithRawResponseTask&lt;PositionsCreateHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a job position with an optional code and name translations, for use in `hr/contracts/create`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PositionsCreateAsync(new PositionsCreateHrRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PositionsCreateHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PositionsUpdateAsync</a>(PositionsUpdateHrRequest { ... }) -> WithRawResponseTask&lt;PositionsUpdateHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the code, name or translations of a position; a null `translations` removes them.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PositionsUpdateAsync(new PositionsUpdateHrRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PositionsUpdateHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PositionsListAsync</a>(PositionsListHrRequest { ... }) -> WithRawResponseTask&lt;PositionsListHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the company's positions; filterable and sortable by `name` and `code`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PositionsListAsync(new PositionsListHrRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PositionsListHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">EmployeesCreateAsync</a>(EmployeesCreateHrRequest { ... }) -> WithRawResponseTask&lt;EmployeesCreateHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an employee record. `payrollOptions` holds the country-specific settings the payroll engine reads for the person (see `hr/employees/fields`); `applyAllowance` defaults to true and `pensionAccumulation` to false.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.EmployeesCreateAsync(
    new EmployeesCreateHrRequest { FirstName = "firstName", LastName = "lastName" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EmployeesCreateHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">EmployeesUpdateAsync</a>(EmployeesUpdateHrRequest { ... }) -> WithRawResponseTask&lt;EmployeesUpdateHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the given fields of an employee; a null clears the fields that allow it (code, personal code, birth date, contact details, address, IBAN, social insurance number and start, hire date, notes). `status` and `terminationDate` are set here too.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.EmployeesUpdateAsync(new EmployeesUpdateHrRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EmployeesUpdateHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">EmployeesGetAsync</a>(EmployeesGetHrRequest { ... }) -> WithRawResponseTask&lt;EmployeesGetHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Reads one employee.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.EmployeesGetAsync(new EmployeesGetHrRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EmployeesGetHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">EmployeesFieldsAsync</a>(EmployeesFieldsHrRequest { ... }) -> WithRawResponseTask&lt;EmployeesFieldsHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Attributes a filing of the company country needs about a person that the shared employee record does not carry, such as the sex and place of birth an Italian income certificate asks for. Their values are kept in the payrollOptions of the employee.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.EmployeesFieldsAsync(new EmployeesFieldsHrRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EmployeesFieldsHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">EmployeesListAsync</a>(EmployeesListHrRequest { ... }) -> WithRawResponseTask&lt;EmployeesListHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the employees that are not deleted; filterable by `firstName`, `lastName`, `code`, `status` and `email`, sortable by `lastName`, `code` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.EmployeesListAsync(new EmployeesListHrRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EmployeesListHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">EmployeesDeleteAsync</a>(EmployeesDeleteHrRequest { ... }) -> WithRawResponseTask&lt;EmployeesDeleteHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Marks the employee deleted; the record stays and no longer appears in lists or payroll runs. `hr/employees/anonymize` also blanks the personal data.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.EmployeesDeleteAsync(new EmployeesDeleteHrRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EmployeesDeleteHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">EmployeesAnonymizeAsync</a>(EmployeesAnonymizeHrRequest { ... }) -> WithRawResponseTask&lt;EmployeesAnonymizeHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Replaces the name with a placeholder and removes personal code, birth date, contact details, address, bank account, social-insurance number, notes and sick-leave reasons. Payroll and contract rows stay linked to the record for the statutory retention period.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.EmployeesAnonymizeAsync(new EmployeesAnonymizeHrRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EmployeesAnonymizeHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">ContractsCreateAsync</a>(ContractsCreateHrRequest { ... }) -> WithRawResponseTask&lt;ContractsCreateHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an employment contract for an employee. A `permanent` contract takes no `endDate` and a `fixed_term` one requires it; the number comes from `contractNo` or, with `agreementId`, from the employee's agreement; `workHours` defaults by `salaryType`. Answers 422 when the end date is before the start, and 409 when the employee already has a contract overlapping the period (end it with `hr/contracts/end` first) or the contract number already exists.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.ContractsCreateAsync(
    new ContractsCreateHrRequest
    {
        EmployeeId = "employeeId",
        StartDate = new DateOnly(2026, 7, 1),
        BaseSalary = "121.0000",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ContractsCreateHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">ContractsEndAsync</a>(ContractsEndHrRequest { ... }) -> WithRawResponseTask&lt;ContractsEndHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Ends a contract on `endDate` with an optional reason. Answers 422 when the end date is before the contract start.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.ContractsEndAsync(
    new ContractsEndHrRequest { Id = "id", EndDate = new DateOnly(2026, 7, 1) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ContractsEndHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">ContractsListAsync</a>(ContractsListHrRequest { ... }) -> WithRawResponseTask&lt;ContractsListHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists employment contracts; filterable by `employeeId`, `agreementId`, `status` and `contractNo`, sortable by `startDate` and `contractNo`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.ContractsListAsync(new ContractsListHrRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ContractsListHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">LeaveBalancesSetAsync</a>(LeaveBalancesSetHrRequest { ... }) -> WithRawResponseTask&lt;LeaveBalancesSetHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates or replaces the leave entitlement of an employee for a year; `usedDays` is kept unless given (0 on a new row) and `remainingDays` is the entitled days less the used ones.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.LeaveBalancesSetAsync(
    new LeaveBalancesSetHrRequest
    {
        EmployeeId = "employeeId",
        Year = 1000000,
        EntitledDays = "121.00",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LeaveBalancesSetHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">LeaveBalancesListAsync</a>(LeaveBalancesListHrRequest { ... }) -> WithRawResponseTask&lt;LeaveBalancesListHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists leave balances, narrowed to an employee and/or a year when given, oldest year first.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.LeaveBalancesListAsync(new LeaveBalancesListHrRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LeaveBalancesListHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">IncapacityCertificatesCreateAsync</a>(IncapacityCertificatesCreateHrRequest { ... }) -> WithRawResponseTask&lt;IncapacityCertificatesCreateHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Records a sick-leave certificate of an employee. Answers 422 when `toDate` is before `fromDate`. `payroll/runs/create` warns when a certificate covers working days of a month that has no timesheet.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.IncapacityCertificatesCreateAsync(
    new IncapacityCertificatesCreateHrRequest
    {
        EmployeeId = "employeeId",
        Number = "number",
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IncapacityCertificatesCreateHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">IncapacityCertificatesListAsync</a>(IncapacityCertificatesListHrRequest { ... }) -> WithRawResponseTask&lt;IncapacityCertificatesListHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists incapacity certificates; filterable by `employeeId` and `number`, sortable by `fromDate` and `number`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.IncapacityCertificatesListAsync(new IncapacityCertificatesListHrRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IncapacityCertificatesListHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PerDiemRatesCreateAsync</a>(PerDiemRatesCreateHrRequest { ... }) -> WithRawResponseTask&lt;PerDiemRatesCreateHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds the company's daily per diem rate for a destination country from `validFrom`; `hr/business-trips/create` takes the latest rate valid on the trip's start date. Answers 409 when a rate for that country already starts on that date.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PerDiemRatesCreateAsync(
    new PerDiemRatesCreateHrRequest
    {
        CountryCode = "countryCode",
        DailyAmount = "121.00",
        ValidFrom = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PerDiemRatesCreateHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PerDiemRatesListAsync</a>(PerDiemRatesListHrRequest { ... }) -> WithRawResponseTask&lt;PerDiemRatesListHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists per diem rates; filterable by `countryCode`, sortable by `countryCode` and `validFrom`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PerDiemRatesListAsync(new PerDiemRatesListHrRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PerDiemRatesListHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PerDiemRatesDeleteAsync</a>(PerDiemRatesDeleteHrRequest { ... }) -> WithRawResponseTask&lt;PerDiemRatesDeleteHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a per diem rate.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PerDiemRatesDeleteAsync(new PerDiemRatesDeleteHrRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PerDiemRatesDeleteHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">BusinessTripsCreateAsync</a>(BusinessTripsCreateHrRequest { ... }) -> WithRawResponseTask&lt;BusinessTripsCreateHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Stores the trip as a draft with `days` counted as calendar days, both ends included, and `perDiemAmount` as the days times the company's rate for the destination valid on the start date (`hr/per-diem-rates/create`). Answers 422 when the trip ends before it starts or no rate covers the destination on that date, and 409 when the employee already has a trip overlapping the dates.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.BusinessTripsCreateAsync(
    new BusinessTripsCreateHrRequest
    {
        EmployeeId = "employeeId",
        DestinationCountryCode = "destinationCountryCode",
        Purpose = "purpose",
        StartDate = new DateOnly(2026, 7, 1),
        EndDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BusinessTripsCreateHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">BusinessTripsGetAsync</a>(BusinessTripsGetHrRequest { ... }) -> WithRawResponseTask&lt;BusinessTripsGetHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Reads one business trip.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.BusinessTripsGetAsync(new BusinessTripsGetHrRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BusinessTripsGetHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">BusinessTripsListAsync</a>(BusinessTripsListHrRequest { ... }) -> WithRawResponseTask&lt;BusinessTripsListHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists business trips; filterable by `employeeId`, `status` and `payrollRunId`, sortable by `startDate`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.BusinessTripsListAsync(new BusinessTripsListHrRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BusinessTripsListHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">BusinessTripsApproveAsync</a>(BusinessTripsApproveHrRequest { ... }) -> WithRawResponseTask&lt;BusinessTripsApproveHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Sets the trip's status to `approved`. `payroll/runs/create` without explicit lines adds the per diem of every approved trip ending in the run month as an untaxed addition and sets the trip's `payrollRunId`; reversing or cancelling the run releases the trip again. Answers 409 when the trip is not a draft.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.BusinessTripsApproveAsync(new BusinessTripsApproveHrRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BusinessTripsApproveHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">BusinessTripsDeleteAsync</a>(BusinessTripsDeleteHrRequest { ... }) -> WithRawResponseTask&lt;BusinessTripsDeleteHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a draft trip; answers 409 when the trip is not a draft.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.BusinessTripsDeleteAsync(new BusinessTripsDeleteHrRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BusinessTripsDeleteHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">EmployeesRecordsCreateAsync</a>(EmployeesRecordsCreateHrRequest { ... }) -> WithRawResponseTask&lt;EmployeesRecordsCreateHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds an education, qualification, certificate or training record to an employee, optionally linked to one of the company's uploaded files (`fileId`).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.EmployeesRecordsCreateAsync(
    new EmployeesRecordsCreateHrRequest
    {
        EmployeeId = "employeeId",
        Type = EmployeesRecordsCreateHrRequestType.Education,
        Title = "title",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EmployeesRecordsCreateHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">EmployeesRecordsUpdateAsync</a>(EmployeesRecordsUpdateHrRequest { ... }) -> WithRawResponseTask&lt;EmployeesRecordsUpdateHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes the given fields of an employee record; `issuedAt`, `validUntil` and `fileId` can be cleared with null.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.EmployeesRecordsUpdateAsync(new EmployeesRecordsUpdateHrRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EmployeesRecordsUpdateHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">EmployeesRecordsDeleteAsync</a>(EmployeesRecordsDeleteHrRequest { ... }) -> WithRawResponseTask&lt;EmployeesRecordsDeleteHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes an employee record.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.EmployeesRecordsDeleteAsync(new EmployeesRecordsDeleteHrRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EmployeesRecordsDeleteHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">EmployeesRecordsListAsync</a>(EmployeesRecordsListHrRequest { ... }) -> WithRawResponseTask&lt;EmployeesRecordsListHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists employee records; filterable by `employeeId`, `type` and `title`, sortable by `createdAt` and `issuedAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.EmployeesRecordsListAsync(new EmployeesRecordsListHrRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EmployeesRecordsListHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">EmployeesAttachmentsListAsync</a>(EmployeesAttachmentsListHrRequest { ... }) -> WithRawResponseTask&lt;EmployeesAttachmentsListHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the files uploaded against an employee, newest first.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.EmployeesAttachmentsListAsync(
    new EmployeesAttachmentsListHrRequest { EmployeeId = "employeeId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EmployeesAttachmentsListHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">TimesheetsGenerateAsync</a>(TimesheetsGenerateHrRequest { ... }) -> WithRawResponseTask&lt;TimesheetsGenerateHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Builds the timesheet of the month for every employee with a contract in it, or for one employee with `employeeId`, replacing any existing timesheet: the Monday to Friday days within the contract get the contract's daily hours (its weekly hours over five), and for a Lithuanian company the public holidays are `holiday` days with 0 hours. Answers 422 when no contract covers the month.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.TimesheetsGenerateAsync(
    new TimesheetsGenerateHrRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TimesheetsGenerateHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">TimesheetsUpsertAsync</a>(TimesheetsUpsertHrRequest { ... }) -> WithRawResponseTask&lt;TimesheetsUpsertHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates or replaces the timesheet of an employee for a month from the given days; `workedDays` and `workedHours` count the `work` and `business_trip` days with hours. Answers 422 for a day outside the month, a day given twice or more than 24 hours in a day. `payroll/runs/create` reads the timesheet for the paid days, the days worked and the business-trip days of the month.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.TimesheetsUpsertAsync(
    new TimesheetsUpsertHrRequest
    {
        EmployeeId = "employeeId",
        Year = 1000000,
        Month = 1000000,
        Days = new List<TimesheetsUpsertHrRequestDaysItem>()
        {
            new TimesheetsUpsertHrRequestDaysItem
            {
                Day = 1000000,
                Hours = "121.00",
                Type = TimesheetsUpsertHrRequestDaysItemType.Work,
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TimesheetsUpsertHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">TimesheetsGetAsync</a>(TimesheetsGetHrRequest { ... }) -> WithRawResponseTask&lt;TimesheetsGetHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Reads the timesheet of an employee for a month.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.TimesheetsGetAsync(
    new TimesheetsGetHrRequest
    {
        EmployeeId = "employeeId",
        Year = 1000000,
        Month = 1000000,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TimesheetsGetHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">TimesheetsListAsync</a>(TimesheetsListHrRequest { ... }) -> WithRawResponseTask&lt;TimesheetsListHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the timesheets of a month, ordered by employee name.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.TimesheetsListAsync(
    new TimesheetsListHrRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TimesheetsListHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">TimesheetsDeleteAsync</a>(TimesheetsDeleteHrRequest { ... }) -> WithRawResponseTask&lt;TimesheetsDeleteHrResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a timesheet.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.TimesheetsDeleteAsync(new TimesheetsDeleteHrRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TimesheetsDeleteHrRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## fleet
<details><summary><code>client.Fleet.<a href="/src/NordletApi/Fleet/FleetClient.cs">VehiclesCreateAsync</a>(VehiclesCreateFleetRequest { ... }) -> WithRawResponseTask&lt;VehiclesCreateFleetResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Register a vehicle. The plate number is stored in upper case and must be unique in the company (409 otherwise); `fixedAssetId` must name an existing fixed asset. Uploaded `documents` are attached to the vehicle.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.VehiclesCreateAsync(
    new VehiclesCreateFleetRequest
    {
        PlateNumber = "plateNumber",
        Make = "make",
        Model = "model",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VehiclesCreateFleetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Fleet.<a href="/src/NordletApi/Fleet/FleetClient.cs">VehiclesUpdateAsync</a>(VehiclesUpdateFleetRequest { ... }) -> WithRawResponseTask&lt;VehiclesUpdateFleetResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change a vehicle's details or set its `status` to `active`, `sold` or `scrapped`; omitted fields keep their value. A plate number already used by another vehicle is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.VehiclesUpdateAsync(new VehiclesUpdateFleetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VehiclesUpdateFleetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Fleet.<a href="/src/NordletApi/Fleet/FleetClient.cs">VehiclesGetAsync</a>(VehiclesGetFleetRequest { ... }) -> WithRawResponseTask&lt;VehiclesGetFleetResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read one vehicle with its current assignment, when an employee holds it today.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.VehiclesGetAsync(new VehiclesGetFleetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VehiclesGetFleetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Fleet.<a href="/src/NordletApi/Fleet/FleetClient.cs">VehiclesListAsync</a>(VehiclesListFleetRequest { ... }) -> WithRawResponseTask&lt;VehiclesListFleetResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List vehicles with their current assignment. Filterable by `plateNumber`, `make`, `model` and `status`; sortable by `plateNumber`, `make` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.VehiclesListAsync(new VehiclesListFleetRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VehiclesListFleetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Fleet.<a href="/src/NordletApi/Fleet/FleetClient.cs">AssignmentsCreateAsync</a>(AssignmentsCreateFleetRequest { ... }) -> WithRawResponseTask&lt;AssignmentsCreateFleetResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Assign a vehicle to an employee from `fromDate`, open-ended or until `toDate`. A period that overlaps another assignment of the same vehicle is refused with 409, a `toDate` before `fromDate` with 422. `privateUse` makes the car a benefit in kind in `fleet/natura/preview`, and `employerPaysFuel` picks its rate.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.AssignmentsCreateAsync(
    new AssignmentsCreateFleetRequest
    {
        VehicleId = "vehicleId",
        EmployeeId = "employeeId",
        FromDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AssignmentsCreateFleetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Fleet.<a href="/src/NordletApi/Fleet/FleetClient.cs">AssignmentsEndAsync</a>(AssignmentsEndFleetRequest { ... }) -> WithRawResponseTask&lt;AssignmentsEndFleetResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

End an open assignment on `toDate`. An assignment that already has an end date is refused with 409, a `toDate` before its `fromDate` with 422.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.AssignmentsEndAsync(
    new AssignmentsEndFleetRequest { Id = "id", ToDate = new DateOnly(2026, 7, 1) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AssignmentsEndFleetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Fleet.<a href="/src/NordletApi/Fleet/FleetClient.cs">AssignmentsListAsync</a>(AssignmentsListFleetRequest { ... }) -> WithRawResponseTask&lt;AssignmentsListFleetResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List vehicle assignments with the plate number and the employee's name. Filterable by `vehicleId`, `employeeId` and `privateUse`; sortable by `fromDate` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.AssignmentsListAsync(new AssignmentsListFleetRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AssignmentsListFleetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Fleet.<a href="/src/NordletApi/Fleet/FleetClient.cs">NaturaPreviewAsync</a>(NaturaPreviewFleetRequest { ... }) -> WithRawResponseTask&lt;NaturaPreviewFleetResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Preview the car benefit in kind of a month for a Lithuanian company: every assignment with `privateUse` that overlaps the month is valued at 0.75 % of the vehicle's market value when the employer pays the fuel, else 0.70 %, one row per employee and vehicle, with the total. A company registered in another country is refused with 422. The same amounts are added to a payroll run created with `includeNatura` (`payroll/runs/create`).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.NaturaPreviewAsync(
    new NaturaPreviewFleetRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `NaturaPreviewFleetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## payroll
<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">DepartmentsCreateAsync</a>(DepartmentsCreatePayrollRequest { ... }) -> WithRawResponseTask&lt;DepartmentsCreatePayrollResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a department with a code and a name; answers 409 when the code already exists.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.DepartmentsCreateAsync(
    new DepartmentsCreatePayrollRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DepartmentsCreatePayrollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">DepartmentsListAsync</a>(DepartmentsListPayrollRequest { ... }) -> WithRawResponseTask&lt;DepartmentsListPayrollResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the company's departments ordered by code.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.DepartmentsListAsync(new DepartmentsListPayrollRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DepartmentsListPayrollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">SchedulesCreateAsync</a>(SchedulesCreatePayrollRequest { ... }) -> WithRawResponseTask&lt;SchedulesCreatePayrollResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a work schedule with a code, a name and `hoursPerWeek` (default 40); answers 409 when the code already exists.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.SchedulesCreateAsync(
    new SchedulesCreatePayrollRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SchedulesCreatePayrollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">SchedulesListAsync</a>(SchedulesListPayrollRequest { ... }) -> WithRawResponseTask&lt;SchedulesListPayrollResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists the company's work schedules ordered by code.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.SchedulesListAsync(new SchedulesListPayrollRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SchedulesListPayrollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">PaymentTypesListAsync</a>(PaymentTypesListPayrollRequest { ... }) -> WithRawResponseTask&lt;PaymentTypesListPayrollResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Reads the payment types of the company country's payroll engine, each with the labels of the taxes, contributions and reporting lines it is subject to (`applies`), and the default type an untyped payment falls under. These codes are what `payroll/calc` and the additions of `payroll/runs/create` accept as `paymentType`. Answers 422 when Nordlet has no payroll engine for the company's country.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.PaymentTypesListAsync(new PaymentTypesListPayrollRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PaymentTypesListPayrollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">CalcAsync</a>(CalcPayrollRequest { ... }) -> WithRawResponseTask&lt;CalcPayrollResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Runs the company country's payroll engine once on a taxable base at a date, with the employee settings given in the body instead of an employee record, and returns the allowance, income tax, contributions, components and net; nothing is saved. `payments` passes typed payments to the engine; each `paymentType` must be a code from `payroll/payment-types/list` (422 otherwise). Answers 422 when Nordlet has no payroll engine for the company's country.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.CalcAsync(
    new CalcPayrollRequest { TaxableBase = "121.00", Date = new DateOnly(2026, 7, 1) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CalcPayrollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">RunsCreateAsync</a>(RunsCreatePayrollRequest { ... }) -> WithRawResponseTask&lt;RunsCreatePayrollResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a draft payroll run for a month, computing each line with the company country's payroll engine, the employee's approved runs of the year so far and of the two previous years, the month's timesheet and `payDate` (default the last day of the month). Without `lines`, every active employee whose contract covers the month gets a line: the gross is the contract's monthly salary reduced to the paid working days of the contract and the timesheet, unless `grossOverrides` sets it; the per diems of approved business trips ending in the month are added untaxed and the trips linked to the run; for a Lithuanian company the car benefit in kind (`includeNatura`) and the compensation for unused leave of a contract ending in the month are added. With `lines`, only the given employees are computed with their gross, additions and deductions; a taxable addition may carry a `paymentType` from `payroll/payment-types/list` and `hours`. Answers 422 when the country has no engine, an employee is given twice, has two contracts in the month, has no contract and no gross, or is paid by the hour or day without a gross; 409 when a run for the month already exists or the accounting period is locked.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.RunsCreateAsync(
    new RunsCreatePayrollRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RunsCreatePayrollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">RunsGetAsync</a>(RunsGetPayrollRequest { ... }) -> WithRawResponseTask&lt;RunsGetPayrollResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Reads a payroll run with its lines.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.RunsGetAsync(new RunsGetPayrollRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RunsGetPayrollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">RunsListAsync</a>(RunsListPayrollRequest { ... }) -> WithRawResponseTask&lt;RunsListPayrollResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists payroll runs without their lines; filterable by `status`, `year` and `month`, sortable by `createdAt`, `year` and `month`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.RunsListAsync(new RunsListPayrollRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RunsListPayrollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">LinesAttendanceAsync</a>(LinesAttendancePayrollRequest { ... }) -> WithRawResponseTask&lt;LinesAttendancePayrollResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

The days and hours worked, the days on the register and the average hourly earnings that some countries report per employment. The Czech monthly employer report asks for all four. They can be set while the run is a draft.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.LinesAttendanceAsync(new LinesAttendancePayrollRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LinesAttendancePayrollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">RunsApproveAsync</a>(RunsApprovePayrollRequest { ... }) -> WithRawResponseTask&lt;RunsApprovePayrollResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Posts the run's journal entry dated the last day of the month and sets the status to `approved`: the wage expense (net pay, income tax, employee contributions and deductions) and the employer contributions are debited; the net payable, the income tax, the social contributions (on one account, or split between the employee and employer accounts when their codes differ) and the deductions are credited. The accounts default to the payroll accounts of the company's chart template; each can be given per call. Answers 409 when the run is not a draft or the accounting period is locked, 422 when the run has no lines or nothing to post, and emits `payroll_run.approved`. For an Irish company with the automation of the `ie-payroll-withholding` deadline switched on, the month's payroll submission is sent at once and a failure is added to the run's `warnings`. Undo with `payroll/runs/reverse`, pay with `payroll/payments/export`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.RunsApproveAsync(new RunsApprovePayrollRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RunsApprovePayrollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">RunsReverseAsync</a>(RunsReversePayrollRequest { ... }) -> WithRawResponseTask&lt;RunsReversePayrollResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Posts a journal entry dated the last day of the month that mirrors the run's entry (debits and credits swapped), sets the status to `reversed` with the reason, and releases the business trips the run paid so the next run picks them up again. Answers 409 when the run is not approved, when part of it is matched to bank payments (`paidAmount`, unmatch them first) or when the accounting period is locked. Emits `payroll_run.reversed`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.RunsReverseAsync(
    new RunsReversePayrollRequest { Id = "id", Reason = "reason" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RunsReversePayrollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">RunsCancelAsync</a>(RunsCancelPayrollRequest { ... }) -> WithRawResponseTask&lt;RunsCancelPayrollResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a draft run with its lines and releases the business trips linked to it; answers 409 when the run is not a draft. An approved run is undone with `payroll/runs/reverse`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.RunsCancelAsync(new RunsCancelPayrollRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RunsCancelPayrollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">PaymentsExportAsync</a>(PaymentsExportPayrollRequest { ... }) -> WithRawResponseTask&lt;PaymentsExportPayrollResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Builds a SEPA credit transfer file (pain.001.001.03) for an approved run: one transfer from the chosen bank account to each employee's IBAN for the line's net when it is positive, with a remittance text in `locale` (default the locale of the calling user) and the run period, executed on `executionDate` (default the company's current date). Answers 409 when the run is not approved, and 422 when the bank account has no IBAN or is not in the company's base currency, an employee has no IBAN (`hr/employees/update`) or no line has a positive net. The file is returned in `xml`; nothing is sent to the bank.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.PaymentsExportAsync(
    new PaymentsExportPayrollRequest { RunId = "runId", BankAccountId = "bankAccountId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PaymentsExportPayrollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## agreements
<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">SettingsGetAsync</a>(SettingsGetAgreementsRequest { ... }) -> WithRawResponseTask&lt;SettingsGetAgreementsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return whether automatic agreement billing is switched on for the company.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.SettingsGetAsync(new SettingsGetAgreementsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettingsGetAgreementsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">SettingsUpdateAsync</a>(SettingsUpdateAgreementsRequest { ... }) -> WithRawResponseTask&lt;SettingsUpdateAgreementsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Switch automatic agreement billing on or off for the company. With it on, a scheduled job runs the same billing as `agreements/agreements/billing/run` for the company once a day.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.SettingsUpdateAsync(
    new SettingsUpdateAgreementsRequest { AutoBilling = true }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettingsUpdateAgreementsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">TypesCreateAsync</a>(TypesCreateAgreementsRequest { ... }) -> WithRawResponseTask&lt;TypesCreateAgreementsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create an agreement type with a `code` and a `name`. Answers 409 when the company already has a type with that code.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.TypesCreateAsync(
    new TypesCreateAgreementsRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TypesCreateAgreementsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">TypesListAsync</a>(TypesListAgreementsRequest { ... }) -> WithRawResponseTask&lt;TypesListAgreementsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the company's agreement types. Filterable and sortable by `code` and `name`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.TypesListAsync(new TypesListAgreementsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TypesListAgreementsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">AgreementsCreateAsync</a>(AgreementsCreateAgreementsRequest { ... }) -> WithRawResponseTask&lt;AgreementsCreateAgreementsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create an agreement for exactly one party, a partner, an employee or a bank account, which must exist in the company (400 otherwise). Without `kind`, an employee agreement is `employment`, a bank account agreement is `bank` and a partner agreement is `other`; a `documentRef` (the `storageKey` of an uploaded file) attaches that file to the agreement. Answers 409 when the company already has an agreement with that `number`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.AgreementsCreateAsync(
    new AgreementsCreateAgreementsRequest
    {
        Number = "number",
        StartDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AgreementsCreateAgreementsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">AgreementsGetAsync</a>(AgreementsGetAgreementsRequest { ... }) -> WithRawResponseTask&lt;AgreementsGetAgreementsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one agreement with its items.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.AgreementsGetAsync(new AgreementsGetAgreementsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AgreementsGetAgreementsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">AgreementsUpdateAsync</a>(AgreementsUpdateAgreementsRequest { ... }) -> WithRawResponseTask&lt;AgreementsUpdateAgreementsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change the given fields of an agreement and return it with its items. The party, `number`, `startDate`, `currency` and items are not changed by this call.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.AgreementsUpdateAsync(new AgreementsUpdateAgreementsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AgreementsUpdateAgreementsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">AgreementsDeleteAsync</a>(AgreementsDeleteAgreementsRequest { ... }) -> WithRawResponseTask&lt;AgreementsDeleteAgreementsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Mark an agreement as deleted. It is no longer returned, changed or billed.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.AgreementsDeleteAsync(new AgreementsDeleteAgreementsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AgreementsDeleteAgreementsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">AgreementsListAsync</a>(AgreementsListAgreementsRequest { ... }) -> WithRawResponseTask&lt;AgreementsListAgreementsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the company's agreements without their items, each with `partnerName`. Filterable by `number`, `name`, `partnerId`, `employeeId`, `bankAccountId`, `kind`, `typeId`, `status`, `startDate`, `endDate` and `value`; sortable by `number`, `startDate` and `createdAt` (default `startDate` descending).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.AgreementsListAsync(new AgreementsListAgreementsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AgreementsListAgreementsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">AgreementsGenerateInvoiceAsync</a>(AgreementsGenerateInvoiceAgreementsRequest { ... }) -> WithRawResponseTask&lt;AgreementsGenerateInvoiceAgreementsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a draft sale invoice for the next unbilled period of an active agreement that has a partner and a `billingPeriod`. The period follows the monthly, quarterly or annual grid from `startDate`, continues after the last period already invoiced for the agreement, and is prorated by days when it starts late or is cut by `endDate`; an `autoRenew` agreement has its `endDate` moved forward by whole terms instead (`renewedEndDate`). The lines come from the agreement items, else one line of `value`, with revenue recognised ratably over the period. Answers 422 when the agreement is not active, has no partner, billing period, items or value, carries VAT while the company is not a VAT payer, is fully billed through its end date, or when the next period starts after `asOfDate` (default today). Emits `agreement.invoice_generated`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.AgreementsGenerateInvoiceAsync(
    new AgreementsGenerateInvoiceAgreementsRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AgreementsGenerateInvoiceAgreementsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">AgreementsBillingRunAsync</a>(AgreementsBillingRunAgreementsRequest { ... }) -> WithRawResponseTask&lt;AgreementsBillingRunAgreementsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Generate the invoices due up to `asOfDate` (default today) for every active agreement of the company that has a partner and a billing period, one invoice per period and at most 60 per agreement in one run, in the same way as `agreements/agreements/generate-invoice`. An agreement that is fully billed and whose `endDate` has passed is set to `expired`. A failing agreement is listed in `errors` and does not stop the run. Each invoice emits `agreement.invoice_generated`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.AgreementsBillingRunAsync(new AgreementsBillingRunAgreementsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AgreementsBillingRunAgreementsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">InsurancePoliciesCreateAsync</a>(InsurancePoliciesCreateAgreementsRequest { ... }) -> WithRawResponseTask&lt;InsurancePoliciesCreateAgreementsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create an insurance policy. Answers 422 when `toDate` is before `fromDate`, 400 when `insurerPartnerId` is not a partner of the company, and 409 when the company already has a policy with that `policyNumber`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.InsurancePoliciesCreateAsync(
    new InsurancePoliciesCreateAgreementsRequest
    {
        PolicyNumber = "policyNumber",
        InsuredObject = "insuredObject",
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InsurancePoliciesCreateAgreementsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">InsurancePoliciesListAsync</a>(InsurancePoliciesListAgreementsRequest { ... }) -> WithRawResponseTask&lt;InsurancePoliciesListAgreementsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the company's insurance policies. Filterable by `policyNumber`, `insurerPartnerId` and `toDate`; sortable by `policyNumber` and `toDate` (default `toDate` descending).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.InsurancePoliciesListAsync(new InsurancePoliciesListAgreementsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InsurancePoliciesListAgreementsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">InsurancePoliciesDeleteAsync</a>(InsurancePoliciesDeleteAgreementsRequest { ... }) -> WithRawResponseTask&lt;InsurancePoliciesDeleteAgreementsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Mark an insurance policy as deleted.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.InsurancePoliciesDeleteAsync(
    new InsurancePoliciesDeleteAgreementsRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InsurancePoliciesDeleteAgreementsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## inventory
<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">SettingsGetAsync</a>(SettingsGetInventoryRequest { ... }) -> WithRawResponseTask&lt;SettingsGetInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the company's negative stock policy.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.SettingsGetAsync(new SettingsGetInventoryRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettingsGetInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">SettingsUpdateAsync</a>(SettingsUpdateInventoryRequest { ... }) -> WithRawResponseTask&lt;SettingsUpdateInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Set the negative stock policy. With `reject` a consumption larger than the stock on hand of the item in the warehouse is refused with 422. With `allow` the missing quantity is written as a shortage priced at the unit cost of the last receipt in that warehouse (the item's purchase price when there is none); the next receipt of the item there settles the shortage and posts any cost difference between `inventory.cogs` and `inventory.stock`. A consumption from a named lot is refused with 422 under both policies.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.SettingsUpdateAsync(
    new SettingsUpdateInventoryRequest
    {
        NegativeStockPolicy = SettingsUpdateInventoryRequestNegativeStockPolicy.Reject,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettingsUpdateInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">WarehousesCreateAsync</a>(WarehousesCreateInventoryRequest { ... }) -> WithRawResponseTask&lt;WarehousesCreateInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a warehouse. 409 when the code already exists.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.WarehousesCreateAsync(
    new WarehousesCreateInventoryRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WarehousesCreateInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">WarehousesListAsync</a>(WarehousesListInventoryRequest { ... }) -> WithRawResponseTask&lt;WarehousesListInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the warehouses. Filterable and sortable: code, name.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.WarehousesListAsync(new WarehousesListInventoryRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WarehousesListInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">WarehousesUpdateAsync</a>(WarehousesUpdateInventoryRequest { ... }) -> WithRawResponseTask&lt;WarehousesUpdateInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change the name or the country code of a warehouse.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.WarehousesUpdateAsync(new WarehousesUpdateInventoryRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WarehousesUpdateInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">StockReceiveAsync</a>(StockReceiveInventoryRequest { ... }) -> WithRawResponseTask&lt;StockReceiveInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Record a manual receipt of an item into a warehouse at `unitCost` (document type `manual_receipt`); the quantity must be positive (422). A lot- or serial-tracked item needs `lotNumber` (422); an unknown lot is created, and `expiryDate` is stored on a lot that has none. A serial-tracked item is received one unit at a time (422), and 409 when that serial number is already in stock. Open shortages of the item in the warehouse (negative stock policy `allow`) are settled from the receipt. Emits `stock.changed`. Receipts against a purchase order go through `purchases/receipts/create`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.StockReceiveAsync(
    new StockReceiveInventoryRequest
    {
        WarehouseId = "warehouseId",
        ItemId = "itemId",
        Date = new DateOnly(2026, 7, 1),
        Quantity = "121.0000",
        UnitCost = "121.000000",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StockReceiveInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">StockWriteOffAsync</a>(StockWriteOffInventoryRequest { ... }) -> WithRawResponseTask&lt;StockWriteOffInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Consume a quantity of an item from a warehouse, oldest layers first (from one lot when `lotNumber` is given), and post a journal entry: debit the expense account (`expenseAccountCode`, default the chart's inventory expense account), credit the stock account each consumed layer was received on (the chart's inventory account for layers without one), or `inventoryAccountCode` for the whole cost when given. 409 when the accounting period of `date` is locked; 422 when the stock is insufficient under the `reject` policy or in the named lot. Emits `stock.changed` and, when the consumption takes the available quantity from above a reorder rule's minimum to at or below it, `stock.reorder_needed`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.StockWriteOffAsync(
    new StockWriteOffInventoryRequest
    {
        WarehouseId = "warehouseId",
        ItemId = "itemId",
        Date = new DateOnly(2026, 7, 1),
        Quantity = "121.0000",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StockWriteOffInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">StockTransferAsync</a>(StockTransferInventoryRequest { ... }) -> WithRawResponseTask&lt;StockTransferInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Move a quantity of an item from one warehouse to another: the source layers are consumed oldest first (from one lot when `lotNumber` is given) and received in the target with the same quantities, costs, lots and stock accounts (document type `warehouse_transfer`). 422 when both warehouses are the same or the source stock is insufficient under the `reject` policy. `inMovementId` is the first receipt when the consumption spans several lots or stock accounts. Emits `stock.changed` for both warehouses and `stock.reorder_needed` as `inventory/stock/write-off` does.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.StockTransferAsync(
    new StockTransferInventoryRequest
    {
        FromWarehouseId = "fromWarehouseId",
        ToWarehouseId = "toWarehouseId",
        ItemId = "itemId",
        Date = new DateOnly(2026, 7, 1),
        Quantity = "121.0000",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StockTransferInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">StockTakeAsync</a>(StockTakeInventoryRequest { ... }) -> WithRawResponseTask&lt;StockTakeInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Post a stock count for a warehouse. Each line names an item by `itemId` or `barcode` with its `countedQty`; the difference to the quantity on hand in the warehouse (all lots together) is written off oldest layers first or received as a surplus at `unitCost` (the item's purchase price when omitted; 422 when neither is set), with document type `stock_take`, and a surplus of a lot- or serial-tracked item needs `lotNumber` (422). The shortage cost less the surplus cost is posted in one journal entry between the expense account (`expenseAccountCode`, default the chart's inventory expense account) and the stock accounts (`inventoryAccountCode` for everything when given, else the accounts of the consumed layers and the chart's inventory account for the surpluses); nothing is posted and `journalTransactionId` is null when the net is zero. 409 when the accounting period of `date` is locked. Emits `stock.changed` per adjusted item.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.StockTakeAsync(
    new StockTakeInventoryRequest
    {
        WarehouseId = "warehouseId",
        Date = new DateOnly(2026, 7, 1),
        Lines = new List<StockTakeInventoryRequestLinesItem>()
        {
            new StockTakeInventoryRequestLinesItem { CountedQty = "121.0000" },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StockTakeInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">StockLevelsAsync</a>(StockLevelsInventoryRequest { ... }) -> WithRawResponseTask&lt;StockLevelsInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the quantity and value on hand per item and warehouse, summed from the stock movements, optionally for one `warehouseId` and/or `itemId`. Rows with a zero quantity are left out.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.StockLevelsAsync(new StockLevelsInventoryRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StockLevelsInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">StockMovementsListAsync</a>(StockMovementsListInventoryRequest { ... }) -> WithRawResponseTask&lt;StockMovementsListInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the stock movements. Filterable: itemId, warehouseId, lotId, direction, documentType, date, quantity, totalCost. Sortable: date, createdAt, quantity, totalCost; default newest first.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.StockMovementsListAsync(new StockMovementsListInventoryRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StockMovementsListInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">LotsListAsync</a>(LotsListInventoryRequest { ... }) -> WithRawResponseTask&lt;LotsListInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the lots with their quantity on hand (the remaining quantity of the lot's incoming movements). Filterable: itemId, lotNumber, expiryDate. Sortable: lotNumber, expiryDate, createdAt; default newest first.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.LotsListAsync(new LotsListInventoryRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LotsListInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">LotsGetAsync</a>(LotsGetInventoryRequest { ... }) -> WithRawResponseTask&lt;LotsGetInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return a lot with its quantity on hand and its movements in date order.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.LotsGetAsync(new LotsGetInventoryRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LotsGetInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">LotsUpdateAsync</a>(LotsUpdateInventoryRequest { ... }) -> WithRawResponseTask&lt;LotsUpdateInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change the expiry date or the notes of a lot; null clears the value.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.LotsUpdateAsync(new LotsUpdateInventoryRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LotsUpdateInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">LandedCostsCreateAsync</a>(LandedCostsCreateInventoryRequest { ... }) -> WithRawResponseTask&lt;LandedCostsCreateInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Allocate an extra cost `amount` (positive, whole cents; 422 otherwise) over incoming stock movements, named by `movementIds` or taken from the lines of a goods receipt (`goodsReceiptId`; 422 when the receipt has no stock movements), in proportion to their cost (`by_value`) or quantity (`by_quantity`), largest remainder to the cent. The part of each share that belongs to the quantity still on hand raises the movement's remaining cost and recomputes its unit cost; the part that belongs to quantity already consumed is posted in a journal entry dated `date` debiting `inventory.cogs` and crediting the movement's stock account (`inventory.stock` when it has none), 409 when that period is locked. 422 when a movement is not incoming or the weights sum to zero. `sourceInvoiceId` records the purchase invoice the cost came from. Goods receipts come from `purchases/receipts/create`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.LandedCostsCreateAsync(
    new LandedCostsCreateInventoryRequest { Date = new DateOnly(2026, 7, 1), Amount = "121.000000" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LandedCostsCreateInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">LandedCostsGetAsync</a>(LandedCostsGetInventoryRequest { ... }) -> WithRawResponseTask&lt;LandedCostsGetInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return a landed cost with its allocation lines and the journal transaction it posted, if any.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.LandedCostsGetAsync(new LandedCostsGetInventoryRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LandedCostsGetInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">LandedCostsListAsync</a>(LandedCostsListInventoryRequest { ... }) -> WithRawResponseTask&lt;LandedCostsListInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the landed costs without their lines. Filterable: date, method, goodsReceiptId, sourceInvoiceId. Sortable: date, createdAt, amount; default newest first.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.LandedCostsListAsync(new LandedCostsListInventoryRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LandedCostsListInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">ReorderRulesCreateAsync</a>(ReorderRulesCreateInventoryRequest { ... }) -> WithRawResponseTask&lt;ReorderRulesCreateInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a reorder rule for an item, for one warehouse or, without `warehouseId`, for the item over all warehouses; one rule per item and warehouse (409). While the rule is active, an outgoing movement or a reservation that takes the available quantity (on hand less reserved) from above `minQty` to at or below it emits `stock.reorder_needed` with the `reorderQty`. `inventory/reorder-rules/check` lists the rules currently at or below their minimum.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.ReorderRulesCreateAsync(
    new ReorderRulesCreateInventoryRequest { ItemId = "itemId", MinQty = "121.0000" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReorderRulesCreateInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">ReorderRulesUpdateAsync</a>(ReorderRulesUpdateInventoryRequest { ... }) -> WithRawResponseTask&lt;ReorderRulesUpdateInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change the minimum quantity, the reorder quantity (null clears it), the active flag or the notes of a reorder rule.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.ReorderRulesUpdateAsync(
    new ReorderRulesUpdateInventoryRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReorderRulesUpdateInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">ReorderRulesDeleteAsync</a>(ReorderRulesDeleteInventoryRequest { ... }) -> WithRawResponseTask&lt;ReorderRulesDeleteInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a reorder rule.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.ReorderRulesDeleteAsync(
    new ReorderRulesDeleteInventoryRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReorderRulesDeleteInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">ReorderRulesListAsync</a>(ReorderRulesListInventoryRequest { ... }) -> WithRawResponseTask&lt;ReorderRulesListInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the reorder rules. Filterable: itemId, warehouseId, isActive. Sortable: createdAt, minQty; default newest first.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.ReorderRulesListAsync(new ReorderRulesListInventoryRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReorderRulesListInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">ReorderRulesCheckAsync</a>(ReorderRulesCheckInventoryRequest { ... }) -> WithRawResponseTask&lt;ReorderRulesCheckInventoryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the active reorder rules whose available quantity (on hand less reserved, in the rule's warehouse or over all warehouses) is at or below `minQty`, with the quantities. Emits no event.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.ReorderRulesCheckAsync(new ReorderRulesCheckInventoryRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReorderRulesCheckInventoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## production
<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">WorkCentersCreateAsync</a>(WorkCentersCreateProductionRequest { ... }) -> WithRawResponseTask&lt;WorkCentersCreateProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a work center with its `costPerHour`. `costAccountCode` must be a postable account of the chart (422 otherwise); when a production order completes, the labor cost of the operations run on this center is credited to it instead of the `production.laborApplied` posting rule account. A duplicate `code` is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.WorkCentersCreateAsync(
    new WorkCentersCreateProductionRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WorkCentersCreateProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">WorkCentersUpdateAsync</a>(WorkCentersUpdateProductionRequest { ... }) -> WithRawResponseTask&lt;WorkCentersUpdateProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change a work center; only the fields sent are changed. `costAccountCode` must be a postable account of the chart (422 otherwise); a `code` already used by another work center is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.WorkCentersUpdateAsync(
    new WorkCentersUpdateProductionRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WorkCentersUpdateProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">WorkCentersListAsync</a>(WorkCentersListProductionRequest { ... }) -> WithRawResponseTask&lt;WorkCentersListProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List work centers. `nextMaintenanceDate` is the latest completed maintenance date (the creation date when there is none) plus `maintenanceIntervalDays`, null without an interval. Filterable by `code`, `name` and `isActive`; sortable by `code`, `name` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.WorkCentersListAsync(new WorkCentersListProductionRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WorkCentersListProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">RoutingsCreateAsync</a>(RoutingsCreateProductionRequest { ... }) -> WithRawResponseTask&lt;RoutingsCreateProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a routing with its operations: `sequence`, work center, `setupMinutes`, `runMinutesPerUnit` and an optional `qualityCheckName` that becomes a pending quality check on every production order using the routing. Operation sequences must be unique (422); a duplicate `code` is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.RoutingsCreateAsync(
    new RoutingsCreateProductionRequest
    {
        Code = "code",
        Name = "name",
        Operations = new List<RoutingsCreateProductionRequestOperationsItem>()
        {
            new RoutingsCreateProductionRequestOperationsItem
            {
                Sequence = 1000000,
                Name = "name",
                WorkCenterId = "workCenterId",
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RoutingsCreateProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">RoutingsGetAsync</a>(RoutingsGetProductionRequest { ... }) -> WithRawResponseTask&lt;RoutingsGetProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one routing with its operations in sequence order.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.RoutingsGetAsync(new RoutingsGetProductionRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RoutingsGetProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">RoutingsListAsync</a>(RoutingsListProductionRequest { ... }) -> WithRawResponseTask&lt;RoutingsListProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List routings without their operations. Filterable by `code`, `name` and `isActive`; sortable by `code`, `name` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.RoutingsListAsync(new RoutingsListProductionRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RoutingsListProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">MaintenanceCreateAsync</a>(MaintenanceCreateProductionRequest { ... }) -> WithRawResponseTask&lt;MaintenanceCreateProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Record a `preventive` or `corrective` maintenance planned for a work center on `plannedDate`; it starts as `planned`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.MaintenanceCreateAsync(
    new MaintenanceCreateProductionRequest
    {
        WorkCenterId = "workCenterId",
        Type = MaintenanceCreateProductionRequestType.Preventive,
        PlannedDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MaintenanceCreateProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">MaintenanceCompleteAsync</a>(MaintenanceCompleteProductionRequest { ... }) -> WithRawResponseTask&lt;MaintenanceCompleteProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Mark a `planned` maintenance as completed on `completedDate`, with optional `downtimeHours` and `cost` (409 when it is already completed or cancelled). The work center's `nextMaintenanceDate` is then counted from the latest completed maintenance date.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.MaintenanceCompleteAsync(
    new MaintenanceCompleteProductionRequest { Id = "id", CompletedDate = new DateOnly(2026, 7, 1) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MaintenanceCompleteProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">MaintenanceCancelAsync</a>(MaintenanceCancelProductionRequest { ... }) -> WithRawResponseTask&lt;MaintenanceCancelProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Cancel a `planned` maintenance (409 when it is already completed or cancelled).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.MaintenanceCancelAsync(
    new MaintenanceCancelProductionRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MaintenanceCancelProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">MaintenanceListAsync</a>(MaintenanceListProductionRequest { ... }) -> WithRawResponseTask&lt;MaintenanceListProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List maintenance records. Filterable by `workCenterId`, `status` and `type`; sortable by `plannedDate` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.MaintenanceListAsync(new MaintenanceListProductionRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MaintenanceListProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">BomsCreateAsync</a>(BomsCreateProductionRequest { ... }) -> WithRawResponseTask&lt;BomsCreateProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a bill of materials for a finished item. `outputQuantity` is the finished quantity made per unit of order quantity; each line's `quantity` is the component consumed per unit of order quantity, increased by its `scrapPercent` at completion; `routingId` is the default routing of assembly orders. A BOM that consumes its own finished item is refused with 422, a duplicate `code` with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.BomsCreateAsync(
    new BomsCreateProductionRequest
    {
        Code = "code",
        Name = "name",
        FinishedItemId = "finishedItemId",
        Lines = new List<BomsCreateProductionRequestLinesItem>()
        {
            new BomsCreateProductionRequestLinesItem
            {
                ComponentItemId = "componentItemId",
                Quantity = "121.0000",
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BomsCreateProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">BomsGetAsync</a>(BomsGetProductionRequest { ... }) -> WithRawResponseTask&lt;BomsGetProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one bill of materials with its component lines.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.BomsGetAsync(new BomsGetProductionRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BomsGetProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">BomsListAsync</a>(BomsListProductionRequest { ... }) -> WithRawResponseTask&lt;BomsListProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List bills of materials without their lines. Filterable by `code`, `name`, `finishedItemId` and `isActive`; sortable by `code` and `name`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.BomsListAsync(new BomsListProductionRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BomsListProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">OrdersCreateAsync</a>(OrdersCreateProductionRequest { ... }) -> WithRawResponseTask&lt;OrdersCreateProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a draft production order for `quantity` units of a BOM in a warehouse; stock moves only at `production/orders/complete`. An `assembly` order takes its routing from `routingId`, else from the BOM, and copies the routing's operations onto the order (`plannedMinutes` = setup minutes + run minutes per unit × finished quantity, priced at the work center's current `costPerHour`) with a pending quality check for every operation that names one. A `routingId` on a `disassembly` order, an inactive routing or a routing without operations is refused with 422.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.OrdersCreateAsync(
    new OrdersCreateProductionRequest
    {
        BomId = "bomId",
        WarehouseId = "warehouseId",
        Quantity = "121.0000",
        Date = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersCreateProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">OrdersRecordOperationAsync</a>(OrdersRecordOperationProductionRequest { ... }) -> WithRawResponseTask&lt;OrdersRecordOperationProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Record the `actualMinutes` spent on one operation of a draft production order; at completion the actual minutes, else the planned ones, price the operation's labor cost. Refused with 409 once the order is completed.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.OrdersRecordOperationAsync(
    new OrdersRecordOperationProductionRequest { Id = "id", ActualMinutes = "121.00" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersRecordOperationProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">QualityChecksAddAsync</a>(QualityChecksAddProductionRequest { ... }) -> WithRawResponseTask&lt;QualityChecksAddProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a pending quality check to a draft production order (409 once the order is completed). The order cannot complete while a check is pending.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.QualityChecksAddAsync(
    new QualityChecksAddProductionRequest { OrderId = "orderId", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `QualityChecksAddProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">QualityChecksRecordAsync</a>(QualityChecksRecordProductionRequest { ... }) -> WithRawResponseTask&lt;QualityChecksRecordProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Record the result of a quality check as `passed` or `failed`, with the time and the actor (409 once the order is completed). Only a `pending` check blocks `production/orders/complete`; a `failed` one does not.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.QualityChecksRecordAsync(
    new QualityChecksRecordProductionRequest
    {
        Id = "id",
        Result = QualityChecksRecordProductionRequestResult.Passed,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `QualityChecksRecordProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">QualityChecksListAsync</a>(QualityChecksListProductionRequest { ... }) -> WithRawResponseTask&lt;QualityChecksListProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List quality checks. Filterable by `orderId`, `result` and `name`; sortable by `createdAt` and `name`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.QualityChecksListAsync(new QualityChecksListProductionRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `QualityChecksListProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">OrdersCompleteAsync</a>(OrdersCompleteProductionRequest { ... }) -> WithRawResponseTask&lt;OrdersCompleteProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Complete a draft production order on the order's date. An `assembly` consumes the components FIFO from the warehouse (line quantity × order quantity, increased by `scrapPercent`), prices each operation at its actual or planned minutes × `costPerHour`, receives the finished item at material cost + labor cost less the share of `scrappedQuantity`, and, when there is labor, scrap or a component stock account other than the finished one, posts a journal entry debiting the finished stock account (and the `production.scrap` rule account for the scrapped share) and crediting the component stock accounts and the work centers' cost accounts (or the `production.laborApplied` rule account); a `disassembly` consumes the finished item and receives the components at its cost shared by quantity. `componentsAccountCode` and `finishedAccountCode` default to the chart's production accounts. Refused with 409 when the order is already completed, a quality check is still pending or the accounting period is locked, and with 422 when the BOM has no lines, `scrappedQuantity` is given on a disassembly or exceeds the finished quantity, the assembly cost is zero, stock is insufficient, a received item needs lot or serial tracking, or a posting account is missing. Emits `stock.changed`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.OrdersCompleteAsync(new OrdersCompleteProductionRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersCompleteProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">OrdersGetAsync</a>(OrdersGetProductionRequest { ... }) -> WithRawResponseTask&lt;OrdersGetProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one production order with its operations and quality checks.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.OrdersGetAsync(new OrdersGetProductionRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersGetProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">OrdersListAsync</a>(OrdersListProductionRequest { ... }) -> WithRawResponseTask&lt;OrdersListProductionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List production orders without operations and quality checks. Filterable by `bomId`, `warehouseId`, `status` and `type`; sortable by `date` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.OrdersListAsync(new OrdersListProductionRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersListProductionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ecommerce
<details><summary><code>client.Ecommerce.<a href="/src/NordletApi/Ecommerce/EcommerceClient.cs">OrdersCreateAsync</a>(OrdersCreateEcommerceRequest { ... }) -> WithRawResponseTask&lt;OrdersCreateEcommerceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a sales order from an online channel in status `new`. The customer is `partnerId` or `partner` details: with an `email` the existing partner with that e-mail is reused, otherwise a new partner is created; without either the call is refused with 422. `currency` defaults to the company's invoice currency, and `shipToCountryCode` and `marketplace` are kept for the VAT treatment of the invoice at fulfilment. A second order with the same `channel` and `externalRef` is refused with 409. Emits `sales_order.created`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.OrdersCreateAsync(
    new OrdersCreateEcommerceRequest
    {
        Lines = new List<OrdersCreateEcommerceRequestLinesItem>()
        {
            new OrdersCreateEcommerceRequestLinesItem
            {
                Description = "description",
                Quantity = "121.0000",
                UnitPriceExclVat = "121.0000",
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersCreateEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/NordletApi/Ecommerce/EcommerceClient.cs">OrdersGetAsync</a>(OrdersGetEcommerceRequest { ... }) -> WithRawResponseTask&lt;OrdersGetEcommerceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read one sales order with its lines.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.OrdersGetAsync(new OrdersGetEcommerceRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersGetEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/NordletApi/Ecommerce/EcommerceClient.cs">OrdersListAsync</a>(OrdersListEcommerceRequest { ... }) -> WithRawResponseTask&lt;OrdersListEcommerceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List sales orders without their lines. Filterable by `channel`, `externalRef`, `partnerId` and `status`; sortable by `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.OrdersListAsync(new OrdersListEcommerceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersListEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/NordletApi/Ecommerce/EcommerceClient.cs">OrdersReserveAsync</a>(OrdersReserveEcommerceRequest { ... }) -> WithRawResponseTask&lt;OrdersReserveEcommerceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Reserve stock for a `new` order in `warehouseId` (default: the order's warehouse; 422 when neither is set). Each product line, and each product component of a set line, is checked against the warehouse's on-hand quantity less the existing reservations; when any item is short the call is refused with 422 and nothing is reserved. Otherwise a reservation is written per stock line, `stock.changed` (change type `reserve`) is emitted for each, and the order becomes `reserved`. An order in another status is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.OrdersReserveAsync(new OrdersReserveEcommerceRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersReserveEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/NordletApi/Ecommerce/EcommerceClient.cs">OrdersFulfillAsync</a>(OrdersFulfillEcommerceRequest { ... }) -> WithRawResponseTask&lt;OrdersFulfillEcommerceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Fulfil a `new` or `reserved` order: its reservations are released, the stock lines are consumed FIFO from the order's warehouse on `date` (default: the company's today), the cost of goods sold is posted as a journal entry debiting `cogsAccountCode` and crediting the stock accounts of the consumed layers (`inventoryAccountCode` when a layer has none), and a draft sale invoice for the order lines is created and linked as `invoiceId`, ready for `sales/invoices/issue`. With a `shipToCountryCode` on the order the invoice's VAT scheme is resolved for goods shipped there, as a marketplace sale when `marketplace` is set. Account codes default to the company's chart. Refused with 422 when the stock lines have no warehouse or stock is insufficient (unless the company allows negative stock), with 409 when the accounting period is locked or the order is already `fulfilled` or `cancelled`. Emits `sales_order.fulfilled` and `stock.changed`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.OrdersFulfillAsync(new OrdersFulfillEcommerceRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersFulfillEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/NordletApi/Ecommerce/EcommerceClient.cs">OrdersCancelAsync</a>(OrdersCancelEcommerceRequest { ... }) -> WithRawResponseTask&lt;OrdersCancelEcommerceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Cancel an order that is not fulfilled: its stock reservations are released, `stock.changed` (change type `release`) is emitted for each, and the status becomes `cancelled`. A fulfilled order is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.OrdersCancelAsync(new OrdersCancelEcommerceRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersCancelEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/NordletApi/Ecommerce/EcommerceClient.cs">ProductsListAsync</a>(ProductsListEcommerceRequest { ... }) -> WithRawResponseTask&lt;ProductsListEcommerceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the company's items as a shop catalogue, in order of last update, with price and stock. `price` is the item's price in `priceListId` when given, else its own sale price, and `currency` that of the price list, else the company's invoice currency; `vatRatePercent` falls back to the rate of the item's VAT classifier. For a product `onHand`, `reserved` and `available` are summed over all warehouses or over `warehouseId` only; for a set `available` is the number of sets its product components can still make; for a service they are null. With `updatedSince` only items changed after that time are returned, deleted ones included (`deleted: true`), so a shop can sync incrementally; without it only live items are listed.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.ProductsListAsync(new ProductsListEcommerceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ProductsListEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/NordletApi/Ecommerce/EcommerceClient.cs">StockListAsync</a>(StockListEcommerceRequest { ... }) -> WithRawResponseTask&lt;StockListEcommerceResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Stock position per item and warehouse: `onHand`, `reserved` and their difference `available`, for all warehouses or `warehouseId` only. Only items with a positive quantity on hand are returned.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.StockListAsync(new StockListEcommerceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StockListEcommerceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## cash
<details><summary><code>client.Cash.<a href="/src/NordletApi/Cash/CashClient.cs">OrdersCreateAsync</a>(OrdersCreateCashRequest { ... }) -> WithRawResponseTask&lt;OrdersCreateCashResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a numbered cash receipt (series `KPO`) or cash disbursement (`KIO`) and posts it in the base currency between the cash account (`cashAccountCode`, default the cash account of the company's chart) and `counterAccountCode`; a receipt debits the cash account, a disbursement credits it. Linked to an invoice - `saleInvoiceId` for a receipt against an issued invoice or advance invoice or a disbursement against an issued credit note, `purchaseInvoiceId` for a disbursement against a registered purchase invoice - the counter account is the receivable or payable account of the posting rules, the invoice's paid amount and payment status (`partial` or `paid`) are updated, and `sale_invoice.paid` or `purchase_invoice.paid` is emitted when the invoice becomes fully paid. Answers 422 when both invoice ids are given, a receipt names a purchase invoice, `counterAccountCode` differs from the invoice's account, or the invoice is in another currency or belongs to another partner; 409 when `amount` exceeds the invoice's remaining amount or the accounting period of `date` is locked.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Cash.OrdersCreateAsync(
    new OrdersCreateCashRequest
    {
        Type = OrdersCreateCashRequestType.Receipt,
        Date = new DateOnly(2026, 7, 1),
        Amount = "121.0000",
        Purpose = "purpose",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersCreateCashRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Cash.<a href="/src/NordletApi/Cash/CashClient.cs">OrdersGetAsync</a>(OrdersGetCashRequest { ... }) -> WithRawResponseTask&lt;OrdersGetCashResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns one cash order.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Cash.OrdersGetAsync(new OrdersGetCashRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersGetCashRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Cash.<a href="/src/NordletApi/Cash/CashClient.cs">OrdersListAsync</a>(OrdersListCashRequest { ... }) -> WithRawResponseTask&lt;OrdersListCashResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists cash orders. Filterable by `type`, `date`, `partnerId`, `employeeId`, `fullNumber` and `amount`; sortable by `date`, `fullNumber`, `createdAt` and `amount`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Cash.OrdersListAsync(new OrdersListCashRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrdersListCashRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Cash.<a href="/src/NordletApi/Cash/CashClient.cs">BalanceAsync</a>(BalanceCashRequest { ... }) -> WithRawResponseTask&lt;BalanceCashResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the balance of a cash account (default: the cash account of the company's chart) from the posted journal entries, up to and including `asOf` when given.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Cash.BalanceAsync(new BalanceCashRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BalanceCashRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Cash.<a href="/src/NordletApi/Cash/CashClient.cs">ExpenseReportsCreateAsync</a>(ExpenseReportsCreateCashRequest { ... }) -> WithRawResponseTask&lt;ExpenseReportsCreateCashResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a numbered expense report (series `AA`) for the employee and posts it: each line's net amount is debited to its `accountCode` and the VAT total to the input VAT account of the posting rules (`purchases.vatReceivable`), or the gross amount to the line account when the company is not a VAT payer, and the total is credited to the cash advances account (`cash.advances`), which settles the employee's advance balance shown by `cash/advance-holders/balances`. Answers 422 when the total is zero or a line account is missing from the chart or not postable, and 409 when the accounting period of `date` is locked.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Cash.ExpenseReportsCreateAsync(
    new ExpenseReportsCreateCashRequest
    {
        EmployeeId = "employeeId",
        Date = new DateOnly(2026, 7, 1),
        Lines = new List<ExpenseReportsCreateCashRequestLinesItem>()
        {
            new ExpenseReportsCreateCashRequestLinesItem
            {
                Description = "description",
                AccountCode = "accountCode",
                NetAmount = "121.00",
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ExpenseReportsCreateCashRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Cash.<a href="/src/NordletApi/Cash/CashClient.cs">ExpenseReportsGetAsync</a>(ExpenseReportsGetCashRequest { ... }) -> WithRawResponseTask&lt;ExpenseReportsGetCashResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns one expense report with its lines.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Cash.ExpenseReportsGetAsync(new ExpenseReportsGetCashRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ExpenseReportsGetCashRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Cash.<a href="/src/NordletApi/Cash/CashClient.cs">ExpenseReportsListAsync</a>(ExpenseReportsListCashRequest { ... }) -> WithRawResponseTask&lt;ExpenseReportsListCashResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists expense reports without their lines. Filterable by `employeeId` and `date`; sortable by `date` and `number`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Cash.ExpenseReportsListAsync(new ExpenseReportsListCashRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ExpenseReportsListCashRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Cash.<a href="/src/NordletApi/Cash/CashClient.cs">AdvanceHoldersBalancesAsync</a>(AdvanceHoldersBalancesCashRequest { ... }) -> WithRawResponseTask&lt;AdvanceHoldersBalancesCashResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns, per employee, the cash advances issued to them (disbursements posted to the `cash.advances` account with the employee set), the amounts returned (receipts on the same account), the total settled by expense reports and the open balance (issued less returned less settled).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Cash.AdvanceHoldersBalancesAsync(new AdvanceHoldersBalancesCashRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AdvanceHoldersBalancesCashRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## projects
<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">CreateAsync</a>(CreateProjectsRequest { ... }) -> WithRawResponseTask&lt;CreateProjectsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a project; `partnerId` is the customer that `projects/time-entries/bill` invoices by default. A duplicate `code` is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.CreateAsync(new CreateProjectsRequest { Code = "code", Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateProjectsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">UpdateAsync</a>(UpdateProjectsRequest { ... }) -> WithRawResponseTask&lt;UpdateProjectsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change a project's name, customer, `status` (`active`, `completed`, `archived`) or notes; only the fields sent are changed. An archived project accepts no new time entries.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.UpdateAsync(new UpdateProjectsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateProjectsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">GetAsync</a>(GetProjectsRequest { ... }) -> WithRawResponseTask&lt;GetProjectsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one project.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.GetAsync(new GetProjectsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetProjectsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">ListAsync</a>(ListProjectsRequest { ... }) -> WithRawResponseTask&lt;ListProjectsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List projects. Filterable by `code`, `name`, `status` and `partnerId`; sortable by `code`, `name` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.ListAsync(new ListProjectsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListProjectsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">TimeEntriesCreateAsync</a>(TimeEntriesCreateProjectsRequest { ... }) -> WithRawResponseTask&lt;TimeEntriesCreateProjectsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Record hours worked on a project on a date, optionally for an employee and with the `hourlyRate` used when billing. `hours` must be positive (422); an archived project is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.TimeEntriesCreateAsync(
    new TimeEntriesCreateProjectsRequest
    {
        ProjectId = "projectId",
        Date = new DateOnly(2026, 7, 1),
        Hours = "121.00",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TimeEntriesCreateProjectsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">TimeEntriesUpdateAsync</a>(TimeEntriesUpdateProjectsRequest { ... }) -> WithRawResponseTask&lt;TimeEntriesUpdateProjectsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change a time entry; only the fields sent are changed. `hours` must be positive (422); an entry already billed to an invoice cannot be changed (409).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.TimeEntriesUpdateAsync(new TimeEntriesUpdateProjectsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TimeEntriesUpdateProjectsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">TimeEntriesDeleteAsync</a>(TimeEntriesDeleteProjectsRequest { ... }) -> WithRawResponseTask&lt;TimeEntriesDeleteProjectsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a time entry (409 once it is billed).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.TimeEntriesDeleteAsync(new TimeEntriesDeleteProjectsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TimeEntriesDeleteProjectsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">TimeEntriesListAsync</a>(TimeEntriesListProjectsRequest { ... }) -> WithRawResponseTask&lt;TimeEntriesListProjectsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List time entries. Filterable by `projectId`, `employeeId`, `billable`, `billedInvoiceId` and `date`; sortable by `date`, `createdAt` and `hours`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.TimeEntriesListAsync(new TimeEntriesListProjectsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TimeEntriesListProjectsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">TimeEntriesBillAsync</a>(TimeEntriesBillProjectsRequest { ... }) -> WithRawResponseTask&lt;TimeEntriesBillProjectsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a draft sale invoice from the project's unbilled billable time entries, optionally limited to `dateFrom` and `dateTo`, and mark them billed; needs the `sales:write` scope, and the invoice is issued with `sales/invoices/issue`. The customer is `partnerId`, else the project's partner (422 without either); each entry is priced at its own `hourlyRate`, else the call's `hourlyRate` (422 when an entry has neither); `groupBy` `rate` makes one line per rate with the summed hours, `entry` one line per entry; `itemId`, `vatRatePercent` and `vatClassifierCode` go onto every line. No matching entries is 422.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.TimeEntriesBillAsync(
    new TimeEntriesBillProjectsRequest { ProjectId = "projectId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TimeEntriesBillProjectsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">ReportAsync</a>(ReportProjectsRequest { ... }) -> WithRawResponseTask&lt;ReportProjectsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Profitability per project: `revenue` and `costs` from posted journal entries tagged with the project (income accounts credit less debit, expense accounts debit less credit), `profit` as their difference, and the hours from time entries (total, billable, billed, unbilled, and the unbilled amount at the entries' hourly rates). `projectId` limits the report to one project; `dateFrom` and `dateTo` limit the journal dates and the entry dates. Nothing is changed.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.ReportAsync(new ReportProjectsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReportProjectsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## transport
<details><summary><code>client.Transport.<a href="/src/NordletApi/Transport/TransportClient.cs">WaybillsCreateAsync</a>(WaybillsCreateTransportRequest { ... }) -> WithRawResponseTask&lt;WaybillsCreateTransportResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a draft waybill to the consignee. The cargo lines are `lines` or, when none are given and `saleInvoiceId` is set, the product lines of that sale invoice (422 when it has none); a line without `description`, `unit` or `productCode` takes them from its item. `documentDate` defaults to the company's today and `series` to `VAZ`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Transport.WaybillsCreateAsync(
    new WaybillsCreateTransportRequest
    {
        ConsigneePartnerId = "consigneePartnerId",
        DispatchAt = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        LoadAddress = "loadAddress",
        UnloadAddress = "unloadAddress",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WaybillsCreateTransportRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Transport.<a href="/src/NordletApi/Transport/TransportClient.cs">WaybillsUpdateAsync</a>(WaybillsUpdateTransportRequest { ... }) -> WithRawResponseTask&lt;WaybillsUpdateTransportResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change a draft waybill; omitted fields keep their value, the optional ones can be cleared with null, and `lines`, when given, replace all existing lines. A waybill that is already issued or cancelled is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Transport.WaybillsUpdateAsync(new WaybillsUpdateTransportRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WaybillsUpdateTransportRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Transport.<a href="/src/NordletApi/Transport/TransportClient.cs">WaybillsIssueAsync</a>(WaybillsIssueTransportRequest { ... }) -> WithRawResponseTask&lt;WaybillsIssueTransportResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Issue a draft waybill: it takes the next number of its `series` for the year of `documentDate` and becomes `issued`. Without a vehicle plate or without lines the call is refused with 422, a waybill that is not a draft with 409. Only issued waybills can go into the Lithuanian i.VAZ file (`declarations/lt/ivaz/generate`) and the Romanian e-Transport declaration (`declarations/ro/etransport/build`).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Transport.WaybillsIssueAsync(new WaybillsIssueTransportRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WaybillsIssueTransportRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Transport.<a href="/src/NordletApi/Transport/TransportClient.cs">WaybillsCancelAsync</a>(WaybillsCancelTransportRequest { ... }) -> WithRawResponseTask&lt;WaybillsCancelTransportResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Cancel a draft or issued waybill. An already cancelled one is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Transport.WaybillsCancelAsync(new WaybillsCancelTransportRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WaybillsCancelTransportRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Transport.<a href="/src/NordletApi/Transport/TransportClient.cs">WaybillsGetAsync</a>(WaybillsGetTransportRequest { ... }) -> WithRawResponseTask&lt;WaybillsGetTransportResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read one waybill with its lines.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Transport.WaybillsGetAsync(new WaybillsGetTransportRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WaybillsGetTransportRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Transport.<a href="/src/NordletApi/Transport/TransportClient.cs">WaybillsListAsync</a>(WaybillsListTransportRequest { ... }) -> WithRawResponseTask&lt;WaybillsListTransportResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List waybills with the consignee's name. Filterable by `status`, `consigneePartnerId`, `documentDate`, `fullNumber` and `dispatchAt`; sortable by `createdAt`, `dispatchAt` and `fullNumber`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Transport.WaybillsListAsync(new WaybillsListTransportRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WaybillsListTransportRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## pos
<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">DevicesCreateAsync</a>(DevicesCreatePosRequest { ... }) -> WithRawResponseTask&lt;DevicesCreatePosResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Register a cash register (POS device). The serial number must be unique in the company; a repeat is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.DevicesCreateAsync(
    new DevicesCreatePosRequest { Name = "name", SerialNumber = "serialNumber" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DevicesCreatePosRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">DevicesUpdateAsync</a>(DevicesUpdatePosRequest { ... }) -> WithRawResponseTask&lt;DevicesUpdatePosResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change a POS device's details or set `isActive`; an inactive device accepts no new shifts or reports. A serial number already used by another device is refused with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.DevicesUpdateAsync(new DevicesUpdatePosRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DevicesUpdatePosRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">DevicesListAsync</a>(DevicesListPosRequest { ... }) -> WithRawResponseTask&lt;DevicesListPosResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List POS devices. Filterable by `name` and `serialNumber`; sortable by `name`, `serialNumber` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.DevicesListAsync(new DevicesListPosRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DevicesListPosRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">ReportsCreateAsync</a>(ReportsCreatePosRequest { ... }) -> WithRawResponseTask&lt;ReportsCreatePosResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Record a daily cash register report (Z-report) and post it to the ledger in one journal entry: the cash and card takings are debited to `cashAccountCode` and `cardAccountCode`, the net of the `vatLines` is credited to `revenueAccountCode` and their VAT to `vatAccountCode`. `itemLines` write the sold products off `warehouseId` FIFO (a set is expanded to its product components) and add the cost of goods sold, debited to `cogsAccountCode` against the stock accounts. Account codes default to the company's chart. Refused with 422 when cash plus card differs from the gross total, the item lines have no warehouse or the device is inactive, with 409 when the accounting period is locked or the `reportNumber` already exists. Emits `pos_report.created` and, per item line, `stock.changed`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.ReportsCreateAsync(
    new ReportsCreatePosRequest
    {
        ReportNumber = "reportNumber",
        Date = new DateOnly(2026, 7, 1),
        VatLines = new List<ReportsCreatePosRequestVatLinesItem>()
        {
            new ReportsCreatePosRequestVatLinesItem
            {
                VatRatePercent = "121.00",
                NetAmount = "121.0000",
                VatAmount = "121.0000",
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReportsCreatePosRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">ReportsGetAsync</a>(ReportsGetPosRequest { ... }) -> WithRawResponseTask&lt;ReportsGetPosResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read one POS report with its VAT lines.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.ReportsGetAsync(new ReportsGetPosRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReportsGetPosRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">ReportsListAsync</a>(ReportsListPosRequest { ... }) -> WithRawResponseTask&lt;ReportsListPosResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List POS reports without their VAT lines. Filterable by `date`, `reportNumber` and `deviceId`; sortable by `date`, `reportNumber` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.ReportsListAsync(new ReportsListPosRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReportsListPosRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">ShiftsOpenAsync</a>(ShiftsOpenPosRequest { ... }) -> WithRawResponseTask&lt;ShiftsOpenPosResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Open a shift on a POS device with the cash float `openingCash`. A device has at most one open shift (409 for a second); an inactive device is refused with 422. Give `warehouseId` when the shift will sell stock items; they are written off that warehouse when the shift is closed.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.ShiftsOpenAsync(new ShiftsOpenPosRequest { DeviceId = "deviceId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ShiftsOpenPosRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">ShiftsGetAsync</a>(ShiftsGetPosRequest { ... }) -> WithRawResponseTask&lt;ShiftsGetPosResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read one POS shift.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.ShiftsGetAsync(new ShiftsGetPosRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ShiftsGetPosRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">ShiftsListAsync</a>(ShiftsListPosRequest { ... }) -> WithRawResponseTask&lt;ShiftsListPosResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List POS shifts. Filterable by `deviceId` and `status`; sortable by `openedAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.ShiftsListAsync(new ShiftsListPosRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ShiftsListPosRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">ReceiptsCreateAsync</a>(ReceiptsCreatePosRequest { ... }) -> WithRawResponseTask&lt;ReceiptsCreatePosResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Record a receipt in an open shift, numbered per shift from 1. Each line's net, VAT and gross come from its VAT-inclusive unit price; a line without `description` takes its item's name. Refused with 422 when cash plus card differs from the receipt total or a stock item is sold in a shift opened without a warehouse, with 409 when the shift is closed.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.ReceiptsCreateAsync(
    new ReceiptsCreatePosRequest
    {
        ShiftId = "shiftId",
        Lines = new List<ReceiptsCreatePosRequestLinesItem>()
        {
            new ReceiptsCreatePosRequestLinesItem
            {
                Quantity = "121.0000",
                UnitPriceInclVat = "121.0000",
                VatRatePercent = "121.00",
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReceiptsCreatePosRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">ReceiptsListAsync</a>(ReceiptsListPosRequest { ... }) -> WithRawResponseTask&lt;ReceiptsListPosResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List receipts without their lines. Filterable by `shiftId`; sortable by `number` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.ReceiptsListAsync(new ReceiptsListPosRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReceiptsListPosRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">ReceiptsGetAsync</a>(ReceiptsGetPosRequest { ... }) -> WithRawResponseTask&lt;ReceiptsGetPosResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read one receipt with its lines.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.ReceiptsGetAsync(new ReceiptsGetPosRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReceiptsGetPosRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">ShiftsCloseAsync</a>(ShiftsClosePosRequest { ... }) -> WithRawResponseTask&lt;ShiftsClosePosResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Close an open shift: its receipts are summed by VAT rate and by product into one POS report, created as by `pos/reports/create` with number `reportNumber` (default `Z-<device serial>-<n>`, n being the device's closed shifts plus one) on `date` (default: the company's today), which posts the takings and the stock write-off to the ledger and emits `pos_report.created`. The response adds `expectedCash` (opening cash plus the cash receipts) and `cashDifference` (`countedCash` less expected). A shift without receipts is refused with 422, a closed one with 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.ShiftsCloseAsync(new ShiftsClosePosRequest { Id = "id", CountedCash = "121.00" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ShiftsClosePosRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## calendar
<details><summary><code>client.Calendar.<a href="/src/NordletApi/Calendar/CalendarClient.cs">ListAsync</a>(ListCalendarRequest { ... }) -> WithRawResponseTask&lt;ListCalendarResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists, in due-date order, the filing deadlines Nordlet derives for the company from its country and profile together with the company's own events, between `from` and `to` (default 45 days back to 120 days ahead of the company's current date). Each deadline carries its submissions, whether it can be filed with `calendar/submit`, amended, or built with `calendar/download`, and whether its automation is on; `includeDone: false` leaves out the rows that are completed, submitted or accepted.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Calendar.ListAsync(new ListCalendarRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListCalendarRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Calendar.<a href="/src/NordletApi/Calendar/CalendarClient.cs">GetAsync</a>(GetCalendarRequest { ... }) -> WithRawResponseTask&lt;GetCalendarResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Reads one calendar row by `key`: the id of a company event, or `ruleKey:period` for a filing deadline with its submissions.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Calendar.GetAsync(new GetCalendarRequest { Key = "key" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetCalendarRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Calendar.<a href="/src/NordletApi/Calendar/CalendarClient.cs">SubmitAsync</a>(SubmitCalendarRequest { ... }) -> WithRawResponseTask&lt;SubmitCalendarResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

With amend: true the return is filed again as a correction of the one already submitted or accepted for the period; only returns whose format has a correction mark accept it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Calendar.SubmitAsync(new SubmitCalendarRequest { Key = "key" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SubmitCalendarRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Calendar.<a href="/src/NordletApi/Calendar/CalendarClient.cs">DownloadAsync</a>(DownloadCalendarRequest { ... }) -> WithRawResponseTask&lt;DownloadCalendarResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Builds the file of a deadline whose format Nordlet produces but whose administration takes it only through the company's own account or program. Nothing is sent and no filing is recorded.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Calendar.DownloadAsync(new DownloadCalendarRequest { Key = "key" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DownloadCalendarRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Calendar.<a href="/src/NordletApi/Calendar/CalendarClient.cs">CreateAsync</a>(CreateCalendarRequest { ... }) -> WithRawResponseTask&lt;CreateCalendarResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a company event (kind `custom`) with a title, a due date, notes and a done flag.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Calendar.CreateAsync(
    new CreateCalendarRequest { Title = "title", DueDate = new DateOnly(2026, 7, 1) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateCalendarRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Calendar.<a href="/src/NordletApi/Calendar/CalendarClient.cs">UpdateAsync</a>(UpdateCalendarRequest { ... }) -> WithRawResponseTask&lt;UpdateCalendarResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Changes a calendar row by `key`. A company event takes a new title, due date, notes or done flag; a filing deadline (`ruleKey:period`) takes only notes and done, keeps its own title and date, and gets a stored row the first time it is annotated.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Calendar.UpdateAsync(new UpdateCalendarRequest { Key = "key" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateCalendarRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Calendar.<a href="/src/NordletApi/Calendar/CalendarClient.cs">DeleteAsync</a>(DeleteCalendarRequest { ... }) -> WithRawResponseTask&lt;DeleteCalendarResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a company event by its id, or the stored notes and done mark of a filing deadline by `ruleKey:period`; the deadline itself still comes from the rules.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Calendar.DeleteAsync(new DeleteCalendarRequest { Key = "key" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteCalendarRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## audit
<details><summary><code>client.Audit.<a href="/src/NordletApi/Audit/AuditClient.cs">ListAsync</a>(ListAuditRequest { ... }) -> WithRawResponseTask&lt;ListAuditResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the audit log of the company: who did what to which entity, with the recorded change in `diff`. Filterable by `action`, `entity`, `entityId`, `actorType` and `actorId`; sortable by `createdAt` and `id`, newest first by default.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Audit.ListAsync(new ListAuditRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListAuditRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## webhooks
<details><summary><code>client.Webhooks.<a href="/src/NordletApi/Webhooks/WebhooksClient.cs">SubscriptionsCreateAsync</a>(SubscriptionsCreateWebhooksRequest { ... }) -> WithRawResponseTask&lt;SubscriptionsCreateWebhooksResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Register a webhook endpoint for the given event types (`*` for every event). The URL must be an https address that resolves to a public network (422 otherwise). The signing secret is generated unless `secret` is given, and this call is the only one that returns it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.SubscriptionsCreateAsync(
    new SubscriptionsCreateWebhooksRequest
    {
        Url = "url",
        Events = new List<SubscriptionsCreateWebhooksRequestEventsItem>()
        {
            SubscriptionsCreateWebhooksRequestEventsItem.AgreementInvoiceGenerated,
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SubscriptionsCreateWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/NordletApi/Webhooks/WebhooksClient.cs">SubscriptionsListAsync</a>(SubscriptionsListWebhooksRequest { ... }) -> WithRawResponseTask&lt;SubscriptionsListWebhooksResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the company's webhook subscriptions with their last delivery state. Filterable by `url` and `isActive`; sortable by `createdAt` and `url`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.SubscriptionsListAsync(new SubscriptionsListWebhooksRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SubscriptionsListWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/NordletApi/Webhooks/WebhooksClient.cs">SubscriptionsUpdateAsync</a>(SubscriptionsUpdateWebhooksRequest { ... }) -> WithRawResponseTask&lt;SubscriptionsUpdateWebhooksResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change the URL, event types or `isActive` flag of a subscription; at least one field is required (400) and a new URL must be an https address that resolves to a public network (422). Setting `isActive` to true also clears `pausedAt` and `consecutiveFailures`, which is how a subscription paused after 5 failed deliveries in a row is switched back on.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.SubscriptionsUpdateAsync(
    new SubscriptionsUpdateWebhooksRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SubscriptionsUpdateWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/NordletApi/Webhooks/WebhooksClient.cs">SubscriptionsDeleteAsync</a>(SubscriptionsDeleteWebhooksRequest { ... }) -> WithRawResponseTask&lt;SubscriptionsDeleteWebhooksResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a webhook subscription.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.SubscriptionsDeleteAsync(
    new SubscriptionsDeleteWebhooksRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SubscriptionsDeleteWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/NordletApi/Webhooks/WebhooksClient.cs">DeliveriesListAsync</a>(DeliveriesListWebhooksRequest { ... }) -> WithRawResponseTask&lt;DeliveriesListWebhooksResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the company's webhook deliveries, newest first. Filterable by `status`, `eventType` and `subscriptionId`; sortable by `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.DeliveriesListAsync(new DeliveriesListWebhooksRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeliveriesListWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/NordletApi/Webhooks/WebhooksClient.cs">DeliveriesRedeliverAsync</a>(DeliveriesRedeliverWebhooksRequest { ... }) -> WithRawResponseTask&lt;DeliveriesRedeliverWebhooksResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Send a delivery again now: its status goes back to `pending` with the attempt count and last error cleared. Answers 409 when the subscription is inactive.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.DeliveriesRedeliverAsync(
    new DeliveriesRedeliverWebhooksRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeliveriesRedeliverWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## bank
<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">AccountsCreateAsync</a>(AccountsCreateBankRequest { ... }) -> WithRawResponseTask&lt;AccountsCreateBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a bank, Stripe or broker account. `currency` defaults to the company base currency and `accountCode` to the default bank account of the chart of accounts. A `documentRef` also creates a bank agreement with that document attached. A Stripe account with an `iban` is refused with 422; an account with the same IBAN already existing answers 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.AccountsCreateAsync(new AccountsCreateBankRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AccountsCreateBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">AccountsListAsync</a>(AccountsListBankRequest { ... }) -> WithRawResponseTask&lt;AccountsListBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the bank accounts of the company. Filterable by name, type, iban and isActive; sortable by name and createdAt.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.AccountsListAsync(new AccountsListBankRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AccountsListBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">AccountsUpdateAsync</a>(AccountsUpdateBankRequest { ... }) -> WithRawResponseTask&lt;AccountsUpdateBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change the name, type, IBAN, ledger account code or active flag of a bank account. Setting type to stripe clears the IBAN, and sending an `iban` together with it is refused with 422.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.AccountsUpdateAsync(new AccountsUpdateBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AccountsUpdateBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">TransactionsImportAsync</a>(TransactionsImportBankRequest { ... }) -> WithRawResponseTask&lt;TransactionsImportBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Insert statement lines (up to 1000 per call) into a bank account as new transactions. A line without `currency` takes the account currency; a line in another currency is refused with 422. A line whose `externalId` is already on the account is skipped and counted in `skipped`. An incoming line that an active match rule (`bank/match-rules/create`) recognises is linked to its settlement batch.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.TransactionsImportAsync(
    new TransactionsImportBankRequest
    {
        BankAccountId = "bankAccountId",
        Transactions = new List<TransactionsImportBankRequestTransactionsItem>()
        {
            new TransactionsImportBankRequestTransactionsItem
            {
                Date = new DateOnly(2026, 7, 1),
                Amount = "-121.0000",
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TransactionsImportBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">StatementsImportAsync</a>(StatementsImportBankRequest { ... }) -> WithRawResponseTask&lt;StatementsImportBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Import a statement file into a bank account: camt.053 XML, MT940, a Stripe balance CSV or a Revolut Business CSV, chosen by `format` or by the type of `templateId` (an iso20022 template also takes MT940 content). Statements whose IBAN or currency differ from the account are left out; the call is refused with 422 when none remains, when a line is in another currency, when the file lacks the columns or elements the template requires or when it holds more than 50000 lines. Lines already on the account are skipped, and Stripe movements already posted through a settlement payout are skipped with a warning. With a template, the mapped fields are posted to their ledger accounts, partners are created, payments are matched to the invoices they reference, and invoices, credit notes or advance invoices are issued where the template asks for them (`invoiceMetaField`, `advanceInvoices`); `transfersCsv` posts the lender payouts and commissions of a Stripe template. Invoices issued this way are announced as `sale_invoice.issued`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.StatementsImportAsync(
    new StatementsImportBankRequest { BankAccountId = "bankAccountId", Content = "content" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StatementsImportBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">TransactionsListAsync</a>(TransactionsListBankRequest { ... }) -> WithRawResponseTask&lt;TransactionsListBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the bank transactions of the company. Filterable by id, bankAccountId, status, matchedDocumentId, date, amount, counterpartyIban, counterpartyName and externalId; sortable by date, createdAt and amount.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.TransactionsListAsync(new TransactionsListBankRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TransactionsListBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">TransactionsMatchAsync</a>(TransactionsMatchBankRequest { ... }) -> WithRawResponseTask&lt;TransactionsMatchBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Match one new bank transaction to a document: an issued sale invoice or advance for incoming money; an issued sale credit note, a registered purchase invoice or an approved payroll run (company currency only) for outgoing money. Posts the payment journal transaction between the bank account and the receivable, payable or net payable account, with any exchange difference on the gain or loss account, raises the paid amount of the document and sets the line to matched. `invoiceAmount` states the amount settled on an invoice in another currency; in the same currency it must equal the payment (422). Answers 409 when the line is already matched, when the amount exceeds the remaining balance of the document or when the accounting period of the line date is locked. A document that becomes fully paid is announced as `sale_invoice.paid` or `purchase_invoice.paid`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.TransactionsMatchAsync(
    new TransactionsMatchBankRequest
    {
        TransactionId = "transactionId",
        DocumentType = TransactionsMatchBankRequestDocumentType.SaleInvoice,
        DocumentId = "documentId",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TransactionsMatchBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">TransactionsMatchManyAsync</a>(TransactionsMatchManyBankRequest { ... }) -> WithRawResponseTask&lt;TransactionsMatchManyBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

The documents are issued sale invoices or advances for incoming money; issued sale credit notes, registered purchase invoices or approved payroll runs for outgoing money. Each must be in the currency of the payment, each allocation must be above zero, a document may appear once and the allocations must add up to the payment (422 otherwise). One journal transaction carries the bank entry, one entry per document and any exchange difference; the line is matched as an `invoice_allocation`. Answers 409 when the line is already matched, when an allocation exceeds the remaining balance of its document or when the accounting period of the line date is locked. Each document that becomes fully paid is announced as `sale_invoice.paid` or `purchase_invoice.paid`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.TransactionsMatchManyAsync(
    new TransactionsMatchManyBankRequest
    {
        TransactionId = "transactionId",
        Allocations = new List<TransactionsMatchManyBankRequestAllocationsItem>()
        {
            new TransactionsMatchManyBankRequestAllocationsItem
            {
                DocumentType =
                    TransactionsMatchManyBankRequestAllocationsItemDocumentType.SaleInvoice,
                DocumentId = "documentId",
                Amount = "121.0000",
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TransactionsMatchManyBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">TransactionsUnmatchAsync</a>(TransactionsUnmatchBankRequest { ... }) -> WithRawResponseTask&lt;TransactionsUnmatchBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Undo a match. A payment matched to an invoice, or a line posted by an import template, gets a reversing journal transaction dated date (default: today) and the invoice paid amount and payment status are restored; a line linked to a payment-provider settlement is only unlinked. The line returns to status new.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.TransactionsUnmatchAsync(
    new TransactionsUnmatchBankRequest { TransactionId = "transactionId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TransactionsUnmatchBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">TransactionsRecordAsync</a>(TransactionsRecordBankRequest { ... }) -> WithRawResponseTask&lt;TransactionsRecordBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Record a payment that is on no imported statement: inserts a bank transaction on the account dated `date` (positive for a sale invoice, negative for a purchase invoice or payroll run, in the account currency) and matches it to the document with the checks, posting and `sale_invoice.paid` or `purchase_invoice.paid` event of `bank/transactions/match`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.TransactionsRecordAsync(
    new TransactionsRecordBankRequest
    {
        BankAccountId = "bankAccountId",
        Date = new DateOnly(2026, 7, 1),
        Amount = "121.0000",
        DocumentType = TransactionsRecordBankRequestDocumentType.SaleInvoice,
        DocumentId = "documentId",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TransactionsRecordBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PaymentsExportAsync</a>(PaymentsExportBankRequest { ... }) -> WithRawResponseTask&lt;PaymentsExportBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build a SEPA credit transfer file (pain.001.001.03) that pays the remaining amount of each registered purchase invoice from the bank account on `executionDate` (default: today), to the partner's default bank account. The bank account needs an IBAN and every invoice must be in EUR and have a partner bank account on file (422 otherwise, see `partners/bank-accounts/create`); an invoice that is already paid answers 409. The file is returned as `xml`; nothing is posted or marked paid.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PaymentsExportAsync(
    new PaymentsExportBankRequest
    {
        BankAccountId = "bankAccountId",
        PurchaseInvoiceIds = new List<string>() { "purchaseInvoiceIds" },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PaymentsExportBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">ImportTemplatesCreateAsync</a>(ImportTemplatesCreateBankRequest { ... }) -> WithRawResponseTask&lt;ImportTemplatesCreateBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

A template of type stripe, iso20022, revolut or bank_connection names the fields of the file or feed: a field with an `accountCode` is posted to that ledger account on import, a field with `createPartner` creates the customer, supplier or fee partner. `invoiceMetaField` is the Stripe metadata key (stripe) or the reference field (other types) by which payments are linked to invoices; with it `invoiceVatRatePercent`, `invoiceItemId` and, outside Stripe, `advanceInvoices` apply. `companyMetaField`, `lenderMetaField`, the operation types and the refund labels are for Stripe templates only. A template with the same name already existing answers 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.ImportTemplatesCreateAsync(
    new ImportTemplatesCreateBankRequest
    {
        Name = "name",
        Type = ImportTemplatesCreateBankRequestType.Stripe,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ImportTemplatesCreateBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">ImportTemplatesUpdateAsync</a>(ImportTemplatesUpdateBankRequest { ... }) -> WithRawResponseTask&lt;ImportTemplatesUpdateBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change a company import template under the rules of `bank/import-templates/create`; a change of `type` re-checks the existing fields against the new type. Built-in templates cannot be changed. A name already used by another template answers 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.ImportTemplatesUpdateAsync(new ImportTemplatesUpdateBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ImportTemplatesUpdateBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">ImportTemplatesDeleteAsync</a>(ImportTemplatesDeleteBankRequest { ... }) -> WithRawResponseTask&lt;ImportTemplatesDeleteBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a company import template. Built-in templates cannot be deleted.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.ImportTemplatesDeleteAsync(new ImportTemplatesDeleteBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ImportTemplatesDeleteBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">ImportTemplatesGetAsync</a>(ImportTemplatesGetBankRequest { ... }) -> WithRawResponseTask&lt;ImportTemplatesGetBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read one import template, a company one or a built-in one.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.ImportTemplatesGetAsync(new ImportTemplatesGetBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ImportTemplatesGetBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">ImportTemplatesListBuiltinAsync</a>(ImportTemplatesListBuiltinBankRequest { ... }) -> WithRawResponseTask&lt;ImportTemplatesListBuiltinBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Today the Revolut Business template: the Revolut CSV fields, with fees, card payments and top-ups posted to the accounts of the posting rules, the sender and beneficiary names creating partners and the Reference column linking payments to invoices. The rows carry `builtin: true`, are readable with `bank/import-templates/get` and are not in `bank/import-templates/list`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.ImportTemplatesListBuiltinAsync(new ImportTemplatesListBuiltinBankRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ImportTemplatesListBuiltinBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">ImportTemplatesListAsync</a>(ImportTemplatesListBankRequest { ... }) -> WithRawResponseTask&lt;ImportTemplatesListBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the import templates of the company (the built-in ones are under `bank/import-templates/list-builtin`). Filterable by name and type; sortable by name and createdAt.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.ImportTemplatesListAsync(new ImportTemplatesListBankRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ImportTemplatesListBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">MatchRulesCreateAsync</a>(MatchRulesCreateBankRequest { ... }) -> WithRawResponseTask&lt;MatchRulesCreateBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a rule that links incoming bank lines to the settlement batches of a payment provider when lines are imported and when a batch is posted. A line whose description, counterparty name or external id contains `pattern` (case-insensitive) is linked to the open batch of `provider` whose payout id follows `payoutIdPrefix` in the line text or, without a prefix, to the single open batch on the same bank account with the same currency and net amount and a payout date within `dateWindowDays` of the line date. `bankAccountId` limits the rule to one account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.MatchRulesCreateAsync(
    new MatchRulesCreateBankRequest { Name = "name", Pattern = "pattern" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MatchRulesCreateBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">MatchRulesUpdateAsync</a>(MatchRulesUpdateBankRequest { ... }) -> WithRawResponseTask&lt;MatchRulesUpdateBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change a match rule; `payoutIdPrefix` and `bankAccountId` are cleared with null.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.MatchRulesUpdateAsync(new MatchRulesUpdateBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MatchRulesUpdateBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">MatchRulesDeleteAsync</a>(MatchRulesDeleteBankRequest { ... }) -> WithRawResponseTask&lt;MatchRulesDeleteBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a match rule.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.MatchRulesDeleteAsync(new MatchRulesDeleteBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MatchRulesDeleteBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">MatchRulesListAsync</a>(MatchRulesListBankRequest { ... }) -> WithRawResponseTask&lt;MatchRulesListBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the match rules of the company, ordered by name.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.MatchRulesListAsync(new MatchRulesListBankRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MatchRulesListBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">MandatesCreateAsync</a>(MandatesCreateBankRequest { ... }) -> WithRawResponseTask&lt;MandatesCreateBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Record a SEPA direct debit mandate a partner has signed: debtor IBAN and BIC, scheme (CORE or B2B), recurrent or one-off, and the signature date. `reference` is the mandate reference written into the collection files; without one `MNDT-` followed by a generated id is used. `debtorName` defaults to the partner name. A reference already in use answers 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.MandatesCreateAsync(
    new MandatesCreateBankRequest
    {
        PartnerId = "partnerId",
        Iban = "iban",
        SignatureDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MandatesCreateBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">MandatesUpdateAsync</a>(MandatesUpdateBankRequest { ... }) -> WithRawResponseTask&lt;MandatesUpdateBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change the BIC, debtor name or notes of a mandate.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.MandatesUpdateAsync(new MandatesUpdateBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MandatesUpdateBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">MandatesCancelAsync</a>(MandatesCancelBankRequest { ... }) -> WithRawResponseTask&lt;MandatesCancelBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Cancel an active mandate. A mandate that is already cancelled or completed answers 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.MandatesCancelAsync(new MandatesCancelBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MandatesCancelBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">MandatesGetAsync</a>(MandatesGetBankRequest { ... }) -> WithRawResponseTask&lt;MandatesGetBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read one mandate. `expiresOn` is 36 months after the last collection, or after the signature date when nothing has been collected.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.MandatesGetAsync(new MandatesGetBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MandatesGetBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">MandatesListAsync</a>(MandatesListBankRequest { ... }) -> WithRawResponseTask&lt;MandatesListBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the mandates of the company. Filterable by partnerId, status, scheme, reference and iban; sortable by createdAt and signatureDate.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.MandatesListAsync(new MandatesListBankRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MandatesListBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">DirectDebitsCandidatesAsync</a>(DirectDebitsCandidatesBankRequest { ... }) -> WithRawResponseTask&lt;DirectDebitsCandidatesBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the issued EUR sale invoices that are unpaid or partly paid and whose partner holds an active mandate, each with the mandate `bank/direct-debits/export` would use (the most recently signed active one). Filterable by partnerId, fullNumber, issueDate and dueDate; sortable by issueDate, dueDate, fullNumber, grossTotal and createdAt.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.DirectDebitsCandidatesAsync(new DirectDebitsCandidatesBankRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DirectDebitsCandidatesBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">DirectDebitsExportAsync</a>(DirectDebitsExportBankRequest { ... }) -> WithRawResponseTask&lt;DirectDebitsExportBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build a SEPA direct debit file (pain.008.001.02) that collects the remaining amount of each issued EUR sale invoice into the bank account on `collectionDate` (default: today) under the partner's most recently signed active mandate. The bank account needs an IBAN and the company a valid `sepaCreditorId` (422, see `account/companies/update`); an invoice whose partner has no active mandate, or whose mandate expired (36 months without a collection), answers 422; an invoice already paid, or a one-off mandate asked to collect more than one invoice, answers 409. The sequence type is OOFF for a one-off mandate, FRST for the first collection under a recurrent one and RCUR after that. On success the collection count and last collection date of each mandate are advanced and a one-off mandate is completed; nothing is posted.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.DirectDebitsExportAsync(
    new DirectDebitsExportBankRequest
    {
        BankAccountId = "bankAccountId",
        SaleInvoiceIds = new List<string>() { "saleInvoiceIds" },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DirectDebitsExportBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">TransactionsSuggestMatchesAsync</a>(TransactionsSuggestMatchesBankRequest { ... }) -> WithRawResponseTask&lt;TransactionsSuggestMatchesBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Suggest documents for a new bank transaction: issued sale invoices and advances for incoming money; registered purchase invoices, issued sale credit notes and approved payroll runs for outgoing money. Candidates are unpaid documents whose remaining balance covers the payment (any balance when in another currency), scored by an equal remaining balance, the document number or payroll period in the payment description and a counterparty IBAN or name matching the partner or an employee on the run; the best `limit` come back with their reasons. A transaction that is already matched answers 409.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.TransactionsSuggestMatchesAsync(
    new TransactionsSuggestMatchesBankRequest { TransactionId = "transactionId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TransactionsSuggestMatchesBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">SettlementsImportAsync</a>(SettlementsImportBankRequest { ... }) -> WithRawResponseTask&lt;SettlementsImportBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Import a Stripe payout report into settlement batches, one per payout: the itemized payout reconciliation CSV (`format` payout_reconciliation) or the unified payments export with its Transfer column (unified_payments); another CSV is refused with 422. Rows without a payout, the payout rows themselves and unsettled payments are skipped and counted. Each line is matched to an issued sale invoice through the references the report carries (the external reference of a sales order or an invoice number) or through a charge matched earlier. A payout already imported receives its new lines while the batch is in status imported and is skipped once posted; a payout mixing currencies answers 422. Emits `settlement.imported` for a new batch and `settlement.updated` for one that received lines.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.SettlementsImportAsync(
    new SettlementsImportBankRequest { BankAccountId = "bankAccountId", Content = "content" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettlementsImportBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">SettlementsListAsync</a>(SettlementsListBankRequest { ... }) -> WithRawResponseTask&lt;SettlementsListBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the settlement batches with their line counts and the clearing figures against the bank lines. Filterable by provider, payoutId, status, currency and bankAccountId; sortable by payoutDate, createdAt and netTotal.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.SettlementsListAsync(new SettlementsListBankRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettlementsListBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">SettlementsGetAsync</a>(SettlementsGetBankRequest { ... }) -> WithRawResponseTask&lt;SettlementsGetBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read one settlement batch with its lines, each with the invoice it is matched to and the bank line that cleared it (`clearingBooked`, `clearingDifference`, `clearingUnposted`).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.SettlementsGetAsync(new SettlementsGetBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettlementsGetBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">SettlementsMatchAsync</a>(SettlementsMatchBankRequest { ... }) -> WithRawResponseTask&lt;SettlementsMatchBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Match a settlement line to an issued sale invoice or advance by hand (`matchStatus` manual), or clear the match with `invoiceId` null. Only lines of the categories charge, refund, dispute, dispute_reversal and partial_capture_reversal can be matched (422), and only while the batch is in status imported (409).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.SettlementsMatchAsync(new SettlementsMatchBankRequest { LineId = "lineId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettlementsMatchBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">SettlementsCommissionAsync</a>(SettlementsCommissionBankRequest { ... }) -> WithRawResponseTask&lt;SettlementsCommissionBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

A line with its own rate or amount is split with that value when the batch is posted. A line without one falls back to the commissionPercent given to the posting call, and without that the amount goes to the suspense account. Send both fields as null to clear the line back to the fallback.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.SettlementsCommissionAsync(
    new SettlementsCommissionBankRequest { LineId = "lineId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettlementsCommissionBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">SettlementsLinkAsync</a>(SettlementsLinkBankRequest { ... }) -> WithRawResponseTask&lt;SettlementsLinkBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Attach the incoming bank-statement line that carries this payout to the settlement batch.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.SettlementsLinkAsync(
    new SettlementsLinkBankRequest { Id = "id", BankTransactionId = "bankTransactionId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettlementsLinkBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">SettlementsUnlinkAsync</a>(SettlementsUnlinkBankRequest { ... }) -> WithRawResponseTask&lt;SettlementsUnlinkBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Detach the bank-statement line from the settlement batch and return the line to unmatched.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.SettlementsUnlinkAsync(new SettlementsUnlinkBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettlementsUnlinkBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">SettlementsPostAsync</a>(SettlementsPostBankRequest { ... }) -> WithRawResponseTask&lt;SettlementsPostBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Post a settlement batch dated `date` (default: the payout date, else today): the bank account receives the net payout, the matched sale invoices are settled against the receivable (the receivable of each partner in a journal transaction of its own when invoices of several partners are settled), the provider fees, the marketplace commission and the seller payable are booked, and a payout in another currency is converted at the rate of that date with the exchange difference against each invoice's own rate on the gain or loss account. A line without a matched invoice is split by its own rate or amount, else by `commissionPercent`, else parked on the suspense account; a line already imported as a movement of a bank account is posted against that account instead. Answers 409 when the batch is already posted or the period is locked, 422 when it has no lines. The payout is linked to the bank line a match rule recognises. Emits `settlement.posted`, `sale_invoice.paid` for each invoice that becomes paid and `refund_liability.actual` for refunds of invoices carrying a refund liability.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.SettlementsPostAsync(new SettlementsPostBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettlementsPostBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">SecuritiesImportAsync</a>(SecuritiesImportBankRequest { ... }) -> WithRawResponseTask&lt;SecuritiesImportBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Import an Interactive Brokers activity statement (CSV) into a bank account of type `broker`; refused with 422 for another account type, a file that is not an IBKR statement, a statement of a different IBKR account than the bank account already holds, or a trade older than the latest trade already imported (statements go in in date order). Rows already imported are skipped. Dividends, withholding tax, interest and fees are posted against the broker account; stock, option and futures trades are matched FIFO against the open lots and post the cost to `securities.investments` and the realised result to `securities.gain` or `securities.loss` (posting rules), one journal entry per date in the base currency at the rate of the day (422 without a rate, 409 when the date's period is locked). Deposits, corporate actions and currency conversions are stored as `not_posted` with a note.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.SecuritiesImportAsync(
    new SecuritiesImportBankRequest { BankAccountId = "bankAccountId", Content = "content" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SecuritiesImportBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">SecuritiesListAsync</a>(SecuritiesListBankRequest { ... }) -> WithRawResponseTask&lt;SecuritiesListBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the securities imports, newest first; filterable by `bankAccountId` and `brokerAccount`, sortable by `createdAt` and `realizedTotal`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.SecuritiesListAsync(new SecuritiesListBankRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SecuritiesListBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">SecuritiesGetAsync</a>(SecuritiesGetBankRequest { ... }) -> WithRawResponseTask&lt;SecuritiesGetBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one securities import with its operations in date order, each with its posting status, its amounts in the base currency and the journal transaction it was posted in.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.SecuritiesGetAsync(new SecuritiesGetBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SecuritiesGetBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">SecuritiesOperationsListAsync</a>(SecuritiesOperationsListBankRequest { ... }) -> WithRawResponseTask&lt;SecuritiesOperationsListBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the imported securities operations, newest first; filterable by `bankAccountId`, `kind`, `status`, `symbol` and `date`, sortable by `date` and `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.SecuritiesOperationsListAsync(new SecuritiesOperationsListBankRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SecuritiesOperationsListBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">FeedsBanksListAsync</a>(FeedsBanksListBankRequest { ... }) -> WithRawResponseTask&lt;FeedsBanksListBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read from the bank-feed provider configured on the API server or in platform settings (Enable Banking or an HTTP bridge, named in `provider`), for one `country` or all. Without a provider the call answers 503.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.FeedsBanksListAsync(new FeedsBanksListBankRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FeedsBanksListBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">FeedsConnectionsStartAsync</a>(FeedsConnectionsStartBankRequest { ... }) -> WithRawResponseTask&lt;FeedsConnectionsStartBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a pending bank connection and asks the provider for the authorization page of the bank. `url` is where the user authorizes access for `validForDays` (default 90); `reference` is the state the bank sends back and what `bank/feeds/connections/complete` takes. `redirectUrl` falls back to the one in platform settings, and the call is refused with 422 when neither is set.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.FeedsConnectionsStartAsync(
    new FeedsConnectionsStartBankRequest { AspspName = "aspspName", AspspCountry = "aspspCountry" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FeedsConnectionsStartBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">FeedsConnectionsCompleteAsync</a>(FeedsConnectionsCompleteBankRequest { ... }) -> WithRawResponseTask&lt;FeedsConnectionsCompleteBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Exchanges `code` for a provider session, sets the connection to active with the consent expiry the bank reports, and records every account of the session as a bank-feed account, not yet linked to a ledger account (`bank/feeds/accounts/link`). A connection that is already active answers 409. When the provider refuses the code the connection goes to status error with the message in `error`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.FeedsConnectionsCompleteAsync(
    new FeedsConnectionsCompleteBankRequest { Reference = "reference", Code = "code" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FeedsConnectionsCompleteBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">FeedsConnectionsGetAsync</a>(FeedsConnectionsGetBankRequest { ... }) -> WithRawResponseTask&lt;FeedsConnectionsGetBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read one bank connection with its bank-feed accounts.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.FeedsConnectionsGetAsync(new FeedsConnectionsGetBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FeedsConnectionsGetBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">FeedsConnectionsListAsync</a>(FeedsConnectionsListBankRequest { ... }) -> WithRawResponseTask&lt;FeedsConnectionsListBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the bank connections of the company, without their accounts. Filterable by status, provider and aspspCountry; sortable by createdAt and lastSyncedAt.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.FeedsConnectionsListAsync(new FeedsConnectionsListBankRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FeedsConnectionsListBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">FeedsConnectionsDeleteAsync</a>(FeedsConnectionsDeleteBankRequest { ... }) -> WithRawResponseTask&lt;FeedsConnectionsDeleteBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Closes the provider session when the connection has one and a provider is configured (a failure at the bank does not stop the call), then deletes the connection and its bank-feed accounts. The ledger bank accounts and the transactions already imported stay.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.FeedsConnectionsDeleteAsync(new FeedsConnectionsDeleteBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FeedsConnectionsDeleteBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">FeedsAccountsLinkAsync</a>(FeedsAccountsLinkBankRequest { ... }) -> WithRawResponseTask&lt;FeedsAccountsLinkBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Give exactly one of `bankAccountId` (an existing ledger bank account) or `createBankAccount` (a new one with the IBAN and currency of the feed account; `accountCode` defaults to the default bank account of the chart of accounts). `syncFrom` is the date the first sync starts from; without it the first sync covers the last 90 days.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.FeedsAccountsLinkAsync(new FeedsAccountsLinkBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FeedsAccountsLinkBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">FeedsAccountsConfigureAsync</a>(FeedsAccountsConfigureBankRequest { ... }) -> WithRawResponseTask&lt;FeedsAccountsConfigureBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

`importTemplateId` must be a template of type bank_connection, or null to apply none. `syncSchedule` is manual, daily, weekly or monthly; every account whose schedule is not manual is synced by Nordlet when it is due. At least one of the two must be given.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.FeedsAccountsConfigureAsync(new FeedsAccountsConfigureBankRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FeedsAccountsConfigureBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">FeedsSyncAsync</a>(FeedsSyncBankRequest { ... }) -> WithRawResponseTask&lt;FeedsSyncBankResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Fetches the transactions of every linked bank-feed account of the connection, or of `feedAccountId` alone, from `dateFrom` (default: seven days before the last sync, else the `syncFrom` of the account, else 90 days back) to `dateTo`, and inserts the new ones into the linked ledger bank account; lines already there count as `skipped`. An import template set on the account is applied as in `bank/statements/import`. Answers 409 when the connection is not active or has no session, and when the bank returns more than 20 pages for the range (keep `dateFrom` and set an earlier `dateTo`). A provider failure is written to the `error` of the connection, and one that is not retryable sets its status to error. The outcome is announced as `bank_feed.synced`, and invoices the template issues as `sale_invoice.issued`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.FeedsSyncAsync(new FeedsSyncBankRequest { ConnectionId = "connectionId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FeedsSyncBankRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## files
<details><summary><code>client.Files.<a href="/src/NordletApi/Files/FilesClient.cs">UploadAsync</a>(UploadFilesRequest { ... }) -> WithRawResponseTask&lt;UploadFilesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Store a base64-encoded file of up to 10 MB (413 above that) under an `entity` and optional `entityId`, and return its record with the SHA-256 of the content and its `storageKey`, which other calls take as `documentRef`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Files.UploadAsync(
    new UploadFilesRequest
    {
        Entity = "entity",
        FileName = "fileName",
        MimeType = "mimeType",
        Content = "content",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UploadFilesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Files.<a href="/src/NordletApi/Files/FilesClient.cs">GetAsync</a>(GetFilesRequest { ... }) -> WithRawResponseTask&lt;GetFilesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return a file record with its content, base64-encoded.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Files.GetAsync(new GetFilesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetFilesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Files.<a href="/src/NordletApi/Files/FilesClient.cs">ListAsync</a>(ListFilesRequest { ... }) -> WithRawResponseTask&lt;ListFilesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the company's files. Filterable by `entity`, `entityId` and `fileName`; sortable by `createdAt`, `fileName` and `sizeBytes`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Files.ListAsync(new ListFilesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListFilesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Files.<a href="/src/NordletApi/Files/FilesClient.cs">DeleteAsync</a>(DeleteFilesRequest { ... }) -> WithRawResponseTask&lt;DeleteFilesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a file record and its stored content.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Files.DeleteAsync(new DeleteFilesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteFilesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## reports
<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">TrialBalanceAsync</a>(TrialBalanceReportsRequest { ... }) -> WithRawResponseTask&lt;TrialBalanceReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Trial balance of the posted ledger for a period: for every account with an opening balance or movement, the balance before `fromDate`, the debit and credit turnover between `fromDate` and `toDate`, and the closing balance, with debit and credit totals. Template account names follow the `Accept-Language` header.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.TrialBalanceAsync(
    new TrialBalanceReportsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TrialBalanceReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">SizeCategoryAsync</a>(SizeCategoryReportsRequest { ... }) -> WithRawResponseTask&lt;SizeCategoryReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Classify the company's size for a calendar year as micro, small, medium or large from total assets at the year end, the net turnover of the year and the average number of employees under employment contracts, against the limits returned in `thresholds`; a category applies when at least two of its three limits are met. This is the default category of `reports/financial-statements`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.SizeCategoryAsync(new SizeCategoryReportsRequest { Year = 1000000 });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SizeCategoryReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">FinancialStatementsAsync</a>(FinancialStatementsReportsRequest { ... }) -> WithRawResponseTask&lt;FinancialStatementsReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Balance sheet at `toDate` and profit and loss for the period from the posted ledger, year-end closing entries excluded, laid out by size category: `category` when given, else the one `reports/size-category` derives for the period. Micro gets the short balance sheet and profit and loss; the other categories add the balance sheet and profit and loss detail; medium and large also get the changes in equity and a cash flow summary. Line groupings follow the company's chart template.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.FinancialStatementsAsync(
    new FinancialStatementsReportsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FinancialStatementsReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">GeneralJournalAsync</a>(GeneralJournalReportsRequest { ... }) -> WithRawResponseTask&lt;GeneralJournalReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Posted journal transactions of a period in date order, each with its lines (account, debit, credit), paged with `page` and `pageSize` and the total count. Template account names follow the `Accept-Language` header.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.GeneralJournalAsync(
    new GeneralJournalReportsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GeneralJournalReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">GlDetailAsync</a>(GlDetailReportsRequest { ... }) -> WithRawResponseTask&lt;GlDetailReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Ledger card of one account for a period: the opening balance before `fromDate`, every posted line in date order with a running balance, and the closing balance.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.GlDetailAsync(
    new GlDetailReportsRequest
    {
        AccountCode = "accountCode",
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GlDetailReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PartnerBalancesAsync</a>(PartnerBalancesReportsRequest { ... }) -> WithRawResponseTask&lt;PartnerBalancesReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Open balance per partner: receivables from issued sale invoices and payables from registered purchase invoices that are not fully paid, credit notes reducing the balance, converted to the base currency at the document rate, with totals.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PartnerBalancesAsync(new PartnerBalancesReportsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PartnerBalancesReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">DebtAgingAsync</a>(DebtAgingReportsRequest { ... }) -> WithRawResponseTask&lt;DebtAgingReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Ageing of the open receivables or payables (`side`) at `asOf` (default the company's current date) per partner: not yet due, 1 to 30, 31 to 60, 61 to 90 and over 90 days past the due date. Counts documents dated on or before `asOf` and payments made up to that date.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.DebtAgingAsync(new DebtAgingReportsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DebtAgingReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">MonthlySummaryAsync</a>(MonthlySummaryReportsRequest { ... }) -> WithRawResponseTask&lt;MonthlySummaryReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

One row per calendar month for the last `months` months ending with the current one: the receivable and payable balances at the end of the month and the revenue, expenses and net result posted in it, year-end closing entries excluded.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.MonthlySummaryAsync(new MonthlySummaryReportsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MonthlySummaryReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">StockBalanceAsync</a>(StockBalanceReportsRequest { ... }) -> WithRawResponseTask&lt;StockBalanceReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Quantity and value on hand per item and warehouse at `asOf`, summed from the stock movements dated on or before it; `warehouseId` limits the report to one warehouse. Rows with zero quantity and zero value are left out.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.StockBalanceAsync(
    new StockBalanceReportsRequest { AsOf = new DateOnly(2026, 7, 1) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StockBalanceReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">StockMovementAsync</a>(StockMovementReportsRequest { ... }) -> WithRawResponseTask&lt;StockMovementReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Stock movement per item for a period: opening quantity and value before `fromDate`, quantities and values received and issued between `fromDate` and `toDate`, and the closing figures; `warehouseId` and `itemId` narrow the report.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.StockMovementAsync(
    new StockMovementReportsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StockMovementReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">VatSummaryAsync</a>(VatSummaryReportsRequest { ... }) -> WithRawResponseTask&lt;VatSummaryReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

VAT of issued sale invoices (by issue date) or registered purchase invoices (by registration date) in a period, summed per VAT rate: net, VAT and gross in the base currency and the number of documents, credit notes counting negative. The rows of `reports/vat-detail` grouped by rate.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.VatSummaryAsync(
    new VatSummaryReportsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VatSummaryReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">CashFlowAsync</a>(CashFlowReportsRequest { ... }) -> WithRawResponseTask&lt;CashFlowReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Cash flow statement of a period from the posted transactions that touch a cash account: the inflow and outflow of every counterpart account, grouped into operating, investing and financing by the account prefixes of the company's chart template, with opening and closing cash and `balanced` telling whether opening cash plus the net change equals closing cash. Template account names follow the `Accept-Language` header.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.CashFlowAsync(
    new CashFlowReportsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CashFlowReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">StockAgingAsync</a>(StockAgingReportsRequest { ... }) -> WithRawResponseTask&lt;StockAgingReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Age of the stock on hand at `asOf` per item and warehouse: the remaining quantity and value of each FIFO receipt layer, bucketed by days since the receipt (0 to 30, 31 to 60, 61 to 90, over 90), with totals; `warehouseId` limits the report to one warehouse. When movements after `asOf` exist, the layers are rebuilt by replaying the movements up to that date.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.StockAgingAsync(
    new StockAgingReportsRequest { AsOf = new DateOnly(2026, 7, 1) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StockAgingReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">StockShortageAsync</a>(StockShortageReportsRequest { ... }) -> WithRawResponseTask&lt;StockShortageReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Items whose reserved quantity exceeds the quantity on hand, per warehouse: on hand, reserved and the shortage. Only items with a reservation are checked; `warehouseId` limits the report to one warehouse.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.StockShortageAsync(new StockShortageReportsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StockShortageReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">SieAsync</a>(SieReportsRequest { ... }) -> WithRawResponseTask&lt;SieReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Export the ledger of one financial year as an SIE file (the Swedish standard accounting interchange format, specification 4B). The file carries the chart of accounts, the opening and closing balance of every balance sheet account and the turnover of every result account for the year and the year before it, and, when asked for, every posted voucher of the year with its lines. Cost centres travel as dimension 1 and projects as dimension 6. Services that build a Swedish annual report read this file.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.SieAsync(
    new SieReportsRequest { FromDate = new DateOnly(2026, 7, 1), ToDate = new DateOnly(2026, 7, 1) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SieReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">DatevAsync</a>(DatevReportsRequest { ... }) -> WithRawResponseTask&lt;DatevReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Export the posted ledger of a period as a DATEV Buchungsstapel file (DATEV format, category 21, version 700). Every transaction becomes one or more bookings of an amount between an account and a contra account; a transaction with more than two lines is split into pairs whose totals match it. The file is semicolon separated and written in the Windows-1252 character set DATEV expects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.DatevAsync(
    new DatevReportsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DatevReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">FecAsync</a>(FecReportsRequest { ... }) -> WithRawResponseTask&lt;FecReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Export the posted ledger of a period as a French FEC file (fichier des écritures comptables, order of 29 July 2013). One line per journal entry line, with the eighteen fields the order names, in their order, after a header line. Tab separated, UTF-8, comma as the decimal separator.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.FecAsync(
    new FecReportsRequest { FromDate = new DateOnly(2026, 7, 1), ToDate = new DateOnly(2026, 7, 1) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FecReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">EuPurchasesAsync</a>(EuPurchasesReportsRequest { ... }) -> WithRawResponseTask&lt;EuPurchasesReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Registered purchase invoices of a period (by registration date) from partners in another EU country, summed per partner country and VAT rate: net and VAT in the base currency and the number of documents, credit notes counting negative. The partner's country is the country code of its address, else the first two characters of its VAT number.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.EuPurchasesAsync(
    new EuPurchasesReportsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EuPurchasesReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">VatDetailAsync</a>(VatDetailReportsRequest { ... }) -> WithRawResponseTask&lt;VatDetailReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

VAT of issued sale invoices (by issue date) or registered purchase invoices (by registration date) in a period, one row per document and VAT rate: net, VAT and gross in the base currency, with totals; credit notes count negative. `reports/vat-summary` groups these rows by rate.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.VatDetailAsync(
    new VatDetailReportsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VatDetailReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PosSalesAsync</a>(PosSalesReportsRequest { ... }) -> WithRawResponseTask&lt;PosSalesReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

POS reports of a period (by report date): per report the net, VAT, gross, cash and card amounts and the cost of goods sold, the net and VAT per VAT rate across the reports, and totals.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PosSalesAsync(
    new PosSalesReportsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PosSalesReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">OnlineSalesAsync</a>(OnlineSalesReportsRequest { ... }) -> WithRawResponseTask&lt;OnlineSalesReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Sales orders created in a period, grouped by channel and currency: the number of orders, how many are fulfilled, cancelled or still open (new or reserved), and the net and gross of the orders that are not cancelled, computed from their lines.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.OnlineSalesAsync(
    new OnlineSalesReportsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OnlineSalesReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">OssAsync</a>(OssReportsRequest { ... }) -> WithRawResponseTask&lt;OssReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Issued sale invoices and credit notes of a period (by issue date) to partners in another EU country, summed per partner country and VAT rate: net and VAT in the base currency and the number of documents. The partner's country is the country code of its address, else the first two characters of its VAT number.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.OssAsync(
    new OssReportsRequest { FromDate = new DateOnly(2026, 7, 1), ToDate = new DateOnly(2026, 7, 1) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OssReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">AdvanceReconciliationAsync</a>(AdvanceReconciliationReportsRequest { ... }) -> WithRawResponseTask&lt;AdvanceReconciliationReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Cash advances per employee for a period: the balance before `fromDate`, the advances paid out and returned through cash orders in the period, the amount settled by expense reports dated in the period, and the closing balance. A cash order counts as an advance when it names an employee and its counter account is the `cash.advances` posting rule.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.AdvanceReconciliationAsync(
    new AdvanceReconciliationReportsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AdvanceReconciliationReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">WriteOffActsAsync</a>(WriteOffActsReportsRequest { ... }) -> WithRawResponseTask&lt;WriteOffActsReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Stock issued by write-offs and stock takes in a period: one row per outgoing movement with item, warehouse, quantity, cost and notes, and the total cost; `warehouseId` limits the report to one warehouse.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.WriteOffActsAsync(
    new WriteOffActsReportsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WriteOffActsReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">CostCentersAsync</a>(CostCentersReportsRequest { ... }) -> WithRawResponseTask&lt;CostCentersReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Income, expenses and result per cost centre for a period, from the posted journal lines assigned to a cost centre.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.CostCentersAsync(
    new CostCentersReportsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CostCentersReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">CostCenterActivityAsync</a>(CostCenterActivityReportsRequest { ... }) -> WithRawResponseTask&lt;CostCenterActivityReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Posted journal lines of one cost centre for a period, summed per account: debit, credit and net. Template account names follow the `Accept-Language` header.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.CostCenterActivityAsync(
    new CostCenterActivityReportsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
        CostCenterId = "costCenterId",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CostCenterActivityReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">CostCenterItemsAsync</a>(CostCenterItemsReportsRequest { ... }) -> WithRawResponseTask&lt;CostCenterItemsReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Net purchases per cost centre and item for a period, from the lines of registered purchase invoices (by registration date) that carry a cost centre, credit notes counting negative; `costCenterId` limits the report to one cost centre. A line without an item is reported under its description.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.CostCenterItemsAsync(
    new CostCenterItemsReportsRequest
    {
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CostCenterItemsReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">JobsCreateAsync</a>(JobsCreateReportsRequest { ... }) -> WithRawResponseTask&lt;JobsCreateReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Queue a report to be built in the background in one or more formats (`json`, `xlsx`, `pdf`) and stored as files; the job is returned at once with status `queued`. `reportType` is one of trial-balance, partner-balances, debt-aging, stock-balance, vat-summary, vat-detail, eu-purchases, oss, pos-sales, online-sales, advance-reconciliation, write-off-acts, cost-centers, cost-center-activity, cost-center-items and cash-flow, and `params` is the body of that report route; an unknown type or invalid params are refused with 422. Follow the job with `reports/jobs/get`, download its outputs with `files/get`, and listen for `report.completed` or `report.failed`; a report that does not finish within ten minutes fails.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.JobsCreateAsync(new JobsCreateReportsRequest { ReportType = "reportType" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `JobsCreateReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">JobsGetAsync</a>(JobsGetReportsRequest { ... }) -> WithRawResponseTask&lt;JobsGetReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one report job with its status (`queued`, `running`, `completed` or `failed`), the error of a failed job and the output files of a completed one.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.JobsGetAsync(new JobsGetReportsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `JobsGetReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">JobsListAsync</a>(JobsListReportsRequest { ... }) -> WithRawResponseTask&lt;JobsListReportsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the company's report jobs, newest first; filterable by `status` and `reportType`, sortable by `createdAt`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.JobsListAsync(new JobsListReportsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `JobsListReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## consolidation
<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">GroupsCreateAsync</a>(GroupsCreateConsolidationRequest { ... }) -> WithRawResponseTask&lt;GroupsCreateConsolidationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a consolidation group owned by the calling company; `presentationCurrency` defaults to the company's base currency. Members are added with `consolidation/members/add`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.GroupsCreateAsync(
    new GroupsCreateConsolidationRequest { Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GroupsCreateConsolidationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">GroupsListAsync</a>(GroupsListConsolidationRequest { ... }) -> WithRawResponseTask&lt;GroupsListConsolidationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the calling company's consolidation groups with their member counts.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.GroupsListAsync(new GroupsListConsolidationRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GroupsListConsolidationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">GroupsGetAsync</a>(GroupsGetConsolidationRequest { ... }) -> WithRawResponseTask&lt;GroupsGetConsolidationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return one consolidation group with its members, each with its ownership percentage and consolidation method.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.GroupsGetAsync(
    new GroupsGetConsolidationRequest { GroupId = "groupId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GroupsGetConsolidationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">GroupsUpdateAsync</a>(GroupsUpdateConsolidationRequest { ... }) -> WithRawResponseTask&lt;GroupsUpdateConsolidationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Rename a consolidation group or change its presentation currency.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.GroupsUpdateAsync(
    new GroupsUpdateConsolidationRequest { GroupId = "groupId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GroupsUpdateConsolidationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">GroupsDeleteAsync</a>(GroupsDeleteConsolidationRequest { ... }) -> WithRawResponseTask&lt;GroupsDeleteConsolidationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a consolidation group.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.GroupsDeleteAsync(
    new GroupsDeleteConsolidationRequest { GroupId = "groupId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GroupsDeleteConsolidationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">MembersAddAsync</a>(MembersAddConsolidationRequest { ... }) -> WithRawResponseTask&lt;MembersAddConsolidationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a company to a consolidation group with its ownership percentage and method (`full`, `proportional` or `equity`), or change those of an existing member. Another company can be added only by a signed-in user who is owner, admin or accountant of it; an API key is refused with 403.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.MembersAddAsync(
    new MembersAddConsolidationRequest { GroupId = "groupId", MemberCompanyId = "memberCompanyId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MembersAddConsolidationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">MembersRemoveAsync</a>(MembersRemoveConsolidationRequest { ... }) -> WithRawResponseTask&lt;MembersRemoveConsolidationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove a company from a consolidation group.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.MembersRemoveAsync(
    new MembersRemoveConsolidationRequest
    {
        GroupId = "groupId",
        MemberCompanyId = "memberCompanyId",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MembersRemoveConsolidationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">IntercompanyCandidatesAsync</a>(IntercompanyCandidatesConsolidationRequest { ... }) -> WithRawResponseTask&lt;IntercompanyCandidatesConsolidationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Partners in member companies that look like other members of the same group (matched on company code or VAT code), with any existing intercompany link. Confirming a candidate via intercompany/links/set enables invoice mirroring.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.IntercompanyCandidatesAsync(
    new IntercompanyCandidatesConsolidationRequest { GroupId = "groupId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IntercompanyCandidatesConsolidationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">IntercompanyLinksSetAsync</a>(IntercompanyLinksSetConsolidationRequest { ... }) -> WithRawResponseTask&lt;IntercompanyLinksSetConsolidationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Confirm that a partner record in one member company represents another member company of the group. Once links exist in both directions, issuing an intercompany sale invoice automatically creates the matching draft purchase invoice in the counterparty.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.IntercompanyLinksSetAsync(
    new IntercompanyLinksSetConsolidationRequest
    {
        GroupId = "groupId",
        PartnerId = "partnerId",
        CounterpartyCompanyId = "counterpartyCompanyId",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IntercompanyLinksSetConsolidationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">IntercompanyLinksListAsync</a>(IntercompanyLinksListConsolidationRequest { ... }) -> WithRawResponseTask&lt;IntercompanyLinksListConsolidationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the intercompany links of a group: which partner record of which member company stands for which other member company.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.IntercompanyLinksListAsync(
    new IntercompanyLinksListConsolidationRequest { GroupId = "groupId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IntercompanyLinksListConsolidationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">IntercompanyLinksRemoveAsync</a>(IntercompanyLinksRemoveConsolidationRequest { ... }) -> WithRawResponseTask&lt;IntercompanyLinksRemoveConsolidationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove an intercompany link from a group.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.IntercompanyLinksRemoveAsync(
    new IntercompanyLinksRemoveConsolidationRequest { GroupId = "groupId", Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IntercompanyLinksRemoveConsolidationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">IntercompanyReportAsync</a>(IntercompanyReportConsolidationRequest { ... }) -> WithRawResponseTask&lt;IntercompanyReportConsolidationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Intercompany reconciliation for a period: every issued intercompany sale invoice with its mirrored or manually recorded counterpart, unmatched documents on both sides, and per-currency totals with differences. Confirmed pairs are the basis for consolidation eliminations.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.IntercompanyReportAsync(
    new IntercompanyReportConsolidationRequest
    {
        GroupId = "groupId",
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IntercompanyReportConsolidationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">ReportAsync</a>(ReportConsolidationRequest { ... }) -> WithRawResponseTask&lt;ReportConsolidationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Consolidated financial statements of a group for a period in its presentation currency, with the consolidated trial balance and cash flow, each member's contribution and the intercompany candidates. Each member's balances are translated at the group owner's exchange rates of `toDate` and taken in full, in proportion to the ownership (`proportional`) or as an equity-method investment (`equity`); a fully consolidated member held below 100 % yields the non-controlling interest, and `eliminations` are amounts added to account codes before the statements are assembled (`balanced` tells whether they net to zero). Refused with 422 when the group has no members.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.ReportAsync(
    new ReportConsolidationRequest
    {
        GroupId = "groupId",
        FromDate = new DateOnly(2026, 7, 1),
        ToDate = new DateOnly(2026, 7, 1),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReportConsolidationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## public
<details><summary><code>client.Public.<a href="/src/NordletApi/Public/PublicClient.cs">IntegrationRequestsAsync</a>(IntegrationRequestsPublicRequest { ... }) -> WithRawResponseTask&lt;IntegrationRequestsPublicResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Store a request for an integration: the integration asked for and the sender's name, company, e-mail and details. When `website` is filled in, the call answers `received` without storing anything.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Public.IntegrationRequestsAsync(
    new IntegrationRequestsPublicRequest
    {
        Integration = "integration",
        Name = "name",
        Email = "email",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IntegrationRequestsPublicRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Public.<a href="/src/NordletApi/Public/PublicClient.cs">PayAsync</a>(PayPublicRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Redirect (302) to the company's payment page for the issued invoice that carries this payment token, rendered from the template set with `sales/invoices/payment-settings/update` with the invoice number, the amount still unpaid, the currency, the token, the invoice id and the customer name (see `sales/invoices/payment-link`). Answers 404 when the token matches no issued invoice, the invoice has `payLinkEnabled` false or the company has no template, and 409 when the invoice is already paid.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Public.PayAsync(new PayPublicRequest { Token = "token" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PayPublicRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Public.<a href="/src/NordletApi/Public/PublicClient.cs">InvoicesGetAsync</a>(InvoicesGetPublicRequest { ... }) -> WithRawResponseTask&lt;InvoicesGetPublicResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the issued sale document that carries this customer token (`token` of `sales/invoices/view`), in the shape of `sales/invoices/view` without the token. Answers 404 when the token matches no issued document.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Public.InvoicesGetAsync(new InvoicesGetPublicRequest { Token = "token" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesGetPublicRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Public.<a href="/src/NordletApi/Public/PublicClient.cs">InvoicesCheckoutAsync</a>(InvoicesCheckoutPublicRequest { ... }) -> WithRawResponseTask&lt;InvoicesCheckoutPublicResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Open a Stripe Checkout page on the company's connected Stripe account for the amount still unpaid on the issued invoice that carries this customer token, and return its `url`. Stripe sends the customer back to the public invoice page. Answers 404 when the token matches no issued invoice, the invoice has `payLinkEnabled` false or the company has no Stripe account that can take charges, 409 when the invoice is already paid and 422 when Stripe cannot take the amount in the invoice currency.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Public.InvoicesCheckoutAsync(new InvoicesCheckoutPublicRequest { Token = "token" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesCheckoutPublicRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Public.<a href="/src/NordletApi/Public/PublicClient.cs">InvoicesPdfAsync</a>(InvoicesPdfPublicRequest { ... }) -> WithRawResponseTask&lt;InvoicesPdfPublicResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the PDF of the issued sale document that carries this customer token, base64-encoded, as `sales/invoices/pdf` renders it in the document's own language, English when it has none. Answers 404 when the token matches no issued document.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Public.InvoicesPdfAsync(new InvoicesPdfPublicRequest { Token = "token" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvoicesPdfPublicRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## billing
<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">AccountGetAsync</a>(AccountGetBillingRequest { ... }) -> WithRawResponseTask&lt;AccountGetBillingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the signed-in user's billing account: plan, account type, status, balance, trial and payment state, the month-to-date usage of the companies the user pays for with an estimate of today's charge, the plan catalogue, and the top-up, automatic top-up and overdraft settings.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.AccountGetAsync(new AccountGetBillingRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AccountGetBillingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">AccountSetPlanAsync</a>(AccountSetPlanBillingRequest { ... }) -> WithRawResponseTask&lt;AccountSetPlanBillingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change the plan of the user's flat-rate billing account; answers 409 when the account type is not `flat_rate`. With a Stripe subscription and payments configured, the subscription is moved to the new plan.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.AccountSetPlanAsync(
    new AccountSetPlanBillingRequest { Plan = AccountSetPlanBillingRequestPlan.Starter }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AccountSetPlanBillingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">AccountSetAccountTypeAsync</a>(AccountSetAccountTypeBillingRequest { ... }) -> WithRawResponseTask&lt;AccountSetAccountTypeBillingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Switch the user's billing account between `flat_rate` and `per_request`. With a Stripe subscription and payments configured, the subscription is moved to the plan's price for `flat_rate`; for `per_request` the plan is taken off the subscription, and a subscription that carried only the plan is cancelled, leaving the account without one. When Stripe refuses the change, the previous account type is restored.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.AccountSetAccountTypeAsync(
    new AccountSetAccountTypeBillingRequest
    {
        AccountType = AccountSetAccountTypeBillingRequestAccountType.FlatRate,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AccountSetAccountTypeBillingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">AccountSetAutoTopUpAsync</a>(AccountSetAutoTopUpBillingRequest { ... }) -> WithRawResponseTask&lt;AccountSetAutoTopUpBillingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Switch automatic top-ups on or off and set their amount. Switching them on needs a Stripe customer, which the first card top-up creates (400 otherwise); when switched on, a top-up is charged at once if the balance is at or below zero, no payment has failed and no top-up was requested in the last 24 hours.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.AccountSetAutoTopUpAsync(
    new AccountSetAutoTopUpBillingRequest { Enabled = true, AmountCents = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AccountSetAutoTopUpBillingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">AccountSetOverdraftCapAsync</a>(AccountSetOverdraftCapBillingRequest { ... }) -> WithRawResponseTask&lt;AccountSetOverdraftCapBillingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Set the overdraft cap of the user's billing account: how far usage charges may take the balance below zero before the account is suspended. A suspended account whose balance is within the new cap is activated again.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.AccountSetOverdraftCapAsync(
    new AccountSetOverdraftCapBillingRequest { CapCents = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AccountSetOverdraftCapBillingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">TopupCreateAsync</a>(TopupCreateBillingRequest { ... }) -> WithRawResponseTask&lt;TopupCreateBillingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Open a Stripe Checkout session for a one-time credit top-up of `amountCents` and return its URL; a Stripe customer is created for the user when there is none. `returnTo` chooses whether Checkout returns to the credits page or to the onboarding plan page, in `locale`. Answers 503 when online payments are not configured.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.TopupCreateAsync(new TopupCreateBillingRequest { AmountCents = 1000000 });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TopupCreateBillingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">TopupConfirmAsync</a>(TopupConfirmBillingRequest { ... }) -> WithRawResponseTask&lt;TopupConfirmBillingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Confirm a paid top-up Checkout session by `sessionId` and credit the account at once instead of waiting for the Stripe webhook; a session is credited only once. Answers 404 when the session is not the user's own or is not paid.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.TopupConfirmAsync(new TopupConfirmBillingRequest { SessionId = "sessionId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TopupConfirmBillingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">FlatRateCreateAsync</a>(FlatRateCreateBillingRequest { ... }) -> WithRawResponseTask&lt;FlatRateCreateBillingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Open a Stripe Checkout session for a flat-rate subscription on `plan`, with the trial period of `trialDays` days, and return its URL; a Stripe customer is created for the user when there is none. The `invoicing` plan of the invoice tool takes its trial days from the server setting `INVOICE_PLAN_TRIAL_DAYS` and returns to the invoice app. Answers 409 when a flat-rate subscription is already active and 503 when online payments are not configured, the plan has no price, or the Invoicing trial is not set.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.FlatRateCreateAsync(new FlatRateCreateBillingRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FlatRateCreateBillingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">FlatRateConfirmAsync</a>(FlatRateConfirmBillingRequest { ... }) -> WithRawResponseTask&lt;FlatRateConfirmBillingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Confirm a completed flat-rate Checkout session by `sessionId`: the account becomes `flat_rate` on the session's plan with status `active` and the subscription attached, unless the Stripe webhook already did this. Answers 404 when the session is not the user's own or not completed.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.FlatRateConfirmAsync(
    new FlatRateConfirmBillingRequest { SessionId = "sessionId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FlatRateConfirmBillingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">SubscriptionCancelAsync</a>(SubscriptionCancelBillingRequest { ... }) -> WithRawResponseTask&lt;SubscriptionCancelBillingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Cancel the user's Stripe subscription at the end of the period already paid: the plan stays active until `subscriptionCancelAt`, and Stripe then ends the subscription, which its `customer.subscription.deleted` webhook records. Answers 503 when online payments are not configured and 409 when the account has no subscription.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.SubscriptionCancelAsync(new SubscriptionCancelBillingRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SubscriptionCancelBillingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">PortalCreateAsync</a>(PortalCreateBillingRequest { ... }) -> WithRawResponseTask&lt;PortalCreateBillingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Open a Stripe customer portal session that returns to the credits page in `locale`, and return its URL. Answers 503 when online payments are not configured and 400 when the user has no Stripe customer yet.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.PortalCreateAsync(new PortalCreateBillingRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PortalCreateBillingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">TransactionsListAsync</a>(TransactionsListBillingRequest { ... }) -> WithRawResponseTask&lt;TransactionsListBillingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the newest credit transactions of the user's billing account, up to `limit`: trial grants, top-ups, usage charges, activations and adjustments, each with the balance after it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.TransactionsListAsync(new TransactionsListBillingRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TransactionsListBillingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">UsageListAsync</a>(UsageListBillingRequest { ... }) -> WithRawResponseTask&lt;UsageListBillingResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the daily usage records of the companies the user pays for, from `from` to `to`: one row per company, date and metric (API requests, OCR pages, file storage bytes, database bytes, sale invoices).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.UsageListAsync(
    new UsageListBillingRequest { From = new DateOnly(2026, 7, 1), To = new DateOnly(2026, 7, 1) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UsageListBillingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## account
<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">LoginLinkRequestAsync</a>(LoginLinkRequestAccountRequest { ... }) -> WithRawResponseTask&lt;LoginLinkRequestAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a sign-in link for the e-mail address and send it; the link is valid for 15 minutes and is consumed with `account/login-link/consume`. When an unused link was requested for the same address within the last minute, the call answers `sent` without sending another. `locale` sets the language of the e-mail and of the link; `app` set to `invoice` makes the link open the invoice app instead of the Nordlet app; `acceptTerms`, `acceptDpa` and `referralCode` are stored with the link and used when the address has no account yet.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.LoginLinkRequestAsync(new LoginLinkRequestAccountRequest { Email = "email" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LoginLinkRequestAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">LoginLinkConsumeAsync</a>(LoginLinkConsumeAccountRequest { ... }) -> WithRawResponseTask&lt;LoginLinkConsumeAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Exchange a sign-in link token for a session; an unknown, used or expired token is refused with 401. When no account has the address, one is created (`isNewUser`), which is refused with 422 unless the link was requested with `acceptTerms` and `acceptDpa`; a `referralCode` on the link records who referred the new user. A link from `account/email/change-request` changes the signed-in user's address instead, refused with 409 when another account has it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.LoginLinkConsumeAsync(new LoginLinkConsumeAccountRequest { Token = "token" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LoginLinkConsumeAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">LogoutAsync</a>(LogoutAccountRequest { ... }) -> WithRawResponseTask&lt;LogoutAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete the session the call was made with.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.LogoutAsync(new LogoutAccountRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LogoutAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">MeAsync</a>(MeAccountRequest { ... }) -> WithRawResponseTask&lt;MeAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the signed-in user, their active company and role in it, the companies they belong to and their consent state. `billing` is the billing account that pays for the active company (its payer, or the user when there is none or no company), with `isPayer` saying whether that is the user; `referralPoints` is the user's current points balance.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.MeAsync(new MeAccountRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MeAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">MembersListAsync</a>(MembersListAccountRequest { ... }) -> WithRawResponseTask&lt;MembersListAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the members of the active company with their role.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.MembersListAsync(new MembersListAccountRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MembersListAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">MembersSetRoleAsync</a>(MembersSetRoleAccountRequest { ... }) -> WithRawResponseTask&lt;MembersSetRoleAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change the role of a member of the active company; owners and admins may call it. Refused with 422 for the caller's own role and with 403 for the owner's, which only `account/members/transfer-ownership` changes.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.MembersSetRoleAsync(
    new MembersSetRoleAccountRequest
    {
        UserId = "userId",
        Role = MembersSetRoleAccountRequestRole.Admin,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MembersSetRoleAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">MembersTransferOwnershipAsync</a>(MembersTransferOwnershipAccountRequest { ... }) -> WithRawResponseTask&lt;MembersTransferOwnershipAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Make another member the owner of the active company; the caller must be its owner and becomes an admin. Refused with 422 when `userId` is the caller. With `movePayer` the company's billing also moves to the new owner, which only the member currently paying for it may do (403).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.MembersTransferOwnershipAsync(
    new MembersTransferOwnershipAccountRequest { UserId = "userId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MembersTransferOwnershipAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">MembersRemoveAsync</a>(MembersRemoveAccountRequest { ... }) -> WithRawResponseTask&lt;MembersRemoveAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove a member from the active company; owners and admins may call it. Their sessions lose this company as the active one and the API keys they created for it are revoked. Refused with 422 for the caller themself and with 403 for the owner.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.MembersRemoveAsync(new MembersRemoveAccountRequest { UserId = "userId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MembersRemoveAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">InvitesCreateAsync</a>(InvitesCreateAccountRequest { ... }) -> WithRawResponseTask&lt;InvitesCreateAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create an invitation to the active company for an e-mail address with the given role and send it by e-mail in `locale`; owners and admins may call it. The invitation is valid for 7 days and replaces an earlier pending one for the same address. Refused with 409 when the address already belongs to a member.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.InvitesCreateAsync(
    new InvitesCreateAccountRequest
    {
        Email = "email",
        Role = InvitesCreateAccountRequestRole.Admin,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvitesCreateAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">InvitesListAsync</a>(InvitesListAccountRequest { ... }) -> WithRawResponseTask&lt;InvitesListAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the pending invitations of the active company; `expired` marks those past their expiry.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.InvitesListAsync(new InvitesListAccountRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvitesListAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">InvitesRevokeAsync</a>(InvitesRevokeAccountRequest { ... }) -> WithRawResponseTask&lt;InvitesRevokeAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a pending invitation of the active company.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.InvitesRevokeAsync(new InvitesRevokeAccountRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvitesRevokeAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">InvitesGetAsync</a>(InvitesGetAccountRequest { ... }) -> WithRawResponseTask&lt;InvitesGetAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Read a pending invitation by its token: the invited address, role and company name, whether it has expired and whether an account with that address already exists (`userExists`), in which case `account/invites/accept` must be called signed in as that account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.InvitesGetAsync(new InvitesGetAccountRequest { Token = "token" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvitesGetAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">InvitesAcceptAsync</a>(InvitesAcceptAccountRequest { ... }) -> WithRawResponseTask&lt;InvitesAcceptAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Accept an invitation and return a session with the invited company active. When the address has no account, one is created with `name` and `locale`, which is refused with 422 unless `acceptTerms` and `acceptDpa` are true; when it has one, the call must be made signed in as that account (401 otherwise). An expired invitation is refused with 422.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.InvitesAcceptAsync(new InvitesAcceptAccountRequest { Token = "token" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvitesAcceptAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">LocaleSetAsync</a>(LocaleSetAccountRequest { ... }) -> WithRawResponseTask&lt;LocaleSetAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Set the user's language: with an active company it is stored on their membership of that company (`scope` = `membership`), otherwise on the user (`scope` = `user`).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.LocaleSetAsync(
    new LocaleSetAccountRequest { Locale = LocaleSetAccountRequestLocale.En }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LocaleSetAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">CompaniesCreateAsync</a>(CompaniesCreateAccountRequest { ... }) -> WithRawResponseTask&lt;CompaniesCreateAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a company with the caller as its owner and payer, seed its chart of accounts from the template of `countryCode`, and make it the active company of the session. `timeZone` defaults to the country's, `isVatPayer` to true and `defaultInvoiceCurrency` to the base currency. Refused with 422 when `baseCurrency` is not a supported currency.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.CompaniesCreateAsync(new CompaniesCreateAccountRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CompaniesCreateAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">CompaniesSelectAsync</a>(CompaniesSelectAccountRequest { ... }) -> WithRawResponseTask&lt;CompaniesSelectAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Make one of the caller's companies the active company of the session. Refused with 403 when the caller is not a member and with 422 when the company is archived or deleted.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.CompaniesSelectAsync(
    new CompaniesSelectAccountRequest { CompanyId = "companyId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CompaniesSelectAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">CompaniesProfileAsync</a>(CompaniesProfileAccountRequest { ... }) -> WithRawResponseTask&lt;CompaniesProfileAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the profile of the active company.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.CompaniesProfileAsync(new CompaniesProfileAccountRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CompaniesProfileAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">CompaniesUpdateAsync</a>(CompaniesUpdateAccountRequest { ... }) -> WithRawResponseTask&lt;CompaniesUpdateAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change the profile of the active company; owners and admins may call it. Only the fields sent are changed, and the nullable ones can be sent as null to clear them. `logo` stores a base64-encoded image as a file of the company and sets `logoFileId`. The country, base currency, sandbox flag and cash-basis flag are fixed at creation.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.CompaniesUpdateAsync(new CompaniesUpdateAccountRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CompaniesUpdateAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">CompaniesArchiveAsync</a>(CompaniesArchiveAccountRequest { ... }) -> WithRawResponseTask&lt;CompaniesArchiveAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Set the company named by `companyId` to `archived`; the caller must be its owner. Every session that had it active loses it. Refused with 409 unless the company is active; `account/companies/activate` reverses it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.CompaniesArchiveAsync(
    new CompaniesArchiveAccountRequest { CompanyId = "companyId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CompaniesArchiveAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">CompaniesDeleteAsync</a>(CompaniesDeleteAccountRequest { ... }) -> WithRawResponseTask&lt;CompaniesDeleteAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Set the company named by `companyId` to `deleted`; the caller must be its owner, and every session that had it active loses it. A sandbox company is purged at once; any other is purged by the scheduled purge after `purgeAfter` (10 days) and can be restored until then with `account/companies/activate`. Refused with 409 when it is already deleted.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.CompaniesDeleteAsync(
    new CompaniesDeleteAccountRequest { CompanyId = "companyId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CompaniesDeleteAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">CompaniesActivateAsync</a>(CompaniesActivateAccountRequest { ... }) -> WithRawResponseTask&lt;CompaniesActivateAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Set an archived or deleted company named by `companyId` back to `active`; the caller must be its owner. Refused with 409 when it is already active.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.CompaniesActivateAsync(
    new CompaniesActivateAccountRequest { CompanyId = "companyId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CompaniesActivateAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">ApiKeysCreateAsync</a>(ApiKeysCreateAccountRequest { ... }) -> WithRawResponseTask&lt;ApiKeysCreateAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create an API key for the active company and return the key itself once; owners, admins and developers may call it. `scopes` defaults to the caller's own scopes and may not exceed them (403); without `expiresInDays` the key does not expire.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.ApiKeysCreateAsync(new ApiKeysCreateAccountRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ApiKeysCreateAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">ApiKeysListAsync</a>(ApiKeysListAccountRequest { ... }) -> WithRawResponseTask&lt;ApiKeysListAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the API keys of the active company, including expired and revoked ones.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.ApiKeysListAsync(new ApiKeysListAccountRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ApiKeysListAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">ApiKeysRotateAsync</a>(ApiKeysRotateAccountRequest { ... }) -> WithRawResponseTask&lt;ApiKeysRotateAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new key with the name and scopes of the key `id` and return it once; the old key keeps working for `overlapHours` and then expires, and its `replacedByKeyId` points to the new one. `expiresInDays` applies to the new key. Refused with 409 when the old key is revoked.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.ApiKeysRotateAsync(new ApiKeysRotateAccountRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ApiKeysRotateAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">ApiKeysRevokeAsync</a>(ApiKeysRevokeAccountRequest { ... }) -> WithRawResponseTask&lt;ApiKeysRevokeAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Revoke an API key of the active company at once.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.ApiKeysRevokeAsync(new ApiKeysRevokeAccountRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ApiKeysRevokeAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">ConsentAcceptAsync</a>(ConsentAcceptAccountRequest { ... }) -> WithRawResponseTask&lt;ConsentAcceptAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Record the signed-in user's acceptance of the current Terms of Service and Data Processing Agreement versions and return the consent state.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.ConsentAcceptAsync(
    new ConsentAcceptAccountRequest { AcceptTerms = true, AcceptDpa = true }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ConsentAcceptAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">ProfileUpdateAsync</a>(ProfileUpdateAccountRequest { ... }) -> WithRawResponseTask&lt;ProfileUpdateAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Set the signed-in user's name; null or a blank string clears it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.ProfileUpdateAsync(new ProfileUpdateAccountRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ProfileUpdateAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">EmailChangeRequestAsync</a>(EmailChangeRequestAccountRequest { ... }) -> WithRawResponseTask&lt;EmailChangeRequestAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Send a confirmation link to `newEmail`; the address changes when that link is consumed with `account/login-link/consume`. When an unused link was sent to the address within the last minute, the call answers `sent` without sending another. Refused with 422 when it is already the user's address and with 409 when another account has it.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.EmailChangeRequestAsync(
    new EmailChangeRequestAccountRequest { NewEmail = "newEmail" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EmailChangeRequestAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">SessionsListAsync</a>(SessionsListAccountRequest { ... }) -> WithRawResponseTask&lt;SessionsListAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the signed-in user's sessions that have not expired; `current` marks the one the call was made with.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.SessionsListAsync(new SessionsListAccountRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SessionsListAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">SessionsRevokeAsync</a>(SessionsRevokeAccountRequest { ... }) -> WithRawResponseTask&lt;SessionsRevokeAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete one of the signed-in user's sessions.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.SessionsRevokeAsync(new SessionsRevokeAccountRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SessionsRevokeAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">SessionsRevokeOthersAsync</a>(SessionsRevokeOthersAccountRequest { ... }) -> WithRawResponseTask&lt;SessionsRevokeOthersAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete every session of the signed-in user except the one the call was made with, and return how many were deleted.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.SessionsRevokeOthersAsync(new SessionsRevokeOthersAccountRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SessionsRevokeOthersAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">ExportAsync</a>(ExportAccountRequest { ... }) -> WithRawResponseTask&lt;ExportAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the user's profile, consent state, memberships, unexpired sessions, billing account, credit transactions and the audit entries they made in their companies (the most recent 5000 of each of the last two).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.ExportAsync(new ExportAccountRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ExportAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">DeleteAsync</a>(DeleteAccountRequest { ... }) -> WithRawResponseTask&lt;DeleteAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Removes the user: sessions, sign-in links, memberships and pending invitations are deleted at once; the email and name are replaced by an anonymous placeholder immediately and the remaining row is removed after 30 days. Refused while the user still owns or pays for a company that is not deleted.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.DeleteAsync(new DeleteAccountRequest { ConfirmEmail = "confirmEmail" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">ReferralGetAsync</a>(ReferralGetAccountRequest { ... }) -> WithRawResponseTask&lt;ReferralGetAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the user's referral code (allocated on first call) and sign-up link, their points balance, the number of accounts they referred and the last 50 points entries. `rates.perEur` is the points the referrer earns per euro a referred user tops up, `rates.pointCents` the credit one point converts to with `account/referral/convert`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.ReferralGetAsync(new ReferralGetAccountRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReferralGetAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">ReferralConvertAsync</a>(ReferralConvertAccountRequest { ... }) -> WithRawResponseTask&lt;ReferralConvertAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Convert `points` of the user's referral points into credit on their billing account at `rates.pointCents` per point, booked as an `adjustment` credit transaction; a billing account past its trial is set to active when the new balance allows. Refused with 422 when the user has fewer points than requested.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.ReferralConvertAsync(new ReferralConvertAccountRequest { Points = 1000000 });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReferralConvertAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">TableSettingsGetAsync</a>(TableSettingsGetAccountRequest { ... }) -> WithRawResponseTask&lt;TableSettingsGetAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return the signed-in user's saved column list and page size for the table `tableKey`; both are null when nothing is saved.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.TableSettingsGetAsync(
    new TableSettingsGetAccountRequest { TableKey = "tableKey" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TableSettingsGetAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">TableSettingsSetAsync</a>(TableSettingsSetAccountRequest { ... }) -> WithRawResponseTask&lt;TableSettingsSetAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Save the signed-in user's column list and page size for the table `tableKey`; only the fields sent are changed, and null clears one.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.TableSettingsSetAsync(
    new TableSettingsSetAccountRequest { TableKey = "tableKey" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TableSettingsSetAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">TableSettingsListAsync</a>(TableSettingsListAccountRequest { ... }) -> WithRawResponseTask&lt;TableSettingsListAccountResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List the signed-in user's saved table settings.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.TableSettingsListAsync(new TableSettingsListAccountRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TableSettingsListAccountRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

