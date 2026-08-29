using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankFeedsConnectionsGetResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    [JsonPropertyName("aspspName")]
    public required string AspspName { get; set; }

    [JsonPropertyName("aspspCountry")]
    public required string AspspCountry { get; set; }

    [JsonPropertyName("psuType")]
    public required PostV1BankFeedsConnectionsGetResponsePsuType PsuType { get; set; }

    [JsonPropertyName("status")]
    public required PostV1BankFeedsConnectionsGetResponseStatus Status { get; set; }

    [JsonPropertyName("reference")]
    public required string Reference { get; set; }

    [JsonPropertyName("consentExpiresAt")]
    public string? ConsentExpiresAt { get; set; }

    [JsonPropertyName("lastSyncedAt")]
    public string? LastSyncedAt { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required string UpdatedAt { get; set; }

    [JsonPropertyName("accounts")]
    public IEnumerable<PostV1BankFeedsConnectionsGetResponseAccountsItem> Accounts { get; set; } =
        new List<PostV1BankFeedsConnectionsGetResponseAccountsItem>();

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
