using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbP11DItemsCreateDeclarationsResponseItemLoan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("jointBorrowers")]
    public required long JointBorrowers { get; set; }

    [JsonPropertyName("outstandingStart")]
    public required string OutstandingStart { get; set; }

    [JsonPropertyName("outstandingEnd")]
    public required string OutstandingEnd { get; set; }

    [JsonPropertyName("maximumOutstanding")]
    public required string MaximumOutstanding { get; set; }

    [JsonPropertyName("interestPaid")]
    public required string InterestPaid { get; set; }

    [JsonPropertyName("madeOn")]
    public DateOnly? MadeOn { get; set; }

    [JsonPropertyName("dischargedOn")]
    public DateOnly? DischargedOn { get; set; }

    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

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
