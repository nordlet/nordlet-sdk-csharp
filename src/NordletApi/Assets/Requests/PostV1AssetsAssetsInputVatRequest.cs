using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AssetsAssetsInputVatRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("inputVatAmount")]
    public string? InputVatAmount { get; set; }

    [JsonPropertyName("inputVatFirstUseDate")]
    public string? InputVatFirstUseDate { get; set; }

    [JsonPropertyName("inputVatDeductiblePercent")]
    public string? InputVatDeductiblePercent { get; set; }

    [JsonPropertyName("inputVatRealEstate")]
    public required bool InputVatRealEstate { get; set; }

    [JsonPropertyName("inputVatUseChanges")]
    public IEnumerable<PostV1AssetsAssetsInputVatRequestInputVatUseChangesItem> InputVatUseChanges { get; set; } =
        new List<PostV1AssetsAssetsInputVatRequestInputVatUseChangesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
