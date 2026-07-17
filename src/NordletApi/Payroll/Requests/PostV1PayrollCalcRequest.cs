using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PayrollCalcRequest
{
    [JsonPropertyName("taxableBase")]
    public required string TaxableBase { get; set; }

    [JsonPropertyName("date")]
    public required string Date { get; set; }

    [JsonPropertyName("applyNpd")]
    public bool? ApplyNpd { get; set; }

    [JsonPropertyName("npdOverride")]
    public string? NpdOverride { get; set; }

    [JsonPropertyName("pensionAccumulation")]
    public bool? PensionAccumulation { get; set; }

    [JsonPropertyName("fixedTerm")]
    public bool? FixedTerm { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
