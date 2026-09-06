using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankFeedsConnectionsCompleteResponseAccountsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("connectionId")]
    public required string ConnectionId { get; set; }

    [JsonPropertyName("bankAccountId")]
    public string? BankAccountId { get; set; }

    [JsonPropertyName("importTemplateId")]
    public string? ImportTemplateId { get; set; }

    [JsonPropertyName("syncSchedule")]
    public required PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule SyncSchedule { get; set; }

    [JsonPropertyName("externalId")]
    public required string ExternalId { get; set; }

    [JsonPropertyName("iban")]
    public string? Iban { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("product")]
    public string? Product { get; set; }

    [JsonPropertyName("syncFrom")]
    public string? SyncFrom { get; set; }

    [JsonPropertyName("lastSyncedAt")]
    public string? LastSyncedAt { get; set; }

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
