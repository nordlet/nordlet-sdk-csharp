using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SettlementsCommissionBankRequest
{
    [JsonPropertyName("lineId")]
    public required string LineId { get; set; }

    [JsonPropertyName("commissionPercent")]
    public string? CommissionPercent { get; set; }

    [JsonPropertyName("commissionAmount")]
    public string? CommissionAmount { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
