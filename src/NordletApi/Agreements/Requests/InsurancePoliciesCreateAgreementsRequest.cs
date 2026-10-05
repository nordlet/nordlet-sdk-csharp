using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InsurancePoliciesCreateAgreementsRequest
{
    [JsonPropertyName("insurerPartnerId")]
    public string? InsurerPartnerId { get; set; }

    [JsonPropertyName("policyNumber")]
    public required string PolicyNumber { get; set; }

    [JsonPropertyName("insuredObject")]
    public required string InsuredObject { get; set; }

    [JsonPropertyName("fromDate")]
    public required DateOnly FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required DateOnly ToDate { get; set; }

    [JsonPropertyName("premium")]
    public string? Premium { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
