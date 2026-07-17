using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1LedgerOwnersUpdateResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("equityAccountCode")]
    public required string EquityAccountCode { get; set; }

    [JsonPropertyName("sharesQuantity")]
    public string? SharesQuantity { get; set; }

    [JsonPropertyName("sharesAmount")]
    public string? SharesAmount { get; set; }

    [JsonPropertyName("sharesType")]
    public string? SharesType { get; set; }

    [JsonPropertyName("sharesAcquisitionDate")]
    public string? SharesAcquisitionDate { get; set; }

    [JsonPropertyName("address")]
    public PostV1LedgerOwnersUpdateResponseAddress? Address { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

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
