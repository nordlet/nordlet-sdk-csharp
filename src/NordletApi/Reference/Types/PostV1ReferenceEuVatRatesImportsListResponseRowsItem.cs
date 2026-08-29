using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReferenceEuVatRatesImportsListResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("situationOn")]
    public required string SituationOn { get; set; }

    [JsonPropertyName("status")]
    public required PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus Status { get; set; }

    [JsonPropertyName("trigger")]
    public required PostV1ReferenceEuVatRatesImportsListResponseRowsItemTrigger Trigger { get; set; }

    [JsonPropertyName("ratesFetched")]
    public required long RatesFetched { get; set; }

    [JsonPropertyName("ratesInserted")]
    public required long RatesInserted { get; set; }

    [JsonPropertyName("ratesClosed")]
    public required long RatesClosed { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("startedAt")]
    public required string StartedAt { get; set; }

    [JsonPropertyName("finishedAt")]
    public string? FinishedAt { get; set; }

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
