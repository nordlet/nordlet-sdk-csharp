using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AssetsUpdateAssetsRequest
{
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("acquisitionDate")]
    public DateOnly? AcquisitionDate { get; set; }

    [JsonPropertyName("depreciationStartDate")]
    public DateOnly? DepreciationStartDate { get; set; }

    [JsonPropertyName("acquisitionCost")]
    public string? AcquisitionCost { get; set; }

    [JsonPropertyName("salvageValue")]
    public string? SalvageValue { get; set; }

    [JsonPropertyName("usefulLifeMonths")]
    public long? UsefulLifeMonths { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("documents")]
    public IEnumerable<AssetsUpdateAssetsRequestDocumentsItem>? Documents { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
