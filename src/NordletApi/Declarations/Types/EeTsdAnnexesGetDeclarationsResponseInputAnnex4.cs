using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EeTsdAnnexesGetDeclarationsResponseInputAnnex4 : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// 4000: full or partial cover of the employee’s housing costs
    /// </summary>
    [JsonPropertyName("housing")]
    public string? Housing { get; set; }

    /// <summary>
    /// 4010: insurance premiums not required by law, the employee being the beneficiary
    /// </summary>
    [JsonPropertyName("insurancePremiums")]
    public string? InsurancePremiums { get; set; }

    /// <summary>
    /// 4030: compensation for a personal car used for work above the limit
    /// </summary>
    [JsonPropertyName("carCompensationAboveLimit")]
    public string? CarCompensationAboveLimit { get; set; }

    /// <summary>
    /// 4040: an employer vehicle used for non-work purposes (TuMS § 48 lg 8)
    /// </summary>
    [JsonPropertyName("employerVehicle")]
    public string? EmployerVehicle { get; set; }

    /// <summary>
    /// 4050: other employer property used for non-work purposes
    /// </summary>
    [JsonPropertyName("otherProperty")]
    public string? OtherProperty { get; set; }

    /// <summary>
    /// 4061: interest at market terms on a loan given below market interest
    /// </summary>
    [JsonPropertyName("loanMarketInterest")]
    public string? LoanMarketInterest { get; set; }

    /// <summary>
    /// 4062: interest at the rate of the loan contract
    /// </summary>
    [JsonPropertyName("loanContractInterest")]
    public string? LoanContractInterest { get; set; }

    /// <summary>
    /// 4071: market price of a thing, security, right or service given free or cheap
    /// </summary>
    [JsonPropertyName("transferMarketPrice")]
    public string? TransferMarketPrice { get; set; }

    /// <summary>
    /// 4072: price applied to it
    /// </summary>
    [JsonPropertyName("transferAppliedPrice")]
    public string? TransferAppliedPrice { get; set; }

    [JsonPropertyName("stockOption")]
    public EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOption? StockOption { get; set; }

    /// <summary>
    /// 4091: price paid for a thing, security, right or service bought above market
    /// </summary>
    [JsonPropertyName("purchaseAppliedPrice")]
    public string? PurchaseAppliedPrice { get; set; }

    /// <summary>
    /// 4092: its market price
    /// </summary>
    [JsonPropertyName("purchaseMarketPrice")]
    public string? PurchaseMarketPrice { get; set; }

    /// <summary>
    /// 4100: waiver of a monetary claim
    /// </summary>
    [JsonPropertyName("waivedClaims")]
    public string? WaivedClaims { get; set; }

    /// <summary>
    /// 4110: education costs not directly related to the job
    /// </summary>
    [JsonPropertyName("education")]
    public string? Education { get; set; }

    /// <summary>
    /// 4120: health promotion above the yearly exempt amount
    /// </summary>
    [JsonPropertyName("healthPromotion")]
    public string? HealthPromotion { get; set; }

    /// <summary>
    /// 4130: other fringe benefits
    /// </summary>
    [JsonPropertyName("other")]
    public string? Other { get; set; }

    /// <summary>
    /// 4150: of the total, not taxed with Estonian income tax
    /// </summary>
    [JsonPropertyName("notTaxedWithIncomeTax")]
    public string? NotTaxedWithIncomeTax { get; set; }

    /// <summary>
    /// 4160: of the total, not taxed with Estonian social tax
    /// </summary>
    [JsonPropertyName("notTaxedWithSocialTax")]
    public string? NotTaxedWithSocialTax { get; set; }

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
