using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PosReportsListResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("reportNumber")]
    public required string ReportNumber { get; set; }

    [JsonPropertyName("date")]
    public required string Date { get; set; }

    [JsonPropertyName("deviceId")]
    public string? DeviceId { get; set; }

    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    [JsonPropertyName("netTotal")]
    public required string NetTotal { get; set; }

    [JsonPropertyName("vatTotal")]
    public required string VatTotal { get; set; }

    [JsonPropertyName("grossTotal")]
    public required string GrossTotal { get; set; }

    [JsonPropertyName("cashAmount")]
    public required string CashAmount { get; set; }

    [JsonPropertyName("cardAmount")]
    public required string CardAmount { get; set; }

    [JsonPropertyName("cogsTotal")]
    public string? CogsTotal { get; set; }

    [JsonPropertyName("journalTransactionId")]
    public string? JournalTransactionId { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

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
