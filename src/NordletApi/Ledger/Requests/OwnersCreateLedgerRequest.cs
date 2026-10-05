using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record OwnersCreateLedgerRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("equityAccountCode")]
    public string? EquityAccountCode { get; set; }

    [JsonPropertyName("sharesQuantity")]
    public string? SharesQuantity { get; set; }

    [JsonPropertyName("sharesAmount")]
    public string? SharesAmount { get; set; }

    [JsonPropertyName("sharesType")]
    public OwnersCreateLedgerRequestSharesType? SharesType { get; set; }

    [JsonPropertyName("sharesAcquisitionDate")]
    public DateOnly? SharesAcquisitionDate { get; set; }

    [JsonPropertyName("withholdingTaxPercent")]
    public string? WithholdingTaxPercent { get; set; }

    [JsonPropertyName("partnerLiability")]
    public OwnersCreateLedgerRequestPartnerLiability? PartnerLiability { get; set; }

    [JsonPropertyName("specialBalanceRequired")]
    public bool? SpecialBalanceRequired { get; set; }

    [JsonPropertyName("supplementaryBalanceRequired")]
    public bool? SupplementaryBalanceRequired { get; set; }

    [JsonPropertyName("address")]
    public OwnersCreateLedgerRequestAddress? Address { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
