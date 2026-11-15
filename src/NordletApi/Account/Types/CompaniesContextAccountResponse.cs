using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CompaniesContextAccountResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("periods")]
    public required CompaniesContextAccountResponsePeriods Periods { get; set; }

    [JsonPropertyName("postingRules")]
    public Dictionary<string, string> PostingRules { get; set; } = new Dictionary<string, string>();

    [JsonPropertyName("bankAccounts")]
    public IEnumerable<CompaniesContextAccountResponseBankAccountsItem> BankAccounts { get; set; } =
        new List<CompaniesContextAccountResponseBankAccountsItem>();

    [JsonPropertyName("vatTypesUsed")]
    public IEnumerable<CompaniesContextAccountResponseVatTypesUsedItem> VatTypesUsed { get; set; } =
        new List<CompaniesContextAccountResponseVatTypesUsedItem>();

    [JsonPropertyName("filings")]
    public IEnumerable<CompaniesContextAccountResponseFilingsItem> Filings { get; set; } =
        new List<CompaniesContextAccountResponseFilingsItem>();

    [JsonPropertyName("payroll")]
    public required CompaniesContextAccountResponsePayroll Payroll { get; set; }

    [JsonPropertyName("profile")]
    public required CompaniesContextAccountResponseProfile Profile { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
