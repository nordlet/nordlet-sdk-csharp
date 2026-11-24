using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AssetsCreateFromPurchaseAssetsRequest
{
    [JsonPropertyName("purchaseInvoiceLineId")]
    public required string PurchaseInvoiceLineId { get; set; }

    [JsonPropertyName("groupId")]
    public required string GroupId { get; set; }

    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
    public IEnumerable<AssetsCreateFromPurchaseAssetsRequestDocumentsItem>? Documents { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
