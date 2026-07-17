using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1WebhooksDeliveriesListResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("subscriptionId")]
    public required string SubscriptionId { get; set; }

    [JsonPropertyName("eventType")]
    public required string EventType { get; set; }

    [JsonPropertyName("status")]
    public required PostV1WebhooksDeliveriesListResponseRowsItemStatus Status { get; set; }

    [JsonPropertyName("attempts")]
    public required long Attempts { get; set; }

    [JsonPropertyName("lastError")]
    public string? LastError { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("deliveredAt")]
    public string? DeliveredAt { get; set; }

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
