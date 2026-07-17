using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtFr0600ComputeResponseBreakdownItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("direction")]
    public required PostV1DeclarationsLtFr0600ComputeResponseBreakdownItemDirection Direction { get; set; }

    [JsonPropertyName("taxCode")]
    public string? TaxCode { get; set; }

    [JsonPropertyName("net")]
    public required string Net { get; set; }

    [JsonPropertyName("vat")]
    public required string Vat { get; set; }

    [JsonPropertyName("taxableFields")]
    public IEnumerable<string> TaxableFields { get; set; } = new List<string>();

    [JsonPropertyName("vatFields")]
    public IEnumerable<string> VatFields { get; set; } = new List<string>();

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
