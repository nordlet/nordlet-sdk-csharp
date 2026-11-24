using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record VatProrataAdjustmentGetDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("fiscalYear")]
    public required long FiscalYear { get; set; }

    [JsonPropertyName("provisionalPercent")]
    public string? ProvisionalPercent { get; set; }

    [JsonPropertyName("computedPercent")]
    public string? ComputedPercent { get; set; }

    [JsonPropertyName("definitivePercent")]
    public string? DefinitivePercent { get; set; }

    [JsonPropertyName("turnoverWithDeduction")]
    public required string TurnoverWithDeduction { get; set; }

    [JsonPropertyName("turnoverWithoutDeduction")]
    public required string TurnoverWithoutDeduction { get; set; }

    [JsonPropertyName("capitalGoodsSales")]
    public required string CapitalGoodsSales { get; set; }

    [JsonPropertyName("proRataVat")]
    public required string ProRataVat { get; set; }

    [JsonPropertyName("deductedVat")]
    public required string DeductedVat { get; set; }

    [JsonPropertyName("definitiveDeductibleVat")]
    public string? DefinitiveDeductibleVat { get; set; }

    [JsonPropertyName("adjustment")]
    public string? Adjustment { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

    [JsonPropertyName("source")]
    public required string Source { get; set; }

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
