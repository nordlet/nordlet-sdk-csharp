using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EuSmeThresholdsListDeclarationsResponseThresholdsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("nationalThreshold")]
    public string? NationalThreshold { get; set; }

    [JsonPropertyName("sectors")]
    public IEnumerable<EuSmeThresholdsListDeclarationsResponseThresholdsItemSectorsItem>? Sectors { get; set; }

    [JsonPropertyName("intraEuAcquisitionsTrigger")]
    public EuSmeThresholdsListDeclarationsResponseThresholdsItemIntraEuAcquisitionsTrigger? IntraEuAcquisitionsTrigger { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("source")]
    public required string Source { get; set; }

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
