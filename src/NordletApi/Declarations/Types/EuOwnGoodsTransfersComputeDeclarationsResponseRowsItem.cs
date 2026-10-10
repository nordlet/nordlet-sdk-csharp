using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EuOwnGoodsTransfersComputeDeclarationsResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("destinationCountryCode")]
    public required string DestinationCountryCode { get; set; }

    [JsonPropertyName("dispatchCountryCode")]
    public required string DispatchCountryCode { get; set; }

    [JsonPropertyName("taxableAmount")]
    public required string TaxableAmount { get; set; }

    [JsonPropertyName("transfers")]
    public required long Transfers { get; set; }

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
