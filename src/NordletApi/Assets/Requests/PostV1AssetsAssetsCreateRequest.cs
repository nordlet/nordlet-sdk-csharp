using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AssetsAssetsCreateRequest
{
    [JsonPropertyName("groupId")]
    public required string GroupId { get; set; }

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

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("documents")]
    public IEnumerable<PostV1AssetsAssetsCreateRequestDocumentsItem>? Documents { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
