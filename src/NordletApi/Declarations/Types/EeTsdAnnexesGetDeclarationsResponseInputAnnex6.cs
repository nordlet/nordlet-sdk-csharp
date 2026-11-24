using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EeTsdAnnexesGetDeclarationsResponseInputAnnex6 : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Part II rows; their sum is 6000
    /// </summary>
    [JsonPropertyName("relatedParties")]
    public IEnumerable<EeTsdAnnexesGetDeclarationsResponseInputAnnex6RelatedPartiesItem>? RelatedParties { get; set; }

    /// <summary>
    /// 6010: fines and penalty payments imposed by law
    /// </summary>
    [JsonPropertyName("fines")]
    public string? Fines { get; set; }

    /// <summary>
    /// 6020: interest paid under the Taxation Act
    /// </summary>
    [JsonPropertyName("taxInterest")]
    public string? TaxInterest { get; set; }

    /// <summary>
    /// 6030: value of confiscated property
    /// </summary>
    [JsonPropertyName("confiscatedProperty")]
    public string? ConfiscatedProperty { get; set; }

    /// <summary>
    /// 6040: environmental charges at the elevated rate and damage compensation
    /// </summary>
    [JsonPropertyName("environmentalCharges")]
    public string? EnvironmentalCharges { get; set; }

    /// <summary>
    /// 6050: bribes
    /// </summary>
    [JsonPropertyName("bribes")]
    public string? Bribes { get; set; }

    /// <summary>
    /// 6060: entrance and membership fees of non-profits not related to the business
    /// </summary>
    [JsonPropertyName("membershipFees")]
    public string? MembershipFees { get; set; }

    /// <summary>
    /// 6070: payments without a source document meeting the requirements
    /// </summary>
    [JsonPropertyName("undocumentedPayments")]
    public string? UndocumentedPayments { get; set; }

    /// <summary>
    /// 6080: non-business obligations, assets and services, excess borrowing costs and the other amounts of the code
    /// </summary>
    [JsonPropertyName("nonBusinessExpenses")]
    public string? NonBusinessExpenses { get; set; }

    /// <summary>
    /// 6090: securities of a legal person in a low tax rate territory
    /// </summary>
    [JsonPropertyName("lowTaxSecurities")]
    public string? LowTaxSecurities { get; set; }

    /// <summary>
    /// 6100: holdings in a legal person in a low tax rate territory
    /// </summary>
    [JsonPropertyName("lowTaxHoldings")]
    public string? LowTaxHoldings { get; set; }

    /// <summary>
    /// 6110: penalties and damages paid to such a legal person
    /// </summary>
    [JsonPropertyName("lowTaxPenalties")]
    public string? LowTaxPenalties { get; set; }

    /// <summary>
    /// 6120: loans, prepayments and claims against such a legal person
    /// </summary>
    [JsonPropertyName("lowTaxLoans")]
    public string? LowTaxLoans { get; set; }

    /// <summary>
    /// 6130: credit institutions only
    /// </summary>
    [JsonPropertyName("creditInstitutionLosses")]
    public string? CreditInstitutionLosses { get; set; }

    /// <summary>
    /// 6140: reductions of an amount taxed on an earlier annex 6 (TuMS § 54 lg 6)
    /// </summary>
    [JsonPropertyName("reductions")]
    public IEnumerable<EeTsdAnnexesGetDeclarationsResponseInputAnnex6ReductionsItem>? Reductions { get; set; }

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
