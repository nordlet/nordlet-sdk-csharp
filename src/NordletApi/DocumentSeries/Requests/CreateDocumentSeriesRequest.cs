using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CreateDocumentSeriesRequest
{
    [JsonPropertyName("documentType")]
    public CreateDocumentSeriesRequestDocumentType? DocumentType { get; set; }

    [JsonPropertyName("prefix")]
    public required string Prefix { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("operationTypeId")]
    public string? OperationTypeId { get; set; }

    [JsonPropertyName("numberLength")]
    public long? NumberLength { get; set; }

    [JsonPropertyName("nextNumber")]
    public long? NextNumber { get; set; }

    [JsonPropertyName("allocatedFrom")]
    public long? AllocatedFrom { get; set; }

    [JsonPropertyName("allocatedTo")]
    public long? AllocatedTo { get; set; }

    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    [JsonPropertyName("printSeries")]
    public bool? PrintSeries { get; set; }

    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
