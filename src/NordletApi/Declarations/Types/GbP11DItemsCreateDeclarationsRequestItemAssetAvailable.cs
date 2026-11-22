using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbP11DItemsCreateDeclarationsRequestItemAssetAvailable : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asset")]
    public required GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset Asset { get; set; }

    [JsonPropertyName("otherDescription")]
    public string? OtherDescription { get; set; }

    [JsonPropertyName("annualValue")]
    public required string AnnualValue { get; set; }

    [JsonPropertyName("madeGood")]
    public required string MadeGood { get; set; }

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
