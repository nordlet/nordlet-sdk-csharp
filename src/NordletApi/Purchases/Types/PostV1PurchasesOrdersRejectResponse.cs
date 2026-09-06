using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PurchasesOrdersRejectResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("status")]
    public required PostV1PurchasesOrdersRejectResponseStatus Status { get; set; }

    [JsonPropertyName("orderNumber")]
    public required string OrderNumber { get; set; }

    [JsonPropertyName("orderDate")]
    public required string OrderDate { get; set; }

    [JsonPropertyName("expectedDate")]
    public string? ExpectedDate { get; set; }

    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("netTotal")]
    public required string NetTotal { get; set; }

    [JsonPropertyName("vatTotal")]
    public required string VatTotal { get; set; }

    [JsonPropertyName("grossTotal")]
    public required string GrossTotal { get; set; }

    [JsonPropertyName("approvedBy")]
    public string? ApprovedBy { get; set; }

    [JsonPropertyName("approvedAt")]
    public string? ApprovedAt { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("documentRef")]
    public string? DocumentRef { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required string UpdatedAt { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1PurchasesOrdersRejectResponseLinesItem> Lines { get; set; } =
        new List<PostV1PurchasesOrdersRejectResponseLinesItem>();

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
