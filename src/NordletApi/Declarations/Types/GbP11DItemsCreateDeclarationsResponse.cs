using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbP11DItemsCreateDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("taxYear")]
    public required double TaxYear { get; set; }

    [JsonPropertyName("section")]
    public required string Section { get; set; }

    [JsonPropertyName("class1A")]
    public required bool Class1A { get; set; }

    [JsonPropertyName("cashEquivalent")]
    public required string CashEquivalent { get; set; }

    [JsonPropertyName("item")]
    public required GbP11DItemsCreateDeclarationsResponseItem Item { get; set; }

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
