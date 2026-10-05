using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record VehiclesUpdateFleetResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("plateNumber")]
    public required string PlateNumber { get; set; }

    [JsonPropertyName("make")]
    public required string Make { get; set; }

    [JsonPropertyName("model")]
    public required string Model { get; set; }

    [JsonPropertyName("year")]
    public long? Year { get; set; }

    [JsonPropertyName("vin")]
    public string? Vin { get; set; }

    [JsonPropertyName("fuelType")]
    public string? FuelType { get; set; }

    [JsonPropertyName("acquisitionDate")]
    public DateOnly? AcquisitionDate { get; set; }

    [JsonPropertyName("marketValue")]
    public required string MarketValue { get; set; }

    [JsonPropertyName("fixedAssetId")]
    public string? FixedAssetId { get; set; }

    [JsonPropertyName("technicalInspectionDue")]
    public string? TechnicalInspectionDue { get; set; }

    [JsonPropertyName("insuranceDue")]
    public string? InsuranceDue { get; set; }

    [JsonPropertyName("status")]
    public required VehiclesUpdateFleetResponseStatus Status { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("documents")]
    public IEnumerable<VehiclesUpdateFleetResponseDocumentsItem>? Documents { get; set; }

    [JsonPropertyName("currentAssignment")]
    public VehiclesUpdateFleetResponseCurrentAssignment? CurrentAssignment { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

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
