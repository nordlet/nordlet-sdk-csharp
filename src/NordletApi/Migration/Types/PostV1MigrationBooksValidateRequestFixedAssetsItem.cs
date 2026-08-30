using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1MigrationBooksValidateRequestFixedAssetsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("groupCode")]
    public required string GroupCode { get; set; }

    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("acquisitionDate")]
    public required string AcquisitionDate { get; set; }

    [JsonPropertyName("depreciationStartDate")]
    public string? DepreciationStartDate { get; set; }

    [JsonPropertyName("acquisitionCost")]
    public required string AcquisitionCost { get; set; }

    [JsonPropertyName("salvageValue")]
    public string? SalvageValue { get; set; }

    [JsonPropertyName("usefulLifeMonths")]
    public long? UsefulLifeMonths { get; set; }

    [JsonPropertyName("accumulatedDepreciation")]
    public string? AccumulatedDepreciation { get; set; }

    [JsonPropertyName("depreciatedMonths")]
    public long? DepreciatedMonths { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

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
