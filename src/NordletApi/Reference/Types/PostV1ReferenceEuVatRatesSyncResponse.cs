using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReferenceEuVatRatesSyncResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("situationOn")]
    public required string SituationOn { get; set; }

    [JsonPropertyName("status")]
    public required PostV1ReferenceEuVatRatesSyncResponseStatus Status { get; set; }

    [JsonPropertyName("ratesFetched")]
    public required long RatesFetched { get; set; }

    [JsonPropertyName("ratesInserted")]
    public required long RatesInserted { get; set; }

    [JsonPropertyName("ratesClosed")]
    public required long RatesClosed { get; set; }

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
