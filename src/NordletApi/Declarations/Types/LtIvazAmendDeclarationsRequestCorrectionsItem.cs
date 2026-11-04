using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record LtIvazAmendDeclarationsRequestCorrectionsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("waybillId")]
    public required string WaybillId { get; set; }

    [JsonPropertyName("consigneePartnerId")]
    public string? ConsigneePartnerId { get; set; }

    [JsonPropertyName("unloadAddress")]
    public string? UnloadAddress { get; set; }

    [JsonPropertyName("vehiclePlate")]
    public string? VehiclePlate { get; set; }

    [JsonPropertyName("trailerPlate")]
    public string? TrailerPlate { get; set; }

    [JsonPropertyName("driverName")]
    public string? DriverName { get; set; }

    [JsonPropertyName("driverSurname")]
    public string? DriverSurname { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<LtIvazAmendDeclarationsRequestCorrectionsItemLinesItem>? Lines { get; set; }

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
