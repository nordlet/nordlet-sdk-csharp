using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ItTfrAccrualComputeDeclarationsResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("destination")]
    public required ItTfrAccrualComputeDeclarationsResponseRowsItemDestination Destination { get; set; }

    [JsonPropertyName("base")]
    public required string Base { get; set; }

    [JsonPropertyName("quota")]
    public required string Quota { get; set; }

    [JsonPropertyName("contributionBase")]
    public required string ContributionBase { get; set; }

    [JsonPropertyName("contribution")]
    public required string Contribution { get; set; }

    [JsonPropertyName("accrual")]
    public required string Accrual { get; set; }

    [JsonPropertyName("leftOut")]
    public IEnumerable<ItTfrAccrualComputeDeclarationsResponseRowsItemLeftOutItem> LeftOut { get; set; } =
        new List<ItTfrAccrualComputeDeclarationsResponseRowsItemLeftOutItem>();

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
