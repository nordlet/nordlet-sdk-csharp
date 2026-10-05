using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record OwnersUpdateLedgerRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("equityAccountCode")]
    public string? EquityAccountCode { get; set; }

    [JsonPropertyName("sharesQuantity")]
    public string? SharesQuantity { get; set; }

    [JsonPropertyName("sharesAmount")]
    public string? SharesAmount { get; set; }

    [JsonPropertyName("sharesType")]
    public OwnersUpdateLedgerRequestSharesType? SharesType { get; set; }

    [JsonPropertyName("sharesAcquisitionDate")]
    public DateOnly? SharesAcquisitionDate { get; set; }

    [JsonPropertyName("withholdingTaxPercent")]
    public string? WithholdingTaxPercent { get; set; }

    [JsonPropertyName("partnerLiability")]
    public OwnersUpdateLedgerRequestPartnerLiability? PartnerLiability { get; set; }

    [JsonPropertyName("specialBalanceRequired")]
    public bool? SpecialBalanceRequired { get; set; }

    [JsonPropertyName("supplementaryBalanceRequired")]
    public bool? SupplementaryBalanceRequired { get; set; }

    [JsonPropertyName("address")]
    public OwnersUpdateLedgerRequestAddress? Address { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
