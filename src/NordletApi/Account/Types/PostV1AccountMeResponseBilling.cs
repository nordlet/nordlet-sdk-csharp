using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountMeResponseBilling : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("status")]
    public required PostV1AccountMeResponseBillingStatus Status { get; set; }

    [JsonPropertyName("plan")]
    public required string Plan { get; set; }

    [JsonPropertyName("balanceCents")]
    public required long BalanceCents { get; set; }

    [JsonPropertyName("trialEndsAt")]
    public string? TrialEndsAt { get; set; }

    [JsonPropertyName("payerUserId")]
    public required string PayerUserId { get; set; }

    [JsonPropertyName("payerEmail")]
    public required string PayerEmail { get; set; }

    [JsonPropertyName("isPayer")]
    public required bool IsPayer { get; set; }

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
