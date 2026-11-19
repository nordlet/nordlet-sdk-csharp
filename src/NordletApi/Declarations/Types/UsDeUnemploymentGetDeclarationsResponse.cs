using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsDeUnemploymentGetDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required double Year { get; set; }

    [JsonPropertyName("quarter")]
    public required double Quarter { get; set; }

    [JsonPropertyName("totalWages")]
    public required string TotalWages { get; set; }

    [JsonPropertyName("excessWages")]
    public required string ExcessWages { get; set; }

    [JsonPropertyName("taxableWages")]
    public required string TaxableWages { get; set; }

    [JsonPropertyName("contributions")]
    public required string Contributions { get; set; }

    [JsonPropertyName("employees")]
    public IEnumerable<UsDeUnemploymentGetDeclarationsResponseEmployeesItem> Employees { get; set; } =
        new List<UsDeUnemploymentGetDeclarationsResponseEmployeesItem>();

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
