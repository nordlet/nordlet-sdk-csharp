using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PayrollRunsApproveRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("wageAccountCode")]
    public string? WageAccountCode { get; set; }

    [JsonPropertyName("employerAccountCode")]
    public string? EmployerAccountCode { get; set; }

    [JsonPropertyName("payableAccountCode")]
    public string? PayableAccountCode { get; set; }

    [JsonPropertyName("gpmAccountCode")]
    public string? GpmAccountCode { get; set; }

    [JsonPropertyName("sodraAccountCode")]
    public string? SodraAccountCode { get; set; }

    [JsonPropertyName("deductionAccountCode")]
    public string? DeductionAccountCode { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
