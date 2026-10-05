using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CalcPayrollRequest
{
    [JsonPropertyName("taxableBase")]
    public required string TaxableBase { get; set; }

    [JsonPropertyName("date")]
    public required DateOnly Date { get; set; }

    [JsonPropertyName("applyAllowance")]
    public bool? ApplyAllowance { get; set; }

    [JsonPropertyName("allowanceOverride")]
    public string? AllowanceOverride { get; set; }

    [JsonPropertyName("pensionAccumulation")]
    public bool? PensionAccumulation { get; set; }

    [JsonPropertyName("fixedTerm")]
    public bool? FixedTerm { get; set; }

    [JsonPropertyName("benefitInKind")]
    public string? BenefitInKind { get; set; }

    [JsonPropertyName("options")]
    public Dictionary<string, string>? Options { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
