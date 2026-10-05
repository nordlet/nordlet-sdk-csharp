using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record BalanceCashRequest
{
    [JsonPropertyName("cashAccountCode")]
    public string? CashAccountCode { get; set; }

    [JsonPropertyName("asOf")]
    public DateOnly? AsOf { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
