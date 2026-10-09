# Reference
## reference
<details><summary><code>client.Reference.<a href="/src/NordletApi/Reference/ReferenceClient.cs">ExchangeRatesSyncAsync</a>(ExchangeRatesSyncReferenceRequest { ... }) -> WithRawResponseTask&lt;ExchangeRatesSyncReferenceResponse&gt;</code></summary>
<dl>
<dd>

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

<details><summary><code>client.Partners.<a href="/src/NordletApi/Partners/PartnersClient.cs">ValidateVatAsync</a>(ValidateVatPartnersRequest { ... }) -> WithRawResponseTask&lt;ValidateVatPartnersResponse&gt;</code></summary>
<dl>
<dd>

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

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">InvoicesSendAsync</a>(InvoicesSendSalesRequest { ... }) -> WithRawResponseTask&lt;InvoicesSendSalesResponse&gt;</code></summary>
<dl>
<dd>

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

<details><summary><code>client.Sales.<a href="/src/NordletApi/Sales/SalesClient.cs">RecognitionComputeAsync</a>(RecognitionComputeSalesRequest { ... }) -> WithRawResponseTask&lt;RecognitionComputeSalesResponse&gt;</code></summary>
<dl>
<dd>

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

## OperationTypes
<details><summary><code>client.OperationTypes.<a href="/src/NordletApi/OperationTypes/OperationTypesClient.cs">CreateAsync</a>(CreateOperationTypesRequest { ... }) -> WithRawResponseTask&lt;CreateOperationTypesResponse&gt;</code></summary>
<dl>
<dd>

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

## declarations
<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">LtIntrastatComputeAsync</a>(LtIntrastatComputeDeclarationsRequest { ... }) -> WithRawResponseTask&lt;LtIntrastatComputeDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

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

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">EuDistanceSalesThresholdGetAsync</a>(EuDistanceSalesThresholdGetDeclarationsRequest { ... }) -> WithRawResponseTask&lt;EuDistanceSalesThresholdGetDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

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

Build one of the German returns that ELSTER accepts only through a licensed ERiC transmission (E-Bilanz, Körperschaftsteuer, Gewerbesteuer with its Zerlegungserklärung, annual VAT return, Lohnsteuer-Anmeldung, Lohnsteuerbescheinigung) for the company to send through its own ELSTER-capable program. The period is the year, or YYYY-MM for the monthly Lohnsteuer-Anmeldung.
</dd>
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

<details><summary><code>client.Declarations.<a href="/src/NordletApi/Declarations/DeclarationsClient.cs">DeReturnFactsGetAsync</a>(DeReturnFactsGetDeclarationsRequest { ... }) -> WithRawResponseTask&lt;DeReturnFactsGetDeclarationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

The facts of one year that the German annual returns (Körperschaftsteuer, Gewerbesteuer, Umsatzsteuererklärung) need and the ledger does not hold: changes of shareholders, contracts with shareholders, the tax contribution account, loss carry-back, the donation carry-forward, the business premises with the municipalities for the apportionment of the trade tax, the land values or property tax and the participations for the trade tax additions and reductions, the foreign income per country for the Anlage AESt, the date of leaving the small-business scheme and the Anlage UN answers of a company seated abroad. A key that is absent has not been answered.
</dd>
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

Build the working paper for the Form B1 annual return of a financial year - company details, registered office, directors and secretary from Settings → Officers, the members from Settings → Shareholders, the issued share capital and the figures of the financial statements - in the order the CORE screens ask for them. The CRO publishes no file format for the B1, so it is keyed into CORE.
</dd>
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

Generate PIT-11(29) for every person on the payroll of one year: the pay, the deductible costs, the advance withheld and the social and health contributions taken off it. One document per person, because that is how the form is filed.
</dd>
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

Replaces the seeded chart with the chart template of the company country (the Romanian general chart for a company registered in Romania, the Lithuanian standard chart otherwise) and switches the posting defaults with it. Answers 409 when the company already uses that chart, has journal entries, holds accounts created by hand, or has settings that name an account the new chart does not have.
</dd>
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

The rows or codes of each return or registry deposit of the company country that are filled from account balances. Accounts fall into a row by the layout defaults for the standard chart of accounts unless mapped under Settings → Statement rows.
</dd>
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

<details><summary><code>client.Payroll.<a href="/src/NordletApi/Payroll/PayrollClient.cs">CalcAsync</a>(CalcPayrollRequest { ... }) -> WithRawResponseTask&lt;CalcPayrollResponse&gt;</code></summary>
<dl>
<dd>

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

<details><summary><code>client.Inventory.<a href="/src/NordletApi/Inventory/InventoryClient.cs">StockReceiveAsync</a>(StockReceiveInventoryRequest { ... }) -> WithRawResponseTask&lt;StockReceiveInventoryResponse&gt;</code></summary>
<dl>
<dd>

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

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">ImportTemplatesListAsync</a>(ImportTemplatesListBankRequest { ... }) -> WithRawResponseTask&lt;ImportTemplatesListBankResponse&gt;</code></summary>
<dl>
<dd>

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

<details><summary><code>client.Bank.<a href="/src/NordletApi/Bank/BankClient.cs">FeedsBanksListAsync</a>(FeedsBanksListBankRequest { ... }) -> WithRawResponseTask&lt;FeedsBanksListBankResponse&gt;</code></summary>
<dl>
<dd>

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

## billing
<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">AccountGetAsync</a>(AccountGetBillingRequest { ... }) -> WithRawResponseTask&lt;AccountGetBillingResponse&gt;</code></summary>
<dl>
<dd>

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

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">TopupCreateAsync</a>(TopupCreateBillingRequest { ... }) -> WithRawResponseTask&lt;TopupCreateBillingResponse&gt;</code></summary>
<dl>
<dd>

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

<details><summary><code>client.Billing.<a href="/src/NordletApi/Billing/BillingClient.cs">PortalCreateAsync</a>(PortalCreateBillingRequest { ... }) -> WithRawResponseTask&lt;PortalCreateBillingResponse&gt;</code></summary>
<dl>
<dd>

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

