using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ShiftsGetPosResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("deviceId")]
    public required string DeviceId { get; set; }

    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    [JsonPropertyName("status")]
    public required ShiftsGetPosResponseStatus Status { get; set; }

    [JsonPropertyName("openingCash")]
    public required string OpeningCash { get; set; }

    [JsonPropertyName("countedCash")]
    public string? CountedCash { get; set; }

    [JsonPropertyName("receiptCount")]
    public required long ReceiptCount { get; set; }

    [JsonPropertyName("reportId")]
    public string? ReportId { get; set; }

    [JsonPropertyName("openedAt")]
    public required DateTime OpenedAt { get; set; }

    [JsonPropertyName("closedAt")]
    public DateTime? ClosedAt { get; set; }

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
