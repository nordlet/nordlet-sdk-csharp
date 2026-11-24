using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostingRulesCreateBankRequest
{
    [JsonPropertyName("counterpartyContains")]
    public string? CounterpartyContains { get; set; }

    [JsonPropertyName("descriptionContains")]
    public string? DescriptionContains { get; set; }

    [JsonPropertyName("accountCode")]
    public required string AccountCode { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
