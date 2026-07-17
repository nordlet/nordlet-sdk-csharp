using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1TransportWaybillsUpdateRequest
{
    [JsonPropertyName("consigneePartnerId")]
    public string? ConsigneePartnerId { get; set; }

    [JsonPropertyName("transporterPartnerId")]
    public string? TransporterPartnerId { get; set; }

    [JsonPropertyName("documentDate")]
    public string? DocumentDate { get; set; }

    [JsonPropertyName("dispatchAt")]
    public DateTime? DispatchAt { get; set; }

    [JsonPropertyName("estimatedArrivalAt")]
    public DateTime? EstimatedArrivalAt { get; set; }

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
    public string? LoadAddress { get; set; }

    [JsonPropertyName("unloadAddress")]
    public string? UnloadAddress { get; set; }

    [JsonPropertyName("valueEur")]
    public string? ValueEur { get; set; }

    [JsonPropertyName("saleInvoiceId")]
    public string? SaleInvoiceId { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("series")]
    public string? Series { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1TransportWaybillsUpdateRequestLinesItem>? Lines { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
