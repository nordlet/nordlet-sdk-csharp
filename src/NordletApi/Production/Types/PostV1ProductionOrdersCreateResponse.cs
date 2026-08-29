using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ProductionOrdersCreateResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("type")]
    public required PostV1ProductionOrdersCreateResponseType Type { get; set; }

    [JsonPropertyName("bomId")]
    public required string BomId { get; set; }

    [JsonPropertyName("warehouseId")]
    public required string WarehouseId { get; set; }

    [JsonPropertyName("routingId")]
    public string? RoutingId { get; set; }

    [JsonPropertyName("quantity")]
    public required string Quantity { get; set; }

    [JsonPropertyName("date")]
    public required string Date { get; set; }

    [JsonPropertyName("status")]
    public required PostV1ProductionOrdersCreateResponseStatus Status { get; set; }

    [JsonPropertyName("scrappedQuantity")]
    public string? ScrappedQuantity { get; set; }

    [JsonPropertyName("materialCost")]
    public string? MaterialCost { get; set; }

    [JsonPropertyName("laborCost")]
    public string? LaborCost { get; set; }

    [JsonPropertyName("scrapCost")]
    public string? ScrapCost { get; set; }

    [JsonPropertyName("totalCost")]
    public string? TotalCost { get; set; }

    [JsonPropertyName("journalTransactionId")]
    public string? JournalTransactionId { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("operations")]
    public IEnumerable<PostV1ProductionOrdersCreateResponseOperationsItem> Operations { get; set; } =
        new List<PostV1ProductionOrdersCreateResponseOperationsItem>();

    [JsonPropertyName("qualityChecks")]
    public IEnumerable<PostV1ProductionOrdersCreateResponseQualityChecksItem> QualityChecks { get; set; } =
        new List<PostV1ProductionOrdersCreateResponseQualityChecksItem>();

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
