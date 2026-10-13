using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AccountSetAutoTopUpBillingRequest
{
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }

    [JsonPropertyName("amountCents")]
    public required long AmountCents { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
