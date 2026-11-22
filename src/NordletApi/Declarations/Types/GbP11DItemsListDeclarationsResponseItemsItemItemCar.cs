using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbP11DItemsListDeclarationsResponseItemsItemItemCar : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("make")]
    public required string Make { get; set; }

    [JsonPropertyName("registered")]
    public required DateOnly Registered { get; set; }

    [JsonPropertyName("availableFrom")]
    public DateOnly? AvailableFrom { get; set; }

    [JsonPropertyName("availableTo")]
    public DateOnly? AvailableTo { get; set; }

    [JsonPropertyName("engineSize")]
    public long? EngineSize { get; set; }

    [JsonPropertyName("fuel")]
    public GbP11DItemsListDeclarationsResponseItemsItemItemCarFuel? Fuel { get; set; }

    [JsonPropertyName("co2")]
    public long? Co2 { get; set; }

    [JsonPropertyName("zeroEmissionMileage")]
    public long? ZeroEmissionMileage { get; set; }

    [JsonPropertyName("noApprovedCo2")]
    public bool? NoApprovedCo2 { get; set; }

    [JsonPropertyName("listPrice")]
    public required string ListPrice { get; set; }

    [JsonPropertyName("accessories")]
    public required string Accessories { get; set; }

    [JsonPropertyName("capitalContribution")]
    public required string CapitalContribution { get; set; }

    [JsonPropertyName("privateUsePayment")]
    public required string PrivateUsePayment { get; set; }

    [JsonPropertyName("fuelWithdrawn")]
    public DateOnly? FuelWithdrawn { get; set; }

    [JsonPropertyName("fuelReinstated")]
    public bool? FuelReinstated { get; set; }

    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

    [JsonPropertyName("fuelAmount")]
    public string? FuelAmount { get; set; }

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
