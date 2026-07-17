using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CashBalanceRequest
{
    [JsonPropertyName("cashAccountCode")]
    public string? CashAccountCode { get; set; }

    [JsonPropertyName("asOf")]
    public string? AsOf { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
