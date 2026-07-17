using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1LedgerOwnersUpdateRequest
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
    public PostV1LedgerOwnersUpdateRequestSharesType? SharesType { get; set; }

    [JsonPropertyName("sharesAcquisitionDate")]
    public string? SharesAcquisitionDate { get; set; }

    [JsonPropertyName("address")]
    public PostV1LedgerOwnersUpdateRequestAddress? Address { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
