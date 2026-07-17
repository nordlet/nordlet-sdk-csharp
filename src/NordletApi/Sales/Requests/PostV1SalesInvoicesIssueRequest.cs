using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesInvoicesIssueRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("series")]
    public string? Series { get; set; }

    [JsonPropertyName("issueDate")]
    public string? IssueDate { get; set; }

    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
