using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SecuritiesListBankResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("bankAccountId")]
    public required string BankAccountId { get; set; }

    [JsonPropertyName("broker")]
    public required string Broker { get; set; }

    [JsonPropertyName("brokerAccount")]
    public required string BrokerAccount { get; set; }

    [JsonPropertyName("period")]
    public required string Period { get; set; }

    [JsonPropertyName("fileName")]
    public string? FileName { get; set; }

    [JsonPropertyName("operationCount")]
    public required long OperationCount { get; set; }

    [JsonPropertyName("duplicateCount")]
    public required long DuplicateCount { get; set; }

    [JsonPropertyName("postedCount")]
    public required long PostedCount { get; set; }

    [JsonPropertyName("notPostedCount")]
    public required long NotPostedCount { get; set; }

    [JsonPropertyName("realizedTotal")]
    public required string RealizedTotal { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

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
