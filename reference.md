# Reference
## Reference
<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceExchangeRatesSyncAsync</a>(PostV1ReferenceExchangeRatesSyncRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceExchangeRatesSyncResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceExchangeRatesSyncAsync(
    new PostV1ReferenceExchangeRatesSyncRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceExchangeRatesSyncRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceExchangeRatesListAsync</a>(PostV1ReferenceExchangeRatesListRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceExchangeRatesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceExchangeRatesListAsync(
    new PostV1ReferenceExchangeRatesListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceExchangeRatesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceExchangeRatesSetAsync</a>(PostV1ReferenceExchangeRatesSetRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceExchangeRatesSetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceExchangeRatesSetAsync(
    new PostV1ReferenceExchangeRatesSetRequest
    {
        Currency = "currency",
        Date = "date",
        Rate = "rate",
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

**request:** `PostV1ReferenceExchangeRatesSetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceExchangeRatesOverridesListAsync</a>(PostV1ReferenceExchangeRatesOverridesListRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceExchangeRatesOverridesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceExchangeRatesOverridesListAsync(
    new PostV1ReferenceExchangeRatesOverridesListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceExchangeRatesOverridesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceExchangeRatesOverridesDeleteAsync</a>(PostV1ReferenceExchangeRatesOverridesDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceExchangeRatesOverridesDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceExchangeRatesOverridesDeleteAsync(
    new PostV1ReferenceExchangeRatesOverridesDeleteRequest { Currency = "currency", Date = "date" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceExchangeRatesOverridesDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceCountriesListAsync</a>(PostV1ReferenceCountriesListRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceCountriesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceCountriesListAsync(new PostV1ReferenceCountriesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceCountriesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceBanksListAsync</a>(PostV1ReferenceBanksListRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceBanksListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceBanksListAsync(new PostV1ReferenceBanksListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceBanksListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceBanksUpsertAsync</a>(PostV1ReferenceBanksUpsertRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceBanksUpsertResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceBanksUpsertAsync(
    new PostV1ReferenceBanksUpsertRequest
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

**request:** `PostV1ReferenceBanksUpsertRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceLtRegionsListAsync</a>(PostV1ReferenceLtRegionsListRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceLtRegionsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceLtRegionsListAsync(new PostV1ReferenceLtRegionsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceLtRegionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceCurrenciesListAsync</a>(PostV1ReferenceCurrenciesListRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceCurrenciesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceCurrenciesListAsync(
    new PostV1ReferenceCurrenciesListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceCurrenciesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceVatClassifiersListAsync</a>(PostV1ReferenceVatClassifiersListRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceVatClassifiersListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceVatClassifiersListAsync(
    new PostV1ReferenceVatClassifiersListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceVatClassifiersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceVatClassifiersUpsertAsync</a>(PostV1ReferenceVatClassifiersUpsertRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceVatClassifiersUpsertResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceVatClassifiersUpsertAsync(
    new PostV1ReferenceVatClassifiersUpsertRequest
    {
        Rows = new List<PostV1ReferenceVatClassifiersUpsertRequestRowsItem>()
        {
            new PostV1ReferenceVatClassifiersUpsertRequestRowsItem { Code = "code", Name = "name" },
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

**request:** `PostV1ReferenceVatClassifiersUpsertRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceEuVatRatesListAsync</a>(PostV1ReferenceEuVatRatesListRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceEuVatRatesListResponse&gt;</code></summary>
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
await client.Reference.PostV1ReferenceEuVatRatesListAsync(
    new PostV1ReferenceEuVatRatesListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceEuVatRatesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceEuVatRatesImportsListAsync</a>(PostV1ReferenceEuVatRatesImportsListRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceEuVatRatesImportsListResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

History of EU VAT rate imports from the EC TEDB VatRetrievalService: when rates were pulled, what changed, and whether the run succeeded. The initial seed run carries the built-in snapshot.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceEuVatRatesImportsListAsync(
    new PostV1ReferenceEuVatRatesImportsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceEuVatRatesImportsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceEuVatRatesSyncAsync</a>(PostV1ReferenceEuVatRatesSyncRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceEuVatRatesSyncResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Trigger an immediate pull of EU VAT rates from the EC TEDB VatRetrievalService. Rates are shared reference data: new rates open with today as their effective date, rates that disappeared are closed with a validity end date. Returns the finished import run.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceEuVatRatesSyncAsync(
    new PostV1ReferenceEuVatRatesSyncRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceEuVatRatesSyncRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceEuVatRatesSetOverridesAsync</a>(PostV1ReferenceEuVatRatesSetOverridesRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceEuVatRatesSetOverridesResponse&gt;</code></summary>
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
await client.Reference.PostV1ReferenceEuVatRatesSetOverridesAsync(
    new PostV1ReferenceEuVatRatesSetOverridesRequest
    {
        CountryCode = "countryCode",
        Rates = new List<PostV1ReferenceEuVatRatesSetOverridesRequestRatesItem>()
        {
            new PostV1ReferenceEuVatRatesSetOverridesRequestRatesItem
            {
                Category = PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory.Standard,
                RatePercent = "ratePercent",
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

**request:** `PostV1ReferenceEuVatRatesSetOverridesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceVatResolveAsync</a>(PostV1ReferenceVatResolveRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceVatResolveResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceVatResolveAsync(new PostV1ReferenceVatResolveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceVatResolveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceCnCodesListAsync</a>(PostV1ReferenceCnCodesListRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceCnCodesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceCnCodesListAsync(new PostV1ReferenceCnCodesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceCnCodesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceCnCodesUpsertAsync</a>(PostV1ReferenceCnCodesUpsertRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceCnCodesUpsertResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceCnCodesUpsertAsync(
    new PostV1ReferenceCnCodesUpsertRequest
    {
        Rows = new List<PostV1ReferenceCnCodesUpsertRequestRowsItem>()
        {
            new PostV1ReferenceCnCodesUpsertRequestRowsItem { Code = "code", Name = "name" },
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

**request:** `PostV1ReferenceCnCodesUpsertRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceComplianceVersionsListAsync</a>(PostV1ReferenceComplianceVersionsListRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceComplianceVersionsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceComplianceVersionsListAsync(
    new PostV1ReferenceComplianceVersionsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceComplianceVersionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceIntrastatThresholdsListAsync</a>(PostV1ReferenceIntrastatThresholdsListRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceIntrastatThresholdsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceIntrastatThresholdsListAsync(
    new PostV1ReferenceIntrastatThresholdsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceIntrastatThresholdsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceUnitsListAsync</a>(PostV1ReferenceUnitsListRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceUnitsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceUnitsListAsync(new PostV1ReferenceUnitsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceUnitsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceSeriesCreateAsync</a>(PostV1ReferenceSeriesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceSeriesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceSeriesCreateAsync(
    new PostV1ReferenceSeriesCreateRequest { DocumentType = "documentType", Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceSeriesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">PostV1ReferenceSeriesListAsync</a>(PostV1ReferenceSeriesListRequest { ... }) -> WithRawResponseTask&lt;PostV1ReferenceSeriesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reference.PostV1ReferenceSeriesListAsync(new PostV1ReferenceSeriesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReferenceSeriesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Partners
<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersAddressesCreateAsync</a>(PostV1PartnersAddressesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersAddressesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersAddressesCreateAsync(
    new PostV1PartnersAddressesCreateRequest { PartnerId = "partnerId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersAddressesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersAddressesUpdateAsync</a>(PostV1PartnersAddressesUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersAddressesUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersAddressesUpdateAsync(
    new PostV1PartnersAddressesUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersAddressesUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersAddressesDeleteAsync</a>(PostV1PartnersAddressesDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersAddressesDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersAddressesDeleteAsync(
    new PostV1PartnersAddressesDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersAddressesDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersAddressesListAsync</a>(PostV1PartnersAddressesListRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersAddressesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersAddressesListAsync(new PostV1PartnersAddressesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersAddressesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersContactsCreateAsync</a>(PostV1PartnersContactsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersContactsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersContactsCreateAsync(
    new PostV1PartnersContactsCreateRequest { Name = "name", PartnerId = "partnerId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersContactsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersContactsUpdateAsync</a>(PostV1PartnersContactsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersContactsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersContactsUpdateAsync(
    new PostV1PartnersContactsUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersContactsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersContactsDeleteAsync</a>(PostV1PartnersContactsDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersContactsDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersContactsDeleteAsync(
    new PostV1PartnersContactsDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersContactsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersContactsListAsync</a>(PostV1PartnersContactsListRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersContactsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersContactsListAsync(new PostV1PartnersContactsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersContactsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersBankAccountsCreateAsync</a>(PostV1PartnersBankAccountsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersBankAccountsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersBankAccountsCreateAsync(
    new PostV1PartnersBankAccountsCreateRequest { Iban = "iban", PartnerId = "partnerId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersBankAccountsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersBankAccountsUpdateAsync</a>(PostV1PartnersBankAccountsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersBankAccountsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersBankAccountsUpdateAsync(
    new PostV1PartnersBankAccountsUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersBankAccountsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersBankAccountsDeleteAsync</a>(PostV1PartnersBankAccountsDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersBankAccountsDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersBankAccountsDeleteAsync(
    new PostV1PartnersBankAccountsDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersBankAccountsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersBankAccountsListAsync</a>(PostV1PartnersBankAccountsListRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersBankAccountsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersBankAccountsListAsync(
    new PostV1PartnersBankAccountsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersBankAccountsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersValidateVatAsync</a>(PostV1PartnersValidateVatRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersValidateVatResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersValidateVatAsync(new PostV1PartnersValidateVatRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersValidateVatRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersVatReviewsListAsync</a>(PostV1PartnersVatReviewsListRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersVatReviewsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersVatReviewsListAsync(new PostV1PartnersVatReviewsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersVatReviewsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersVatReviewsResolveAsync</a>(PostV1PartnersVatReviewsResolveRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersVatReviewsResolveResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersVatReviewsResolveAsync(
    new PostV1PartnersVatReviewsResolveRequest
    {
        Id = "id",
        Resolution = PostV1PartnersVatReviewsResolveRequestResolution.ConfirmedValid,
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

**request:** `PostV1PartnersVatReviewsResolveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersCreateAsync</a>(PostV1PartnersCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersCreateAsync(new PostV1PartnersCreateRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersFindOrCreateAsync</a>(PostV1PartnersFindOrCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersFindOrCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersFindOrCreateAsync(
    new PostV1PartnersFindOrCreateRequest { Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersFindOrCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersGetAsync</a>(PostV1PartnersGetRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersGetAsync(new PostV1PartnersGetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersUpdateAsync</a>(PostV1PartnersUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersUpdateAsync(new PostV1PartnersUpdateRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersDeleteAsync</a>(PostV1PartnersDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersDeleteAsync(new PostV1PartnersDeleteRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersListAsync</a>(PostV1PartnersListRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersListAsync(new PostV1PartnersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersGroupsCreateAsync</a>(PostV1PartnersGroupsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersGroupsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersGroupsCreateAsync(
    new PostV1PartnersGroupsCreateRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersGroupsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersGroupsUpdateAsync</a>(PostV1PartnersGroupsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersGroupsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersGroupsUpdateAsync(
    new PostV1PartnersGroupsUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersGroupsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersGroupsDeleteAsync</a>(PostV1PartnersGroupsDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersGroupsDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersGroupsDeleteAsync(
    new PostV1PartnersGroupsDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersGroupsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersGroupsListAsync</a>(PostV1PartnersGroupsListRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersGroupsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersGroupsListAsync(new PostV1PartnersGroupsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersGroupsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersStatusesCreateAsync</a>(PostV1PartnersStatusesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersStatusesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersStatusesCreateAsync(
    new PostV1PartnersStatusesCreateRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersStatusesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersStatusesUpdateAsync</a>(PostV1PartnersStatusesUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersStatusesUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersStatusesUpdateAsync(
    new PostV1PartnersStatusesUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersStatusesUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersStatusesDeleteAsync</a>(PostV1PartnersStatusesDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersStatusesDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersStatusesDeleteAsync(
    new PostV1PartnersStatusesDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersStatusesDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersStatusesListAsync</a>(PostV1PartnersStatusesListRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersStatusesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersStatusesListAsync(new PostV1PartnersStatusesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersStatusesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersInquiriesCreateAsync</a>(PostV1PartnersInquiriesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersInquiriesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersInquiriesCreateAsync(
    new PostV1PartnersInquiriesCreateRequest { Subject = "subject" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersInquiriesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersInquiriesUpdateAsync</a>(PostV1PartnersInquiriesUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersInquiriesUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersInquiriesUpdateAsync(
    new PostV1PartnersInquiriesUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersInquiriesUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersInquiriesGetAsync</a>(PostV1PartnersInquiriesGetRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersInquiriesGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersInquiriesGetAsync(
    new PostV1PartnersInquiriesGetRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersInquiriesGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersInquiriesListAsync</a>(PostV1PartnersInquiriesListRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersInquiriesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersInquiriesListAsync(new PostV1PartnersInquiriesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersInquiriesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">PostV1PartnersCreditCheckAsync</a>(PostV1PartnersCreditCheckRequest { ... }) -> WithRawResponseTask&lt;PostV1PartnersCreditCheckResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Partners.PostV1PartnersCreditCheckAsync(
    new PostV1PartnersCreditCheckRequest { PartnerId = "partnerId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PartnersCreditCheckRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Catalog
<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogItemsCreateAsync</a>(PostV1CatalogItemsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogItemsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogItemsCreateAsync(
    new PostV1CatalogItemsCreateRequest { Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogItemsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogItemsGetAsync</a>(PostV1CatalogItemsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogItemsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogItemsGetAsync(new PostV1CatalogItemsGetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogItemsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogItemsUpdateAsync</a>(PostV1CatalogItemsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogItemsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogItemsUpdateAsync(
    new PostV1CatalogItemsUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogItemsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogItemsDeleteAsync</a>(PostV1CatalogItemsDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogItemsDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogItemsDeleteAsync(
    new PostV1CatalogItemsDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogItemsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogItemsListAsync</a>(PostV1CatalogItemsListRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogItemsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogItemsListAsync(new PostV1CatalogItemsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogItemsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogItemGroupsCreateAsync</a>(PostV1CatalogItemGroupsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogItemGroupsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogItemGroupsCreateAsync(
    new PostV1CatalogItemGroupsCreateRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogItemGroupsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogItemGroupsUpdateAsync</a>(PostV1CatalogItemGroupsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogItemGroupsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogItemGroupsUpdateAsync(
    new PostV1CatalogItemGroupsUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogItemGroupsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogItemGroupsDeleteAsync</a>(PostV1CatalogItemGroupsDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogItemGroupsDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogItemGroupsDeleteAsync(
    new PostV1CatalogItemGroupsDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogItemGroupsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogItemGroupsListAsync</a>(PostV1CatalogItemGroupsListRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogItemGroupsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogItemGroupsListAsync(new PostV1CatalogItemGroupsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogItemGroupsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogItemsSuppliersUpsertAsync</a>(PostV1CatalogItemsSuppliersUpsertRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogItemsSuppliersUpsertResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogItemsSuppliersUpsertAsync(
    new PostV1CatalogItemsSuppliersUpsertRequest { ItemId = "itemId", PartnerId = "partnerId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogItemsSuppliersUpsertRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogItemsSuppliersListAsync</a>(PostV1CatalogItemsSuppliersListRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogItemsSuppliersListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogItemsSuppliersListAsync(
    new PostV1CatalogItemsSuppliersListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogItemsSuppliersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogItemsSuppliersDeleteAsync</a>(PostV1CatalogItemsSuppliersDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogItemsSuppliersDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogItemsSuppliersDeleteAsync(
    new PostV1CatalogItemsSuppliersDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogItemsSuppliersDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogPriceListsCreateAsync</a>(PostV1CatalogPriceListsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogPriceListsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogPriceListsCreateAsync(
    new PostV1CatalogPriceListsCreateRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogPriceListsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogPriceListsUpdateAsync</a>(PostV1CatalogPriceListsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogPriceListsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogPriceListsUpdateAsync(
    new PostV1CatalogPriceListsUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogPriceListsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogPriceListsListAsync</a>(PostV1CatalogPriceListsListRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogPriceListsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogPriceListsListAsync(new PostV1CatalogPriceListsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogPriceListsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogPriceListsItemsSetAsync</a>(PostV1CatalogPriceListsItemsSetRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogPriceListsItemsSetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogPriceListsItemsSetAsync(
    new PostV1CatalogPriceListsItemsSetRequest
    {
        PriceListId = "priceListId",
        Items = new List<PostV1CatalogPriceListsItemsSetRequestItemsItem>()
        {
            new PostV1CatalogPriceListsItemsSetRequestItemsItem
            {
                ItemId = "itemId",
                UnitPriceExclVat = "unitPriceExclVat",
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

**request:** `PostV1CatalogPriceListsItemsSetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogPriceListsItemsListAsync</a>(PostV1CatalogPriceListsItemsListRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogPriceListsItemsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogPriceListsItemsListAsync(
    new PostV1CatalogPriceListsItemsListRequest { PriceListId = "priceListId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogPriceListsItemsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Catalog.<a href="/src/NordletApi/Catalog/CatalogClient.cs">PostV1CatalogPriceListsItemsDeleteAsync</a>(PostV1CatalogPriceListsItemsDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1CatalogPriceListsItemsDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Catalog.PostV1CatalogPriceListsItemsDeleteAsync(
    new PostV1CatalogPriceListsItemsDeleteRequest { PriceListId = "priceListId", ItemId = "itemId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CatalogPriceListsItemsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Sales
<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesInvoicesCreateAsync</a>(PostV1SalesInvoicesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesInvoicesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesInvoicesCreateAsync(
    new PostV1SalesInvoicesCreateRequest
    {
        PartnerId = "partnerId",
        Lines = new List<PostV1SalesInvoicesCreateRequestLinesItem>()
        {
            new PostV1SalesInvoicesCreateRequestLinesItem(),
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

**request:** `PostV1SalesInvoicesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesInvoicesGetAsync</a>(PostV1SalesInvoicesGetRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesInvoicesGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesInvoicesGetAsync(new PostV1SalesInvoicesGetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesInvoicesGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesInvoicesPdfAsync</a>(PostV1SalesInvoicesPdfRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesInvoicesPdfResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesInvoicesPdfAsync(new PostV1SalesInvoicesPdfRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesInvoicesPdfRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesInvoicesSendAsync</a>(PostV1SalesInvoicesSendRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesInvoicesSendResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesInvoicesSendAsync(new PostV1SalesInvoicesSendRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesInvoicesSendRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesInvoicesPeppolXmlAsync</a>(PostV1SalesInvoicesPeppolXmlRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesInvoicesPeppolXmlResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesInvoicesPeppolXmlAsync(
    new PostV1SalesInvoicesPeppolXmlRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesInvoicesPeppolXmlRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesInvoicesPeppolSendAsync</a>(PostV1SalesInvoicesPeppolSendRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesInvoicesPeppolSendResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesInvoicesPeppolSendAsync(
    new PostV1SalesInvoicesPeppolSendRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesInvoicesPeppolSendRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesInvoicesEinvoiceXmlAsync</a>(PostV1SalesInvoicesEinvoiceXmlRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesInvoicesEinvoiceXmlResponse&gt;</code></summary>
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
await client.Sales.PostV1SalesInvoicesEinvoiceXmlAsync(
    new PostV1SalesInvoicesEinvoiceXmlRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesInvoicesEinvoiceXmlRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesInvoicesEinvoiceSendAsync</a>(PostV1SalesInvoicesEinvoiceSendRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesInvoicesEinvoiceSendResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Build the national e-invoicing payload and deliver it to the bridge endpoint configured for the country gateway in compliance settings. The bridge (an accredited intermediary or connector) handles the certified national channel - SdI accreditation, KSeF sessions or ANAF SPV OAuth.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesInvoicesEinvoiceSendAsync(
    new PostV1SalesInvoicesEinvoiceSendRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesInvoicesEinvoiceSendRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesInvoicesUpdateAsync</a>(PostV1SalesInvoicesUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesInvoicesUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesInvoicesUpdateAsync(
    new PostV1SalesInvoicesUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesInvoicesUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesInvoicesDeleteAsync</a>(PostV1SalesInvoicesDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesInvoicesDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesInvoicesDeleteAsync(
    new PostV1SalesInvoicesDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesInvoicesDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesInvoicesIssueAsync</a>(PostV1SalesInvoicesIssueRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesInvoicesIssueResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesInvoicesIssueAsync(new PostV1SalesInvoicesIssueRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesInvoicesIssueRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesRecognitionSchedulesListAsync</a>(PostV1SalesRecognitionSchedulesListRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesRecognitionSchedulesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesRecognitionSchedulesListAsync(
    new PostV1SalesRecognitionSchedulesListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesRecognitionSchedulesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesInvoicesApplyAdvanceAsync</a>(PostV1SalesInvoicesApplyAdvanceRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesInvoicesApplyAdvanceResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesInvoicesApplyAdvanceAsync(
    new PostV1SalesInvoicesApplyAdvanceRequest { AdvanceId = "advanceId", InvoiceId = "invoiceId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesInvoicesApplyAdvanceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesInvoicesListAsync</a>(PostV1SalesInvoicesListRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesInvoicesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesInvoicesListAsync(new PostV1SalesInvoicesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesInvoicesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesActsCreateAsync</a>(PostV1SalesActsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesActsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesActsCreateAsync(
    new PostV1SalesActsCreateRequest { PartnerId = "partnerId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesActsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesActsUpdateAsync</a>(PostV1SalesActsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesActsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesActsUpdateAsync(new PostV1SalesActsUpdateRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesActsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesActsIssueAsync</a>(PostV1SalesActsIssueRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesActsIssueResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesActsIssueAsync(new PostV1SalesActsIssueRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesActsIssueRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesActsCancelAsync</a>(PostV1SalesActsCancelRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesActsCancelResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesActsCancelAsync(new PostV1SalesActsCancelRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesActsCancelRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesActsGetAsync</a>(PostV1SalesActsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesActsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesActsGetAsync(new PostV1SalesActsGetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesActsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesActsListAsync</a>(PostV1SalesActsListRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesActsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesActsListAsync(new PostV1SalesActsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesActsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesActsPdfAsync</a>(PostV1SalesActsPdfRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesActsPdfResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesActsPdfAsync(new PostV1SalesActsPdfRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesActsPdfRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesRecognitionComputeAsync</a>(PostV1SalesRecognitionComputeRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesRecognitionComputeResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesRecognitionComputeAsync(new PostV1SalesRecognitionComputeRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesRecognitionComputeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesRecognitionRunAsync</a>(PostV1SalesRecognitionRunRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesRecognitionRunResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesRecognitionRunAsync(new PostV1SalesRecognitionRunRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesRecognitionRunRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesRecognitionProgressAsync</a>(PostV1SalesRecognitionProgressRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesRecognitionProgressResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesRecognitionProgressAsync(
    new PostV1SalesRecognitionProgressRequest
    {
        InvoiceLineId = "invoiceLineId",
        PercentComplete = "percentComplete",
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

**request:** `PostV1SalesRecognitionProgressRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesRecognitionModifyAsync</a>(PostV1SalesRecognitionModifyRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesRecognitionModifyResponse&gt;</code></summary>
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
await client.Sales.PostV1SalesRecognitionModifyAsync(
    new PostV1SalesRecognitionModifyRequest
    {
        InvoiceLineId = "invoiceLineId",
        Approach = PostV1SalesRecognitionModifyRequestApproach.Prospective,
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

**request:** `PostV1SalesRecognitionModifyRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesRecognitionRunsListAsync</a>(PostV1SalesRecognitionRunsListRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesRecognitionRunsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesRecognitionRunsListAsync(new PostV1SalesRecognitionRunsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesRecognitionRunsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesRecognitionSummaryAsync</a>(PostV1SalesRecognitionSummaryRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesRecognitionSummaryResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesRecognitionSummaryAsync(new PostV1SalesRecognitionSummaryRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesRecognitionSummaryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesRefundLiabilityListAsync</a>(PostV1SalesRefundLiabilityListRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesRefundLiabilityListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesRefundLiabilityListAsync(new PostV1SalesRefundLiabilityListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1SalesRefundLiabilityListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">PostV1SalesRefundLiabilityTrueUpAsync</a>(PostV1SalesRefundLiabilityTrueUpRequest { ... }) -> WithRawResponseTask&lt;PostV1SalesRefundLiabilityTrueUpResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sales.PostV1SalesRefundLiabilityTrueUpAsync(
    new PostV1SalesRefundLiabilityTrueUpRequest
    {
        InvoiceId = "invoiceId",
        EstimatedTotal = "estimatedTotal",
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

**request:** `PostV1SalesRefundLiabilityTrueUpRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Purchases
<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesInvoicesCreateAsync</a>(PostV1PurchasesInvoicesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesInvoicesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesInvoicesCreateAsync(
    new PostV1PurchasesInvoicesCreateRequest
    {
        PartnerId = "partnerId",
        DocumentNumber = "documentNumber",
        DocumentDate = "documentDate",
        Lines = new List<PostV1PurchasesInvoicesCreateRequestLinesItem>()
        {
            new PostV1PurchasesInvoicesCreateRequestLinesItem(),
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

**request:** `PostV1PurchasesInvoicesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesInvoicesGetAsync</a>(PostV1PurchasesInvoicesGetRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesInvoicesGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesInvoicesGetAsync(
    new PostV1PurchasesInvoicesGetRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesInvoicesGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesInvoicesUpdateAsync</a>(PostV1PurchasesInvoicesUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesInvoicesUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesInvoicesUpdateAsync(
    new PostV1PurchasesInvoicesUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesInvoicesUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesInvoicesDeleteAsync</a>(PostV1PurchasesInvoicesDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesInvoicesDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesInvoicesDeleteAsync(
    new PostV1PurchasesInvoicesDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesInvoicesDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesInvoicesRegisterAsync</a>(PostV1PurchasesInvoicesRegisterRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesInvoicesRegisterResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesInvoicesRegisterAsync(
    new PostV1PurchasesInvoicesRegisterRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesInvoicesRegisterRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesInvoicesListAsync</a>(PostV1PurchasesInvoicesListRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesInvoicesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesInvoicesListAsync(new PostV1PurchasesInvoicesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesInvoicesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesOrdersCreateAsync</a>(PostV1PurchasesOrdersCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesOrdersCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesOrdersCreateAsync(
    new PostV1PurchasesOrdersCreateRequest
    {
        PartnerId = "partnerId",
        OrderDate = "orderDate",
        Lines = new List<PostV1PurchasesOrdersCreateRequestLinesItem>()
        {
            new PostV1PurchasesOrdersCreateRequestLinesItem(),
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

**request:** `PostV1PurchasesOrdersCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesOrdersUpdateAsync</a>(PostV1PurchasesOrdersUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesOrdersUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesOrdersUpdateAsync(
    new PostV1PurchasesOrdersUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesOrdersUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesOrdersGetAsync</a>(PostV1PurchasesOrdersGetRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesOrdersGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesOrdersGetAsync(
    new PostV1PurchasesOrdersGetRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesOrdersGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesOrdersListAsync</a>(PostV1PurchasesOrdersListRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesOrdersListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesOrdersListAsync(new PostV1PurchasesOrdersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesOrdersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesOrdersSubmitAsync</a>(PostV1PurchasesOrdersSubmitRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesOrdersSubmitResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesOrdersSubmitAsync(
    new PostV1PurchasesOrdersSubmitRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesOrdersSubmitRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesOrdersApproveAsync</a>(PostV1PurchasesOrdersApproveRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesOrdersApproveResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesOrdersApproveAsync(
    new PostV1PurchasesOrdersApproveRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesOrdersApproveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesOrdersRejectAsync</a>(PostV1PurchasesOrdersRejectRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesOrdersRejectResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesOrdersRejectAsync(
    new PostV1PurchasesOrdersRejectRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesOrdersRejectRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesOrdersCancelAsync</a>(PostV1PurchasesOrdersCancelRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesOrdersCancelResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesOrdersCancelAsync(
    new PostV1PurchasesOrdersCancelRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesOrdersCancelRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesOrdersCloseAsync</a>(PostV1PurchasesOrdersCloseRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesOrdersCloseResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesOrdersCloseAsync(
    new PostV1PurchasesOrdersCloseRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesOrdersCloseRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesOrdersDeleteAsync</a>(PostV1PurchasesOrdersDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesOrdersDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesOrdersDeleteAsync(
    new PostV1PurchasesOrdersDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesOrdersDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesReceiptsCreateAsync</a>(PostV1PurchasesReceiptsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesReceiptsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesReceiptsCreateAsync(
    new PostV1PurchasesReceiptsCreateRequest
    {
        OrderId = "orderId",
        ReceiptDate = "receiptDate",
        Lines = new List<PostV1PurchasesReceiptsCreateRequestLinesItem>()
        {
            new PostV1PurchasesReceiptsCreateRequestLinesItem
            {
                OrderLineId = "orderLineId",
                Quantity = "quantity",
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

**request:** `PostV1PurchasesReceiptsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesReceiptsGetAsync</a>(PostV1PurchasesReceiptsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesReceiptsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesReceiptsGetAsync(
    new PostV1PurchasesReceiptsGetRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesReceiptsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesReceiptsListAsync</a>(PostV1PurchasesReceiptsListRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesReceiptsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesReceiptsListAsync(new PostV1PurchasesReceiptsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesReceiptsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Purchases.<a href="/src/NordletApi/Purchases/PurchasesClient.cs">PostV1PurchasesInvoicesMatchAsync</a>(PostV1PurchasesInvoicesMatchRequest { ... }) -> WithRawResponseTask&lt;PostV1PurchasesInvoicesMatchResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Purchases.PostV1PurchasesInvoicesMatchAsync(
    new PostV1PurchasesInvoicesMatchRequest { InvoiceId = "invoiceId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PurchasesInvoicesMatchRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Capture
<details><summary><code>client.Capture.<a href="/src/NordletApi/Capture/CaptureClient.cs">ReadAVendorBillOrReceiptAndReturnAnEditablePurchaseInvoiceDraftAsync</a>(PostV1CaptureDocumentsUploadRequest { ... }) -> WithRawResponseTask&lt;PostV1CaptureDocumentsUploadResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Capture.ReadAVendorBillOrReceiptAndReturnAnEditablePurchaseInvoiceDraftAsync(
    new PostV1CaptureDocumentsUploadRequest
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

**request:** `PostV1CaptureDocumentsUploadRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Capture.<a href="/src/NordletApi/Capture/CaptureClient.cs">ReReadAStoredCaptureReplacingThePreviousDraftAsync</a>(PostV1CaptureDocumentsExtractRequest { ... }) -> WithRawResponseTask&lt;PostV1CaptureDocumentsExtractResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Capture.ReReadAStoredCaptureReplacingThePreviousDraftAsync(
    new PostV1CaptureDocumentsExtractRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CaptureDocumentsExtractRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Capture.<a href="/src/NordletApi/Capture/CaptureClient.cs">PostV1CaptureDocumentsGetAsync</a>(PostV1CaptureDocumentsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1CaptureDocumentsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Capture.PostV1CaptureDocumentsGetAsync(
    new PostV1CaptureDocumentsGetRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CaptureDocumentsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Capture.<a href="/src/NordletApi/Capture/CaptureClient.cs">PostV1CaptureDocumentsListAsync</a>(PostV1CaptureDocumentsListRequest { ... }) -> WithRawResponseTask&lt;PostV1CaptureDocumentsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Capture.PostV1CaptureDocumentsListAsync(new PostV1CaptureDocumentsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CaptureDocumentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Capture.<a href="/src/NordletApi/Capture/CaptureClient.cs">PostV1CaptureDocumentsDeleteAsync</a>(PostV1CaptureDocumentsDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1CaptureDocumentsDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Capture.PostV1CaptureDocumentsDeleteAsync(
    new PostV1CaptureDocumentsDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CaptureDocumentsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Capture.<a href="/src/NordletApi/Capture/CaptureClient.cs">SaveTheReviewedDraftAsAPurchaseInvoiceAndAttachTheOriginalDocumentAsync</a>(PostV1CaptureDocumentsConfirmRequest { ... }) -> WithRawResponseTask&lt;PostV1CaptureDocumentsConfirmResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Capture.SaveTheReviewedDraftAsAPurchaseInvoiceAndAttachTheOriginalDocumentAsync(
    new PostV1CaptureDocumentsConfirmRequest
    {
        Id = "id",
        DocumentNumber = "documentNumber",
        DocumentDate = "documentDate",
        Lines = new List<PostV1CaptureDocumentsConfirmRequestLinesItem>()
        {
            new PostV1CaptureDocumentsConfirmRequestLinesItem(),
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

**request:** `PostV1CaptureDocumentsConfirmRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Declarations
<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsLtIntrastatComputeAsync</a>(PostV1DeclarationsLtIntrastatComputeRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsLtIntrastatComputeResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsLtIntrastatComputeAsync(
    new PostV1DeclarationsLtIntrastatComputeRequest
    {
        Year = 1000000,
        Month = 1000000,
        Flow = PostV1DeclarationsLtIntrastatComputeRequestFlow.Arrivals,
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

**request:** `PostV1DeclarationsLtIntrastatComputeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsLtIvazGenerateAsync</a>(PostV1DeclarationsLtIvazGenerateRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsLtIvazGenerateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsLtIvazGenerateAsync(
    new PostV1DeclarationsLtIvazGenerateRequest { WaybillIds = new List<string>() { "waybillIds" } }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsLtIvazGenerateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsLtIntrastatObligationAsync</a>(PostV1DeclarationsLtIntrastatObligationRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsLtIntrastatObligationResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsLtIntrastatObligationAsync(
    new PostV1DeclarationsLtIntrastatObligationRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsLtIntrastatObligationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsLtIsafGenerateAsync</a>(PostV1DeclarationsLtIsafGenerateRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsLtIsafGenerateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsLtIsafGenerateAsync(
    new PostV1DeclarationsLtIsafGenerateRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsLtIsafGenerateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsLtFr0600ComputeAsync</a>(PostV1DeclarationsLtFr0600ComputeRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsLtFr0600ComputeResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsLtFr0600ComputeAsync(
    new PostV1DeclarationsLtFr0600ComputeRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsLtFr0600ComputeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsLtGpm313ComputeAsync</a>(PostV1DeclarationsLtGpm313ComputeRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsLtGpm313ComputeResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsLtGpm313ComputeAsync(
    new PostV1DeclarationsLtGpm313ComputeRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsLtGpm313ComputeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsLtSamComputeAsync</a>(PostV1DeclarationsLtSamComputeRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsLtSamComputeResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsLtSamComputeAsync(
    new PostV1DeclarationsLtSamComputeRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsLtSamComputeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsLtSdGenerateAsync</a>(PostV1DeclarationsLtSdGenerateRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsLtSdGenerateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsLtSdGenerateAsync(
    new PostV1DeclarationsLtSdGenerateRequest
    {
        Type = PostV1DeclarationsLtSdGenerateRequestType.OneSd,
        FromDate = "fromDate",
        ToDate = "toDate",
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

**request:** `PostV1DeclarationsLtSdGenerateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsLtSaftGenerateAsync</a>(PostV1DeclarationsLtSaftGenerateRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsLtSaftGenerateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsLtSaftGenerateAsync(
    new PostV1DeclarationsLtSaftGenerateRequest { FromDate = "fromDate", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsLtSaftGenerateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsEuOssComputeAsync</a>(PostV1DeclarationsEuOssComputeRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsEuOssComputeResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsEuOssComputeAsync(
    new PostV1DeclarationsEuOssComputeRequest { Year = 1000000, Quarter = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsEuOssComputeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsEuIossComputeAsync</a>(PostV1DeclarationsEuIossComputeRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsEuIossComputeResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsEuIossComputeAsync(
    new PostV1DeclarationsEuIossComputeRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsEuIossComputeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsEuDistanceSalesThresholdGetAsync</a>(PostV1DeclarationsEuDistanceSalesThresholdGetRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsEuDistanceSalesThresholdGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsEuDistanceSalesThresholdGetAsync(
    new PostV1DeclarationsEuDistanceSalesThresholdGetRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsEuDistanceSalesThresholdGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsEuUnionTurnoverGetAsync</a>(PostV1DeclarationsEuUnionTurnoverGetRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsEuUnionTurnoverGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsEuUnionTurnoverGetAsync(
    new PostV1DeclarationsEuUnionTurnoverGetRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsEuUnionTurnoverGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsEuSmeCrossBorderReportComputeAsync</a>(PostV1DeclarationsEuSmeCrossBorderReportComputeRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsEuSmeCrossBorderReportComputeResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsEuSmeCrossBorderReportComputeAsync(
    new PostV1DeclarationsEuSmeCrossBorderReportComputeRequest { Year = 1000000, Quarter = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsEuSmeCrossBorderReportComputeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsEuSmeThresholdsListAsync</a>(PostV1DeclarationsEuSmeThresholdsListRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsEuSmeThresholdsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsEuSmeThresholdsListAsync(
    new PostV1DeclarationsEuSmeThresholdsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsEuSmeThresholdsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsEuSmeThresholdGetAsync</a>(PostV1DeclarationsEuSmeThresholdGetRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsEuSmeThresholdGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsEuSmeThresholdGetAsync(
    new PostV1DeclarationsEuSmeThresholdGetRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsEuSmeThresholdGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsEuVatReturnPacksListAsync</a>(PostV1DeclarationsEuVatReturnPacksListRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsEuVatReturnPacksListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsEuVatReturnPacksListAsync(
    new PostV1DeclarationsEuVatReturnPacksListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsEuVatReturnPacksListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsEuVatReturnComputeAsync</a>(PostV1DeclarationsEuVatReturnComputeRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsEuVatReturnComputeResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsEuVatReturnComputeAsync(
    new PostV1DeclarationsEuVatReturnComputeRequest
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

**request:** `PostV1DeclarationsEuVatReturnComputeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsPlJpkV7MGenerateAsync</a>(PostV1DeclarationsPlJpkV7MGenerateRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsPlJpkV7MGenerateResponse&gt;</code></summary>
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
await client.Declarations.PostV1DeclarationsPlJpkV7MGenerateAsync(
    new PostV1DeclarationsPlJpkV7MGenerateRequest
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

**request:** `PostV1DeclarationsPlJpkV7MGenerateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsConfigsListAsync</a>(PostV1DeclarationsConfigsListRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsConfigsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsConfigsListAsync(
    new PostV1DeclarationsConfigsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsConfigsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsConfigsUpdateAsync</a>(PostV1DeclarationsConfigsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsConfigsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsConfigsUpdateAsync(
    new PostV1DeclarationsConfigsUpdateRequest
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

**request:** `PostV1DeclarationsConfigsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsSubmissionsCreateAsync</a>(PostV1DeclarationsSubmissionsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsSubmissionsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsSubmissionsCreateAsync(
    new PostV1DeclarationsSubmissionsCreateRequest
    {
        Obligation = PostV1DeclarationsSubmissionsCreateRequestObligation.LtIsaf,
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

**request:** `PostV1DeclarationsSubmissionsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsSubmissionsMarkAsync</a>(PostV1DeclarationsSubmissionsMarkRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsSubmissionsMarkResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsSubmissionsMarkAsync(
    new PostV1DeclarationsSubmissionsMarkRequest
    {
        Id = "id",
        Status = PostV1DeclarationsSubmissionsMarkRequestStatus.Submitted,
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

**request:** `PostV1DeclarationsSubmissionsMarkRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">PostV1DeclarationsSubmissionsListAsync</a>(PostV1DeclarationsSubmissionsListRequest { ... }) -> WithRawResponseTask&lt;PostV1DeclarationsSubmissionsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Declarations.PostV1DeclarationsSubmissionsListAsync(
    new PostV1DeclarationsSubmissionsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1DeclarationsSubmissionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ledger
<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerAccountsListAsync</a>(PostV1LedgerAccountsListRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerAccountsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerAccountsListAsync(new PostV1LedgerAccountsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerAccountsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerAccountsCreateAsync</a>(PostV1LedgerAccountsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerAccountsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerAccountsCreateAsync(
    new PostV1LedgerAccountsCreateRequest
    {
        Code = "code",
        Name = "name",
        Type = PostV1LedgerAccountsCreateRequestType.Asset,
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

**request:** `PostV1LedgerAccountsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerAccountsUpdateAsync</a>(PostV1LedgerAccountsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerAccountsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerAccountsUpdateAsync(
    new PostV1LedgerAccountsUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerAccountsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerAccountsApplyTemplateAsync</a>(PostV1LedgerAccountsApplyTemplateRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerAccountsApplyTemplateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerAccountsApplyTemplateAsync(
    new PostV1LedgerAccountsApplyTemplateRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerAccountsApplyTemplateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerPeriodsListAsync</a>(PostV1LedgerPeriodsListRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerPeriodsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerPeriodsListAsync(new PostV1LedgerPeriodsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerPeriodsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerPeriodsLockAsync</a>(PostV1LedgerPeriodsLockRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerPeriodsLockResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerPeriodsLockAsync(
    new PostV1LedgerPeriodsLockRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerPeriodsLockRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerPeriodsUnlockAsync</a>(PostV1LedgerPeriodsUnlockRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerPeriodsUnlockResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerPeriodsUnlockAsync(
    new PostV1LedgerPeriodsUnlockRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerPeriodsUnlockRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerJournalTransactionsListAsync</a>(PostV1LedgerJournalTransactionsListRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerJournalTransactionsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerJournalTransactionsListAsync(
    new PostV1LedgerJournalTransactionsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerJournalTransactionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerCostCentersCreateAsync</a>(PostV1LedgerCostCentersCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerCostCentersCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerCostCentersCreateAsync(
    new PostV1LedgerCostCentersCreateRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerCostCentersCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerCostCentersUpdateAsync</a>(PostV1LedgerCostCentersUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerCostCentersUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerCostCentersUpdateAsync(
    new PostV1LedgerCostCentersUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerCostCentersUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerCostCentersListAsync</a>(PostV1LedgerCostCentersListRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerCostCentersListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerCostCentersListAsync(new PostV1LedgerCostCentersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerCostCentersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerCostCenterGroupsCreateAsync</a>(PostV1LedgerCostCenterGroupsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerCostCenterGroupsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerCostCenterGroupsCreateAsync(
    new PostV1LedgerCostCenterGroupsCreateRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerCostCenterGroupsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerCostCenterGroupsUpdateAsync</a>(PostV1LedgerCostCenterGroupsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerCostCenterGroupsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerCostCenterGroupsUpdateAsync(
    new PostV1LedgerCostCenterGroupsUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerCostCenterGroupsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerCostCenterGroupsDeleteAsync</a>(PostV1LedgerCostCenterGroupsDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerCostCenterGroupsDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerCostCenterGroupsDeleteAsync(
    new PostV1LedgerCostCenterGroupsDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerCostCenterGroupsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerCostCenterGroupsListAsync</a>(PostV1LedgerCostCenterGroupsListRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerCostCenterGroupsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerCostCenterGroupsListAsync(
    new PostV1LedgerCostCenterGroupsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerCostCenterGroupsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerPostingRulesListAsync</a>(PostV1LedgerPostingRulesListRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerPostingRulesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerPostingRulesListAsync(new PostV1LedgerPostingRulesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerPostingRulesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerPostingRulesUpdateAsync</a>(PostV1LedgerPostingRulesUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerPostingRulesUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerPostingRulesUpdateAsync(
    new PostV1LedgerPostingRulesUpdateRequest
    {
        Rules = new List<PostV1LedgerPostingRulesUpdateRequestRulesItem>()
        {
            new PostV1LedgerPostingRulesUpdateRequestRulesItem
            {
                Key = PostV1LedgerPostingRulesUpdateRequestRulesItemKey.SalesReceivable,
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

**request:** `PostV1LedgerPostingRulesUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerOwnersCreateAsync</a>(PostV1LedgerOwnersCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerOwnersCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerOwnersCreateAsync(
    new PostV1LedgerOwnersCreateRequest { Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerOwnersCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerOwnersUpdateAsync</a>(PostV1LedgerOwnersUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerOwnersUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerOwnersUpdateAsync(
    new PostV1LedgerOwnersUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerOwnersUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerOwnersDeleteAsync</a>(PostV1LedgerOwnersDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerOwnersDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerOwnersDeleteAsync(
    new PostV1LedgerOwnersDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerOwnersDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerOwnersListAsync</a>(PostV1LedgerOwnersListRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerOwnersListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerOwnersListAsync(new PostV1LedgerOwnersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerOwnersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerJournalTransactionsGetAsync</a>(PostV1LedgerJournalTransactionsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerJournalTransactionsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerJournalTransactionsGetAsync(
    new PostV1LedgerJournalTransactionsGetRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1LedgerJournalTransactionsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ledger.<a href="/src/NordletApi/Ledger/LedgerClient.cs">PostV1LedgerJournalTransactionsCreateAsync</a>(PostV1LedgerJournalTransactionsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1LedgerJournalTransactionsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ledger.PostV1LedgerJournalTransactionsCreateAsync(
    new PostV1LedgerJournalTransactionsCreateRequest
    {
        Date = "date",
        Entries = new List<PostV1LedgerJournalTransactionsCreateRequestEntriesItem>()
        {
            new PostV1LedgerJournalTransactionsCreateRequestEntriesItem
            {
                AccountCode = "accountCode",
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

**request:** `PostV1LedgerJournalTransactionsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Assets
<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">PostV1AssetsGroupsCreateAsync</a>(PostV1AssetsGroupsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1AssetsGroupsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.PostV1AssetsGroupsCreateAsync(
    new PostV1AssetsGroupsCreateRequest
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

**request:** `PostV1AssetsGroupsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">PostV1AssetsGroupsListAsync</a>(PostV1AssetsGroupsListRequest { ... }) -> WithRawResponseTask&lt;PostV1AssetsGroupsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.PostV1AssetsGroupsListAsync(new PostV1AssetsGroupsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AssetsGroupsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">PostV1AssetsAssetsCreateAsync</a>(PostV1AssetsAssetsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1AssetsAssetsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.PostV1AssetsAssetsCreateAsync(
    new PostV1AssetsAssetsCreateRequest
    {
        GroupId = "groupId",
        Code = "code",
        Name = "name",
        AcquisitionDate = "acquisitionDate",
        AcquisitionCost = "acquisitionCost",
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

**request:** `PostV1AssetsAssetsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">PostV1AssetsAssetsGetAsync</a>(PostV1AssetsAssetsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1AssetsAssetsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.PostV1AssetsAssetsGetAsync(new PostV1AssetsAssetsGetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AssetsAssetsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">PostV1AssetsAssetsListAsync</a>(PostV1AssetsAssetsListRequest { ... }) -> WithRawResponseTask&lt;PostV1AssetsAssetsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.PostV1AssetsAssetsListAsync(new PostV1AssetsAssetsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AssetsAssetsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">PostV1AssetsAssetsModernizeAsync</a>(PostV1AssetsAssetsModernizeRequest { ... }) -> WithRawResponseTask&lt;PostV1AssetsAssetsModernizeResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.PostV1AssetsAssetsModernizeAsync(
    new PostV1AssetsAssetsModernizeRequest
    {
        Id = "id",
        Date = "date",
        Amount = "amount",
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

**request:** `PostV1AssetsAssetsModernizeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">PostV1AssetsDepreciationPreviewAsync</a>(PostV1AssetsDepreciationPreviewRequest { ... }) -> WithRawResponseTask&lt;PostV1AssetsDepreciationPreviewResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.PostV1AssetsDepreciationPreviewAsync(
    new PostV1AssetsDepreciationPreviewRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AssetsDepreciationPreviewRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/NordletApi/Assets/AssetsClient.cs">PostV1AssetsDepreciationPostAsync</a>(PostV1AssetsDepreciationPostRequest { ... }) -> WithRawResponseTask&lt;PostV1AssetsDepreciationPostResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.PostV1AssetsDepreciationPostAsync(
    new PostV1AssetsDepreciationPostRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AssetsDepreciationPostRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hr
<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrPositionsCreateAsync</a>(PostV1HrPositionsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1HrPositionsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrPositionsCreateAsync(new PostV1HrPositionsCreateRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrPositionsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrPositionsUpdateAsync</a>(PostV1HrPositionsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1HrPositionsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrPositionsUpdateAsync(new PostV1HrPositionsUpdateRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrPositionsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrPositionsListAsync</a>(PostV1HrPositionsListRequest { ... }) -> WithRawResponseTask&lt;PostV1HrPositionsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrPositionsListAsync(new PostV1HrPositionsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrPositionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrEmployeesCreateAsync</a>(PostV1HrEmployeesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1HrEmployeesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrEmployeesCreateAsync(
    new PostV1HrEmployeesCreateRequest { FirstName = "firstName", LastName = "lastName" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrEmployeesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrEmployeesUpdateAsync</a>(PostV1HrEmployeesUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1HrEmployeesUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrEmployeesUpdateAsync(new PostV1HrEmployeesUpdateRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrEmployeesUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrEmployeesGetAsync</a>(PostV1HrEmployeesGetRequest { ... }) -> WithRawResponseTask&lt;PostV1HrEmployeesGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrEmployeesGetAsync(new PostV1HrEmployeesGetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrEmployeesGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrEmployeesListAsync</a>(PostV1HrEmployeesListRequest { ... }) -> WithRawResponseTask&lt;PostV1HrEmployeesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrEmployeesListAsync(new PostV1HrEmployeesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrEmployeesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrContractsCreateAsync</a>(PostV1HrContractsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1HrContractsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrContractsCreateAsync(
    new PostV1HrContractsCreateRequest
    {
        EmployeeId = "employeeId",
        ContractNo = "contractNo",
        StartDate = "startDate",
        BaseSalary = "baseSalary",
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

**request:** `PostV1HrContractsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrContractsEndAsync</a>(PostV1HrContractsEndRequest { ... }) -> WithRawResponseTask&lt;PostV1HrContractsEndResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrContractsEndAsync(
    new PostV1HrContractsEndRequest { Id = "id", EndDate = "endDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrContractsEndRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrContractsListAsync</a>(PostV1HrContractsListRequest { ... }) -> WithRawResponseTask&lt;PostV1HrContractsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrContractsListAsync(new PostV1HrContractsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrContractsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrLeaveBalancesSetAsync</a>(PostV1HrLeaveBalancesSetRequest { ... }) -> WithRawResponseTask&lt;PostV1HrLeaveBalancesSetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrLeaveBalancesSetAsync(
    new PostV1HrLeaveBalancesSetRequest
    {
        EmployeeId = "employeeId",
        Year = 1000000,
        EntitledDays = "entitledDays",
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

**request:** `PostV1HrLeaveBalancesSetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrLeaveBalancesListAsync</a>(PostV1HrLeaveBalancesListRequest { ... }) -> WithRawResponseTask&lt;PostV1HrLeaveBalancesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrLeaveBalancesListAsync(new PostV1HrLeaveBalancesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrLeaveBalancesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrIncapacityCertificatesCreateAsync</a>(PostV1HrIncapacityCertificatesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1HrIncapacityCertificatesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrIncapacityCertificatesCreateAsync(
    new PostV1HrIncapacityCertificatesCreateRequest
    {
        EmployeeId = "employeeId",
        Number = "number",
        FromDate = "fromDate",
        ToDate = "toDate",
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

**request:** `PostV1HrIncapacityCertificatesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrIncapacityCertificatesListAsync</a>(PostV1HrIncapacityCertificatesListRequest { ... }) -> WithRawResponseTask&lt;PostV1HrIncapacityCertificatesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrIncapacityCertificatesListAsync(
    new PostV1HrIncapacityCertificatesListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrIncapacityCertificatesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrEmployeesRecordsCreateAsync</a>(PostV1HrEmployeesRecordsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1HrEmployeesRecordsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrEmployeesRecordsCreateAsync(
    new PostV1HrEmployeesRecordsCreateRequest
    {
        EmployeeId = "employeeId",
        Type = PostV1HrEmployeesRecordsCreateRequestType.Education,
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

**request:** `PostV1HrEmployeesRecordsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrEmployeesRecordsUpdateAsync</a>(PostV1HrEmployeesRecordsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1HrEmployeesRecordsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrEmployeesRecordsUpdateAsync(
    new PostV1HrEmployeesRecordsUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrEmployeesRecordsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrEmployeesRecordsDeleteAsync</a>(PostV1HrEmployeesRecordsDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1HrEmployeesRecordsDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrEmployeesRecordsDeleteAsync(
    new PostV1HrEmployeesRecordsDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrEmployeesRecordsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrEmployeesRecordsListAsync</a>(PostV1HrEmployeesRecordsListRequest { ... }) -> WithRawResponseTask&lt;PostV1HrEmployeesRecordsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrEmployeesRecordsListAsync(new PostV1HrEmployeesRecordsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrEmployeesRecordsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrEmployeesAttachmentsListAsync</a>(PostV1HrEmployeesAttachmentsListRequest { ... }) -> WithRawResponseTask&lt;PostV1HrEmployeesAttachmentsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrEmployeesAttachmentsListAsync(
    new PostV1HrEmployeesAttachmentsListRequest { EmployeeId = "employeeId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrEmployeesAttachmentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrTimesheetsGenerateAsync</a>(PostV1HrTimesheetsGenerateRequest { ... }) -> WithRawResponseTask&lt;PostV1HrTimesheetsGenerateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrTimesheetsGenerateAsync(
    new PostV1HrTimesheetsGenerateRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrTimesheetsGenerateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrTimesheetsUpsertAsync</a>(PostV1HrTimesheetsUpsertRequest { ... }) -> WithRawResponseTask&lt;PostV1HrTimesheetsUpsertResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrTimesheetsUpsertAsync(
    new PostV1HrTimesheetsUpsertRequest
    {
        EmployeeId = "employeeId",
        Year = 1000000,
        Month = 1000000,
        Days = new List<PostV1HrTimesheetsUpsertRequestDaysItem>()
        {
            new PostV1HrTimesheetsUpsertRequestDaysItem
            {
                Day = 1000000,
                Hours = "hours",
                Type = PostV1HrTimesheetsUpsertRequestDaysItemType.Work,
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

**request:** `PostV1HrTimesheetsUpsertRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrTimesheetsGetAsync</a>(PostV1HrTimesheetsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1HrTimesheetsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrTimesheetsGetAsync(
    new PostV1HrTimesheetsGetRequest
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

**request:** `PostV1HrTimesheetsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrTimesheetsListAsync</a>(PostV1HrTimesheetsListRequest { ... }) -> WithRawResponseTask&lt;PostV1HrTimesheetsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrTimesheetsListAsync(
    new PostV1HrTimesheetsListRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrTimesheetsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hr.<a href="/src/NordletApi/Hr/HrClient.cs">PostV1HrTimesheetsDeleteAsync</a>(PostV1HrTimesheetsDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1HrTimesheetsDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hr.PostV1HrTimesheetsDeleteAsync(new PostV1HrTimesheetsDeleteRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1HrTimesheetsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Fleet
<details><summary><code>client.Fleet.<a href="/src/NordletApi/Fleet/FleetClient.cs">PostV1FleetVehiclesCreateAsync</a>(PostV1FleetVehiclesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1FleetVehiclesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.PostV1FleetVehiclesCreateAsync(
    new PostV1FleetVehiclesCreateRequest
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

**request:** `PostV1FleetVehiclesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Fleet.<a href="/src/NordletApi/Fleet/FleetClient.cs">PostV1FleetVehiclesUpdateAsync</a>(PostV1FleetVehiclesUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1FleetVehiclesUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.PostV1FleetVehiclesUpdateAsync(
    new PostV1FleetVehiclesUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1FleetVehiclesUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Fleet.<a href="/src/NordletApi/Fleet/FleetClient.cs">PostV1FleetVehiclesGetAsync</a>(PostV1FleetVehiclesGetRequest { ... }) -> WithRawResponseTask&lt;PostV1FleetVehiclesGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.PostV1FleetVehiclesGetAsync(new PostV1FleetVehiclesGetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1FleetVehiclesGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Fleet.<a href="/src/NordletApi/Fleet/FleetClient.cs">PostV1FleetVehiclesListAsync</a>(PostV1FleetVehiclesListRequest { ... }) -> WithRawResponseTask&lt;PostV1FleetVehiclesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.PostV1FleetVehiclesListAsync(new PostV1FleetVehiclesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1FleetVehiclesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Fleet.<a href="/src/NordletApi/Fleet/FleetClient.cs">PostV1FleetAssignmentsCreateAsync</a>(PostV1FleetAssignmentsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1FleetAssignmentsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.PostV1FleetAssignmentsCreateAsync(
    new PostV1FleetAssignmentsCreateRequest
    {
        VehicleId = "vehicleId",
        EmployeeId = "employeeId",
        FromDate = "fromDate",
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

**request:** `PostV1FleetAssignmentsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Fleet.<a href="/src/NordletApi/Fleet/FleetClient.cs">PostV1FleetAssignmentsEndAsync</a>(PostV1FleetAssignmentsEndRequest { ... }) -> WithRawResponseTask&lt;PostV1FleetAssignmentsEndResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.PostV1FleetAssignmentsEndAsync(
    new PostV1FleetAssignmentsEndRequest { Id = "id", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1FleetAssignmentsEndRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Fleet.<a href="/src/NordletApi/Fleet/FleetClient.cs">PostV1FleetAssignmentsListAsync</a>(PostV1FleetAssignmentsListRequest { ... }) -> WithRawResponseTask&lt;PostV1FleetAssignmentsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.PostV1FleetAssignmentsListAsync(new PostV1FleetAssignmentsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1FleetAssignmentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Fleet.<a href="/src/NordletApi/Fleet/FleetClient.cs">PostV1FleetNaturaPreviewAsync</a>(PostV1FleetNaturaPreviewRequest { ... }) -> WithRawResponseTask&lt;PostV1FleetNaturaPreviewResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.PostV1FleetNaturaPreviewAsync(
    new PostV1FleetNaturaPreviewRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1FleetNaturaPreviewRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Payroll
<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">PostV1PayrollDepartmentsCreateAsync</a>(PostV1PayrollDepartmentsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1PayrollDepartmentsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.PostV1PayrollDepartmentsCreateAsync(
    new PostV1PayrollDepartmentsCreateRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PayrollDepartmentsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">PostV1PayrollDepartmentsListAsync</a>(PostV1PayrollDepartmentsListRequest { ... }) -> WithRawResponseTask&lt;PostV1PayrollDepartmentsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.PostV1PayrollDepartmentsListAsync(new PostV1PayrollDepartmentsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PayrollDepartmentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">PostV1PayrollSchedulesCreateAsync</a>(PostV1PayrollSchedulesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1PayrollSchedulesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.PostV1PayrollSchedulesCreateAsync(
    new PostV1PayrollSchedulesCreateRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PayrollSchedulesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">PostV1PayrollSchedulesListAsync</a>(PostV1PayrollSchedulesListRequest { ... }) -> WithRawResponseTask&lt;PostV1PayrollSchedulesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.PostV1PayrollSchedulesListAsync(new PostV1PayrollSchedulesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PayrollSchedulesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">PostV1PayrollCalcAsync</a>(PostV1PayrollCalcRequest { ... }) -> WithRawResponseTask&lt;PostV1PayrollCalcResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.PostV1PayrollCalcAsync(
    new PostV1PayrollCalcRequest { TaxableBase = "taxableBase", Date = "date" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PayrollCalcRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">PostV1PayrollRunsCreateAsync</a>(PostV1PayrollRunsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1PayrollRunsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.PostV1PayrollRunsCreateAsync(
    new PostV1PayrollRunsCreateRequest { Year = 1000000, Month = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PayrollRunsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">PostV1PayrollRunsGetAsync</a>(PostV1PayrollRunsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1PayrollRunsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.PostV1PayrollRunsGetAsync(new PostV1PayrollRunsGetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PayrollRunsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">PostV1PayrollRunsListAsync</a>(PostV1PayrollRunsListRequest { ... }) -> WithRawResponseTask&lt;PostV1PayrollRunsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.PostV1PayrollRunsListAsync(new PostV1PayrollRunsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PayrollRunsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">PostV1PayrollRunsApproveAsync</a>(PostV1PayrollRunsApproveRequest { ... }) -> WithRawResponseTask&lt;PostV1PayrollRunsApproveResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.PostV1PayrollRunsApproveAsync(
    new PostV1PayrollRunsApproveRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PayrollRunsApproveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">PostV1PayrollRunsCancelAsync</a>(PostV1PayrollRunsCancelRequest { ... }) -> WithRawResponseTask&lt;PostV1PayrollRunsCancelResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.PostV1PayrollRunsCancelAsync(new PostV1PayrollRunsCancelRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PayrollRunsCancelRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">PostV1PayrollPaymentsExportAsync</a>(PostV1PayrollPaymentsExportRequest { ... }) -> WithRawResponseTask&lt;PostV1PayrollPaymentsExportResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payroll.PostV1PayrollPaymentsExportAsync(
    new PostV1PayrollPaymentsExportRequest { RunId = "runId", BankAccountId = "bankAccountId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PayrollPaymentsExportRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agreements
<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">PostV1AgreementsTypesCreateAsync</a>(PostV1AgreementsTypesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1AgreementsTypesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.PostV1AgreementsTypesCreateAsync(
    new PostV1AgreementsTypesCreateRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AgreementsTypesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">PostV1AgreementsTypesListAsync</a>(PostV1AgreementsTypesListRequest { ... }) -> WithRawResponseTask&lt;PostV1AgreementsTypesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.PostV1AgreementsTypesListAsync(new PostV1AgreementsTypesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AgreementsTypesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">PostV1AgreementsAgreementsCreateAsync</a>(PostV1AgreementsAgreementsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1AgreementsAgreementsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.PostV1AgreementsAgreementsCreateAsync(
    new PostV1AgreementsAgreementsCreateRequest
    {
        PartnerId = "partnerId",
        Number = "number",
        StartDate = "startDate",
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

**request:** `PostV1AgreementsAgreementsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">PostV1AgreementsAgreementsGetAsync</a>(PostV1AgreementsAgreementsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1AgreementsAgreementsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.PostV1AgreementsAgreementsGetAsync(
    new PostV1AgreementsAgreementsGetRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AgreementsAgreementsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">PostV1AgreementsAgreementsUpdateAsync</a>(PostV1AgreementsAgreementsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1AgreementsAgreementsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.PostV1AgreementsAgreementsUpdateAsync(
    new PostV1AgreementsAgreementsUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AgreementsAgreementsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">PostV1AgreementsAgreementsDeleteAsync</a>(PostV1AgreementsAgreementsDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1AgreementsAgreementsDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.PostV1AgreementsAgreementsDeleteAsync(
    new PostV1AgreementsAgreementsDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AgreementsAgreementsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">PostV1AgreementsAgreementsListAsync</a>(PostV1AgreementsAgreementsListRequest { ... }) -> WithRawResponseTask&lt;PostV1AgreementsAgreementsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.PostV1AgreementsAgreementsListAsync(
    new PostV1AgreementsAgreementsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AgreementsAgreementsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">PostV1AgreementsAgreementsGenerateInvoiceAsync</a>(PostV1AgreementsAgreementsGenerateInvoiceRequest { ... }) -> WithRawResponseTask&lt;PostV1AgreementsAgreementsGenerateInvoiceResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.PostV1AgreementsAgreementsGenerateInvoiceAsync(
    new PostV1AgreementsAgreementsGenerateInvoiceRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AgreementsAgreementsGenerateInvoiceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">PostV1AgreementsAgreementsBillingRunAsync</a>(PostV1AgreementsAgreementsBillingRunRequest { ... }) -> WithRawResponseTask&lt;PostV1AgreementsAgreementsBillingRunResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.PostV1AgreementsAgreementsBillingRunAsync(
    new PostV1AgreementsAgreementsBillingRunRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AgreementsAgreementsBillingRunRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">PostV1AgreementsInsurancePoliciesCreateAsync</a>(PostV1AgreementsInsurancePoliciesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1AgreementsInsurancePoliciesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.PostV1AgreementsInsurancePoliciesCreateAsync(
    new PostV1AgreementsInsurancePoliciesCreateRequest
    {
        PolicyNumber = "policyNumber",
        InsuredObject = "insuredObject",
        FromDate = "fromDate",
        ToDate = "toDate",
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

**request:** `PostV1AgreementsInsurancePoliciesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">PostV1AgreementsInsurancePoliciesListAsync</a>(PostV1AgreementsInsurancePoliciesListRequest { ... }) -> WithRawResponseTask&lt;PostV1AgreementsInsurancePoliciesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.PostV1AgreementsInsurancePoliciesListAsync(
    new PostV1AgreementsInsurancePoliciesListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AgreementsInsurancePoliciesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agreements.<a href="/src/NordletApi/Agreements/AgreementsClient.cs">PostV1AgreementsInsurancePoliciesDeleteAsync</a>(PostV1AgreementsInsurancePoliciesDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1AgreementsInsurancePoliciesDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agreements.PostV1AgreementsInsurancePoliciesDeleteAsync(
    new PostV1AgreementsInsurancePoliciesDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AgreementsInsurancePoliciesDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Inventory
<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventorySettingsGetAsync</a>(PostV1InventorySettingsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1InventorySettingsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventorySettingsGetAsync(new PostV1InventorySettingsGetRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1InventorySettingsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventorySettingsUpdateAsync</a>(PostV1InventorySettingsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1InventorySettingsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventorySettingsUpdateAsync(
    new PostV1InventorySettingsUpdateRequest
    {
        NegativeStockPolicy = PostV1InventorySettingsUpdateRequestNegativeStockPolicy.Reject,
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

**request:** `PostV1InventorySettingsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryWarehousesCreateAsync</a>(PostV1InventoryWarehousesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryWarehousesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryWarehousesCreateAsync(
    new PostV1InventoryWarehousesCreateRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1InventoryWarehousesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryWarehousesListAsync</a>(PostV1InventoryWarehousesListRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryWarehousesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryWarehousesListAsync(
    new PostV1InventoryWarehousesListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1InventoryWarehousesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryStockReceiveAsync</a>(PostV1InventoryStockReceiveRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryStockReceiveResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryStockReceiveAsync(
    new PostV1InventoryStockReceiveRequest
    {
        WarehouseId = "warehouseId",
        ItemId = "itemId",
        Date = "date",
        Quantity = "quantity",
        UnitCost = "unitCost",
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

**request:** `PostV1InventoryStockReceiveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryStockWriteOffAsync</a>(PostV1InventoryStockWriteOffRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryStockWriteOffResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryStockWriteOffAsync(
    new PostV1InventoryStockWriteOffRequest
    {
        WarehouseId = "warehouseId",
        ItemId = "itemId",
        Date = "date",
        Quantity = "quantity",
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

**request:** `PostV1InventoryStockWriteOffRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryStockTransferAsync</a>(PostV1InventoryStockTransferRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryStockTransferResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryStockTransferAsync(
    new PostV1InventoryStockTransferRequest
    {
        FromWarehouseId = "fromWarehouseId",
        ToWarehouseId = "toWarehouseId",
        ItemId = "itemId",
        Date = "date",
        Quantity = "quantity",
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

**request:** `PostV1InventoryStockTransferRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryStockTakeAsync</a>(PostV1InventoryStockTakeRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryStockTakeResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryStockTakeAsync(
    new PostV1InventoryStockTakeRequest
    {
        WarehouseId = "warehouseId",
        Date = "date",
        Lines = new List<PostV1InventoryStockTakeRequestLinesItem>()
        {
            new PostV1InventoryStockTakeRequestLinesItem { CountedQty = "countedQty" },
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

**request:** `PostV1InventoryStockTakeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryStockLevelsAsync</a>(PostV1InventoryStockLevelsRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryStockLevelsResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryStockLevelsAsync(new PostV1InventoryStockLevelsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1InventoryStockLevelsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryStockMovementsListAsync</a>(PostV1InventoryStockMovementsListRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryStockMovementsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryStockMovementsListAsync(
    new PostV1InventoryStockMovementsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1InventoryStockMovementsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryLotsListAsync</a>(PostV1InventoryLotsListRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryLotsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryLotsListAsync(new PostV1InventoryLotsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1InventoryLotsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryLotsGetAsync</a>(PostV1InventoryLotsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryLotsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryLotsGetAsync(new PostV1InventoryLotsGetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1InventoryLotsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryLotsUpdateAsync</a>(PostV1InventoryLotsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryLotsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryLotsUpdateAsync(
    new PostV1InventoryLotsUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1InventoryLotsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryLandedCostsCreateAsync</a>(PostV1InventoryLandedCostsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryLandedCostsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryLandedCostsCreateAsync(
    new PostV1InventoryLandedCostsCreateRequest { Date = "date", Amount = "amount" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1InventoryLandedCostsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryLandedCostsGetAsync</a>(PostV1InventoryLandedCostsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryLandedCostsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryLandedCostsGetAsync(
    new PostV1InventoryLandedCostsGetRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1InventoryLandedCostsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryLandedCostsListAsync</a>(PostV1InventoryLandedCostsListRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryLandedCostsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryLandedCostsListAsync(
    new PostV1InventoryLandedCostsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1InventoryLandedCostsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryReorderRulesCreateAsync</a>(PostV1InventoryReorderRulesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryReorderRulesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryReorderRulesCreateAsync(
    new PostV1InventoryReorderRulesCreateRequest { ItemId = "itemId", MinQty = "minQty" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1InventoryReorderRulesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryReorderRulesUpdateAsync</a>(PostV1InventoryReorderRulesUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryReorderRulesUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryReorderRulesUpdateAsync(
    new PostV1InventoryReorderRulesUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1InventoryReorderRulesUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryReorderRulesDeleteAsync</a>(PostV1InventoryReorderRulesDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryReorderRulesDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryReorderRulesDeleteAsync(
    new PostV1InventoryReorderRulesDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1InventoryReorderRulesDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryReorderRulesListAsync</a>(PostV1InventoryReorderRulesListRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryReorderRulesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryReorderRulesListAsync(
    new PostV1InventoryReorderRulesListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1InventoryReorderRulesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">PostV1InventoryReorderRulesCheckAsync</a>(PostV1InventoryReorderRulesCheckRequest { ... }) -> WithRawResponseTask&lt;PostV1InventoryReorderRulesCheckResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inventory.PostV1InventoryReorderRulesCheckAsync(
    new PostV1InventoryReorderRulesCheckRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1InventoryReorderRulesCheckRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Production
<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionWorkCentersCreateAsync</a>(PostV1ProductionWorkCentersCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionWorkCentersCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionWorkCentersCreateAsync(
    new PostV1ProductionWorkCentersCreateRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProductionWorkCentersCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionWorkCentersUpdateAsync</a>(PostV1ProductionWorkCentersUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionWorkCentersUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionWorkCentersUpdateAsync(
    new PostV1ProductionWorkCentersUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProductionWorkCentersUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionWorkCentersListAsync</a>(PostV1ProductionWorkCentersListRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionWorkCentersListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionWorkCentersListAsync(
    new PostV1ProductionWorkCentersListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProductionWorkCentersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionRoutingsCreateAsync</a>(PostV1ProductionRoutingsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionRoutingsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionRoutingsCreateAsync(
    new PostV1ProductionRoutingsCreateRequest
    {
        Code = "code",
        Name = "name",
        Operations = new List<PostV1ProductionRoutingsCreateRequestOperationsItem>()
        {
            new PostV1ProductionRoutingsCreateRequestOperationsItem
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

**request:** `PostV1ProductionRoutingsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionRoutingsGetAsync</a>(PostV1ProductionRoutingsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionRoutingsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionRoutingsGetAsync(
    new PostV1ProductionRoutingsGetRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProductionRoutingsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionRoutingsListAsync</a>(PostV1ProductionRoutingsListRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionRoutingsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionRoutingsListAsync(
    new PostV1ProductionRoutingsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProductionRoutingsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionMaintenanceCreateAsync</a>(PostV1ProductionMaintenanceCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionMaintenanceCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionMaintenanceCreateAsync(
    new PostV1ProductionMaintenanceCreateRequest
    {
        WorkCenterId = "workCenterId",
        Type = PostV1ProductionMaintenanceCreateRequestType.Preventive,
        PlannedDate = "plannedDate",
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

**request:** `PostV1ProductionMaintenanceCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionMaintenanceCompleteAsync</a>(PostV1ProductionMaintenanceCompleteRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionMaintenanceCompleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionMaintenanceCompleteAsync(
    new PostV1ProductionMaintenanceCompleteRequest { Id = "id", CompletedDate = "completedDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProductionMaintenanceCompleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionMaintenanceCancelAsync</a>(PostV1ProductionMaintenanceCancelRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionMaintenanceCancelResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionMaintenanceCancelAsync(
    new PostV1ProductionMaintenanceCancelRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProductionMaintenanceCancelRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionMaintenanceListAsync</a>(PostV1ProductionMaintenanceListRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionMaintenanceListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionMaintenanceListAsync(
    new PostV1ProductionMaintenanceListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProductionMaintenanceListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionBomsCreateAsync</a>(PostV1ProductionBomsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionBomsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionBomsCreateAsync(
    new PostV1ProductionBomsCreateRequest
    {
        Code = "code",
        Name = "name",
        FinishedItemId = "finishedItemId",
        Lines = new List<PostV1ProductionBomsCreateRequestLinesItem>()
        {
            new PostV1ProductionBomsCreateRequestLinesItem
            {
                ComponentItemId = "componentItemId",
                Quantity = "quantity",
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

**request:** `PostV1ProductionBomsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionBomsGetAsync</a>(PostV1ProductionBomsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionBomsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionBomsGetAsync(
    new PostV1ProductionBomsGetRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProductionBomsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionBomsListAsync</a>(PostV1ProductionBomsListRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionBomsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionBomsListAsync(new PostV1ProductionBomsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProductionBomsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionOrdersCreateAsync</a>(PostV1ProductionOrdersCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionOrdersCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionOrdersCreateAsync(
    new PostV1ProductionOrdersCreateRequest
    {
        BomId = "bomId",
        WarehouseId = "warehouseId",
        Quantity = "quantity",
        Date = "date",
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

**request:** `PostV1ProductionOrdersCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionOrdersRecordOperationAsync</a>(PostV1ProductionOrdersRecordOperationRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionOrdersRecordOperationResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionOrdersRecordOperationAsync(
    new PostV1ProductionOrdersRecordOperationRequest { Id = "id", ActualMinutes = "actualMinutes" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProductionOrdersRecordOperationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionQualityChecksAddAsync</a>(PostV1ProductionQualityChecksAddRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionQualityChecksAddResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionQualityChecksAddAsync(
    new PostV1ProductionQualityChecksAddRequest { OrderId = "orderId", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProductionQualityChecksAddRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionQualityChecksRecordAsync</a>(PostV1ProductionQualityChecksRecordRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionQualityChecksRecordResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionQualityChecksRecordAsync(
    new PostV1ProductionQualityChecksRecordRequest
    {
        Id = "id",
        Result = PostV1ProductionQualityChecksRecordRequestResult.Passed,
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

**request:** `PostV1ProductionQualityChecksRecordRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionQualityChecksListAsync</a>(PostV1ProductionQualityChecksListRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionQualityChecksListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionQualityChecksListAsync(
    new PostV1ProductionQualityChecksListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProductionQualityChecksListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionOrdersCompleteAsync</a>(PostV1ProductionOrdersCompleteRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionOrdersCompleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionOrdersCompleteAsync(
    new PostV1ProductionOrdersCompleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProductionOrdersCompleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionOrdersGetAsync</a>(PostV1ProductionOrdersGetRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionOrdersGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionOrdersGetAsync(
    new PostV1ProductionOrdersGetRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProductionOrdersGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Production.<a href="/src/NordletApi/Production/ProductionClient.cs">PostV1ProductionOrdersListAsync</a>(PostV1ProductionOrdersListRequest { ... }) -> WithRawResponseTask&lt;PostV1ProductionOrdersListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Production.PostV1ProductionOrdersListAsync(new PostV1ProductionOrdersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProductionOrdersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ecommerce
<details><summary><code>client.Ecommerce.<a href="/src/NordletApi/Ecommerce/EcommerceClient.cs">PostV1EcommerceOrdersCreateAsync</a>(PostV1EcommerceOrdersCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1EcommerceOrdersCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.PostV1EcommerceOrdersCreateAsync(
    new PostV1EcommerceOrdersCreateRequest
    {
        Lines = new List<PostV1EcommerceOrdersCreateRequestLinesItem>()
        {
            new PostV1EcommerceOrdersCreateRequestLinesItem
            {
                Description = "description",
                Quantity = "quantity",
                UnitPriceExclVat = "unitPriceExclVat",
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

**request:** `PostV1EcommerceOrdersCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/NordletApi/Ecommerce/EcommerceClient.cs">PostV1EcommerceOrdersGetAsync</a>(PostV1EcommerceOrdersGetRequest { ... }) -> WithRawResponseTask&lt;PostV1EcommerceOrdersGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.PostV1EcommerceOrdersGetAsync(
    new PostV1EcommerceOrdersGetRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1EcommerceOrdersGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/NordletApi/Ecommerce/EcommerceClient.cs">PostV1EcommerceOrdersListAsync</a>(PostV1EcommerceOrdersListRequest { ... }) -> WithRawResponseTask&lt;PostV1EcommerceOrdersListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.PostV1EcommerceOrdersListAsync(new PostV1EcommerceOrdersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1EcommerceOrdersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/NordletApi/Ecommerce/EcommerceClient.cs">PostV1EcommerceOrdersReserveAsync</a>(PostV1EcommerceOrdersReserveRequest { ... }) -> WithRawResponseTask&lt;PostV1EcommerceOrdersReserveResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.PostV1EcommerceOrdersReserveAsync(
    new PostV1EcommerceOrdersReserveRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1EcommerceOrdersReserveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/NordletApi/Ecommerce/EcommerceClient.cs">PostV1EcommerceOrdersFulfillAsync</a>(PostV1EcommerceOrdersFulfillRequest { ... }) -> WithRawResponseTask&lt;PostV1EcommerceOrdersFulfillResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.PostV1EcommerceOrdersFulfillAsync(
    new PostV1EcommerceOrdersFulfillRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1EcommerceOrdersFulfillRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/NordletApi/Ecommerce/EcommerceClient.cs">PostV1EcommerceOrdersCancelAsync</a>(PostV1EcommerceOrdersCancelRequest { ... }) -> WithRawResponseTask&lt;PostV1EcommerceOrdersCancelResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.PostV1EcommerceOrdersCancelAsync(
    new PostV1EcommerceOrdersCancelRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1EcommerceOrdersCancelRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/NordletApi/Ecommerce/EcommerceClient.cs">PostV1EcommerceProductsListAsync</a>(PostV1EcommerceProductsListRequest { ... }) -> WithRawResponseTask&lt;PostV1EcommerceProductsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.PostV1EcommerceProductsListAsync(new PostV1EcommerceProductsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1EcommerceProductsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ecommerce.<a href="/src/NordletApi/Ecommerce/EcommerceClient.cs">PostV1EcommerceStockListAsync</a>(PostV1EcommerceStockListRequest { ... }) -> WithRawResponseTask&lt;PostV1EcommerceStockListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ecommerce.PostV1EcommerceStockListAsync(new PostV1EcommerceStockListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1EcommerceStockListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Cash
<details><summary><code>client.Cash.<a href="/src/NordletApi/Cash/CashClient.cs">PostV1CashOrdersCreateAsync</a>(PostV1CashOrdersCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1CashOrdersCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Cash.PostV1CashOrdersCreateAsync(
    new PostV1CashOrdersCreateRequest
    {
        Type = PostV1CashOrdersCreateRequestType.Receipt,
        Date = "date",
        Amount = "amount",
        Purpose = "purpose",
        CounterAccountCode = "counterAccountCode",
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

**request:** `PostV1CashOrdersCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Cash.<a href="/src/NordletApi/Cash/CashClient.cs">PostV1CashOrdersGetAsync</a>(PostV1CashOrdersGetRequest { ... }) -> WithRawResponseTask&lt;PostV1CashOrdersGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Cash.PostV1CashOrdersGetAsync(new PostV1CashOrdersGetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CashOrdersGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Cash.<a href="/src/NordletApi/Cash/CashClient.cs">PostV1CashOrdersListAsync</a>(PostV1CashOrdersListRequest { ... }) -> WithRawResponseTask&lt;PostV1CashOrdersListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Cash.PostV1CashOrdersListAsync(new PostV1CashOrdersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CashOrdersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Cash.<a href="/src/NordletApi/Cash/CashClient.cs">PostV1CashBalanceAsync</a>(PostV1CashBalanceRequest { ... }) -> WithRawResponseTask&lt;PostV1CashBalanceResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Cash.PostV1CashBalanceAsync(new PostV1CashBalanceRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CashBalanceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Cash.<a href="/src/NordletApi/Cash/CashClient.cs">PostV1CashAdvanceHoldersBalancesAsync</a>(PostV1CashAdvanceHoldersBalancesRequest { ... }) -> WithRawResponseTask&lt;PostV1CashAdvanceHoldersBalancesResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Cash.PostV1CashAdvanceHoldersBalancesAsync(
    new PostV1CashAdvanceHoldersBalancesRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1CashAdvanceHoldersBalancesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Projects
<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">PostV1ProjectsCreateAsync</a>(PostV1ProjectsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1ProjectsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.PostV1ProjectsCreateAsync(
    new PostV1ProjectsCreateRequest { Code = "code", Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProjectsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">PostV1ProjectsUpdateAsync</a>(PostV1ProjectsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1ProjectsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.PostV1ProjectsUpdateAsync(new PostV1ProjectsUpdateRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProjectsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">PostV1ProjectsGetAsync</a>(PostV1ProjectsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1ProjectsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.PostV1ProjectsGetAsync(new PostV1ProjectsGetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProjectsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">PostV1ProjectsListAsync</a>(PostV1ProjectsListRequest { ... }) -> WithRawResponseTask&lt;PostV1ProjectsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.PostV1ProjectsListAsync(new PostV1ProjectsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProjectsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">PostV1ProjectsTimeEntriesCreateAsync</a>(PostV1ProjectsTimeEntriesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1ProjectsTimeEntriesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.PostV1ProjectsTimeEntriesCreateAsync(
    new PostV1ProjectsTimeEntriesCreateRequest
    {
        ProjectId = "projectId",
        Date = "date",
        Hours = "hours",
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

**request:** `PostV1ProjectsTimeEntriesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">PostV1ProjectsTimeEntriesUpdateAsync</a>(PostV1ProjectsTimeEntriesUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1ProjectsTimeEntriesUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.PostV1ProjectsTimeEntriesUpdateAsync(
    new PostV1ProjectsTimeEntriesUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProjectsTimeEntriesUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">PostV1ProjectsTimeEntriesDeleteAsync</a>(PostV1ProjectsTimeEntriesDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1ProjectsTimeEntriesDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.PostV1ProjectsTimeEntriesDeleteAsync(
    new PostV1ProjectsTimeEntriesDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProjectsTimeEntriesDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">PostV1ProjectsTimeEntriesListAsync</a>(PostV1ProjectsTimeEntriesListRequest { ... }) -> WithRawResponseTask&lt;PostV1ProjectsTimeEntriesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.PostV1ProjectsTimeEntriesListAsync(
    new PostV1ProjectsTimeEntriesListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProjectsTimeEntriesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">PostV1ProjectsTimeEntriesBillAsync</a>(PostV1ProjectsTimeEntriesBillRequest { ... }) -> WithRawResponseTask&lt;PostV1ProjectsTimeEntriesBillResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.PostV1ProjectsTimeEntriesBillAsync(
    new PostV1ProjectsTimeEntriesBillRequest { ProjectId = "projectId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProjectsTimeEntriesBillRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Projects.<a href="/src/NordletApi/Projects/ProjectsClient.cs">PostV1ProjectsReportAsync</a>(PostV1ProjectsReportRequest { ... }) -> WithRawResponseTask&lt;PostV1ProjectsReportResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Projects.PostV1ProjectsReportAsync(new PostV1ProjectsReportRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ProjectsReportRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Transport
<details><summary><code>client.Transport.<a href="/src/NordletApi/Transport/TransportClient.cs">PostV1TransportWaybillsCreateAsync</a>(PostV1TransportWaybillsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1TransportWaybillsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Transport.PostV1TransportWaybillsCreateAsync(
    new PostV1TransportWaybillsCreateRequest
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

**request:** `PostV1TransportWaybillsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Transport.<a href="/src/NordletApi/Transport/TransportClient.cs">PostV1TransportWaybillsUpdateAsync</a>(PostV1TransportWaybillsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1TransportWaybillsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Transport.PostV1TransportWaybillsUpdateAsync(
    new PostV1TransportWaybillsUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1TransportWaybillsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Transport.<a href="/src/NordletApi/Transport/TransportClient.cs">PostV1TransportWaybillsIssueAsync</a>(PostV1TransportWaybillsIssueRequest { ... }) -> WithRawResponseTask&lt;PostV1TransportWaybillsIssueResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Transport.PostV1TransportWaybillsIssueAsync(
    new PostV1TransportWaybillsIssueRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1TransportWaybillsIssueRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Transport.<a href="/src/NordletApi/Transport/TransportClient.cs">PostV1TransportWaybillsCancelAsync</a>(PostV1TransportWaybillsCancelRequest { ... }) -> WithRawResponseTask&lt;PostV1TransportWaybillsCancelResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Transport.PostV1TransportWaybillsCancelAsync(
    new PostV1TransportWaybillsCancelRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1TransportWaybillsCancelRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Transport.<a href="/src/NordletApi/Transport/TransportClient.cs">PostV1TransportWaybillsGetAsync</a>(PostV1TransportWaybillsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1TransportWaybillsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Transport.PostV1TransportWaybillsGetAsync(
    new PostV1TransportWaybillsGetRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1TransportWaybillsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Transport.<a href="/src/NordletApi/Transport/TransportClient.cs">PostV1TransportWaybillsListAsync</a>(PostV1TransportWaybillsListRequest { ... }) -> WithRawResponseTask&lt;PostV1TransportWaybillsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Transport.PostV1TransportWaybillsListAsync(new PostV1TransportWaybillsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1TransportWaybillsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Pos
<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">PostV1PosDevicesCreateAsync</a>(PostV1PosDevicesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1PosDevicesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.PostV1PosDevicesCreateAsync(
    new PostV1PosDevicesCreateRequest { Name = "name", SerialNumber = "serialNumber" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PosDevicesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">PostV1PosDevicesUpdateAsync</a>(PostV1PosDevicesUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1PosDevicesUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.PostV1PosDevicesUpdateAsync(new PostV1PosDevicesUpdateRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PosDevicesUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">PostV1PosDevicesListAsync</a>(PostV1PosDevicesListRequest { ... }) -> WithRawResponseTask&lt;PostV1PosDevicesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.PostV1PosDevicesListAsync(new PostV1PosDevicesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PosDevicesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">PostV1PosReportsCreateAsync</a>(PostV1PosReportsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1PosReportsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.PostV1PosReportsCreateAsync(
    new PostV1PosReportsCreateRequest
    {
        ReportNumber = "reportNumber",
        Date = "date",
        VatLines = new List<PostV1PosReportsCreateRequestVatLinesItem>()
        {
            new PostV1PosReportsCreateRequestVatLinesItem
            {
                VatRatePercent = "vatRatePercent",
                NetAmount = "netAmount",
                VatAmount = "vatAmount",
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

**request:** `PostV1PosReportsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">PostV1PosReportsGetAsync</a>(PostV1PosReportsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1PosReportsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.PostV1PosReportsGetAsync(new PostV1PosReportsGetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PosReportsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Pos.<a href="/src/NordletApi/Pos/PosClient.cs">PostV1PosReportsListAsync</a>(PostV1PosReportsListRequest { ... }) -> WithRawResponseTask&lt;PostV1PosReportsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Pos.PostV1PosReportsListAsync(new PostV1PosReportsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1PosReportsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Audit
<details><summary><code>client.Audit.<a href="/src/NordletApi/Audit/AuditClient.cs">PostV1AuditListAsync</a>(PostV1AuditListRequest { ... }) -> WithRawResponseTask&lt;PostV1AuditListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Audit.PostV1AuditListAsync(new PostV1AuditListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AuditListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Webhooks
<details><summary><code>client.Webhooks.<a href="/src/NordletApi/Webhooks/WebhooksClient.cs">PostV1WebhooksSubscriptionsCreateAsync</a>(PostV1WebhooksSubscriptionsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1WebhooksSubscriptionsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.PostV1WebhooksSubscriptionsCreateAsync(
    new PostV1WebhooksSubscriptionsCreateRequest
    {
        Url = "url",
        Events = new List<string>() { "events" },
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

**request:** `PostV1WebhooksSubscriptionsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/NordletApi/Webhooks/WebhooksClient.cs">PostV1WebhooksSubscriptionsListAsync</a>(PostV1WebhooksSubscriptionsListRequest { ... }) -> WithRawResponseTask&lt;PostV1WebhooksSubscriptionsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.PostV1WebhooksSubscriptionsListAsync(
    new PostV1WebhooksSubscriptionsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1WebhooksSubscriptionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/NordletApi/Webhooks/WebhooksClient.cs">PostV1WebhooksSubscriptionsUpdateAsync</a>(PostV1WebhooksSubscriptionsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1WebhooksSubscriptionsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.PostV1WebhooksSubscriptionsUpdateAsync(
    new PostV1WebhooksSubscriptionsUpdateRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1WebhooksSubscriptionsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/NordletApi/Webhooks/WebhooksClient.cs">PostV1WebhooksSubscriptionsDeleteAsync</a>(PostV1WebhooksSubscriptionsDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1WebhooksSubscriptionsDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.PostV1WebhooksSubscriptionsDeleteAsync(
    new PostV1WebhooksSubscriptionsDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1WebhooksSubscriptionsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/NordletApi/Webhooks/WebhooksClient.cs">PostV1WebhooksDeliveriesListAsync</a>(PostV1WebhooksDeliveriesListRequest { ... }) -> WithRawResponseTask&lt;PostV1WebhooksDeliveriesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.PostV1WebhooksDeliveriesListAsync(new PostV1WebhooksDeliveriesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1WebhooksDeliveriesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/NordletApi/Webhooks/WebhooksClient.cs">PostV1WebhooksDeliveriesRedeliverAsync</a>(PostV1WebhooksDeliveriesRedeliverRequest { ... }) -> WithRawResponseTask&lt;PostV1WebhooksDeliveriesRedeliverResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.PostV1WebhooksDeliveriesRedeliverAsync(
    new PostV1WebhooksDeliveriesRedeliverRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1WebhooksDeliveriesRedeliverRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Bank
<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankAccountsCreateAsync</a>(PostV1BankAccountsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1BankAccountsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankAccountsCreateAsync(
    new PostV1BankAccountsCreateRequest { Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankAccountsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankAccountsListAsync</a>(PostV1BankAccountsListRequest { ... }) -> WithRawResponseTask&lt;PostV1BankAccountsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankAccountsListAsync(new PostV1BankAccountsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankAccountsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankAccountsUpdateAsync</a>(PostV1BankAccountsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1BankAccountsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankAccountsUpdateAsync(new PostV1BankAccountsUpdateRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankAccountsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankTransactionsImportAsync</a>(PostV1BankTransactionsImportRequest { ... }) -> WithRawResponseTask&lt;PostV1BankTransactionsImportResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankTransactionsImportAsync(
    new PostV1BankTransactionsImportRequest
    {
        BankAccountId = "bankAccountId",
        Transactions = new List<PostV1BankTransactionsImportRequestTransactionsItem>()
        {
            new PostV1BankTransactionsImportRequestTransactionsItem
            {
                Date = "date",
                Amount = "amount",
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

**request:** `PostV1BankTransactionsImportRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankStatementsImportAsync</a>(PostV1BankStatementsImportRequest { ... }) -> WithRawResponseTask&lt;PostV1BankStatementsImportResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankStatementsImportAsync(
    new PostV1BankStatementsImportRequest { BankAccountId = "bankAccountId", Content = "content" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankStatementsImportRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankTransactionsListAsync</a>(PostV1BankTransactionsListRequest { ... }) -> WithRawResponseTask&lt;PostV1BankTransactionsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankTransactionsListAsync(new PostV1BankTransactionsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankTransactionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankTransactionsMatchAsync</a>(PostV1BankTransactionsMatchRequest { ... }) -> WithRawResponseTask&lt;PostV1BankTransactionsMatchResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankTransactionsMatchAsync(
    new PostV1BankTransactionsMatchRequest
    {
        TransactionId = "transactionId",
        DocumentType = PostV1BankTransactionsMatchRequestDocumentType.SaleInvoice,
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

**request:** `PostV1BankTransactionsMatchRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankPaymentsExportAsync</a>(PostV1BankPaymentsExportRequest { ... }) -> WithRawResponseTask&lt;PostV1BankPaymentsExportResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankPaymentsExportAsync(
    new PostV1BankPaymentsExportRequest
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

**request:** `PostV1BankPaymentsExportRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankMandatesCreateAsync</a>(PostV1BankMandatesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1BankMandatesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankMandatesCreateAsync(
    new PostV1BankMandatesCreateRequest
    {
        PartnerId = "partnerId",
        Iban = "iban",
        SignatureDate = "signatureDate",
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

**request:** `PostV1BankMandatesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankMandatesUpdateAsync</a>(PostV1BankMandatesUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1BankMandatesUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankMandatesUpdateAsync(new PostV1BankMandatesUpdateRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankMandatesUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankMandatesCancelAsync</a>(PostV1BankMandatesCancelRequest { ... }) -> WithRawResponseTask&lt;PostV1BankMandatesCancelResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankMandatesCancelAsync(new PostV1BankMandatesCancelRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankMandatesCancelRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankMandatesGetAsync</a>(PostV1BankMandatesGetRequest { ... }) -> WithRawResponseTask&lt;PostV1BankMandatesGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankMandatesGetAsync(new PostV1BankMandatesGetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankMandatesGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankMandatesListAsync</a>(PostV1BankMandatesListRequest { ... }) -> WithRawResponseTask&lt;PostV1BankMandatesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankMandatesListAsync(new PostV1BankMandatesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankMandatesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankDirectDebitsExportAsync</a>(PostV1BankDirectDebitsExportRequest { ... }) -> WithRawResponseTask&lt;PostV1BankDirectDebitsExportResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankDirectDebitsExportAsync(
    new PostV1BankDirectDebitsExportRequest
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

**request:** `PostV1BankDirectDebitsExportRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankTransactionsSuggestMatchesAsync</a>(PostV1BankTransactionsSuggestMatchesRequest { ... }) -> WithRawResponseTask&lt;PostV1BankTransactionsSuggestMatchesResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankTransactionsSuggestMatchesAsync(
    new PostV1BankTransactionsSuggestMatchesRequest { TransactionId = "transactionId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankTransactionsSuggestMatchesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankSettlementsImportAsync</a>(PostV1BankSettlementsImportRequest { ... }) -> WithRawResponseTask&lt;PostV1BankSettlementsImportResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankSettlementsImportAsync(
    new PostV1BankSettlementsImportRequest { BankAccountId = "bankAccountId", Content = "content" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankSettlementsImportRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankSettlementsListAsync</a>(PostV1BankSettlementsListRequest { ... }) -> WithRawResponseTask&lt;PostV1BankSettlementsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankSettlementsListAsync(new PostV1BankSettlementsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankSettlementsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankSettlementsGetAsync</a>(PostV1BankSettlementsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1BankSettlementsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankSettlementsGetAsync(new PostV1BankSettlementsGetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankSettlementsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankSettlementsMatchAsync</a>(PostV1BankSettlementsMatchRequest { ... }) -> WithRawResponseTask&lt;PostV1BankSettlementsMatchResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankSettlementsMatchAsync(
    new PostV1BankSettlementsMatchRequest { LineId = "lineId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankSettlementsMatchRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankSettlementsPostAsync</a>(PostV1BankSettlementsPostRequest { ... }) -> WithRawResponseTask&lt;PostV1BankSettlementsPostResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankSettlementsPostAsync(
    new PostV1BankSettlementsPostRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankSettlementsPostRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">ListThePsd2BanksAspsPsAvailableToConnectAsync</a>(PostV1BankFeedsBanksListRequest { ... }) -> WithRawResponseTask&lt;PostV1BankFeedsBanksListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.ListThePsd2BanksAspsPsAvailableToConnectAsync(
    new PostV1BankFeedsBanksListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankFeedsBanksListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">BeginBankAuthorizationRedirectTheUserToTheReturnedUrlAsync</a>(PostV1BankFeedsConnectionsStartRequest { ... }) -> WithRawResponseTask&lt;PostV1BankFeedsConnectionsStartResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.BeginBankAuthorizationRedirectTheUserToTheReturnedUrlAsync(
    new PostV1BankFeedsConnectionsStartRequest
    {
        AspspName = "aspspName",
        AspspCountry = "aspspCountry",
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

**request:** `PostV1BankFeedsConnectionsStartRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">ExchangeTheRedirectCodeForASessionAndStoreTheBankAccountsItExposesAsync</a>(PostV1BankFeedsConnectionsCompleteRequest { ... }) -> WithRawResponseTask&lt;PostV1BankFeedsConnectionsCompleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.ExchangeTheRedirectCodeForASessionAndStoreTheBankAccountsItExposesAsync(
    new PostV1BankFeedsConnectionsCompleteRequest { Reference = "reference", Code = "code" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankFeedsConnectionsCompleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankFeedsConnectionsGetAsync</a>(PostV1BankFeedsConnectionsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1BankFeedsConnectionsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankFeedsConnectionsGetAsync(
    new PostV1BankFeedsConnectionsGetRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankFeedsConnectionsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PostV1BankFeedsConnectionsListAsync</a>(PostV1BankFeedsConnectionsListRequest { ... }) -> WithRawResponseTask&lt;PostV1BankFeedsConnectionsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PostV1BankFeedsConnectionsListAsync(new PostV1BankFeedsConnectionsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankFeedsConnectionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">RevokeTheConsentAtTheBankAndDropTheStoredConnectionAsync</a>(PostV1BankFeedsConnectionsDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1BankFeedsConnectionsDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.RevokeTheConsentAtTheBankAndDropTheStoredConnectionAsync(
    new PostV1BankFeedsConnectionsDeleteRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankFeedsConnectionsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PointABankFeedAccountAtALedgerBankAccountSoItsTransactionsCanBeSyncedAsync</a>(PostV1BankFeedsAccountsLinkRequest { ... }) -> WithRawResponseTask&lt;PostV1BankFeedsAccountsLinkResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PointABankFeedAccountAtALedgerBankAccountSoItsTransactionsCanBeSyncedAsync(
    new PostV1BankFeedsAccountsLinkRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankFeedsAccountsLinkRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">PullNewTransactionsFromTheBankIntoTheLedgerEmitsBankFeedSyncedAsync</a>(PostV1BankFeedsSyncRequest { ... }) -> WithRawResponseTask&lt;PostV1BankFeedsSyncResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Bank.PullNewTransactionsFromTheBankIntoTheLedgerEmitsBankFeedSyncedAsync(
    new PostV1BankFeedsSyncRequest { ConnectionId = "connectionId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BankFeedsSyncRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Files
<details><summary><code>client.Files.<a href="/src/NordletApi/Files/FilesClient.cs">PostV1FilesUploadAsync</a>(PostV1FilesUploadRequest { ... }) -> WithRawResponseTask&lt;PostV1FilesUploadResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Files.PostV1FilesUploadAsync(
    new PostV1FilesUploadRequest
    {
        Entity = "entity",
        EntityId = "entityId",
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

**request:** `PostV1FilesUploadRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Files.<a href="/src/NordletApi/Files/FilesClient.cs">PostV1FilesGetAsync</a>(PostV1FilesGetRequest { ... }) -> WithRawResponseTask&lt;PostV1FilesGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Files.PostV1FilesGetAsync(new PostV1FilesGetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1FilesGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Files.<a href="/src/NordletApi/Files/FilesClient.cs">PostV1FilesListAsync</a>(PostV1FilesListRequest { ... }) -> WithRawResponseTask&lt;PostV1FilesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Files.PostV1FilesListAsync(new PostV1FilesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1FilesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Files.<a href="/src/NordletApi/Files/FilesClient.cs">PostV1FilesDeleteAsync</a>(PostV1FilesDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1FilesDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Files.PostV1FilesDeleteAsync(new PostV1FilesDeleteRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1FilesDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Reports
<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsTrialBalanceAsync</a>(PostV1ReportsTrialBalanceRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsTrialBalanceResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsTrialBalanceAsync(
    new PostV1ReportsTrialBalanceRequest { FromDate = "fromDate", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsTrialBalanceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsSizeCategoryAsync</a>(PostV1ReportsSizeCategoryRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsSizeCategoryResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsSizeCategoryAsync(
    new PostV1ReportsSizeCategoryRequest { Year = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsSizeCategoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsFinancialStatementsAsync</a>(PostV1ReportsFinancialStatementsRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsFinancialStatementsResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsFinancialStatementsAsync(
    new PostV1ReportsFinancialStatementsRequest { FromDate = "fromDate", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsFinancialStatementsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsGeneralJournalAsync</a>(PostV1ReportsGeneralJournalRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsGeneralJournalResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsGeneralJournalAsync(
    new PostV1ReportsGeneralJournalRequest { FromDate = "fromDate", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsGeneralJournalRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsGlDetailAsync</a>(PostV1ReportsGlDetailRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsGlDetailResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsGlDetailAsync(
    new PostV1ReportsGlDetailRequest
    {
        AccountCode = "accountCode",
        FromDate = "fromDate",
        ToDate = "toDate",
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

**request:** `PostV1ReportsGlDetailRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsPartnerBalancesAsync</a>(PostV1ReportsPartnerBalancesRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsPartnerBalancesResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsPartnerBalancesAsync(new PostV1ReportsPartnerBalancesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsPartnerBalancesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsDebtAgingAsync</a>(PostV1ReportsDebtAgingRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsDebtAgingResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsDebtAgingAsync(new PostV1ReportsDebtAgingRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsDebtAgingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsMonthlySummaryAsync</a>(PostV1ReportsMonthlySummaryRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsMonthlySummaryResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsMonthlySummaryAsync(new PostV1ReportsMonthlySummaryRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsMonthlySummaryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsStockBalanceAsync</a>(PostV1ReportsStockBalanceRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsStockBalanceResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsStockBalanceAsync(
    new PostV1ReportsStockBalanceRequest { AsOf = "asOf" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsStockBalanceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsStockMovementAsync</a>(PostV1ReportsStockMovementRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsStockMovementResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsStockMovementAsync(
    new PostV1ReportsStockMovementRequest { FromDate = "fromDate", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsStockMovementRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsVatSummaryAsync</a>(PostV1ReportsVatSummaryRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsVatSummaryResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsVatSummaryAsync(
    new PostV1ReportsVatSummaryRequest { FromDate = "fromDate", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsVatSummaryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsCashFlowAsync</a>(PostV1ReportsCashFlowRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsCashFlowResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsCashFlowAsync(
    new PostV1ReportsCashFlowRequest { FromDate = "fromDate", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsCashFlowRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsStockAgingAsync</a>(PostV1ReportsStockAgingRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsStockAgingResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsStockAgingAsync(
    new PostV1ReportsStockAgingRequest { AsOf = "asOf" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsStockAgingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsStockShortageAsync</a>(PostV1ReportsStockShortageRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsStockShortageResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsStockShortageAsync(new PostV1ReportsStockShortageRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsStockShortageRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsEuPurchasesAsync</a>(PostV1ReportsEuPurchasesRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsEuPurchasesResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsEuPurchasesAsync(
    new PostV1ReportsEuPurchasesRequest { FromDate = "fromDate", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsEuPurchasesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsVatDetailAsync</a>(PostV1ReportsVatDetailRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsVatDetailResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsVatDetailAsync(
    new PostV1ReportsVatDetailRequest { FromDate = "fromDate", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsVatDetailRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsPosSalesAsync</a>(PostV1ReportsPosSalesRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsPosSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsPosSalesAsync(
    new PostV1ReportsPosSalesRequest { FromDate = "fromDate", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsPosSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsOnlineSalesAsync</a>(PostV1ReportsOnlineSalesRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsOnlineSalesResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsOnlineSalesAsync(
    new PostV1ReportsOnlineSalesRequest { FromDate = "fromDate", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsOnlineSalesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsOssAsync</a>(PostV1ReportsOssRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsOssResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsOssAsync(
    new PostV1ReportsOssRequest { FromDate = "fromDate", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsOssRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsAdvanceReconciliationAsync</a>(PostV1ReportsAdvanceReconciliationRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsAdvanceReconciliationResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsAdvanceReconciliationAsync(
    new PostV1ReportsAdvanceReconciliationRequest { FromDate = "fromDate", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsAdvanceReconciliationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsWriteOffActsAsync</a>(PostV1ReportsWriteOffActsRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsWriteOffActsResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsWriteOffActsAsync(
    new PostV1ReportsWriteOffActsRequest { FromDate = "fromDate", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsWriteOffActsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsCostCentersAsync</a>(PostV1ReportsCostCentersRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsCostCentersResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsCostCentersAsync(
    new PostV1ReportsCostCentersRequest { FromDate = "fromDate", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsCostCentersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsCostCenterActivityAsync</a>(PostV1ReportsCostCenterActivityRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsCostCenterActivityResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsCostCenterActivityAsync(
    new PostV1ReportsCostCenterActivityRequest
    {
        FromDate = "fromDate",
        ToDate = "toDate",
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

**request:** `PostV1ReportsCostCenterActivityRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsCostCenterItemsAsync</a>(PostV1ReportsCostCenterItemsRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsCostCenterItemsResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsCostCenterItemsAsync(
    new PostV1ReportsCostCenterItemsRequest { FromDate = "fromDate", ToDate = "toDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsCostCenterItemsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsJobsCreateAsync</a>(PostV1ReportsJobsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsJobsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsJobsCreateAsync(
    new PostV1ReportsJobsCreateRequest { ReportType = "reportType" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsJobsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsJobsGetAsync</a>(PostV1ReportsJobsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsJobsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsJobsGetAsync(new PostV1ReportsJobsGetRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsJobsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/NordletApi/Reports/ReportsClient.cs">PostV1ReportsJobsListAsync</a>(PostV1ReportsJobsListRequest { ... }) -> WithRawResponseTask&lt;PostV1ReportsJobsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.PostV1ReportsJobsListAsync(new PostV1ReportsJobsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ReportsJobsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Consolidation
<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">PostV1ConsolidationGroupsCreateAsync</a>(PostV1ConsolidationGroupsCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1ConsolidationGroupsCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.PostV1ConsolidationGroupsCreateAsync(
    new PostV1ConsolidationGroupsCreateRequest { Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ConsolidationGroupsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">PostV1ConsolidationGroupsListAsync</a>(PostV1ConsolidationGroupsListRequest { ... }) -> WithRawResponseTask&lt;PostV1ConsolidationGroupsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.PostV1ConsolidationGroupsListAsync(
    new PostV1ConsolidationGroupsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ConsolidationGroupsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">PostV1ConsolidationGroupsGetAsync</a>(PostV1ConsolidationGroupsGetRequest { ... }) -> WithRawResponseTask&lt;PostV1ConsolidationGroupsGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.PostV1ConsolidationGroupsGetAsync(
    new PostV1ConsolidationGroupsGetRequest { GroupId = "groupId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ConsolidationGroupsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">PostV1ConsolidationGroupsUpdateAsync</a>(PostV1ConsolidationGroupsUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1ConsolidationGroupsUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.PostV1ConsolidationGroupsUpdateAsync(
    new PostV1ConsolidationGroupsUpdateRequest { GroupId = "groupId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ConsolidationGroupsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">PostV1ConsolidationGroupsDeleteAsync</a>(PostV1ConsolidationGroupsDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1ConsolidationGroupsDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.PostV1ConsolidationGroupsDeleteAsync(
    new PostV1ConsolidationGroupsDeleteRequest { GroupId = "groupId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ConsolidationGroupsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">PostV1ConsolidationMembersAddAsync</a>(PostV1ConsolidationMembersAddRequest { ... }) -> WithRawResponseTask&lt;PostV1ConsolidationMembersAddResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.PostV1ConsolidationMembersAddAsync(
    new PostV1ConsolidationMembersAddRequest
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

**request:** `PostV1ConsolidationMembersAddRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">PostV1ConsolidationMembersRemoveAsync</a>(PostV1ConsolidationMembersRemoveRequest { ... }) -> WithRawResponseTask&lt;PostV1ConsolidationMembersRemoveResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.PostV1ConsolidationMembersRemoveAsync(
    new PostV1ConsolidationMembersRemoveRequest
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

**request:** `PostV1ConsolidationMembersRemoveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">PostV1ConsolidationIntercompanyCandidatesAsync</a>(PostV1ConsolidationIntercompanyCandidatesRequest { ... }) -> WithRawResponseTask&lt;PostV1ConsolidationIntercompanyCandidatesResponse&gt;</code></summary>
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
await client.Consolidation.PostV1ConsolidationIntercompanyCandidatesAsync(
    new PostV1ConsolidationIntercompanyCandidatesRequest { GroupId = "groupId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ConsolidationIntercompanyCandidatesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">PostV1ConsolidationIntercompanyLinksSetAsync</a>(PostV1ConsolidationIntercompanyLinksSetRequest { ... }) -> WithRawResponseTask&lt;PostV1ConsolidationIntercompanyLinksSetResponse&gt;</code></summary>
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
await client.Consolidation.PostV1ConsolidationIntercompanyLinksSetAsync(
    new PostV1ConsolidationIntercompanyLinksSetRequest
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

**request:** `PostV1ConsolidationIntercompanyLinksSetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">PostV1ConsolidationIntercompanyLinksListAsync</a>(PostV1ConsolidationIntercompanyLinksListRequest { ... }) -> WithRawResponseTask&lt;PostV1ConsolidationIntercompanyLinksListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.PostV1ConsolidationIntercompanyLinksListAsync(
    new PostV1ConsolidationIntercompanyLinksListRequest { GroupId = "groupId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ConsolidationIntercompanyLinksListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">PostV1ConsolidationIntercompanyLinksRemoveAsync</a>(PostV1ConsolidationIntercompanyLinksRemoveRequest { ... }) -> WithRawResponseTask&lt;PostV1ConsolidationIntercompanyLinksRemoveResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.PostV1ConsolidationIntercompanyLinksRemoveAsync(
    new PostV1ConsolidationIntercompanyLinksRemoveRequest { GroupId = "groupId", Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1ConsolidationIntercompanyLinksRemoveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">PostV1ConsolidationIntercompanyReportAsync</a>(PostV1ConsolidationIntercompanyReportRequest { ... }) -> WithRawResponseTask&lt;PostV1ConsolidationIntercompanyReportResponse&gt;</code></summary>
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
await client.Consolidation.PostV1ConsolidationIntercompanyReportAsync(
    new PostV1ConsolidationIntercompanyReportRequest
    {
        GroupId = "groupId",
        FromDate = "fromDate",
        ToDate = "toDate",
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

**request:** `PostV1ConsolidationIntercompanyReportRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Consolidation.<a href="/src/NordletApi/Consolidation/ConsolidationClient.cs">PostV1ConsolidationReportAsync</a>(PostV1ConsolidationReportRequest { ... }) -> WithRawResponseTask&lt;PostV1ConsolidationReportResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Consolidation.PostV1ConsolidationReportAsync(
    new PostV1ConsolidationReportRequest
    {
        GroupId = "groupId",
        FromDate = "fromDate",
        ToDate = "toDate",
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

**request:** `PostV1ConsolidationReportRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Public
<details><summary><code>client.Public.<a href="/src/NordletApi/Public/PublicClient.cs">PostV1PublicIntegrationRequestsAsync</a>(PostV1PublicIntegrationRequestsRequest { ... }) -> WithRawResponseTask&lt;PostV1PublicIntegrationRequestsResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Public.PostV1PublicIntegrationRequestsAsync(
    new PostV1PublicIntegrationRequestsRequest
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

**request:** `PostV1PublicIntegrationRequestsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Billing
<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">PostV1BillingAccountGetAsync</a>(PostV1BillingAccountGetRequest { ... }) -> WithRawResponseTask&lt;PostV1BillingAccountGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.PostV1BillingAccountGetAsync(new PostV1BillingAccountGetRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BillingAccountGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">PostV1BillingAccountSetPlanAsync</a>(PostV1BillingAccountSetPlanRequest { ... }) -> WithRawResponseTask&lt;PostV1BillingAccountSetPlanResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.PostV1BillingAccountSetPlanAsync(
    new PostV1BillingAccountSetPlanRequest { Plan = PostV1BillingAccountSetPlanRequestPlan.Starter }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BillingAccountSetPlanRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">PostV1BillingTopupCreateAsync</a>(PostV1BillingTopupCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1BillingTopupCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.PostV1BillingTopupCreateAsync(
    new PostV1BillingTopupCreateRequest { AmountCents = 1000000 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BillingTopupCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">PostV1BillingTransactionsListAsync</a>(PostV1BillingTransactionsListRequest { ... }) -> WithRawResponseTask&lt;PostV1BillingTransactionsListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.PostV1BillingTransactionsListAsync(new PostV1BillingTransactionsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BillingTransactionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">PostV1BillingUsageListAsync</a>(PostV1BillingUsageListRequest { ... }) -> WithRawResponseTask&lt;PostV1BillingUsageListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Billing.PostV1BillingUsageListAsync(
    new PostV1BillingUsageListRequest { From = "from", To = "to" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1BillingUsageListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Account
<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountLoginLinkRequestAsync</a>(PostV1AccountLoginLinkRequestRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountLoginLinkRequestResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountLoginLinkRequestAsync(
    new PostV1AccountLoginLinkRequestRequest { Email = "email" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountLoginLinkRequestRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountLoginLinkConsumeAsync</a>(PostV1AccountLoginLinkConsumeRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountLoginLinkConsumeResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountLoginLinkConsumeAsync(
    new PostV1AccountLoginLinkConsumeRequest { Token = "token" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountLoginLinkConsumeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountLogoutAsync</a>(PostV1AccountLogoutRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountLogoutResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountLogoutAsync(new PostV1AccountLogoutRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountLogoutRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountMeAsync</a>(PostV1AccountMeRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountMeResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountMeAsync(new PostV1AccountMeRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountMeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountMembersListAsync</a>(PostV1AccountMembersListRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountMembersListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountMembersListAsync(new PostV1AccountMembersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountMembersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountMembersSetRoleAsync</a>(PostV1AccountMembersSetRoleRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountMembersSetRoleResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountMembersSetRoleAsync(
    new PostV1AccountMembersSetRoleRequest
    {
        UserId = "userId",
        Role = PostV1AccountMembersSetRoleRequestRole.Admin,
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

**request:** `PostV1AccountMembersSetRoleRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountMembersRemoveAsync</a>(PostV1AccountMembersRemoveRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountMembersRemoveResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountMembersRemoveAsync(
    new PostV1AccountMembersRemoveRequest { UserId = "userId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountMembersRemoveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountInvitesCreateAsync</a>(PostV1AccountInvitesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountInvitesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountInvitesCreateAsync(
    new PostV1AccountInvitesCreateRequest
    {
        Email = "email",
        Role = PostV1AccountInvitesCreateRequestRole.Admin,
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

**request:** `PostV1AccountInvitesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountInvitesListAsync</a>(PostV1AccountInvitesListRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountInvitesListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountInvitesListAsync(new PostV1AccountInvitesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountInvitesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountInvitesRevokeAsync</a>(PostV1AccountInvitesRevokeRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountInvitesRevokeResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountInvitesRevokeAsync(
    new PostV1AccountInvitesRevokeRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountInvitesRevokeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountInvitesGetAsync</a>(PostV1AccountInvitesGetRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountInvitesGetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountInvitesGetAsync(
    new PostV1AccountInvitesGetRequest { Token = "token" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountInvitesGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountInvitesAcceptAsync</a>(PostV1AccountInvitesAcceptRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountInvitesAcceptResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountInvitesAcceptAsync(
    new PostV1AccountInvitesAcceptRequest { Token = "token" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountInvitesAcceptRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountLocaleSetAsync</a>(PostV1AccountLocaleSetRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountLocaleSetResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountLocaleSetAsync(
    new PostV1AccountLocaleSetRequest { Locale = PostV1AccountLocaleSetRequestLocale.Lt }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountLocaleSetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountCompaniesCreateAsync</a>(PostV1AccountCompaniesCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountCompaniesCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountCompaniesCreateAsync(
    new PostV1AccountCompaniesCreateRequest { Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountCompaniesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountCompaniesSelectAsync</a>(PostV1AccountCompaniesSelectRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountCompaniesSelectResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountCompaniesSelectAsync(
    new PostV1AccountCompaniesSelectRequest { CompanyId = "companyId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountCompaniesSelectRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountCompaniesProfileAsync</a>(PostV1AccountCompaniesProfileRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountCompaniesProfileResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountCompaniesProfileAsync(new PostV1AccountCompaniesProfileRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountCompaniesProfileRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountCompaniesUpdateAsync</a>(PostV1AccountCompaniesUpdateRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountCompaniesUpdateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountCompaniesUpdateAsync(new PostV1AccountCompaniesUpdateRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountCompaniesUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountCompaniesArchiveAsync</a>(PostV1AccountCompaniesArchiveRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountCompaniesArchiveResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountCompaniesArchiveAsync(
    new PostV1AccountCompaniesArchiveRequest { CompanyId = "companyId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountCompaniesArchiveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountCompaniesDeleteAsync</a>(PostV1AccountCompaniesDeleteRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountCompaniesDeleteResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountCompaniesDeleteAsync(
    new PostV1AccountCompaniesDeleteRequest { CompanyId = "companyId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountCompaniesDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountCompaniesActivateAsync</a>(PostV1AccountCompaniesActivateRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountCompaniesActivateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountCompaniesActivateAsync(
    new PostV1AccountCompaniesActivateRequest { CompanyId = "companyId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountCompaniesActivateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountApiKeysCreateAsync</a>(PostV1AccountApiKeysCreateRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountApiKeysCreateResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountApiKeysCreateAsync(
    new PostV1AccountApiKeysCreateRequest { Name = "name" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountApiKeysCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountApiKeysListAsync</a>(PostV1AccountApiKeysListRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountApiKeysListResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountApiKeysListAsync(new PostV1AccountApiKeysListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountApiKeysListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Account.<a href="/src/NordletApi/Account/AccountClient.cs">PostV1AccountApiKeysRevokeAsync</a>(PostV1AccountApiKeysRevokeRequest { ... }) -> WithRawResponseTask&lt;PostV1AccountApiKeysRevokeResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Account.PostV1AccountApiKeysRevokeAsync(
    new PostV1AccountApiKeysRevokeRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostV1AccountApiKeysRevokeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

