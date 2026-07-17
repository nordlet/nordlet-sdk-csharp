using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1TransportWaybillsListResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("status")]
    public required PostV1TransportWaybillsListResponseRowsItemStatus Status { get; set; }

    [JsonPropertyName("series")]
    public required string Series { get; set; }

    [JsonPropertyName("fullNumber")]
    public string? FullNumber { get; set; }

    [JsonPropertyName("documentDate")]
    public required string DocumentDate { get; set; }

    [JsonPropertyName("dispatchAt")]
    public required string DispatchAt { get; set; }

    [JsonPropertyName("estimatedArrivalAt")]
    public string? EstimatedArrivalAt { get; set; }

    [JsonPropertyName("consigneePartnerId")]
    public required string ConsigneePartnerId { get; set; }

    [JsonPropertyName("transporterPartnerId")]
    public string? TransporterPartnerId { get; set; }

    [JsonPropertyName("vehiclePlate")]
    public string? VehiclePlate { get; set; }

    [JsonPropertyName("trailerPlate")]
    public string? TrailerPlate { get; set; }

    [JsonPropertyName("driverName")]
    public string? DriverName { get; set; }

    [JsonPropertyName("driverSurname")]
    public string? DriverSurname { get; set; }

    [JsonPropertyName("loadWarehouseId")]
    public string? LoadWarehouseId { get; set; }

    [JsonPropertyName("loadAddress")]
    public required string LoadAddress { get; set; }

    [JsonPropertyName("unloadAddress")]
    public required string UnloadAddress { get; set; }

    [JsonPropertyName("valueEur")]
    public string? ValueEur { get; set; }

    [JsonPropertyName("saleInvoiceId")]
    public string? SaleInvoiceId { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required string UpdatedAt { get; set; }

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
