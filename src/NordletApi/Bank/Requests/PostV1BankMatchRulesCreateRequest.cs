using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankMatchRulesCreateRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    [JsonPropertyName("pattern")]
    public required string Pattern { get; set; }

    [JsonPropertyName("payoutIdPrefix")]
    public string? PayoutIdPrefix { get; set; }

    [JsonPropertyName("bankAccountId")]
    public string? BankAccountId { get; set; }

    [JsonPropertyName("dateWindowDays")]
    public long? DateWindowDays { get; set; }

    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
